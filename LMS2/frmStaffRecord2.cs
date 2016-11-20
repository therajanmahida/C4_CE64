using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Data.OleDb;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
namespace LibraryManagementSystem
{

	public partial class frmStaffRecord2
	{
		OleDbDataReader rdr = null;
		DataTable dtable;
		OleDbConnection con = null;
		OleDbDataAdapter adp;
		DataSet ds;
		OleDbCommand cmd = null;
		DataTable dt = new DataTable();

		string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;";

		public void fillDepartment()
		{
			try {
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct RTRIM(Department) FROM Staff", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbDepartment.Items.Clear();
				foreach (DataRow drow in dtable.Rows) {
					cmbDepartment.Items.Add(drow[0].ToString());
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DataGridView1_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			try {
				DataGridViewRow dr = DataGridView1.SelectedRows[0];
				this.Hide();
				My.MyProject.Forms.frmBookIssue.Show();
				// or simply use column name instead of index
				//dr.Cells["id"].Value.ToString();
				My.MyProject.Forms.frmBookIssue.cmbStaffID.Text = dr.Cells[0].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtStaffName.Text = dr.Cells[1].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtDepartment1.Text = dr.Cells[5].Value.ToString();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DataGridView1_RowPostPaint(object sender, System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
		{
			string strRowNumber = (e.RowIndex + 1).ToString();
			SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
			if (DataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20))) {
				DataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
			}
			Brush b = SystemBrushes.ControlText;
			e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
		}
		public void GetData()
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT StaffID as [Staff ID], StaffName as [Staff Name],Gender, FatherName as [Father's Name],DateOfJoining as [Date Of Joining], Department, TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Staff order by Staffname", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Staff");
				DataGridView1.DataSource = myDataSet.Tables["Staff"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private void cmbDepartment_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT StaffID as [Staff ID], StaffName as [Staff Name],Gender, FatherName as [Father's Name],DateOfJoining as [DateOfJoining], Department, TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Staff where department='" + cmbDepartment.Text + "' order by Staffname", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Staff");
				DataGridView1.DataSource = myDataSet.Tables["Staff"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnReset_Click(System.Object sender, System.EventArgs e)
		{
			txtStaffName.Text = "";
			dtpDateFrom.Text = DateAndTime.Today;
			cmbDepartment.Text = "";
			dtpDateTo.Text = DateAndTime.Today;
			GetData();
		}

		private void btnExportExcel_Click(System.Object sender, System.EventArgs e)
		{
			short rowsTotal = 0;
			short colsTotal = 0;
			short I = 0;
			short j = 0;
			short iC = 0;
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
			Excel.Application xlApp = new Excel.Application();
			try {
				Excel.Workbook excelBook = xlApp.Workbooks.Add();
				Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
				xlApp.Visible = true;

				rowsTotal = DataGridView1.RowCount - 1;
				colsTotal = DataGridView1.Columns.Count - 1;
				var _with1 = excelWorksheet;
				_with1.Cells.Select();
				_with1.Cells.Delete();
				for (iC = 0; iC <= colsTotal; iC++) {
					_with1.Cells(1, iC + 1).Value = DataGridView1.Columns[iC].HeaderText;
				}
				for (I = 0; I <= rowsTotal - 1; I++) {
					for (j = 0; j <= colsTotal; j++) {
						_with1.Cells(I + 2, j + 1).value = DataGridView1.Rows[I].Cells[j].Value;
					}
				}
				_with1.Rows("1:1").Font.FontStyle = "Bold";
				_with1.Rows("1:1").Font.Size = 12;

				_with1.Cells.Columns.AutoFit();
				_with1.Cells.Select();
				_with1.Cells.EntireColumn.AutoFit();
				_with1.Cells(1, 1).Select();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				//RELEASE ALLOACTED RESOURCES
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
				xlApp = null;
			}
		}

		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT StaffID as [Staff ID], StaffName as [Staff Name],Gender, FatherName as [Father's Name],DateOfJoining as [Date Of Joining], Department, TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Staff where DateOfJoining between #" + dtpDateFrom.Text + "# and #" + dtpDateTo.Text + "# order by Staffname", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Staff");
				DataGridView1.DataSource = myDataSet.Tables["Staff"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtStaffName_TextChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT StaffID as [Staff ID], StaffName as [Staff Name],Gender, FatherName as [Father's Name],DateOfJoining as [Date Of Joining], Department, TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Staff where staffname like '" + txtStaffName.Text + "%' order by Staffname", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Staff");
				DataGridView1.DataSource = myDataSet.Tables["Staff"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmStaffRecord_Load(System.Object sender, System.EventArgs e)
		{
			fillDepartment();
			GetData();
		}

		private void dtpDateTo_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			if ((dtpDateFrom.Value.Date) > (dtpDateTo.Value.Date)) {
				MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dtpDateTo.Focus();
			}
		}
		public frmStaffRecord2()
		{
			Load += frmStaffRecord_Load;
			InitializeComponent();
		}
	}
}

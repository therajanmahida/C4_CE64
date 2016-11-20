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
	public partial class frmProjectRecord
	{
		OleDbDataReader rdr = null;
		DataTable dtable;
		OleDbConnection con = null;
		OleDbDataAdapter adp;
		DataSet ds;
		OleDbCommand cmd = null;
		DataTable dt = new DataTable();

		string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;";
		public void fillCourse()
		{
			try {
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct RTRIM(Course) FROM Project", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbCourse.Items.Clear();
				foreach (DataRow drow in dtable.Rows) {
					cmbCourse.Items.Add(drow[0].ToString());
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT ID,ProjectName as [Project Name], StudentName as [Student Name], Course, Proj_year as [Course Year], SubmissionDate as [Submission Date], Remarks from project where SubmissionDate between #" + DateTimePicker2.Text + "# and #" + DateTimePicker1.Text + "#  order by SubmissionDate desc", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Project");
				DataGridView1.DataSource = myDataSet.Tables["Project"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnExportExcel_Click(System.Object sender, System.EventArgs e)
		{
			if (DataGridView1.RowCount == null) {
				MessageBox.Show("Sorry nothing to export into excel sheet.." + Constants.vbCrLf + "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
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
		public void Reset()
		{
			cmbCourse.Text = "";
			cmbYear.Text = "";
			txtProjectTitle.Text = "";
			cmbYear.Enabled = false;
			txtStudentName.Text = "";
			DateTimePicker1.Text = DateAndTime.Today;
			DateTimePicker2.Text = DateAndTime.Today;
			DataGridView1.DataSource = null;
		}
		private void btnReset_Click(System.Object sender, System.EventArgs e)
		{
			FileSystem.Reset();
		}

		private void DataGridView1_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			try {
				DataGridViewRow dr = DataGridView1.SelectedRows[0];
				this.Hide();
				My.MyProject.Forms.frmProject.Show();
				// or simply use column name instead of index
				//dr.Cells["id"].Value.ToString();
				My.MyProject.Forms.frmProject.txtID.Text = dr.Cells[0].Value.ToString();
				My.MyProject.Forms.frmProject.txtProjectName.Text = dr.Cells[1].Value.ToString();
				My.MyProject.Forms.frmProject.txtStudentName.Text = dr.Cells[2].Value.ToString();
				My.MyProject.Forms.frmProject.cmbCourse.Text = dr.Cells[3].Value.ToString();
				My.MyProject.Forms.frmProject.cmbYear.Text = dr.Cells[4].Value.ToString();
				My.MyProject.Forms.frmProject.dtpSubmissionDate.Text = dr.Cells[5].Value.ToString();
				My.MyProject.Forms.frmProject.txtRemarks.Text = dr.Cells[6].Value.ToString();
				My.MyProject.Forms.frmProject.btnUpdate_record.Enabled = true;
				My.MyProject.Forms.frmProject.btnDelete.Enabled = true;
				My.MyProject.Forms.frmProject.btnSave.Enabled = false;
				My.MyProject.Forms.frmProject.txtProjectName.Focus();
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

		private void txtStudentName_TextChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT ID,ProjectName as [Project Name], StudentName as [Student Name], Course, Proj_year as [Course Year], SubmissionDate as [Submission Date], Remarks from project where StudentName like '%" + txtStudentName.Text + "%' order by StudentName", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Project");
				DataGridView1.DataSource = myDataSet.Tables["Project"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Button7_Click(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT ID,ProjectName as [Project Name], StudentName as [Student Name], Course, Proj_year as [Course Year], SubmissionDate as [Submission Date], Remarks from project where course='" + cmbCourse.Text + "' and Proj_Year='" + cmbYear.Text + "' order by ProjectName", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Project");
				DataGridView1.DataSource = myDataSet.Tables["Project"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmbCourse_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				cmbCourse.Text = cmbCourse.Text.Trim();
				cmbYear.Items.Clear();
				cmbYear.Text = "";
				cmbYear.Enabled = true;
				cmbCourse.Focus();
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "select distinct RTRIM(Proj_Year) from Project where course = '" + cmbCourse.Text + "'";
				cmd = new OleDbCommand(ct);
				cmd.Connection = con;
				rdr = cmd.ExecuteReader();
				while (rdr.Read()) {
					cmbYear.Items.Add(rdr[0]);
				}
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void DateTimePicker1_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			if ((DateTimePicker2.Value.Date) > (DateTimePicker1.Value.Date)) {
				MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				DateTimePicker1.Focus();
			}
		}

		private void frmProjectRecord_Load(System.Object sender, System.EventArgs e)
		{
			fillCourse();
		}

		private void txtProjectTitle_TextChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT ID,ProjectName as [Project Name], StudentName as [Student Name], Course, Proj_year as [Course Year], SubmissionDate as [Submission Date], Remarks from project where ProjectName like '" + txtProjectTitle.Text + "%' order by Projectname", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Project");
				DataGridView1.DataSource = myDataSet.Tables["Project"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public frmProjectRecord()
		{
			Load += frmProjectRecord_Load;
			InitializeComponent();
		}
	}
}

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
using Excel = Microsoft.Office.Interop.Excel;
namespace LibraryManagementSystem
{
	public partial class frmBookIssueRecord_Staff1
	{
		OleDbDataReader rdr = null;
		DataTable dtable;
		OleDbConnection con = null;
		OleDbDataAdapter adp;
		DataSet ds;
		OleDbCommand cmd = null;
		DataTable dt = new DataTable();
		string gender;

		string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;";
		public void Reset()
		{
			txtBookName.Text = "";
			txtBookName1.Text = "";
			txtStaffName.Text = "";
			cmbStaffName.Text = "";
			cmbStaffName1.Text = "";
			dtpDateFrom.Text = DateAndTime.Today;
			dtpDateTo.Text = DateAndTime.Today;
			DateTimePicker1.Text = DateAndTime.Today;
			DateTimePicker2.Text = DateAndTime.Today;
			DateTimePicker3.Text = DateAndTime.Today;
			DateTimePicker4.Text = DateAndTime.Today;
			DateTimePicker5.Text = DateAndTime.Today;
			DateTimePicker6.Text = DateAndTime.Today;
			DateTimePicker7.Text = DateAndTime.Today;
			DateTimePicker8.Text = DateAndTime.Today;
			DataGridView1.DataSource = null;
		}
		public void fillStaffName()
		{
			try {
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct RTRIM(Staffname) FROM Staff,BookIssue_Staff where Staff.StaffID=BookIssue_Staff.StaffID", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbStaffName.Items.Clear();
				cmbStaffName1.Items.Clear();
				foreach (DataRow drow in dtable.Rows) {
					cmbStaffName.Items.Add(drow[0].ToString());
					cmbStaffName1.Items.Add(drow[0].ToString());
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void frmBookIssueRecord_Load(System.Object sender, System.EventArgs e)
		{
			fillStaffName();
		}

		private void txtBookName_TextChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Staff.StaffID as [Staff ID],StaffName as [Staff Name],Staff.Department, Status from Book,BookIssue_Staff,Staff where Book.AccessionNo=BookIssue_Staff.AccessionNo and BookIssue_Staff.StaffID=Staff.StaffID and Issuedate Between #" + dtpDateFrom.Text + "# and #" + dtpDateTo.Text + "# and BookTitle like '" + txtBookName.Text + "%' order by Issuedate desc ", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "BookIssue_Staff");
				myDA.Fill(myDataSet, "Book");
				myDA.Fill(myDataSet, "Staff");
				DataGridView1.DataSource = myDataSet.Tables["BookIssue_Staff"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Book"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Staff"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnReset_Click(System.Object sender, System.EventArgs e)
		{
			FileSystem.Reset();
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

		private void txtBookName1_TextChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Staff.StaffID as [Staff ID],StaffName as [Staff Name],Staff.Department, Status from Book,BookIssue_Staff,Staff where Book.AccessionNo=BookIssue_Staff.AccessionNo and BookIssue_Staff.StaffID=Staff.StaffID and DueDate Between #" + DateTimePicker2.Text + "# and #" + DateTimePicker1.Text + "# and BookTitle like '" + txtBookName1.Text + "%' order by DueDate desc ", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "BookIssue_Staff");
				myDA.Fill(myDataSet, "Book");
				myDA.Fill(myDataSet, "Staff");
				DataGridView1.DataSource = myDataSet.Tables["BookIssue_Staff"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Book"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Staff"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Staff.StaffID as [Staff ID],StaffName as [Staff Name],Staff.Department, Status from Book,BookIssue_Staff,Staff where Book.AccessionNo=BookIssue_Staff.AccessionNo and BookIssue_Staff.StaffID=Staff.StaffID and IssueDate Between #" + DateTimePicker8.Text + "# and #" + DateTimePicker7.Text + "#  order by IssueDate desc ", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "BookIssue_Staff");
				myDA.Fill(myDataSet, "Book");
				myDA.Fill(myDataSet, "Staff");
				DataGridView1.DataSource = myDataSet.Tables["BookIssue_Staff"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Book"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Staff"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmbStaffName_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Staff.StaffID as [Staff ID],StaffName as [Staff Name],Staff.Department, Status from Book,BookIssue_Staff,Staff where Book.AccessionNo=BookIssue_Staff.AccessionNo and BookIssue_Staff.StaffID=Staff.StaffID and IssueDate Between #" + DateTimePicker4.Text + "# and #" + DateTimePicker3.Text + "# and StaffName= '" + cmbStaffName.Text + "' order by IssueDate desc ", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "BookIssue_Staff");
				myDA.Fill(myDataSet, "Book");
				myDA.Fill(myDataSet, "Staff");
				DataGridView1.DataSource = myDataSet.Tables["BookIssue_Staff"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Book"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Staff"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void cmbStaffName1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Staff.StaffID as [Staff ID],StaffName as [Staff Name],Staff.Department, Status from Book,BookIssue_Staff,Staff where Book.AccessionNo=BookIssue_Staff.AccessionNo and BookIssue_Staff.StaffID=Staff.StaffID and DueDate Between #" + DateTimePicker6.Text + "# and #" + DateTimePicker5.Text + "# and StaffName= '" + cmbStaffName1.Text + "' order by DueDate desc ", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "BookIssue_Staff");
				myDA.Fill(myDataSet, "Book");
				myDA.Fill(myDataSet, "Staff");
				DataGridView1.DataSource = myDataSet.Tables["BookIssue_Staff"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Book"].DefaultView;
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
				cmd = new OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Staff.StaffID as [Staff ID],StaffName as [Staff Name],Staff.Department, Status from Book,BookIssue_Staff,Staff where Book.AccessionNo=BookIssue_Staff.AccessionNo and BookIssue_Staff.StaffID=Staff.StaffID  and StaffName like '" + txtStaffName.Text + "%' order by Staffname ", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "BookIssue_Staff");
				myDA.Fill(myDataSet, "Book");
				myDA.Fill(myDataSet, "Staff");
				DataGridView1.DataSource = myDataSet.Tables["BookIssue_Staff"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Book"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Staff"].DefaultView;
				con.Close();
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

		private void dtpDateTo_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			if ((dtpDateFrom.Value.Date) > (dtpDateTo.Value.Date)) {
				MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dtpDateTo.Focus();
			}
		}

		private void DateTimePicker1_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			if ((DateTimePicker2.Value.Date) > (DateTimePicker1.Value.Date)) {
				MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				DateTimePicker1.Focus();
			}
		}

		private void DateTimePicker7_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			if ((DateTimePicker8.Value.Date) > (DateTimePicker7.Value.Date)) {
				MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				DateTimePicker7.Focus();
			}
		}

		private void DateTimePicker3_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			if ((DateTimePicker4.Value.Date) > (DateTimePicker3.Value.Date)) {
				MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				DateTimePicker3.Focus();
			}
		}

		private void DateTimePicker5_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			if ((DateTimePicker6.Value.Date) > (DateTimePicker5.Value.Date)) {
				MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				DateTimePicker5.Focus();
			}
		}
		public frmBookIssueRecord_Staff1()
		{
			Load += frmBookIssueRecord_Load;
			InitializeComponent();
		}
	}
}

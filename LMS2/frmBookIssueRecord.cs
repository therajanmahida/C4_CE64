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
	public partial class frmBookIssueRecord
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
			txtStudentName.Text = "";
			cmbStudentName.Text = "";
			cmbStudentName1.Text = "";
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
		public void fillStudentName()
		{
			try {
				cmbStudentName.DataSource = null;
				cmbStudentName1.DataSource = null;
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct Studentname FROM Student,BookIssue_Student where Student.StudentID=BookIssue_Student.StudentID", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbStudentName.DisplayMember = "StudentName";
				cmbStudentName.DataSource = dtable;
				cmbStudentName.SelectedIndex = -1;
				cmbStudentName1.DisplayMember = "StudentName";
				cmbStudentName1.DataSource = dtable;
				cmbStudentName1.SelectedIndex = -1;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void frmBookIssueRecord_Load(System.Object sender, System.EventArgs e)
		{
			fillStudentName();
			FileSystem.Reset();
		}

		private void txtBookName_TextChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Student.StudentID as [Student ID],StudentName as [Student Name],Course,Student.Department, Status from Book,BookIssue_Student,Student where Book.AccessionNo=BookIssue_Student.AccessionNo and BookIssue_Student.StudentID=Student.StudentID and Issuedate Between #" + dtpDateFrom.Text + "# and #" + dtpDateTo.Text + "# and BookTitle like '" + txtBookName.Text + "%' order by Issuedate desc ", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "BookIssue_Student");
				myDA.Fill(myDataSet, "Book");
				myDA.Fill(myDataSet, "Student");
				DataGridView1.DataSource = myDataSet.Tables["BookIssue_Student"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Book"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;
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
				cmd = new OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Student.StudentID as [Student ID],StudentName as [Student Name],Course,Student.Department, Status from Book,BookIssue_Student,Student where Book.AccessionNo=BookIssue_Student.AccessionNo and BookIssue_Student.StudentID=Student.StudentID and DueDate Between #" + DateTimePicker2.Text + "# and #" + DateTimePicker1.Text + "# and BookTitle like '" + txtBookName1.Text + "%' order by DueDate desc ", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "BookIssue_Student");
				myDA.Fill(myDataSet, "Book");
				myDA.Fill(myDataSet, "Student");
				DataGridView1.DataSource = myDataSet.Tables["BookIssue_Student"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Book"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;
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
				cmd = new OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Student.StudentID as [Student ID],StudentName as [Student Name],Course,Student.Department, Status from Book,BookIssue_Student,Student where Book.AccessionNo=BookIssue_Student.AccessionNo and BookIssue_Student.StudentID=Student.StudentID and IssueDate Between #" + DateTimePicker8.Text + "# and #" + DateTimePicker7.Text + "#  order by IssueDate desc ", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "BookIssue_Student");
				myDA.Fill(myDataSet, "Book");
				myDA.Fill(myDataSet, "Student");
				DataGridView1.DataSource = myDataSet.Tables["BookIssue_Student"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Book"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmbStudentName_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Student.StudentID as [Student ID],StudentName as [Student Name],Course,Student.Department, Status from Book,BookIssue_Student,Student where Book.AccessionNo=BookIssue_Student.AccessionNo and BookIssue_Student.StudentID=Student.StudentID and IssueDate Between #" + DateTimePicker4.Text + "# and #" + DateTimePicker3.Text + "# and StudentName= '" + cmbStudentName.Text + "' order by IssueDate desc ", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "BookIssue_Student");
				myDA.Fill(myDataSet, "Book");
				myDA.Fill(myDataSet, "Student");
				DataGridView1.DataSource = myDataSet.Tables["BookIssue_Student"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Book"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void cmbStudentName1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Student.StudentID as [Student ID],StudentName as [Student Name],Course,Student.Department, Status from Book,BookIssue_Student,Student where Book.AccessionNo=BookIssue_Student.AccessionNo and BookIssue_Student.StudentID=Student.StudentID and DueDate Between #" + DateTimePicker6.Text + "# and #" + DateTimePicker5.Text + "# and StudentName= '" + cmbStudentName1.Text + "' order by DueDate desc ", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "BookIssue_Student");
				myDA.Fill(myDataSet, "Book");
				myDA.Fill(myDataSet, "Student");
				DataGridView1.DataSource = myDataSet.Tables["BookIssue_Student"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Book"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtStudentName_TextChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT TransactionID as [Transaction ID], IssueDate as [Issue Date], DueDate as [Due Date], Book.AccessionNo as [Accession No],BookTitle as [Book Title],Author,Subject,ISBN,Edition,Student.StudentID as [Student ID],StudentName as [Student Name],Course,Student.Department, Status from Book,BookIssue_Student,Student where Book.AccessionNo=BookIssue_Student.AccessionNo and BookIssue_Student.StudentID=Student.StudentID  and StudentName like '" + txtStudentName.Text + "%' order by Studentname ", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "BookIssue_Student");
				myDA.Fill(myDataSet, "Book");
				myDA.Fill(myDataSet, "Student");
				DataGridView1.DataSource = myDataSet.Tables["BookIssue_Student"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Book"].DefaultView;
				DataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;
				con.Close();
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
				My.MyProject.Forms.frmBookIssue.txtTransactionID.Text = dr.Cells[0].Value.ToString();
				My.MyProject.Forms.frmBookIssue.dtpIssueDate.Text = dr.Cells[1].Value.ToString();
				My.MyProject.Forms.frmBookIssue.dtpDueDate.Text = dr.Cells[2].Value.ToString();
				My.MyProject.Forms.frmBookIssue.cmbAccessionNo.Text = dr.Cells[3].Value.ToString();
				My.MyProject.Forms.frmBookIssue.TextBox1.Text = dr.Cells[3].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtBookTitle.Text = dr.Cells[4].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtAuthor.Text = dr.Cells[5].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtCategory.Text = dr.Cells[6].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtISBN.Text = dr.Cells[7].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtEdition.Text = dr.Cells[8].Value.ToString();
				My.MyProject.Forms.frmBookIssue.cmbStudentID.Text = dr.Cells[9].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtStudentName.Text = dr.Cells[10].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtCourse.Text = dr.Cells[11].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtDepartment.Text = dr.Cells[12].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtStatus.Text = dr.Cells[13].Value.ToString();
				My.MyProject.Forms.frmBookIssue.btnUpdate_record.Enabled = true;
				My.MyProject.Forms.frmBookIssue.btnDelete.Enabled = true;
				My.MyProject.Forms.frmBookIssue.btnSave.Enabled = false;
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
	}
}

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

	public partial class frmStudentRecord
	{
		OleDbDataReader rdr = null;
		DataTable dtable;
		OleDbConnection con = null;
		OleDbDataAdapter adp;
		DataSet ds;
		OleDbCommand cmd = null;
		DataTable dt = new DataTable();

		string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;";
		private void frmStudentRecord_Load(System.Object sender, System.EventArgs e)
		{
			fillCourse();
			fillDepartment();
			fillSession();
			GetData();
		}
		public void fillSession()
		{
			try {
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct (stu_session) FROM Student", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbSession.Items.Clear();
				foreach (DataRow drow in dtable.Rows) {
					cmbSession.Items.Add(drow[0].ToString());
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void fillCourse()
		{
			try {
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct RTRIM(Course) FROM Student", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbCourse.Items.Clear();
				cmbCourse1.Items.Clear();
				foreach (DataRow drow in dtable.Rows) {
					cmbCourse.Items.Add(drow[0].ToString());
					cmbCourse1.Items.Add(drow[0].ToString());
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void fillDepartment()
		{
			try {
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct RTRIM(Department) FROM Student", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbDepartment.Items.Clear();
				cmbDepartment1.Items.Clear();
				foreach (DataRow drow in dtable.Rows) {
					cmbDepartment.Items.Add(drow[0].ToString());
					cmbDepartment1.Items.Add(drow[0].ToString());
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
				My.MyProject.Forms.frmStudent.Show();
				My.MyProject.Forms.frmStudent.txtStudentID.Text = dr.Cells[0].Value.ToString();
				My.MyProject.Forms.frmStudent.txtStudentName.Text = dr.Cells[1].Value.ToString();
				if ((dr.Cells[2].Value.ToString() == "Male")) {
					My.MyProject.Forms.frmStudent.rbMale.Checked = true;
				}
				if ((dr.Cells[2].Value.ToString() == "Female")) {
					My.MyProject.Forms.frmStudent.rbFemale.Checked = true;
				}
				My.MyProject.Forms.frmStudent.txtFatherName.Text = dr.Cells[3].Value.ToString();
				My.MyProject.Forms.frmStudent.cmbCourse.Text = dr.Cells[4].Value.ToString();
				My.MyProject.Forms.frmStudent.cmbDepartment.Text = dr.Cells[5].Value.ToString();
				My.MyProject.Forms.frmStudent.txtSession.Text = dr.Cells[6].Value.ToString();
				My.MyProject.Forms.frmStudent.txtRollNo.Text = dr.Cells[7].Value.ToString();
				My.MyProject.Forms.frmStudent.txtReceiptNo.Text = dr.Cells[8].Value.ToString();
				My.MyProject.Forms.frmStudent.txtTempAddress.Text = dr.Cells[9].Value.ToString();
				My.MyProject.Forms.frmStudent.txtPermanentAddress.Text = dr.Cells[10].Value.ToString();
				My.MyProject.Forms.frmStudent.dtpDOB.Text = dr.Cells[11].Value.ToString();
				My.MyProject.Forms.frmStudent.txtPhoneNo.Text = dr.Cells[12].Value.ToString();
				My.MyProject.Forms.frmStudent.txtMobileNo.Text = dr.Cells[13].Value.ToString();
				My.MyProject.Forms.frmStudent.txtEmail.Text = dr.Cells[14].Value.ToString();
				byte[] data = (byte[])dr.Cells[15].Value;
				MemoryStream ms = new MemoryStream(data);
				My.MyProject.Forms.frmStudent.Picture.Image = Image.FromStream(ms);
				My.MyProject.Forms.frmStudent.btnUpdate_record.Enabled = true;
				My.MyProject.Forms.frmStudent.btnDelete.Enabled = true;
				My.MyProject.Forms.frmStudent.btnSave.Enabled = false;
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
				cmd = new OleDbCommand("SELECT StudentID as [Student ID], StudentName as [Student Name],Gender, FatherName as [Father's Name], Course, Department, Stu_Session as [Session], ClassRollNo as [Class Roll No], CautionMoneyReceiptNo as [Caution Money Receipt No], TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Student  order by StudentName", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Student");
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
				cmd = new OleDbCommand("SELECT StudentID as [Student ID], StudentName as [Student Name],Gender, FatherName as [Father's Name], Course, Department, Stu_Session as [Session], ClassRollNo as [Class Roll No], CautionMoneyReceiptNo as [Caution Money Receipt No], TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Student where studentname like '" + txtStudentName.Text + "%' order by StudentName", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Student");
				DataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmbCourse_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT StudentID as [Student ID], StudentName as [Student Name],Gender, FatherName as [Father's Name], Course, Department, Stu_Session as [Session], ClassRollNo as [Class Roll No], CautionMoneyReceiptNo as [Caution Money Receipt No], TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Student where Course= '" + cmbCourse.Text + "' order by StudentName", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Student");
				DataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;
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
				cmd = new OleDbCommand("SELECT StudentID as [Student ID], StudentName as [Student Name],Gender, FatherName as [Father's Name], Course, Department, Stu_Session as [Session], ClassRollNo as [Class Roll No], CautionMoneyReceiptNo as [Caution Money Receipt No], TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Student where department= '" + cmbDepartment.Text + "' order by StudentName", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Student");
				DataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnReset_Click(System.Object sender, System.EventArgs e)
		{
			txtStudentName.Text = "";
			cmbCourse.Text = "";
			cmbDepartment.Text = "";
			cmbCourse1.Text = "";
			cmbDepartment1.Text = "";
			cmbSession.Text = "";
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
				if (Strings.Len(Strings.Trim(cmbSession.Text)) == 0) {
					MessageBox.Show("Please select session", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbSession.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbCourse1.Text)) == 0) {
					MessageBox.Show("Please select course", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbCourse1.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbDepartment1.Text)) == 0) {
					MessageBox.Show("Please select department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbDepartment1.Focus();
					return;
				}
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT StudentID as [Student ID], StudentName as [Student Name],Gender, FatherName as [Father's Name], Course, Department, Stu_Session as [Session], ClassRollNo as [Class Roll No], CautionMoneyReceiptNo as [Caution Money Receipt No], TemporaryAddress as [Temporary Address], PermanentAddress as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo from Student where department= '" + cmbDepartment1.Text + "' and Course='" + cmbCourse1.Text + "' and Stu_Session='" + cmbSession.Text + "' order by StudentName", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Student");
				DataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public frmStudentRecord()
		{
			Load += frmStudentRecord_Load;
			InitializeComponent();
		}
	}
}

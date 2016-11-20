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
	public partial class frmStudentsCardRecord
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
		public void fillSession()
		{
			try {
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct RTRIM(Stu_Session) FROM Student", CN);
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
		private void frmCards_Student_Load(System.Object sender, System.EventArgs e)
		{
			fillSession();
		}

		private void cmbCourse_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				cmbCourse.Text = cmbCourse.Text.Trim();
				cmbDepartment.Items.Clear();
				cmbDepartment.Text = "";
				cmbDepartment.Enabled = true;
				cmbDepartment.Focus();
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "select distinct RTRIM(Department) from Student,Cards_Student where Student.StudentID=Cards_Student.StudentID and course = '" + cmbCourse.Text + "'";
				cmd = new OleDbCommand(ct);
				cmd.Connection = con;
				rdr = cmd.ExecuteReader();
				while (rdr.Read()) {
					cmbDepartment.Items.Add(rdr[0]);
				}
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmbSession_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				cmbCourse.Items.Clear();
				cmbCourse.Text = "";
				cmbCourse.Enabled = true;
				cmbCourse.Focus();
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "select distinct RTRIM(Course) from Student,Cards_Student where Student.StudentID=Cards_Student.StudentID and Stu_Session= '" + cmbSession.Text + "'";
				cmd = new OleDbCommand(ct);
				cmd.Connection = con;
				rdr = cmd.ExecuteReader();
				while (rdr.Read()) {
					cmbCourse.Items.Add(rdr[0]);
				}
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void Reset()
		{
			cmbSession.Text = "";
			cmbCourse.Text = "";
			cmbDepartment.Text = "";
			txtStudentName.Text = "";
			cmbCourse.Enabled = false;
			cmbDepartment.Enabled = false;
			DataGridView1.Rows.Clear();
		}

		private void NewRecord_Click(System.Object sender, System.EventArgs e)
		{
			FileSystem.Reset();
		}

		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(cmbSession.Text)) {
				MessageBox.Show("Please select session", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cmbSession.Focus();
				return;
			}
			if (string.IsNullOrEmpty(cmbCourse.Text)) {
				MessageBox.Show("Please select course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cmbCourse.Focus();
				return;
			}
			if (string.IsNullOrEmpty(cmbDepartment.Text)) {
				MessageBox.Show("Please select department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cmbDepartment.Focus();
				return;
			}


			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("select Student.StudentID,StudentName,Status from Cards_Student,Student where Cards_Student.StudentID=Student.StudentID and Course = '" + cmbCourse.Text + "' and Department= '" + cmbDepartment.Text + "' and Stu_Session= '" + cmbSession.Text + "' order by StudentName ", con);
				rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
				DataGridView1.Rows.Clear();
				while ((rdr.Read() == true)) {
					DataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2]);
				}
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void Button1_Click(System.Object sender, System.EventArgs e)
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

		private void txtStudentName_TextChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("select Student.StudentID,StudentName,Status from Cards_Student,Student where Cards_Student.StudentID=Student.StudentID and Studentname like '" + txtStudentName.Text + "%' order by StudentName ", con);
				rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
				DataGridView1.Rows.Clear();
				while ((rdr.Read() == true)) {
					DataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2]);
				}
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtStudentName_TextChanged_1(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("select Student.StudentID,StudentName,Status from Cards_Student,Student where Cards_Student.StudentID=Student.StudentID and StudentName like '" + txtStudentName.Text + "%' order by StudentName ", con);
				rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
				DataGridView1.Rows.Clear();
				while ((rdr.Read() == true)) {
					DataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2]);
				}
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
	}
}

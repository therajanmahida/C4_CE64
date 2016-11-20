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
	public partial class frmProjectRecord1
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

		private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (Strings.Len(Strings.Trim(cmbCourse.Text)) == 0) {
					MessageBox.Show("Please select course", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbCourse.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbYear.Text)) == 0) {
					MessageBox.Show("Please select year", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbYear.Focus();
					return;
				}
				Cursor = Cursors.WaitCursor;
				Timer1.Enabled = true;
				rptProject rpt = new rptProject();
				//The report you created.
				OleDbConnection myConnection = null;
				OleDbCommand MyCommand = new OleDbCommand();
				OleDbDataAdapter myDA = new OleDbDataAdapter();
				LMS_DBDataSet myDS = new LMS_DBDataSet();
				//The DataSet you created.
				myConnection = new OleDbConnection(cs);
				MyCommand.Connection = myConnection;
				MyCommand.CommandText = "SELECT * from Project where Course='" + cmbCourse.Text + "' and Proj_Year='" + cmbYear.Text + "' order by ProjectName";
				MyCommand.CommandType = CommandType.Text;
				myDA.SelectCommand = MyCommand;
				myDA.Fill(myDS, "Project");
				rpt.SetDataSource(myDS);
				My.MyProject.Forms.frmProjectReport.CrystalReportViewer1.ReportSource = rpt;
				My.MyProject.Forms.frmProjectReport.Show();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Timer1_Tick(System.Object sender, System.EventArgs e)
		{
			Cursor = Cursors.Default;
			Timer1.Enabled = false;
		}

		private void frmProjectRecord1_Load(System.Object sender, System.EventArgs e)
		{
			fillCourse();
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

		private void Button7_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (Strings.Len(Strings.Trim(cmbCourse.Text)) == 0) {
					MessageBox.Show("Please select course", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbCourse.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbYear.Text)) == 0) {
					MessageBox.Show("Please select year", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbYear.Focus();
					return;
				}
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

		private void Button6_Click(System.Object sender, System.EventArgs e)
		{
			try {
				Cursor = Cursors.WaitCursor;
				Timer1.Enabled = true;
				rptProject rpt = new rptProject();
				//The report you created.
				OleDbConnection myConnection = null;
				OleDbCommand MyCommand = new OleDbCommand();
				OleDbDataAdapter myDA = new OleDbDataAdapter();
				LMS_DBDataSet myDS = new LMS_DBDataSet();
				//The DataSet you created.
				myConnection = new OleDbConnection(cs);
				MyCommand.Connection = myConnection;
				MyCommand.CommandText = "SELECT * from Project where  SubmissionDate between #" + DateTimePicker2.Text + "# and #" + DateTimePicker1.Text + "#  order by SubmissionDate desc ";
				MyCommand.CommandType = CommandType.Text;
				myDA.SelectCommand = MyCommand;
				myDA.Fill(myDS, "Project");
				rpt.SetDataSource(myDS);
				My.MyProject.Forms.frmProjectReport.CrystalReportViewer1.ReportSource = rpt;
				My.MyProject.Forms.frmProjectReport.Show();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Button5_Click(System.Object sender, System.EventArgs e)
		{
			try {
				Cursor = Cursors.WaitCursor;
				Timer1.Enabled = true;
				rptProject rpt = new rptProject();
				//The report you created.
				OleDbConnection myConnection = null;
				OleDbCommand MyCommand = new OleDbCommand();
				OleDbDataAdapter myDA = new OleDbDataAdapter();
				LMS_DBDataSet myDS = new LMS_DBDataSet();
				//The DataSet you created.
				myConnection = new OleDbConnection(cs);
				MyCommand.Connection = myConnection;
				MyCommand.CommandText = "SELECT * from Project where StudentName like '%" + txtStudentName.Text + "%' order by StudentName ";
				MyCommand.CommandType = CommandType.Text;
				myDA.SelectCommand = MyCommand;
				myDA.Fill(myDS, "Project");
				rpt.SetDataSource(myDS);
				My.MyProject.Forms.frmProjectReport.CrystalReportViewer1.ReportSource = rpt;
				My.MyProject.Forms.frmProjectReport.Show();
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

		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			try {
				Cursor = Cursors.WaitCursor;
				Timer1.Enabled = true;
				rptProject rpt = new rptProject();
				//The report you created.
				OleDbConnection myConnection = null;
				OleDbCommand MyCommand = new OleDbCommand();
				OleDbDataAdapter myDA = new OleDbDataAdapter();
				LMS_DBDataSet myDS = new LMS_DBDataSet();
				//The DataSet you created.
				myConnection = new OleDbConnection(cs);
				MyCommand.Connection = myConnection;
				MyCommand.CommandText = "SELECT * from Project where Projectname like '" + txtProjectTitle.Text + "%' order by Projectname";
				MyCommand.CommandType = CommandType.Text;
				myDA.SelectCommand = MyCommand;
				myDA.Fill(myDS, "Project");
				rpt.SetDataSource(myDS);
				My.MyProject.Forms.frmProjectReport.CrystalReportViewer1.ReportSource = rpt;
				My.MyProject.Forms.frmProjectReport.Show();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public frmProjectRecord1()
		{
			Load += frmProjectRecord1_Load;
			InitializeComponent();
		}
	}
}

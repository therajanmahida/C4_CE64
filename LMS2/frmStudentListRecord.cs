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
namespace LibraryManagementSystem
{
	public partial class frmStudentListRecord
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
		private void frmStudentList_Load(System.Object sender, System.EventArgs e)
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
				string ct = "select distinct RTRIM(Department) from Student,StudentList where Student.StudentID=StudentList.StudentID and course = '" + cmbCourse.Text + "'";
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

		private void cmbDepartment_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				cmbDepartment.Text = cmbDepartment.Text.Trim();
				cmbYear.Items.Clear();
				cmbYear.Text = "";
				cmbYear.Enabled = true;
				cmbYear.Focus();
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "select distinct RTRIM(C_Year) from StudentList,Student where StudentList.StudentID=Student.StudentID and course = '" + cmbCourse.Text + "'";
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

		private void cmbSession_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				cmbCourse.Items.Clear();
				cmbCourse.Text = "";
				cmbCourse.Enabled = true;
				cmbCourse.Focus();
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "select distinct RTRIM(Course) from Student,StudentList where Student.StudentID=StudentList.StudentID and Stu_Session= '" + cmbSession.Text + "'";
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
			cmbYear.Text = "";
			cmbCourse.Enabled = false;
			cmbDepartment.Enabled = false;
			cmbYear.Enabled = false;
			btnViewReport.Enabled = true;
			listView1.Items.Clear();
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
			if (string.IsNullOrEmpty(cmbYear.Text)) {
				MessageBox.Show("Please select year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cmbYear.Focus();
				return;
			}

			try {
				var _with1 = listView1;
				_with1.Clear();
				_with1.Columns.Add("Student ID", 100, HorizontalAlignment.Left);
				_with1.Columns.Add("Student Name", 250, HorizontalAlignment.Center);
				con = new OleDbConnection(cs);
				con.Open();

				cmd = new OleDbCommand("select Student.StudentID,StudentName from StudentList,Student where StudentList.StudentID=Student.StudentID and Course = '" + cmbCourse.Text + "' and Department= '" + cmbDepartment.Text + "' and Stu_Session= '" + cmbSession.Text + "' and C_Year= '" + cmbYear.Text + "' and Status='Yes' order by StudentName", con);

				rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					var item = new ListViewItem();
					item.Text = rdr[0].ToString().Trim();
					item.SubItems.Add(rdr[1].ToString().Trim());
					listView1.Items.Add(item);
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnViewReport_Click(System.Object sender, System.EventArgs e)
		{
			try {
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
				if (string.IsNullOrEmpty(cmbYear.Text)) {
					MessageBox.Show("Please select year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbYear.Focus();
					return;
				}

				Cursor = Cursors.WaitCursor;
				Timer1.Enabled = true;
				rptStudentList rpt = new rptStudentList();
				//The report you created.
				OleDbConnection myConnection = null;
				OleDbCommand MyCommand = new OleDbCommand();
				OleDbDataAdapter myDA = new OleDbDataAdapter();
				Student_DBDataSet myDS = new Student_DBDataSet();
				//The DataSet you created.
				myConnection = new OleDbConnection(cs);
				MyCommand.Connection = myConnection;
				MyCommand.CommandText = "select Student.StudentID,StudentName,Course,Department,Stu_Session,C_Year from StudentList,Student where StudentList.StudentID=Student.StudentID and Course = '" + cmbCourse.Text + "' and Department= '" + cmbDepartment.Text + "' and Stu_Session= '" + cmbSession.Text + "' and C_Year= '" + cmbYear.Text + "' and Status='Yes' order by StudentName";
				MyCommand.CommandType = CommandType.Text;
				myDA.SelectCommand = MyCommand;
				myDA.Fill(myDS, "Student");
				myDA.Fill(myDS, "StudentList");
				rpt.SetDataSource(myDS);
				My.MyProject.Forms.frmStudentsReport.CrystalReportViewer1.ReportSource = rpt;
				My.MyProject.Forms.frmStudentsReport.Show();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Timer1_Tick(System.Object sender, System.EventArgs e)
		{
			Cursor = Cursors.Default;
			Timer1.Enabled = false;
		}
		public frmStudentListRecord()
		{
			Load += frmStudentList_Load;
			InitializeComponent();
		}
	}
}

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
	public partial class frmStudentList
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
				string ct = "select distinct RTRIM(Department) from Student where course = '" + cmbCourse.Text + "'";
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
				string ct = "select distinct RTRIM(C_Year) from tblYears where course = '" + cmbCourse.Text + "'";
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
				string ct = "select distinct RTRIM(Course) from Student where Stu_Session= '" + cmbSession.Text + "'";
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
			btnUpdate_record.Enabled = false;
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
				btnUpdate_record.Enabled = true;
				var _with1 = listView1;
				_with1.Clear();
				_with1.Columns.Add("Student ID", 100, HorizontalAlignment.Left);
				_with1.Columns.Add("Student Name", 250, HorizontalAlignment.Center);

				_with1.Columns.Add("Status", 0, HorizontalAlignment.Center);
				con = new OleDbConnection(cs);
				con.Open();

				cmd = new OleDbCommand("select Student.StudentID,StudentName,Status from StudentList,Student where StudentList.StudentID=Student.StudentID and Course = '" + cmbCourse.Text + "' and Department= '" + cmbDepartment.Text + "' and Stu_Session= '" + cmbSession.Text + "' and C_Year= '" + cmbYear.Text + "' order by StudentName", con);

				rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					var item = new ListViewItem();
					item.Text = rdr[0].ToString().Trim();
					item.SubItems.Add(rdr[1].ToString().Trim());
					item.SubItems.Add(rdr[2].ToString().Trim());
					listView1.Items.Add(item);
					for (int i = listView1.Items.Count - 1; i >= 0; i += -1) {
						if (listView1.Items[i].SubItems[2].Text == "Yes") {
							listView1.Items[i].Checked = true;
						} else {
							listView1.Items[i].Checked = false;
						}
					}
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnUpdate_record_Click(System.Object sender, System.EventArgs e)
		{

			try {

				for (int i = listView1.Items.Count - 1; i >= 0; i += -1) {
					con = new OleDbConnection(cs);
					if (listView1.Items[i].Checked == true) {
						txtStatus.Text = "Yes";
					} else {
						txtStatus.Text = "No";
					}
					string cd = "update StudentList set Status=@d1,C_Year=@d2 where StudentID=@d3";
					cmd = new OleDbCommand(cd);
					cmd.Connection = con;
					cmd.Parameters.AddWithValue("d1", txtStatus.Text);
					cmd.Parameters.AddWithValue("d2", cmbYear.Text);
					cmd.Parameters.AddWithValue("d3", listView1.Items[i].SubItems[0].Text);
					con.Open();
					cmd.ExecuteNonQuery();
					con.Close();
				}
				MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnUpdate_record.Enabled = false;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmStudentListRecord.Show();
		}

		private void Button1_Click(System.Object sender, System.EventArgs e)
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
				btnUpdate_record.Enabled = true;
				var _with1 = listView1;
				_with1.Clear();
				_with1.Columns.Add("Student ID", 100, HorizontalAlignment.Left);
				_with1.Columns.Add("Student Name", 250, HorizontalAlignment.Center);
				con = new OleDbConnection(cs);
				con.Open();

				cmd = new OleDbCommand("select Student.StudentID,StudentName,Status from StudentList,Student where StudentList.StudentID=Student.StudentID and Course = '" + cmbCourse.Text + "' and Department= '" + cmbDepartment.Text + "' and Stu_Session= '" + cmbSession.Text + "' order by StudentName", con);

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
		public frmStudentList()
		{
			Load += frmStudentList_Load;
			InitializeComponent();
		}
	}
}

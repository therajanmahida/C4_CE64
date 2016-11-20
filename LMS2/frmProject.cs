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
	public partial class frmProject
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
			txtProjectName.Text = "";
			txtRemarks.Text = "";
			txtStudentName.Text = "";
			cmbCourse.Text = "";
			cmbYear.Text = "";
			dtpSubmissionDate.Text = DateAndTime.Today;
			btnSave.Enabled = true;
			btnDelete.Enabled = false;
			btnUpdate_record.Enabled = false;
			cmbYear.Enabled = false;
			txtProjectName.Focus();
		}
		public void fillCourse()
		{
			try {
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct RTRIM(Coursename) FROM Course", CN);
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
		private void frmProject_Load(System.Object sender, System.EventArgs e)
		{
			fillCourse();
		}

		private void btnNewRecord_Click(System.Object sender, System.EventArgs e)
		{
			FileSystem.Reset();
		}

		private void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (Strings.Len(Strings.Trim(txtProjectName.Text)) == 0) {
					MessageBox.Show("Please enter project name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtProjectName.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtStudentName.Text)) == 0) {
					MessageBox.Show("Please retrieve student name(s)", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtStudentName.Focus();
					return;
				}
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
				string cb = "insert into Project(ProjectName, StudentName, Course, Proj_year, SubmissionDate, Remarks) VALUES('" + txtProjectName.Text + "','" + txtStudentName.Text + "','" + cmbCourse.Text + "','" + cmbYear.Text + "',#" + dtpSubmissionDate.Text + "#,'" + txtRemarks.Text + "')";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Successfully saved", "Project Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnSave.Enabled = false;
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

		private void btnDelete_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes) {
					DeleteRecord();
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void DeleteRecord()
		{
			try {
				int RowsAffected = 0;
				con = new OleDbConnection(cs);
				con.Open();
				string cq = "delete from Project where ID = " + txtID.Text + "";
				cmd = new OleDbCommand(cq);
				cmd.Connection = con;
				RowsAffected = cmd.ExecuteNonQuery();
				if (RowsAffected > 0) {
					MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
					FileSystem.Reset();
				} else {
					MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
					FileSystem.Reset();
					if (con.State == ConnectionState.Open) {
						con.Close();
					}
					con.Close();
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnUpdate_record_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (Strings.Len(Strings.Trim(txtProjectName.Text)) == 0) {
					MessageBox.Show("Please enter project name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtProjectName.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtStudentName.Text)) == 0) {
					MessageBox.Show("Please retrieve student name(s)", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtStudentName.Focus();
					return;
				}
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
				string cb = "update Project set projectName='" + txtProjectName.Text + "',StudentName='" + txtStudentName.Text + "',Course='" + cmbCourse.Text + "',proj_Year='" + cmbYear.Text + "',SubmissionDate=#" + dtpSubmissionDate.Text + "#,remarks='" + txtRemarks.Text + "' where ID= " + txtID.Text + "";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Successfully updated", "Project Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnUpdate_record.Enabled = false;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmStudentRecord2.Show();
			My.MyProject.Forms.frmStudentRecord2.txtStudentName.Text = "";
			My.MyProject.Forms.frmStudentRecord2.cmbCourse.Text = "";
			My.MyProject.Forms.frmStudentRecord2.cmbDepartment.Text = "";
			My.MyProject.Forms.frmStudentRecord2.cmbCourse1.Text = "";
			My.MyProject.Forms.frmStudentRecord2.cmbDepartment1.Text = "";
			My.MyProject.Forms.frmStudentRecord2.cmbSession.Text = "";
			My.MyProject.Forms.frmStudentRecord2.GetData();
		}

		private void btnGetDetails_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmProjectRecord.Show();
			My.MyProject.Forms.frmProjectRecord.Reset();
		}
		public frmProject()
		{
			Load += frmProject_Load;
			InitializeComponent();
		}
	}
}

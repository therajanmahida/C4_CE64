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
	public partial class frmNewsPaper
	{
		OleDbDataReader rdr = null;
		DataTable dtable;
		OleDbConnection con = null;
		OleDbDataAdapter adp;
		DataSet ds;
		OleDbCommand cmd = null;
		DataTable dt = new DataTable();
		string Status;

		string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;";
		private void NewRecord_Click(System.Object sender, System.EventArgs e)
		{
			FileSystem.Reset();
		}
		public void Reset()
		{
			txtPaperName.Text = "";
			txtRemarks.Text = "";
			dtpDate.Text = DateAndTime.Today;
			RadioButton1.Checked = false;
			RadioButton2.Checked = false;
			btnSave.Enabled = true;
			btnDelete.Enabled = false;
			btnUpdate_record.Enabled = false;
			txtPaperName.Focus();
		}
		private void frmNewsPaper_Load(System.Object sender, System.EventArgs e)
		{
			Autocomplete();
		}

		private void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (Strings.Len(Strings.Trim(txtPaperName.Text)) == 0) {
					MessageBox.Show("Please Enter Paper Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtPaperName.Focus();
					return;
				}
				if ((RadioButton1.Checked == false & RadioButton2.Checked == false)) {
					MessageBox.Show("Please select status", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if ((RadioButton1.Checked == true)) {
					Status = RadioButton1.Text;
				}
				if ((RadioButton2.Checked == true)) {
					Status = RadioButton2.Text;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "insert into NewsPaper(PaperName, N_Date, Status, Remarks) VALUES ('" + txtPaperName.Text + "',#" + dtpDate.Text + "#,'" + Status + "','" + txtRemarks.Text + "')";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteReader();
				MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnSave.Enabled = false;
				Autocomplete();
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
				string cq = "delete from NewsPaper where ID = " + txtID.Text + "";
				cmd = new OleDbCommand(cq);
				cmd.Connection = con;
				RowsAffected = cmd.ExecuteNonQuery();
				if (RowsAffected > 0) {
					MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Autocomplete();
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
				if (Strings.Len(Strings.Trim(txtPaperName.Text)) == 0) {
					MessageBox.Show("Please Enter Paper Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtPaperName.Focus();
					return;
				}
				if ((RadioButton1.Checked == false & RadioButton2.Checked == false)) {
					MessageBox.Show("Please select status", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if ((RadioButton1.Checked == true)) {
					Status = RadioButton1.Text;
				}
				if ((RadioButton2.Checked == true)) {
					Status = RadioButton2.Text;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "update NewsPaper set PaperName='" + txtPaperName.Text + "',N_Date=#" + dtpDate.Text + "#,Status='" + Status + "',Remarks='" + txtRemarks.Text + "' where ID=" + txtID.Text + "";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteReader();
				MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnUpdate_record.Enabled = false;
				Autocomplete();
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnGetDetails_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmNewsPaperRecord.Show();
			My.MyProject.Forms.frmNewsPaperRecord.cmbPaperName.Text = "";
			My.MyProject.Forms.frmNewsPaperRecord.dtpDateFrom.Text = DateAndTime.Today;
			My.MyProject.Forms.frmNewsPaperRecord.dtpDateTo.Text = DateAndTime.Today;
			My.MyProject.Forms.frmNewsPaperRecord.DataGridView1.DataSource = null;
			My.MyProject.Forms.frmNewsPaperRecord.fillcombo();
		}
		public void Autocomplete()
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				OleDbCommand cmd = new OleDbCommand("SELECT distinct PaperName FROM NewsPaper", con);
				DataSet ds = new DataSet();
				OleDbDataAdapter da = new OleDbDataAdapter(cmd);
				da.Fill(ds, "newspaper");
				AutoCompleteStringCollection col = new AutoCompleteStringCollection();
				int i = 0;
				for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++) {
					col.Add(ds.Tables[0].Rows[i]["PaperName"].ToString());
				}
				txtPaperName.AutoCompleteSource = AutoCompleteSource.CustomSource;
				txtPaperName.AutoCompleteCustomSource = col;
				txtPaperName.AutoCompleteMode = AutoCompleteMode.Suggest;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public frmNewsPaper()
		{
			Load += frmNewsPaper_Load;
			InitializeComponent();
		}
	}
}

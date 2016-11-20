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
	public partial class frmJournalsAndMagzines
	{
		OleDbDataReader rdr = null;
		DataTable dtable;
		OleDbConnection con = null;
		OleDbDataAdapter adp;
		DataSet ds;
		OleDbCommand cmd = null;
		DataTable dt = new DataTable();
		string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;";
		private void NewRecord_Click(System.Object sender, System.EventArgs e)
		{
			FileSystem.Reset();
		}
		public void Reset()
		{
			dtpBillDate.Text = DateAndTime.Today;
			dtpPaidOn.Text = DateAndTime.Today;
			dtpSubDate.Text = DateAndTime.Today;
			dtpSubDateFrom.Text = DateAndTime.Today;
			dtpSubDateTo.Text = DateAndTime.Today;
			txtIssueNo.Text = "";
			txtVolume.Text = "";
			txtRemarks.Text = "";
			txtYear.Text = "";
			cmbMonth.Text = "";
			txtName.Text = "";
			txtNumber.Text = "";
			txtSub.Text = "";
			txtSubNo.Text = "";
			txtAmount.Text = "";
			txtBillNo.Text = "";
			cmbDepartment.Text = "";
			dtpDate.Text = DateAndTime.Today;
			cmbSupplierName.Text = "";
			dtpDateOfReceipt.Text = DateAndTime.Today;
			txtName.Focus();
			btnSave.Enabled = true;
			btnDelete.Enabled = false;
			btnUpdate.Enabled = false;
		}

		public void DeleteRecord()
		{
			try {
				int RowsAffected = 0;
				con = new OleDbConnection(cs);
				con.Open();
				string cq = "delete from JournalAndMagzines where ID = " + txtID.Text + "";
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
		public void fillSupplier()
		{
			try {
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct RTRIM(SupplierName) FROM Supplier", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbSupplierName.Items.Clear();
				foreach (DataRow drow in dtable.Rows) {
					cmbSupplierName.Items.Add(drow[0].ToString());
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
				adp.SelectCommand = new OleDbCommand("SELECT distinct RTRIM(Departmentname) FROM Department", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbDepartment.Items.Clear();
				foreach (DataRow drow in dtable.Rows) {
					cmbDepartment.Items.Add(drow[0].ToString());
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (Strings.Len(Strings.Trim(txtName.Text)) == 0) {
					MessageBox.Show("Please Enter Title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtName.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtIssueNo.Text)) == 0) {
					MessageBox.Show("Please Enter Issue No.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtIssueNo.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbMonth.Text)) == 0) {
					MessageBox.Show("Please select month", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbMonth.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtYear.Text)) == 0) {
					MessageBox.Show("Please Enter Year", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtYear.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtVolume.Text)) == 0) {
					MessageBox.Show("Please Enter Volume", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtVolume.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtNumber.Text)) == 0) {
					MessageBox.Show("Please Enter Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtNumber.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbSupplierName.Text)) == 0) {
					MessageBox.Show("Please select supplier", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbSupplierName.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbDepartment.Text)) == 0) {
					MessageBox.Show("Please select department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbDepartment.Focus();
					return;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "insert into JournalAndMagzines( JM_Name, SubscriptionNo, SubscriptionDate, Subscription, SubscriptionDateFrom, SubscriptionDateTo, BillNo, BillDate, Amount, PaidOn, IssueNo,IssueDate, Months, Jm_Year, Volume, V_num, DateOfReceipt, SupplierName, Department, Remarks) VALUES ('" + txtName.Text + "','" + txtSubNo.Text + "',#" + dtpSubDate.Text + "#,'" + txtSub.Text + "',#" + dtpSubDateFrom.Text + "#,#" + dtpSubDateTo.Text + "#,'" + txtBillNo.Text + "',#" + dtpBillDate.Text + "#," + txtAmount.Text + ",#" + dtpPaidOn.Text + "#,'" + txtIssueNo.Text + "',#" + dtpDate.Text + "#,'" + cmbMonth.Text + "'," + txtYear.Text + ",'" + txtVolume.Text + "','" + txtNumber.Text + "',#" + dtpDateOfReceipt.Text + "#,'" + cmbSupplierName.Text + "','" + cmbDepartment.Text + "','" + txtRemarks.Text + "')";
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

		private void btnUpdate_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (Strings.Len(Strings.Trim(txtName.Text)) == 0) {
					MessageBox.Show("Please Enter Title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtName.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtAmount.Text)) == 0) {
					MessageBox.Show("Please Enter Amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtAmount.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtIssueNo.Text)) == 0) {
					MessageBox.Show("Please Enter Issue No.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtIssueNo.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbMonth.Text)) == 0) {
					MessageBox.Show("Please select month", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbMonth.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtYear.Text)) == 0) {
					MessageBox.Show("Please Enter Year", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtYear.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtVolume.Text)) == 0) {
					MessageBox.Show("Please Enter Volume", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtVolume.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtNumber.Text)) == 0) {
					MessageBox.Show("Please Enter Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtNumber.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbSupplierName.Text)) == 0) {
					MessageBox.Show("Please select supplier", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbSupplierName.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbDepartment.Text)) == 0) {
					MessageBox.Show("Please select department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbDepartment.Focus();
					return;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "update JournalAndMagzines set JM_Name='" + txtName.Text + "',SubscriptionNo='" + txtSubNo.Text + "',SubscriptionDate=#" + dtpSubDate.Text + "#,Subscription='" + txtSub.Text + "',SubscriptionDateFrom=#" + dtpSubDateFrom.Text + "#,SubscriptionDateTo=#" + dtpSubDateTo.Text + "#,BillNo='" + txtBillNo.Text + "',BillDate=#" + dtpBillDate.Text + "#,Amount=" + txtAmount.Text + ",PaidOn=#" + dtpPaidOn.Text + "#,IssueNo='" + txtIssueNo.Text + "',Issuedate=#" + dtpDate.Text + "#,Months='" + cmbMonth.Text + "',JM_year=" + txtYear.Text + ",Volume='" + txtVolume.Text + "',V_Num='" + txtNumber.Text + "',DateOfReceipt=#" + dtpDateOfReceipt.Text + "#,SupplierName='" + cmbSupplierName.Text + "', Department='" + cmbDepartment.Text + "',Remarks='" + txtRemarks.Text + "' where ID=" + txtID.Text + "";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteReader();
				MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnUpdate.Enabled = false;
				Autocomplete();
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtYear_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar < Strings.Chr(48) | e.KeyChar > Strings.Chr(57)) & e.KeyChar != Strings.Chr(8)) {
				e.Handled = true;
			}
		}

		private void btnGetDetails_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmJournalsMagzinesRecord.Show();
			My.MyProject.Forms.frmJournalsMagzinesRecord.Reset();
		}
		public void Autocomplete()
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				OleDbCommand cmd = new OleDbCommand("SELECT distinct JM_name FROM JournalAndMagzines", con);
				DataSet ds = new DataSet();
				OleDbDataAdapter da = new OleDbDataAdapter(cmd);
				da.Fill(ds, "JournalAndMagzines");
				AutoCompleteStringCollection col = new AutoCompleteStringCollection();
				int i = 0;
				for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++) {
					col.Add(ds.Tables[0].Rows[i]["JM_name"].ToString());
				}
				txtName.AutoCompleteSource = AutoCompleteSource.CustomSource;
				txtName.AutoCompleteCustomSource = col;
				txtName.AutoCompleteMode = AutoCompleteMode.Suggest;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void frmJournalsAndMagzines_Load(System.Object sender, System.EventArgs e)
		{
			Autocomplete();
			fillDepartment();
			fillSupplier();
		}

		private void txtAmount_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar < Strings.Chr(48) | e.KeyChar > Strings.Chr(57)) & e.KeyChar != Strings.Chr(8)) {
				e.Handled = true;
			}
		}
		public frmJournalsAndMagzines()
		{
			Load += frmJournalsAndMagzines_Load;
			InitializeComponent();
		}
	}
}

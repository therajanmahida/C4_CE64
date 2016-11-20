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
	public partial class frmRegistration
	{
		OleDbDataReader rdr = null;
		DataTable dtable;
		OleDbConnection con = null;
		OleDbDataAdapter adp;
		DataSet ds;
		OleDbCommand cmd = null;
		DataTable dt = new DataTable();
		string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;";
		public void Reset()
		{
			txtContactNo.Text = "";
			txtEmailID.Text = "";
			txtName.Text = "";
			txtPassword.Text = "";
			txtUsername.Text = "";
			cmbUserType.Text = "";
			txtUsername.Focus();
			btnSave.Enabled = true;
			btnUpdate_record.Enabled = false;
			btnDelete.Enabled = false;
		}
		private void frmRegistration_Load(System.Object sender, System.EventArgs e)
		{
			Getdata();
		}
		public void Getdata()
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT * from Registration order by JoiningDate", con);
				rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
				DataGridView1.Rows.Clear();
				while ((rdr.Read() == true)) {
					DataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6]);
				}
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnNewRecord_Click(System.Object sender, System.EventArgs e)
		{
			FileSystem.Reset();
		}

		private void DataGridView1_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			try {
				DataGridViewRow dr = DataGridView1.SelectedRows[0];
				txtUsername.Text = dr.Cells[0].Value.ToString();
				TextBox1.Text = dr.Cells[0].Value.ToString();
				cmbUserType.Text = dr.Cells[1].Value.ToString();
				txtPassword.Text = dr.Cells[2].Value.ToString();
				txtName.Text = dr.Cells[3].Value.ToString();
				txtContactNo.Text = dr.Cells[4].Value.ToString();
				txtEmailID.Text = dr.Cells[5].Value.ToString();
				btnUpdate_record.Enabled = true;
				btnDelete.Enabled = true;
				btnSave.Enabled = false;
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

		private void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(txtUsername.Text)) {
				MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtUsername.Focus();
				return;
			}
			if (string.IsNullOrEmpty(cmbUserType.Text)) {
				MessageBox.Show("Please select user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cmbUserType.Focus();
				return;
			}
			if (string.IsNullOrEmpty(txtPassword.Text)) {
				MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPassword.Focus();
				return;
			}
			if (string.IsNullOrEmpty(txtName.Text)) {
				MessageBox.Show("Please enter name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtName.Focus();
				return;
			}
			if (string.IsNullOrEmpty(txtContactNo.Text)) {
				MessageBox.Show("Please enter contact no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtContactNo.Focus();
				return;
			}
			if (string.IsNullOrEmpty(txtEmailID.Text)) {
				MessageBox.Show("Please enter email id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtEmailID.Focus();
				return;
			}
			try {
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "select username from registration where username=@find";

				cmd = new OleDbCommand(ct);
				cmd.Connection = con;
				cmd.Parameters.Add(new OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 30, "username"));
				cmd.Parameters["@find"].Value = txtUsername.Text;
				rdr = cmd.ExecuteReader();

				if (rdr.Read()) {
					MessageBox.Show("Username Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtUsername.Text = "";
					txtUsername.Focus();
					if ((rdr != null)) {
						rdr.Close();
					}
					return;
				}

				con = new OleDbConnection(cs);
				con.Open();

				string cb = "insert into Registration(UserName, UserType, User_Password, NameOfuser, ContactNo, Email,JoiningDate) VALUES ('" + txtUsername.Text + "','" + cmbUserType.Text + "','" + txtPassword.Text + "','" + txtName.Text + "','" + txtContactNo.Text + "','" + txtEmailID.Text + "','" + System.DateTime.Now + "')";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteReader();
				con.Close();
				con = new OleDbConnection(cs);
				con.Open();
				string cb1 = "insert into users(username) VALUES ('" + txtUsername.Text + "')";
				cmd = new OleDbCommand(cb1);
				cmd.Connection = con;
				cmd.ExecuteReader();
				con.Close();
				MessageBox.Show("Successfully Registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnSave.Enabled = false;
				Getdata();
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

		private void DeleteRecord()
		{
			try {
				if (txtUsername.Text == "admin" | txtUsername.Text == "Admin") {
					MessageBox.Show("Admin account can not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				int RowsAffected = 0;
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "delete from Users where Username='" + txtUsername.Text + "'";
				cmd = new OleDbCommand(ct);
				cmd.Connection = con;
				RowsAffected = cmd.ExecuteNonQuery();
				if (con.State == ConnectionState.Open) {
					con.Close();
				}
				con = new OleDbConnection(cs);
				con.Open();
				string cq = "delete from Registration where Username='" + txtUsername.Text + "'";
				cmd = new OleDbCommand(cq);
				cmd.Connection = con;
				RowsAffected = cmd.ExecuteNonQuery();
				if (RowsAffected > 0) {
					MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Getdata();
					FileSystem.Reset();
				} else {
					MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
					FileSystem.Reset();
				}
				if (con.State == ConnectionState.Open) {
					con.Close();

				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void txtContactNo_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			if ((txtContactNo.TextLength > 10)) {
				MessageBox.Show("Only 10 digits are allowed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtContactNo.Focus();
			}
		}

		private void txtContactNo_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar < Strings.Chr(48) | e.KeyChar > Strings.Chr(57)) & e.KeyChar != Strings.Chr(8)) {
				e.Handled = true;
			}
		}

		private void txtEmailID_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex("^[a-zA-Z][\\w\\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\\w\\.-]*[a-zA-Z0-9]\\.[a-zA-Z][a-zA-Z\\.]*[a-zA-Z]$");
			if (txtEmailID.Text.Length > 0) {
				if (!rEMail.IsMatch(txtEmailID.Text)) {
					MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtEmailID.SelectAll();
					e.Cancel = true;
				}
			}
		}

		private void btnUpdate_record_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (string.IsNullOrEmpty(txtUsername.Text)) {
					MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtUsername.Focus();
					return;
				}
				if (string.IsNullOrEmpty(cmbUserType.Text)) {
					MessageBox.Show("Please select user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbUserType.Focus();
					return;
				}
				if (string.IsNullOrEmpty(txtPassword.Text)) {
					MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtPassword.Focus();
					return;
				}
				if (string.IsNullOrEmpty(txtName.Text)) {
					MessageBox.Show("Please enter name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtName.Focus();
					return;
				}
				if (string.IsNullOrEmpty(txtContactNo.Text)) {
					MessageBox.Show("Please enter contact no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtContactNo.Focus();
					return;
				}
				if (string.IsNullOrEmpty(txtEmailID.Text)) {
					MessageBox.Show("Please enter email id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtEmailID.Focus();
					return;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "update registration set username='" + txtUsername.Text + "', usertype='" + cmbUserType.Text + "',user_password='" + txtPassword.Text + "',contactno='" + txtContactNo.Text + "',email='" + txtEmailID.Text + "',nameofuser='" + txtName.Text + "' where username='" + TextBox1.Text + "'";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteReader();
				con.Close();
				con = new OleDbConnection(cs);
				MessageBox.Show("Successfully updated", "User Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnUpdate_record.Enabled = false;
				Getdata();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public frmRegistration()
		{
			Load += frmRegistration_Load;
			InitializeComponent();
		}
	}
}

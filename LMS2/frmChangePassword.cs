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
using System.Data.OleDB;
namespace LibraryManagementSystem
{
	public partial class frmChangePassword
	{

		OleDbDataReader rdr = null;

		OleDbConnection con = null;
		OleDbCommand cmd = null;

		string ck = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;";
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			try {
				int RowsAffected = 0;
				if (Strings.Len(Strings.Trim(cmbUserType.Text)) == 0) {
					MessageBox.Show("Please select user type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbUserType.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(UserName.Text)) == 0) {
					MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					UserName.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(OldPassword.Text)) == 0) {
					MessageBox.Show("Please enter old password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					OldPassword.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(NewPassword.Text)) == 0) {
					MessageBox.Show("Please enter new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					NewPassword.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(ConfirmPassword.Text)) == 0) {
					MessageBox.Show("Please confirm new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					ConfirmPassword.Focus();
					return;
				}
				if (NewPassword.TextLength < 5) {
					MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					NewPassword.Text = "";
					ConfirmPassword.Text = "";
					NewPassword.Focus();
					return;
				} else if (NewPassword.Text != ConfirmPassword.Text) {
					MessageBox.Show("Password do not match", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					NewPassword.Text = "";
					OldPassword.Text = "";
					ConfirmPassword.Text = "";
					OldPassword.Focus();
					return;
				} else if (OldPassword.Text == NewPassword.Text) {
					MessageBox.Show("Password is same..Re-enter new password", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					NewPassword.Text = "";
					ConfirmPassword.Text = "";
					NewPassword.Focus();
					return;
				}
				con = new OleDbConnection(ck);
				con.Open();
				string co = "update Registration set user_password = '" + NewPassword.Text + "'where username='" + UserName.Text + "' and user_password = '" + OldPassword.Text + "' and usertype='" + cmbUserType.Text + "'";
				cmd = new OleDbCommand(co);
				cmd.Connection = con;
				RowsAffected = cmd.ExecuteNonQuery();

				if (RowsAffected > 0) {
					MessageBox.Show("Successfully changed", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Hide();
					My.MyProject.Forms.Frmlogin.Show();
					My.MyProject.Forms.Frmlogin.cmbUserType.Text = "";
					My.MyProject.Forms.Frmlogin.txtUsername.Text = "";
					My.MyProject.Forms.Frmlogin.txtPassword.Text = "";
					My.MyProject.Forms.Frmlogin.cmbUserType.Focus();

				} else {
					MessageBox.Show("invalid user name or password", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					UserName.Text = "";
					NewPassword.Text = "";
					OldPassword.Text = "";
					ConfirmPassword.Text = "";
					UserName.Focus();
				}
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void ChangePassword_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			this.Hide();
			My.MyProject.Forms.Frmlogin.Show();
			My.MyProject.Forms.Frmlogin.cmbUserType.Text = "";
			My.MyProject.Forms.Frmlogin.txtUsername.Text = "";
			My.MyProject.Forms.Frmlogin.txtPassword.Text = "";
			My.MyProject.Forms.Frmlogin.cmbUserType.Focus();
		}





		private void frmChangePassword_Load(System.Object sender, System.EventArgs e)
		{
		}
		public frmChangePassword()
		{
			Load += frmChangePassword_Load;
			FormClosing += ChangePassword_FormClosing;
			InitializeComponent();
		}
	}
}

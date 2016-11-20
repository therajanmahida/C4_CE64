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
	public partial class Frmlogin
	{

		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (Strings.Len(Strings.Trim(cmbUserType.Text)) == 0) {
				MessageBox.Show("Please select user type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cmbUserType.Focus();
				return;
			}
			if (Strings.Len(Strings.Trim(txtUsername.Text)) == 0) {
				MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtUsername.Focus();
				return;
			}
			if (Strings.Len(Strings.Trim(txtPassword.Text)) == 0) {
				MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPassword.Focus();
				return;
			}
			try {
				OleDbConnection myConnection = null;
				myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;");
				OleDbCommand myCommand = null;
				myCommand = new OleDbCommand("SELECT users.username,User_password FROM Users,Registration where Registration.Username=users.username and Users.Username = @Username and user_password = @UserPassword", myConnection);

				OleDbParameter uName = new OleDbParameter("@Username", SqlDbType.VarChar);
				OleDbParameter uPassword = new OleDbParameter("@UserPassword", SqlDbType.VarChar);
				uName.Value = txtUsername.Text;
				uPassword.Value = txtPassword.Text;
				myCommand.Parameters.Add(uName);

				myCommand.Parameters.Add(uPassword);

				myCommand.Connection.Open();

				OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

				object Login = 0;


				if (myReader.HasRows) {
					myReader.Read();

					Login = myReader[Login];

				}


				if (Login == null) {
					Interaction.MsgBox("Login is Failed...Try again !", MsgBoxStyle.Critical, "Login Denied");
					txtUsername.Clear();
					txtPassword.Clear();
					txtUsername.Focus();


				} else {
					ProgressBar1.Visible = true;
					ProgressBar1.Maximum = 5000;
					ProgressBar1.Minimum = 0;
					ProgressBar1.Value = 4;
					ProgressBar1.Step = 1;

					for (i = 0; i <= 5000; i++) {
						ProgressBar1.PerformStep();
					}
					this.Hide();
					My.MyProject.Forms.frmMain.lblUser.Text = txtUsername.Text;
					My.MyProject.Forms.frmMain.Show();
				}
				myCommand.Dispose();
				myConnection.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void Frmlogin_Load(System.Object sender, System.EventArgs e)
		{
		}

		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			System.Environment.Exit(0);
		}

		private void linkLabel1_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			My.MyProject.Forms.frmChangePassword.Show();
			My.MyProject.Forms.frmChangePassword.cmbUserType.Text = "";
			My.MyProject.Forms.frmChangePassword.UserName.Text = "";
			My.MyProject.Forms.frmChangePassword.OldPassword.Text = "";
			My.MyProject.Forms.frmChangePassword.NewPassword.Text = "";
			My.MyProject.Forms.frmChangePassword.ConfirmPassword.Text = "";
			My.MyProject.Forms.frmChangePassword.cmbUserType.Focus();
		}

		private void linkLabel3_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			My.MyProject.Forms.frmPasswordRecovery.Show();
		}

		private void Frmlogin_FormClosing(System.Object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			System.Environment.Exit(0);
		}
		public Frmlogin()
		{
			FormClosing += Frmlogin_FormClosing;
			Load += Frmlogin_Load;
			InitializeComponent();
		}
	}
}

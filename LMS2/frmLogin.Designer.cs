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
namespace LibraryManagementSystem
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class Frmlogin : System.Windows.Forms.Form
	{

		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try {
				if (disposing && components != null) {
					components.Dispose();
				}
			} finally {
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer

		private System.ComponentModel.IContainer components;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlogin));
			this.Button2 = new System.Windows.Forms.Button();
			this.Button1 = new System.Windows.Forms.Button();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.cmbUserType = new System.Windows.Forms.ComboBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			//
			//Button2
			//
			this.Button2.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button2.Location = new System.Drawing.Point(481, 257);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(76, 34);
			this.Button2.TabIndex = 4;
			this.Button2.Text = "&Cancel";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(385, 257);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(80, 34);
			this.Button1.TabIndex = 3;
			this.Button1.Text = "&OK";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//linkLabel3
			//
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel3.Font = new System.Drawing.Font("Palatino Linotype", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.linkLabel3.ForeColor = System.Drawing.Color.Black;
			this.linkLabel3.LinkColor = System.Drawing.Color.Blue;
			this.linkLabel3.Location = new System.Drawing.Point(430, 319);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(153, 22);
			this.linkLabel3.TabIndex = 6;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "Password Recovery";
			//
			//linkLabel1
			//
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Font = new System.Drawing.Font("Palatino Linotype", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.linkLabel1.ForeColor = System.Drawing.Color.Black;
			this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
			this.linkLabel1.Location = new System.Drawing.Point(263, 321);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(142, 22);
			this.linkLabel1.TabIndex = 5;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Change Password";
			//
			//cmbUserType
			//
			this.cmbUserType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cmbUserType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbUserType.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.cmbUserType.FormattingEnabled = true;
			this.cmbUserType.Items.AddRange(new object[] {
				"Admin",
				"User"
			});
			this.cmbUserType.Location = new System.Drawing.Point(385, 141);
			this.cmbUserType.Name = "cmbUserType";
			this.cmbUserType.Size = new System.Drawing.Size(172, 26);
			this.cmbUserType.TabIndex = 0;
			//
			//txtPassword
			//
			this.txtPassword.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtPassword.Location = new System.Drawing.Point(385, 214);
			this.txtPassword.Multiline = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = Strings.ChrW(9824);
			this.txtPassword.Size = new System.Drawing.Size(172, 25);
			this.txtPassword.TabIndex = 2;
			//
			//txtUsername
			//
			this.txtUsername.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtUsername.Location = new System.Drawing.Point(385, 178);
			this.txtUsername.Multiline = true;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(172, 25);
			this.txtUsername.TabIndex = 1;
			//
			//PasswordLabel
			//
			this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
			this.PasswordLabel.Font = new System.Drawing.Font("Palatino Linotype", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.PasswordLabel.ForeColor = System.Drawing.Color.Black;
			this.PasswordLabel.Location = new System.Drawing.Point(277, 212);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(90, 23);
			this.PasswordLabel.TabIndex = 67;
			this.PasswordLabel.Text = "&Password";
			this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//UsernameLabel
			//
			this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
			this.UsernameLabel.Font = new System.Drawing.Font("Palatino Linotype", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.UsernameLabel.ForeColor = System.Drawing.Color.Black;
			this.UsernameLabel.Location = new System.Drawing.Point(277, 176);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(105, 23);
			this.UsernameLabel.TabIndex = 66;
			this.UsernameLabel.Text = "&User Name";
			this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//label2
			//
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(277, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 28);
			this.label2.TabIndex = 65;
			this.label2.Text = "&User Type";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//ProgressBar1
			//
			this.ProgressBar1.Location = new System.Drawing.Point(-8, 351);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(869, 10);
			this.ProgressBar1.TabIndex = 68;
			this.ProgressBar1.Visible = false;
			//
			//Frmlogin
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::LibraryManagementSystem.My.Resources.Resources.login__2_;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(854, 357);
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.linkLabel3);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.cmbUserType);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UsernameLabel);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frmlogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login Form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button withEventsField_Button2;
		internal System.Windows.Forms.Button Button2 {
			get { return withEventsField_Button2; }
			set {
				if (withEventsField_Button2 != null) {
					withEventsField_Button2.Click -= Button2_Click;
				}
				withEventsField_Button2 = value;
				if (withEventsField_Button2 != null) {
					withEventsField_Button2.Click += Button2_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_Button1;
		internal System.Windows.Forms.Button Button1 {
			get { return withEventsField_Button1; }
			set {
				if (withEventsField_Button1 != null) {
					withEventsField_Button1.Click -= Button1_Click;
				}
				withEventsField_Button1 = value;
				if (withEventsField_Button1 != null) {
					withEventsField_Button1.Click += Button1_Click;
				}
			}
		}
		private System.Windows.Forms.LinkLabel withEventsField_linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel3 {
			get { return withEventsField_linkLabel3; }
			set {
				if (withEventsField_linkLabel3 != null) {
					withEventsField_linkLabel3.LinkClicked -= linkLabel3_LinkClicked;
				}
				withEventsField_linkLabel3 = value;
				if (withEventsField_linkLabel3 != null) {
					withEventsField_linkLabel3.LinkClicked += linkLabel3_LinkClicked;
				}
			}
		}
		private System.Windows.Forms.LinkLabel withEventsField_linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel1 {
			get { return withEventsField_linkLabel1; }
			set {
				if (withEventsField_linkLabel1 != null) {
					withEventsField_linkLabel1.LinkClicked -= linkLabel1_LinkClicked;
				}
				withEventsField_linkLabel1 = value;
				if (withEventsField_linkLabel1 != null) {
					withEventsField_linkLabel1.LinkClicked += linkLabel1_LinkClicked;
				}
			}
		}
		internal System.Windows.Forms.ComboBox cmbUserType;
		internal System.Windows.Forms.TextBox txtPassword;
		internal System.Windows.Forms.TextBox txtUsername;
		internal System.Windows.Forms.Label PasswordLabel;
		internal System.Windows.Forms.Label UsernameLabel;
		internal System.Windows.Forms.Label label2;

		internal System.Windows.Forms.ProgressBar ProgressBar1;
	}
}

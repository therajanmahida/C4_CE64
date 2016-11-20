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
	partial class frmChangePassword : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.OldPassword = new System.Windows.Forms.TextBox();
			this.NewPassword = new System.Windows.Forms.TextBox();
			this.ConfirmPassword = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.Label4 = new System.Windows.Forms.Label();
			this.UserName = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.cmbUserType = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(24, 115);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(83, 17);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Old Password";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(24, 157);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(88, 17);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "New Password";
			//
			//OldPassword
			//
			this.OldPassword.Location = new System.Drawing.Point(163, 112);
			this.OldPassword.Name = "OldPassword";
			this.OldPassword.PasswordChar = Strings.ChrW(9824);
			this.OldPassword.Size = new System.Drawing.Size(122, 20);
			this.OldPassword.TabIndex = 2;
			//
			//NewPassword
			//
			this.NewPassword.Location = new System.Drawing.Point(163, 154);
			this.NewPassword.Name = "NewPassword";
			this.NewPassword.PasswordChar = Strings.ChrW(9824);
			this.NewPassword.Size = new System.Drawing.Size(122, 20);
			this.NewPassword.TabIndex = 3;
			//
			//ConfirmPassword
			//
			this.ConfirmPassword.Location = new System.Drawing.Point(163, 197);
			this.ConfirmPassword.Name = "ConfirmPassword";
			this.ConfirmPassword.PasswordChar = Strings.ChrW(9824);
			this.ConfirmPassword.Size = new System.Drawing.Size(122, 20);
			this.ConfirmPassword.TabIndex = 4;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(24, 200);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(109, 17);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "Confirm Password";
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(97, 251);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(115, 38);
			this.Button1.TabIndex = 5;
			this.Button1.Text = "&Change Password";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(24, 75);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(69, 17);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "User Name";
			//
			//UserName
			//
			this.UserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.UserName.Location = new System.Drawing.Point(163, 72);
			this.UserName.Name = "UserName";
			this.UserName.Size = new System.Drawing.Size(122, 20);
			this.UserName.TabIndex = 1;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.BackColor = System.Drawing.Color.Transparent;
			this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(24, 36);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(65, 17);
			this.Label5.TabIndex = 9;
			this.Label5.Text = "User Type";
			//
			//cmbUserType
			//
			this.cmbUserType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cmbUserType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbUserType.FormattingEnabled = true;
			this.cmbUserType.Items.AddRange(new object[] {
				"Admin",
				"User"
			});
			this.cmbUserType.Location = new System.Drawing.Point(163, 36);
			this.cmbUserType.Name = "cmbUserType";
			this.cmbUserType.Size = new System.Drawing.Size(121, 21);
			this.cmbUserType.TabIndex = 0;
			//
			//frmChangePassword
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::LibraryManagementSystem.My.Resources.Resources.textures_wallpapers_simple_and_beautifull_wood_texture_backgrounds;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(318, 318);
			this.Controls.Add(this.cmbUserType);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.UserName);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.ConfirmPassword);
			this.Controls.Add(this.NewPassword);
			this.Controls.Add(this.OldPassword);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmChangePassword";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Change Password";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox OldPassword;
		internal System.Windows.Forms.TextBox NewPassword;
		internal System.Windows.Forms.TextBox ConfirmPassword;
		internal System.Windows.Forms.Label Label3;
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
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox UserName;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.ComboBox cmbUserType;
	}
}

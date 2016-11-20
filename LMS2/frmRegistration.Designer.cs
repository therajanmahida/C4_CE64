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
	partial class frmRegistration : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
			this.cmbUserType = new System.Windows.Forms.ComboBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtContactNo = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtEmailID = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.btnNewRecord = new System.Windows.Forms.Button();
			this.btnUpdate_record = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.GroupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.SuspendLayout();
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
			this.cmbUserType.Location = new System.Drawing.Point(126, 76);
			this.cmbUserType.Name = "cmbUserType";
			this.cmbUserType.Size = new System.Drawing.Size(121, 25);
			this.cmbUserType.TabIndex = 1;
			//
			//GroupBox1
			//
			this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox1.Controls.Add(this.cmbUserType);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.txtContactNo);
			this.GroupBox1.Controls.Add(this.txtUsername);
			this.GroupBox1.Controls.Add(this.txtEmailID);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.txtName);
			this.GroupBox1.Controls.Add(this.txtPassword);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.GroupBox1.ForeColor = System.Drawing.Color.Black;
			this.GroupBox1.Location = new System.Drawing.Point(32, 29);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(407, 289);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "User Details";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label6.Location = new System.Drawing.Point(31, 78);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(70, 18);
			this.Label6.TabIndex = 17;
			this.Label6.Text = "User Type";
			//
			//txtContactNo
			//
			this.txtContactNo.Location = new System.Drawing.Point(126, 191);
			this.txtContactNo.Name = "txtContactNo";
			this.txtContactNo.Size = new System.Drawing.Size(121, 24);
			this.txtContactNo.TabIndex = 4;
			//
			//txtUsername
			//
			this.txtUsername.Location = new System.Drawing.Point(126, 40);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(183, 24);
			this.txtUsername.TabIndex = 0;
			//
			//txtEmailID
			//
			this.txtEmailID.Location = new System.Drawing.Point(126, 233);
			this.txtEmailID.Name = "txtEmailID";
			this.txtEmailID.Size = new System.Drawing.Size(262, 24);
			this.txtEmailID.TabIndex = 5;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(33, 233);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(62, 18);
			this.Label1.TabIndex = 13;
			this.Label1.Text = "Email ID";
			//
			//txtName
			//
			this.txtName.Location = new System.Drawing.Point(126, 155);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(262, 24);
			this.txtName.TabIndex = 3;
			//
			//txtPassword
			//
			this.txtPassword.Location = new System.Drawing.Point(126, 116);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = Strings.ChrW(42);
			this.txtPassword.Size = new System.Drawing.Size(183, 24);
			this.txtPassword.TabIndex = 2;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(31, 193);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(80, 18);
			this.Label5.TabIndex = 12;
			this.Label5.Text = "Contact No.";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(31, 153);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(45, 18);
			this.Label4.TabIndex = 11;
			this.Label4.Text = "Name";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(31, 114);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(67, 18);
			this.Label3.TabIndex = 10;
			this.Label3.Text = "Password";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(31, 40);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(76, 18);
			this.Label2.TabIndex = 9;
			this.Label2.Text = "User Name";
			//
			//btnNewRecord
			//
			this.btnNewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnNewRecord.Location = new System.Drawing.Point(16, 14);
			this.btnNewRecord.Name = "btnNewRecord";
			this.btnNewRecord.Size = new System.Drawing.Size(95, 33);
			this.btnNewRecord.TabIndex = 0;
			this.btnNewRecord.Text = "&New";
			this.btnNewRecord.UseVisualStyleBackColor = true;
			//
			//btnUpdate_record
			//
			this.btnUpdate_record.Enabled = false;
			this.btnUpdate_record.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnUpdate_record.Location = new System.Drawing.Point(16, 133);
			this.btnUpdate_record.Name = "btnUpdate_record";
			this.btnUpdate_record.Size = new System.Drawing.Size(95, 33);
			this.btnUpdate_record.TabIndex = 3;
			this.btnUpdate_record.Text = "&Update";
			this.btnUpdate_record.UseVisualStyleBackColor = true;
			//
			//panel1
			//
			this.panel1.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnUpdate_record);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.btnNewRecord);
			this.panel1.Location = new System.Drawing.Point(455, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(129, 180);
			this.panel1.TabIndex = 1;
			//
			//btnDelete
			//
			this.btnDelete.Enabled = false;
			this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnDelete.Location = new System.Drawing.Point(16, 93);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(95, 33);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			//
			//btnSave
			//
			this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnSave.Location = new System.Drawing.Point(16, 53);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(95, 33);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "&Register";
			this.btnSave.UseVisualStyleBackColor = true;
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
				this.Column1,
				this.Column2,
				this.Column3,
				this.Column4,
				this.Column5,
				this.Column6,
				this.Column7
			});
			this.DataGridView1.Location = new System.Drawing.Point(32, 337);
			this.DataGridView1.MultiSelect = false;
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DataGridView1.Size = new System.Drawing.Size(750, 316);
			this.DataGridView1.TabIndex = 2;
			//
			//Column1
			//
			this.Column1.HeaderText = "User Name";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			//
			//Column2
			//
			this.Column2.HeaderText = "User Type";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			//
			//Column3
			//
			this.Column3.HeaderText = "Password";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			//
			//Column4
			//
			this.Column4.HeaderText = "Name";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			//
			//Column5
			//
			this.Column5.HeaderText = "Contact No.";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			//
			//Column6
			//
			this.Column6.HeaderText = "Email";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			//
			//Column7
			//
			this.Column7.HeaderText = "Registered Date";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(467, 225);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(100, 24);
			this.TextBox1.TabIndex = 3;
			this.TextBox1.Visible = false;
			//
			//frmRegistration
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BackgroundImage = global::LibraryManagementSystem.My.Resources.Resources.textures_wallpapers_simple_and_beautifull_wood_texture_backgrounds;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(824, 665);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmRegistration";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registration";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.ComboBox cmbUserType;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label6;
		private System.Windows.Forms.TextBox withEventsField_txtContactNo;
		internal System.Windows.Forms.TextBox txtContactNo {
			get { return withEventsField_txtContactNo; }
			set {
				if (withEventsField_txtContactNo != null) {
					withEventsField_txtContactNo.Validating -= txtContactNo_Validating;
					withEventsField_txtContactNo.KeyPress -= txtContactNo_KeyPress;
				}
				withEventsField_txtContactNo = value;
				if (withEventsField_txtContactNo != null) {
					withEventsField_txtContactNo.Validating += txtContactNo_Validating;
					withEventsField_txtContactNo.KeyPress += txtContactNo_KeyPress;
				}
			}
		}
		internal System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox withEventsField_txtEmailID;
		internal System.Windows.Forms.TextBox txtEmailID {
			get { return withEventsField_txtEmailID; }
			set {
				if (withEventsField_txtEmailID != null) {
					withEventsField_txtEmailID.Validating -= txtEmailID_Validating;
				}
				withEventsField_txtEmailID = value;
				if (withEventsField_txtEmailID != null) {
					withEventsField_txtEmailID.Validating += txtEmailID_Validating;
				}
			}
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtName;
		internal System.Windows.Forms.TextBox txtPassword;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Button withEventsField_btnNewRecord;
		private System.Windows.Forms.Button btnNewRecord {
			get { return withEventsField_btnNewRecord; }
			set {
				if (withEventsField_btnNewRecord != null) {
					withEventsField_btnNewRecord.Click -= btnNewRecord_Click;
				}
				withEventsField_btnNewRecord = value;
				if (withEventsField_btnNewRecord != null) {
					withEventsField_btnNewRecord.Click += btnNewRecord_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnUpdate_record;
		public System.Windows.Forms.Button btnUpdate_record {
			get { return withEventsField_btnUpdate_record; }
			set {
				if (withEventsField_btnUpdate_record != null) {
					withEventsField_btnUpdate_record.Click -= btnUpdate_record_Click;
				}
				withEventsField_btnUpdate_record = value;
				if (withEventsField_btnUpdate_record != null) {
					withEventsField_btnUpdate_record.Click += btnUpdate_record_Click;
				}
			}
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button withEventsField_btnDelete;
		public System.Windows.Forms.Button btnDelete {
			get { return withEventsField_btnDelete; }
			set {
				if (withEventsField_btnDelete != null) {
					withEventsField_btnDelete.Click -= btnDelete_Click;
				}
				withEventsField_btnDelete = value;
				if (withEventsField_btnDelete != null) {
					withEventsField_btnDelete.Click += btnDelete_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnSave;
		public System.Windows.Forms.Button btnSave {
			get { return withEventsField_btnSave; }
			set {
				if (withEventsField_btnSave != null) {
					withEventsField_btnSave.Click -= btnSave_Click;
				}
				withEventsField_btnSave = value;
				if (withEventsField_btnSave != null) {
					withEventsField_btnSave.Click += btnSave_Click;
				}
			}
		}
		private System.Windows.Forms.DataGridView withEventsField_DataGridView1;
		internal System.Windows.Forms.DataGridView DataGridView1 {
			get { return withEventsField_DataGridView1; }
			set {
				if (withEventsField_DataGridView1 != null) {
					withEventsField_DataGridView1.RowHeaderMouseClick -= DataGridView1_RowHeaderMouseClick;
					withEventsField_DataGridView1.RowPostPaint -= DataGridView1_RowPostPaint;
				}
				withEventsField_DataGridView1 = value;
				if (withEventsField_DataGridView1 != null) {
					withEventsField_DataGridView1.RowHeaderMouseClick += DataGridView1_RowHeaderMouseClick;
					withEventsField_DataGridView1.RowPostPaint += DataGridView1_RowPostPaint;
				}
			}
		}
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		internal System.Windows.Forms.TextBox TextBox1;
	}
}

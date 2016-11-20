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
	partial class frmNewsPaper : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewsPaper));
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtPaperName = new System.Windows.Forms.TextBox();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.Label20 = new System.Windows.Forms.Label();
			this.txtRemarks = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnUpdate_record = new System.Windows.Forms.Button();
			this.btnGetDetails = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnNewRecord = new System.Windows.Forms.Button();
			this.txtID = new System.Windows.Forms.TextBox();
			this.GroupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtPaperName);
			this.GroupBox1.Controls.Add(this.RadioButton2);
			this.GroupBox1.Controls.Add(this.RadioButton1);
			this.GroupBox1.Controls.Add(this.dtpDate);
			this.GroupBox1.Controls.Add(this.Label20);
			this.GroupBox1.Controls.Add(this.txtRemarks);
			this.GroupBox1.Controls.Add(this.Label11);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(21, 28);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(442, 208);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "News Paper";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Location = new System.Drawing.Point(47, 99);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(45, 18);
			this.Label2.TabIndex = 93;
			this.Label2.Text = "Status";
			//
			//txtPaperName
			//
			this.txtPaperName.Location = new System.Drawing.Point(156, 27);
			this.txtPaperName.Name = "txtPaperName";
			this.txtPaperName.Size = new System.Drawing.Size(237, 25);
			this.txtPaperName.TabIndex = 0;
			//
			//RadioButton2
			//
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Location = new System.Drawing.Point(214, 101);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(36, 22);
			this.RadioButton2.TabIndex = 91;
			this.RadioButton2.TabStop = true;
			this.RadioButton2.Text = "A";
			this.RadioButton2.UseVisualStyleBackColor = true;
			//
			//RadioButton1
			//
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Location = new System.Drawing.Point(156, 101);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(34, 22);
			this.RadioButton1.TabIndex = 2;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "P";
			this.RadioButton1.UseVisualStyleBackColor = true;
			//
			//dtpDate
			//
			this.dtpDate.CustomFormat = "dd/MMM/yyyy";
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDate.Location = new System.Drawing.Point(156, 63);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(140, 25);
			this.dtpDate.TabIndex = 1;
			//
			//Label20
			//
			this.Label20.AutoSize = true;
			this.Label20.BackColor = System.Drawing.Color.Transparent;
			this.Label20.Location = new System.Drawing.Point(47, 67);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(37, 18);
			this.Label20.TabIndex = 87;
			this.Label20.Text = "Date";
			//
			//txtRemarks
			//
			this.txtRemarks.Location = new System.Drawing.Point(156, 138);
			this.txtRemarks.Multiline = true;
			this.txtRemarks.Name = "txtRemarks";
			this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtRemarks.Size = new System.Drawing.Size(265, 52);
			this.txtRemarks.TabIndex = 3;
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.BackColor = System.Drawing.Color.Transparent;
			this.Label11.Location = new System.Drawing.Point(47, 133);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(62, 18);
			this.Label11.TabIndex = 85;
			this.Label11.Text = "Remarks";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Location = new System.Drawing.Point(47, 30);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(83, 18);
			this.Label1.TabIndex = 84;
			this.Label1.Text = "Paper Name";
			//
			//btnDelete
			//
			this.btnDelete.Enabled = false;
			this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnDelete.Location = new System.Drawing.Point(14, 84);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(94, 27);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			//
			//btnSave
			//
			this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnSave.Location = new System.Drawing.Point(14, 51);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(94, 27);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			//
			//btnUpdate_record
			//
			this.btnUpdate_record.Enabled = false;
			this.btnUpdate_record.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnUpdate_record.Location = new System.Drawing.Point(14, 117);
			this.btnUpdate_record.Name = "btnUpdate_record";
			this.btnUpdate_record.Size = new System.Drawing.Size(94, 27);
			this.btnUpdate_record.TabIndex = 3;
			this.btnUpdate_record.Text = "&Update";
			this.btnUpdate_record.UseVisualStyleBackColor = true;
			//
			//btnGetDetails
			//
			this.btnGetDetails.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnGetDetails.Location = new System.Drawing.Point(14, 150);
			this.btnGetDetails.Name = "btnGetDetails";
			this.btnGetDetails.Size = new System.Drawing.Size(94, 28);
			this.btnGetDetails.TabIndex = 4;
			this.btnGetDetails.Text = "&Get Data";
			this.btnGetDetails.UseVisualStyleBackColor = true;
			//
			//panel1
			//
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnGetDetails);
			this.panel1.Controls.Add(this.btnUpdate_record);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.btnNewRecord);
			this.panel1.Location = new System.Drawing.Point(482, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(123, 197);
			this.panel1.TabIndex = 1;
			//
			//btnNewRecord
			//
			this.btnNewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnNewRecord.Location = new System.Drawing.Point(14, 18);
			this.btnNewRecord.Name = "btnNewRecord";
			this.btnNewRecord.Size = new System.Drawing.Size(94, 27);
			this.btnNewRecord.TabIndex = 0;
			this.btnNewRecord.Text = "&New";
			this.btnNewRecord.UseVisualStyleBackColor = true;
			//
			//txtID
			//
			this.txtID.Location = new System.Drawing.Point(482, 12);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(100, 25);
			this.txtID.TabIndex = 9;
			this.txtID.Visible = false;
			//
			//frmNewsPaper
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::LibraryManagementSystem.My.Resources.Resources.textures_wallpapers_simple_and_beautifull_wood_texture_backgrounds1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(621, 266);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "frmNewsPaper";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "News Paper Entry";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.RadioButton RadioButton2;
		internal System.Windows.Forms.RadioButton RadioButton1;
		internal System.Windows.Forms.DateTimePicker dtpDate;
		internal System.Windows.Forms.Label Label20;
		internal System.Windows.Forms.TextBox txtRemarks;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label1;
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
		private System.Windows.Forms.Button withEventsField_btnGetDetails;
		public System.Windows.Forms.Button btnGetDetails {
			get { return withEventsField_btnGetDetails; }
			set {
				if (withEventsField_btnGetDetails != null) {
					withEventsField_btnGetDetails.Click -= btnGetDetails_Click;
				}
				withEventsField_btnGetDetails = value;
				if (withEventsField_btnGetDetails != null) {
					withEventsField_btnGetDetails.Click += btnGetDetails_Click;
				}
			}
		}
		internal System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button withEventsField_btnNewRecord;
		public System.Windows.Forms.Button btnNewRecord {
			get { return withEventsField_btnNewRecord; }
			set {
				if (withEventsField_btnNewRecord != null) {
					withEventsField_btnNewRecord.Click -= NewRecord_Click;
				}
				withEventsField_btnNewRecord = value;
				if (withEventsField_btnNewRecord != null) {
					withEventsField_btnNewRecord.Click += NewRecord_Click;
				}
			}
		}
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtPaperName;
		internal System.Windows.Forms.TextBox txtID;
	}
}

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
	partial class frmProject : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProject));
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.cmbCourse = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtStudentName = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.dtpSubmissionDate = new System.Windows.Forms.DateTimePicker();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtRemarks = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.txtProjectName = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnGetDetails = new System.Windows.Forms.Button();
			this.btnUpdate_record = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnNewRecord = new System.Windows.Forms.Button();
			this.txtID = new System.Windows.Forms.TextBox();
			this.GroupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.cmbYear);
			this.GroupBox1.Controls.Add(this.cmbCourse);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.txtStudentName);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.dtpSubmissionDate);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtRemarks);
			this.GroupBox1.Controls.Add(this.Label11);
			this.GroupBox1.Controls.Add(this.txtProjectName);
			this.GroupBox1.Controls.Add(this.Label10);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(28, 24);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(665, 310);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Project";
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(601, 76);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(28, 23);
			this.Button1.TabIndex = 95;
			this.Button1.Text = ">";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//cmbYear
			//
			this.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbYear.Enabled = false;
			this.cmbYear.FormattingEnabled = true;
			this.cmbYear.Location = new System.Drawing.Point(211, 143);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.Size = new System.Drawing.Size(121, 26);
			this.cmbYear.TabIndex = 3;
			//
			//cmbCourse
			//
			this.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbCourse.FormattingEnabled = true;
			this.cmbCourse.Location = new System.Drawing.Point(211, 109);
			this.cmbCourse.Name = "cmbCourse";
			this.cmbCourse.Size = new System.Drawing.Size(173, 26);
			this.cmbCourse.TabIndex = 2;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.Location = new System.Drawing.Point(33, 113);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(51, 18);
			this.Label4.TabIndex = 91;
			this.Label4.Text = "Course";
			//
			//txtStudentName
			//
			this.txtStudentName.Location = new System.Drawing.Point(211, 74);
			this.txtStudentName.Multiline = true;
			this.txtStudentName.Name = "txtStudentName";
			this.txtStudentName.ReadOnly = true;
			this.txtStudentName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtStudentName.Size = new System.Drawing.Size(384, 28);
			this.txtStudentName.TabIndex = 1;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Location = new System.Drawing.Point(33, 79);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(112, 18);
			this.Label3.TabIndex = 86;
			this.Label3.Text = "Student Name (s)";
			//
			//dtpSubmissionDate
			//
			this.dtpSubmissionDate.CustomFormat = "dd/MMM/yyyy";
			this.dtpSubmissionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpSubmissionDate.Location = new System.Drawing.Point(211, 180);
			this.dtpSubmissionDate.Name = "dtpSubmissionDate";
			this.dtpSubmissionDate.Size = new System.Drawing.Size(136, 25);
			this.dtpSubmissionDate.TabIndex = 4;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Location = new System.Drawing.Point(33, 184);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(112, 18);
			this.Label2.TabIndex = 83;
			this.Label2.Text = "Submission Date";
			//
			//txtRemarks
			//
			this.txtRemarks.Location = new System.Drawing.Point(211, 220);
			this.txtRemarks.Multiline = true;
			this.txtRemarks.Name = "txtRemarks";
			this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtRemarks.Size = new System.Drawing.Size(384, 70);
			this.txtRemarks.TabIndex = 5;
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.BackColor = System.Drawing.Color.Transparent;
			this.Label11.Location = new System.Drawing.Point(33, 222);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(62, 18);
			this.Label11.TabIndex = 77;
			this.Label11.Text = "Remarks";
			//
			//txtProjectName
			//
			this.txtProjectName.Location = new System.Drawing.Point(211, 42);
			this.txtProjectName.Name = "txtProjectName";
			this.txtProjectName.Size = new System.Drawing.Size(384, 25);
			this.txtProjectName.TabIndex = 0;
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.BackColor = System.Drawing.Color.Transparent;
			this.Label10.Location = new System.Drawing.Point(33, 148);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(35, 18);
			this.Label10.TabIndex = 75;
			this.Label10.Text = "Year";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Location = new System.Drawing.Point(33, 45);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(90, 18);
			this.Label1.TabIndex = 72;
			this.Label1.Text = "Project Name";
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
			this.panel1.Location = new System.Drawing.Point(709, 34);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(123, 197);
			this.panel1.TabIndex = 2;
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
			this.txtID.Location = new System.Drawing.Point(709, 2);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(100, 25);
			this.txtID.TabIndex = 10;
			this.txtID.Visible = false;
			//
			//frmProject
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::LibraryManagementSystem.My.Resources.Resources.textures_wallpapers_simple_and_beautifull_wood_texture_backgrounds1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(872, 357);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.GroupBox1);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "frmProject";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Project";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.ComboBox cmbYear;
		private System.Windows.Forms.ComboBox withEventsField_cmbCourse;
		internal System.Windows.Forms.ComboBox cmbCourse {
			get { return withEventsField_cmbCourse; }
			set {
				if (withEventsField_cmbCourse != null) {
					withEventsField_cmbCourse.SelectedIndexChanged -= cmbCourse_SelectedIndexChanged;
				}
				withEventsField_cmbCourse = value;
				if (withEventsField_cmbCourse != null) {
					withEventsField_cmbCourse.SelectedIndexChanged += cmbCourse_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox txtStudentName;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.DateTimePicker dtpSubmissionDate;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtRemarks;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.TextBox txtProjectName;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Panel panel1;
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
		private System.Windows.Forms.Button withEventsField_btnNewRecord;
		public System.Windows.Forms.Button btnNewRecord {
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
		internal System.Windows.Forms.TextBox txtID;
	}
}

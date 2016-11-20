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
	partial class frmNoDues : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNoDues));
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Button3 = new System.Windows.Forms.Button();
			this.btnUpdate_record = new System.Windows.Forms.Button();
			this.NewRecord = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.cmbSession = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.cmbDepartment = new System.Windows.Forms.ComboBox();
			this.cmbCourse = new System.Windows.Forms.ComboBox();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.txtStatus1 = new System.Windows.Forms.TextBox();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.btnGetData1 = new System.Windows.Forms.Button();
			this.btnUpdate1 = new System.Windows.Forms.Button();
			this.btnNewRecord1 = new System.Windows.Forms.Button();
			this.Button8 = new System.Windows.Forms.Button();
			this.ListView2 = new System.Windows.Forms.ListView();
			this.ColumnHeader2 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader4 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.cmbDepartment1 = new System.Windows.Forms.ComboBox();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//TabControl1
			//
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Location = new System.Drawing.Point(-3, 0);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(913, 668);
			this.TabControl1.TabIndex = 0;
			//
			//TabPage1
			//
			this.TabPage1.Controls.Add(this.txtStatus);
			this.TabPage1.Controls.Add(this.panel1);
			this.TabPage1.Controls.Add(this.Button2);
			this.TabPage1.Controls.Add(this.listView1);
			this.TabPage1.Controls.Add(this.GroupBox3);
			this.TabPage1.Location = new System.Drawing.Point(4, 26);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(905, 638);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Students";
			this.TabPage1.UseVisualStyleBackColor = true;
			//
			//txtStatus
			//
			this.txtStatus.Location = new System.Drawing.Point(738, 43);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(100, 24);
			this.txtStatus.TabIndex = 68;
			this.txtStatus.Visible = false;
			//
			//panel1
			//
			this.panel1.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.Button3);
			this.panel1.Controls.Add(this.btnUpdate_record);
			this.panel1.Controls.Add(this.NewRecord);
			this.panel1.Location = new System.Drawing.Point(386, 96);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(129, 141);
			this.panel1.TabIndex = 65;
			//
			//Button3
			//
			this.Button3.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button3.Location = new System.Drawing.Point(16, 92);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(95, 33);
			this.Button3.TabIndex = 4;
			this.Button3.Text = "&Get Data";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//btnUpdate_record
			//
			this.btnUpdate_record.Enabled = false;
			this.btnUpdate_record.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnUpdate_record.Location = new System.Drawing.Point(16, 53);
			this.btnUpdate_record.Name = "btnUpdate_record";
			this.btnUpdate_record.Size = new System.Drawing.Size(95, 33);
			this.btnUpdate_record.TabIndex = 3;
			this.btnUpdate_record.Text = "&Update";
			this.btnUpdate_record.UseVisualStyleBackColor = true;
			//
			//NewRecord
			//
			this.NewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.NewRecord.Location = new System.Drawing.Point(16, 14);
			this.NewRecord.Name = "NewRecord";
			this.NewRecord.Size = new System.Drawing.Size(95, 33);
			this.NewRecord.TabIndex = 0;
			this.NewRecord.Text = "&New";
			this.NewRecord.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button2.Location = new System.Drawing.Point(603, 39);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(80, 35);
			this.Button2.TabIndex = 67;
			this.Button2.Text = "Get List";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//listView1
			//
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
				this.columnHeader1,
				this.columnHeader3
			});
			this.listView1.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(6, 96);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(356, 536);
			this.listView1.TabIndex = 64;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			//
			//columnHeader1
			//
			this.columnHeader1.Text = "Student ID";
			this.columnHeader1.Width = 100;
			//
			//columnHeader3
			//
			this.columnHeader3.Text = "Student Name";
			this.columnHeader3.Width = 250;
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.Label4);
			this.GroupBox3.Controls.Add(this.cmbSession);
			this.GroupBox3.Controls.Add(this.Label2);
			this.GroupBox3.Controls.Add(this.Label1);
			this.GroupBox3.Controls.Add(this.cmbDepartment);
			this.GroupBox3.Controls.Add(this.cmbCourse);
			this.GroupBox3.Location = new System.Drawing.Point(6, 1);
			this.GroupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox3.Size = new System.Drawing.Size(576, 88);
			this.GroupBox3.TabIndex = 63;
			this.GroupBox3.TabStop = false;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(18, 21);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(48, 17);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "Session";
			//
			//cmbSession
			//
			this.cmbSession.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbSession.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSession.FormattingEnabled = true;
			this.cmbSession.Location = new System.Drawing.Point(21, 44);
			this.cmbSession.Name = "cmbSession";
			this.cmbSession.Size = new System.Drawing.Size(165, 25);
			this.cmbSession.TabIndex = 6;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(360, 24);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(74, 17);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Department";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(189, 21);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(47, 17);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Course";
			//
			//cmbDepartment
			//
			this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbDepartment.Enabled = false;
			this.cmbDepartment.FormattingEnabled = true;
			this.cmbDepartment.Location = new System.Drawing.Point(363, 44);
			this.cmbDepartment.Name = "cmbDepartment";
			this.cmbDepartment.Size = new System.Drawing.Size(189, 25);
			this.cmbDepartment.TabIndex = 2;
			//
			//cmbCourse
			//
			this.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbCourse.Enabled = false;
			this.cmbCourse.FormattingEnabled = true;
			this.cmbCourse.Location = new System.Drawing.Point(191, 44);
			this.cmbCourse.Name = "cmbCourse";
			this.cmbCourse.Size = new System.Drawing.Size(165, 25);
			this.cmbCourse.TabIndex = 0;
			//
			//TabPage2
			//
			this.TabPage2.Controls.Add(this.txtStatus1);
			this.TabPage2.Controls.Add(this.Panel2);
			this.TabPage2.Controls.Add(this.Button8);
			this.TabPage2.Controls.Add(this.ListView2);
			this.TabPage2.Controls.Add(this.GroupBox1);
			this.TabPage2.Location = new System.Drawing.Point(4, 26);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new System.Drawing.Size(905, 638);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Staff";
			this.TabPage2.UseVisualStyleBackColor = true;
			//
			//txtStatus1
			//
			this.txtStatus1.Location = new System.Drawing.Point(382, 306);
			this.txtStatus1.Name = "txtStatus1";
			this.txtStatus1.Size = new System.Drawing.Size(100, 24);
			this.txtStatus1.TabIndex = 73;
			this.txtStatus1.Visible = false;
			//
			//Panel2
			//
			this.Panel2.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.Panel2.BackColor = System.Drawing.Color.Transparent;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.btnGetData1);
			this.Panel2.Controls.Add(this.btnUpdate1);
			this.Panel2.Controls.Add(this.btnNewRecord1);
			this.Panel2.Location = new System.Drawing.Point(382, 99);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(129, 142);
			this.Panel2.TabIndex = 71;
			//
			//btnGetData1
			//
			this.btnGetData1.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnGetData1.Location = new System.Drawing.Point(16, 92);
			this.btnGetData1.Name = "btnGetData1";
			this.btnGetData1.Size = new System.Drawing.Size(95, 33);
			this.btnGetData1.TabIndex = 4;
			this.btnGetData1.Text = "&Get Data";
			this.btnGetData1.UseVisualStyleBackColor = true;
			//
			//btnUpdate1
			//
			this.btnUpdate1.Enabled = false;
			this.btnUpdate1.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnUpdate1.Location = new System.Drawing.Point(16, 53);
			this.btnUpdate1.Name = "btnUpdate1";
			this.btnUpdate1.Size = new System.Drawing.Size(95, 33);
			this.btnUpdate1.TabIndex = 3;
			this.btnUpdate1.Text = "&Update";
			this.btnUpdate1.UseVisualStyleBackColor = true;
			//
			//btnNewRecord1
			//
			this.btnNewRecord1.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnNewRecord1.Location = new System.Drawing.Point(16, 14);
			this.btnNewRecord1.Name = "btnNewRecord1";
			this.btnNewRecord1.Size = new System.Drawing.Size(95, 33);
			this.btnNewRecord1.TabIndex = 0;
			this.btnNewRecord1.Text = "&New";
			this.btnNewRecord1.UseVisualStyleBackColor = true;
			//
			//Button8
			//
			this.Button8.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button8.Location = new System.Drawing.Point(287, 40);
			this.Button8.Name = "Button8";
			this.Button8.Size = new System.Drawing.Size(80, 35);
			this.Button8.TabIndex = 72;
			this.Button8.Text = "Get List";
			this.Button8.UseVisualStyleBackColor = true;
			//
			//ListView2
			//
			this.ListView2.CheckBoxes = true;
			this.ListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
				this.ColumnHeader2,
				this.ColumnHeader4
			});
			this.ListView2.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.ListView2.GridLines = true;
			this.ListView2.Location = new System.Drawing.Point(11, 99);
			this.ListView2.Name = "ListView2";
			this.ListView2.Size = new System.Drawing.Size(356, 536);
			this.ListView2.TabIndex = 65;
			this.ListView2.UseCompatibleStateImageBehavior = false;
			this.ListView2.View = System.Windows.Forms.View.Details;
			//
			//ColumnHeader2
			//
			this.ColumnHeader2.Text = "Staff ID";
			this.ColumnHeader2.Width = 100;
			//
			//ColumnHeader4
			//
			this.ColumnHeader4.Text = "Staff Name";
			this.ColumnHeader4.Width = 250;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.cmbDepartment1);
			this.GroupBox1.Location = new System.Drawing.Point(11, 7);
			this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Size = new System.Drawing.Size(262, 88);
			this.GroupBox1.TabIndex = 64;
			this.GroupBox1.TabStop = false;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(15, 21);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(74, 17);
			this.Label6.TabIndex = 4;
			this.Label6.Text = "Department";
			//
			//cmbDepartment1
			//
			this.cmbDepartment1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbDepartment1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbDepartment1.FormattingEnabled = true;
			this.cmbDepartment1.Location = new System.Drawing.Point(18, 43);
			this.cmbDepartment1.Name = "cmbDepartment1";
			this.cmbDepartment1.Size = new System.Drawing.Size(225, 25);
			this.cmbDepartment1.TabIndex = 2;
			//
			//frmNoDues
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(906, 668);
			this.Controls.Add(this.TabControl1);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "frmNoDues";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "No Dues Doc";
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.TabControl withEventsField_TabControl1;
		internal System.Windows.Forms.TabControl TabControl1 {
			get { return withEventsField_TabControl1; }
			set {
				if (withEventsField_TabControl1 != null) {
					withEventsField_TabControl1.Click -= TabControl1_Click;
				}
				withEventsField_TabControl1 = value;
				if (withEventsField_TabControl1 != null) {
					withEventsField_TabControl1.Click += TabControl1_Click;
				}
			}
		}
		internal System.Windows.Forms.TabPage TabPage1;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button withEventsField_Button3;
		public System.Windows.Forms.Button Button3 {
			get { return withEventsField_Button3; }
			set {
				if (withEventsField_Button3 != null) {
					withEventsField_Button3.Click -= Button3_Click_1;
				}
				withEventsField_Button3 = value;
				if (withEventsField_Button3 != null) {
					withEventsField_Button3.Click += Button3_Click_1;
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
		private System.Windows.Forms.Button withEventsField_NewRecord;
		public System.Windows.Forms.Button NewRecord {
			get { return withEventsField_NewRecord; }
			set {
				if (withEventsField_NewRecord != null) {
					withEventsField_NewRecord.Click -= NewRecord_Click;
				}
				withEventsField_NewRecord = value;
				if (withEventsField_NewRecord != null) {
					withEventsField_NewRecord.Click += NewRecord_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_Button2;
		public System.Windows.Forms.Button Button2 {
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
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Label Label4;
		private System.Windows.Forms.ComboBox withEventsField_cmbSession;
		internal System.Windows.Forms.ComboBox cmbSession {
			get { return withEventsField_cmbSession; }
			set {
				if (withEventsField_cmbSession != null) {
					withEventsField_cmbSession.SelectedIndexChanged -= cmbSession_SelectedIndexChanged;
				}
				withEventsField_cmbSession = value;
				if (withEventsField_cmbSession != null) {
					withEventsField_cmbSession.SelectedIndexChanged += cmbSession_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ComboBox cmbDepartment;
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
		internal System.Windows.Forms.TabPage TabPage2;
		private System.Windows.Forms.TextBox txtStatus1;
		private System.Windows.Forms.Panel Panel2;
		private System.Windows.Forms.Button withEventsField_btnGetData1;
		public System.Windows.Forms.Button btnGetData1 {
			get { return withEventsField_btnGetData1; }
			set {
				if (withEventsField_btnGetData1 != null) {
					withEventsField_btnGetData1.Click -= btnGetData1_Click;
				}
				withEventsField_btnGetData1 = value;
				if (withEventsField_btnGetData1 != null) {
					withEventsField_btnGetData1.Click += btnGetData1_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnUpdate1;
		public System.Windows.Forms.Button btnUpdate1 {
			get { return withEventsField_btnUpdate1; }
			set {
				if (withEventsField_btnUpdate1 != null) {
					withEventsField_btnUpdate1.Click -= btnUpdate1_Click;
				}
				withEventsField_btnUpdate1 = value;
				if (withEventsField_btnUpdate1 != null) {
					withEventsField_btnUpdate1.Click += btnUpdate1_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnNewRecord1;
		public System.Windows.Forms.Button btnNewRecord1 {
			get { return withEventsField_btnNewRecord1; }
			set {
				if (withEventsField_btnNewRecord1 != null) {
					withEventsField_btnNewRecord1.Click -= btnNewRecord1_Click;
				}
				withEventsField_btnNewRecord1 = value;
				if (withEventsField_btnNewRecord1 != null) {
					withEventsField_btnNewRecord1.Click += btnNewRecord1_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_Button8;
		public System.Windows.Forms.Button Button8 {
			get { return withEventsField_Button8; }
			set {
				if (withEventsField_Button8 != null) {
					withEventsField_Button8.Click -= Button8_Click;
				}
				withEventsField_Button8 = value;
				if (withEventsField_Button8 != null) {
					withEventsField_Button8.Click += Button8_Click;
				}
			}
		}
		private System.Windows.Forms.ListView ListView2;
		private System.Windows.Forms.ColumnHeader ColumnHeader2;
		private System.Windows.Forms.ColumnHeader ColumnHeader4;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.ComboBox cmbDepartment1;
		public frmNoDues()
		{
			Load += frmStudentList_Load;
			InitializeComponent();
		}
	}
}

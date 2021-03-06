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
	partial class frmStudentList : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentList));
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Label4 = new System.Windows.Forms.Label();
			this.cmbSession = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.cmbDepartment = new System.Windows.Forms.ComboBox();
			this.cmbCourse = new System.Windows.Forms.ComboBox();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Button3 = new System.Windows.Forms.Button();
			this.btnUpdate_record = new System.Windows.Forms.Button();
			this.NewRecord = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Button2 = new System.Windows.Forms.Button();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.GroupBox3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.Button1);
			this.GroupBox3.Controls.Add(this.Label4);
			this.GroupBox3.Controls.Add(this.cmbSession);
			this.GroupBox3.Controls.Add(this.Label2);
			this.GroupBox3.Controls.Add(this.Label1);
			this.GroupBox3.Controls.Add(this.cmbDepartment);
			this.GroupBox3.Controls.Add(this.cmbCourse);
			this.GroupBox3.Location = new System.Drawing.Point(14, 13);
			this.GroupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox3.Size = new System.Drawing.Size(615, 88);
			this.GroupBox3.TabIndex = 1;
			this.GroupBox3.TabStop = false;
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(564, 42);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(31, 27);
			this.Button1.TabIndex = 9;
			this.Button1.Text = ">";
			this.Button1.UseVisualStyleBackColor = true;
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
			this.cmbCourse.Location = new System.Drawing.Point(192, 44);
			this.cmbCourse.Name = "cmbCourse";
			this.cmbCourse.Size = new System.Drawing.Size(165, 25);
			this.cmbCourse.TabIndex = 0;
			//
			//cmbYear
			//
			this.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbYear.Enabled = false;
			this.cmbYear.FormattingEnabled = true;
			this.cmbYear.Location = new System.Drawing.Point(24, 46);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.Size = new System.Drawing.Size(118, 25);
			this.cmbYear.TabIndex = 2;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(21, 22);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(32, 17);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Year";
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
			this.listView1.Location = new System.Drawing.Point(14, 108);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(356, 557);
			this.listView1.TabIndex = 7;
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
			//panel1
			//
			this.panel1.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.Button3);
			this.panel1.Controls.Add(this.btnUpdate_record);
			this.panel1.Controls.Add(this.NewRecord);
			this.panel1.Location = new System.Drawing.Point(394, 108);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(129, 140);
			this.panel1.TabIndex = 8;
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
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.cmbYear);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Location = new System.Drawing.Point(644, 13);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(160, 88);
			this.GroupBox1.TabIndex = 9;
			this.GroupBox1.TabStop = false;
			//
			//Button2
			//
			this.Button2.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button2.Location = new System.Drawing.Point(814, 45);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(80, 35);
			this.Button2.TabIndex = 10;
			this.Button2.Text = "Get List";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//txtStatus
			//
			this.txtStatus.Location = new System.Drawing.Point(394, 363);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(100, 24);
			this.txtStatus.TabIndex = 62;
			this.txtStatus.Visible = false;
			//
			//frmStudentList
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(906, 668);
			this.Controls.Add(this.txtStatus);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.GroupBox3);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "frmStudentList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Students List";
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ComboBox cmbYear;
		private System.Windows.Forms.ComboBox withEventsField_cmbDepartment;
		internal System.Windows.Forms.ComboBox cmbDepartment {
			get { return withEventsField_cmbDepartment; }
			set {
				if (withEventsField_cmbDepartment != null) {
					withEventsField_cmbDepartment.SelectedIndexChanged -= cmbDepartment_SelectedIndexChanged;
				}
				withEventsField_cmbDepartment = value;
				if (withEventsField_cmbDepartment != null) {
					withEventsField_cmbDepartment.SelectedIndexChanged += cmbDepartment_SelectedIndexChanged;
				}
			}
		}
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
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Panel panel1;
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
		internal System.Windows.Forms.GroupBox GroupBox1;
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
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.Button withEventsField_Button3;
		public System.Windows.Forms.Button Button3 {
			get { return withEventsField_Button3; }
			set {
				if (withEventsField_Button3 != null) {
					withEventsField_Button3.Click -= Button3_Click;
				}
				withEventsField_Button3 = value;
				if (withEventsField_Button3 != null) {
					withEventsField_Button3.Click += Button3_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_Button1;
		public System.Windows.Forms.Button Button1 {
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
	}
}

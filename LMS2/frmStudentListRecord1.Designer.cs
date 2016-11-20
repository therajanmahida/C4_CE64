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
	partial class frmStudentListRecord1 : System.Windows.Forms.Form
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentListRecord1));
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.cmbSession = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.cmbDepartment = new System.Windows.Forms.ComboBox();
			this.cmbCourse = new System.Windows.Forms.ComboBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnViewReport = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.GroupBox3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.cmbYear);
			this.GroupBox3.Controls.Add(this.Label3);
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
			this.GroupBox3.Size = new System.Drawing.Size(702, 88);
			this.GroupBox3.TabIndex = 1;
			this.GroupBox3.TabStop = false;
			//
			//cmbYear
			//
			this.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbYear.Enabled = false;
			this.cmbYear.FormattingEnabled = true;
			this.cmbYear.Location = new System.Drawing.Point(564, 44);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.Size = new System.Drawing.Size(118, 25);
			this.cmbYear.TabIndex = 2;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(561, 24);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(32, 17);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Year";
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
			//listView1
			//
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
			this.panel1.Controls.Add(this.btnViewReport);
			this.panel1.Controls.Add(this.btnReset);
			this.panel1.Location = new System.Drawing.Point(387, 108);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(129, 104);
			this.panel1.TabIndex = 8;
			//
			//btnViewReport
			//
			this.btnViewReport.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnViewReport.Location = new System.Drawing.Point(16, 53);
			this.btnViewReport.Name = "btnViewReport";
			this.btnViewReport.Size = new System.Drawing.Size(95, 33);
			this.btnViewReport.TabIndex = 1;
			this.btnViewReport.Text = "&View Report";
			this.btnViewReport.UseVisualStyleBackColor = true;
			//
			//btnReset
			//
			this.btnReset.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnReset.Location = new System.Drawing.Point(16, 14);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(95, 33);
			this.btnReset.TabIndex = 0;
			this.btnReset.Text = "&Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button2.Location = new System.Drawing.Point(732, 37);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(80, 35);
			this.Button2.TabIndex = 10;
			this.Button2.Text = "Get List";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Timer1
			//
			//
			//frmStudentListRecord1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(835, 668);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.GroupBox3);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "frmStudentListRecord1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Students Record";
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

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
		private System.Windows.Forms.Button withEventsField_btnViewReport;
		public System.Windows.Forms.Button btnViewReport {
			get { return withEventsField_btnViewReport; }
			set {
				if (withEventsField_btnViewReport != null) {
					withEventsField_btnViewReport.Click -= btnViewReport_Click;
				}
				withEventsField_btnViewReport = value;
				if (withEventsField_btnViewReport != null) {
					withEventsField_btnViewReport.Click += btnViewReport_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnReset;
		public System.Windows.Forms.Button btnReset {
			get { return withEventsField_btnReset; }
			set {
				if (withEventsField_btnReset != null) {
					withEventsField_btnReset.Click -= NewRecord_Click;
				}
				withEventsField_btnReset = value;
				if (withEventsField_btnReset != null) {
					withEventsField_btnReset.Click += NewRecord_Click;
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
		private System.Windows.Forms.Timer withEventsField_Timer1;
		internal System.Windows.Forms.Timer Timer1 {
			get { return withEventsField_Timer1; }
			set {
				if (withEventsField_Timer1 != null) {
					withEventsField_Timer1.Tick -= Timer1_Tick;
				}
				withEventsField_Timer1 = value;
				if (withEventsField_Timer1 != null) {
					withEventsField_Timer1.Tick += Timer1_Tick;
				}
			}
		}
	}
}

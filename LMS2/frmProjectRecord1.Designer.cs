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
	partial class frmProjectRecord1 : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectRecord1));
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Button7 = new System.Windows.Forms.Button();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.cmbCourse = new System.Windows.Forms.ComboBox();
			this.Button3 = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Button6 = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.Button2 = new System.Windows.Forms.Button();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.btnExportExcel = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.Button5 = new System.Windows.Forms.Button();
			this.txtStudentName = new System.Windows.Forms.TextBox();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.txtProjectTitle = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.GroupBox3.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.Panel1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.Label6);
			this.GroupBox3.Controls.Add(this.Label5);
			this.GroupBox3.Controls.Add(this.Button7);
			this.GroupBox3.Controls.Add(this.cmbYear);
			this.GroupBox3.Controls.Add(this.cmbCourse);
			this.GroupBox3.Controls.Add(this.Button3);
			this.GroupBox3.Location = new System.Drawing.Point(16, 12);
			this.GroupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox3.Size = new System.Drawing.Size(474, 88);
			this.GroupBox3.TabIndex = 4;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "By Course Name and Year";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label6.Location = new System.Drawing.Point(201, 17);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(30, 16);
			this.Label6.TabIndex = 41;
			this.Label6.Text = "Year";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(16, 17);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(43, 16);
			this.Label5.TabIndex = 40;
			this.Label5.Text = "Course";
			//
			//Button7
			//
			this.Button7.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button7.Location = new System.Drawing.Point(295, 36);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(69, 25);
			this.Button7.TabIndex = 39;
			this.Button7.Text = "&Search";
			this.Button7.UseVisualStyleBackColor = true;
			//
			//cmbYear
			//
			this.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbYear.Enabled = false;
			this.cmbYear.FormattingEnabled = true;
			this.cmbYear.Location = new System.Drawing.Point(203, 36);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.Size = new System.Drawing.Size(83, 25);
			this.cmbYear.TabIndex = 38;
			//
			//cmbCourse
			//
			this.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbCourse.FormattingEnabled = true;
			this.cmbCourse.Location = new System.Drawing.Point(19, 36);
			this.cmbCourse.Name = "cmbCourse";
			this.cmbCourse.Size = new System.Drawing.Size(177, 25);
			this.cmbCourse.TabIndex = 37;
			//
			//Button3
			//
			this.Button3.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button3.Location = new System.Drawing.Point(370, 36);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(93, 24);
			this.Button3.TabIndex = 36;
			this.Button3.Text = "&View Report";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Button6);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.DateTimePicker1);
			this.GroupBox1.Controls.Add(this.DateTimePicker2);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Location = new System.Drawing.Point(386, 109);
			this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Size = new System.Drawing.Size(495, 88);
			this.GroupBox1.TabIndex = 6;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "By Submission Date";
			//
			//Button6
			//
			this.Button6.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button6.Location = new System.Drawing.Point(388, 36);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(93, 24);
			this.Button6.TabIndex = 37;
			this.Button6.Text = "&View Report";
			this.Button6.UseVisualStyleBackColor = true;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(172, 17);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(22, 16);
			this.Label3.TabIndex = 33;
			this.Label3.Text = "To";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(24, 19);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(33, 16);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "From";
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.CustomFormat = "dd/MMM/yyyy";
			this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimePicker1.Location = new System.Drawing.Point(175, 38);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(123, 24);
			this.DateTimePicker1.TabIndex = 5;
			//
			//DateTimePicker2
			//
			this.DateTimePicker2.CustomFormat = "dd/MMM/yyyy";
			this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimePicker2.Location = new System.Drawing.Point(24, 38);
			this.DateTimePicker2.Name = "DateTimePicker2";
			this.DateTimePicker2.Size = new System.Drawing.Size(131, 24);
			this.DateTimePicker2.TabIndex = 4;
			//
			//Button2
			//
			this.Button2.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button2.Location = new System.Drawing.Point(313, 35);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(69, 25);
			this.Button2.TabIndex = 3;
			this.Button2.Text = "&Search";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//DataGridView1
			//
			this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(16, 215);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DataGridView1.Size = new System.Drawing.Size(752, 440);
			this.DataGridView1.TabIndex = 33;
			//
			//Panel1
			//
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.btnExportExcel);
			this.Panel1.Controls.Add(this.btnReset);
			this.Panel1.Location = new System.Drawing.Point(783, 215);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(124, 102);
			this.Panel1.TabIndex = 34;
			//
			//btnExportExcel
			//
			this.btnExportExcel.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnExportExcel.Location = new System.Drawing.Point(15, 54);
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(93, 36);
			this.btnExportExcel.TabIndex = 1;
			this.btnExportExcel.Text = "&Export Excel";
			this.btnExportExcel.UseVisualStyleBackColor = true;
			//
			//btnReset
			//
			this.btnReset.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnReset.Location = new System.Drawing.Point(15, 15);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(93, 33);
			this.btnReset.TabIndex = 0;
			this.btnReset.Text = "&Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.Button5);
			this.GroupBox2.Controls.Add(this.txtStudentName);
			this.GroupBox2.Location = new System.Drawing.Point(16, 108);
			this.GroupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox2.Size = new System.Drawing.Size(358, 88);
			this.GroupBox2.TabIndex = 35;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "By Student Name(s)";
			//
			//Button5
			//
			this.Button5.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button5.Location = new System.Drawing.Point(248, 36);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(93, 24);
			this.Button5.TabIndex = 37;
			this.Button5.Text = "&View Report";
			this.Button5.UseVisualStyleBackColor = true;
			//
			//txtStudentName
			//
			this.txtStudentName.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtStudentName.Location = new System.Drawing.Point(19, 37);
			this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtStudentName.Name = "txtStudentName";
			this.txtStudentName.Size = new System.Drawing.Size(222, 24);
			this.txtStudentName.TabIndex = 0;
			//
			//Timer1
			//
			//
			//GroupBox4
			//
			this.GroupBox4.Controls.Add(this.Button1);
			this.GroupBox4.Controls.Add(this.txtProjectTitle);
			this.GroupBox4.Location = new System.Drawing.Point(499, 13);
			this.GroupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox4.Size = new System.Drawing.Size(350, 88);
			this.GroupBox4.TabIndex = 38;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "By Project Title";
			//
			//txtProjectTitle
			//
			this.txtProjectTitle.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtProjectTitle.Location = new System.Drawing.Point(19, 37);
			this.txtProjectTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtProjectTitle.Name = "txtProjectTitle";
			this.txtProjectTitle.Size = new System.Drawing.Size(222, 24);
			this.txtProjectTitle.TabIndex = 0;
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(247, 37);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(93, 24);
			this.Button1.TabIndex = 38;
			this.Button1.Text = "&View Report";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//frmProjectRecord1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(932, 656);
			this.Controls.Add(this.GroupBox4);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.GroupBox3);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "frmProjectRecord1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search Projects Record";
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		private System.Windows.Forms.DateTimePicker withEventsField_DateTimePicker1;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1 {
			get { return withEventsField_DateTimePicker1; }
			set {
				if (withEventsField_DateTimePicker1 != null) {
					withEventsField_DateTimePicker1.Validating -= DateTimePicker1_Validating;
				}
				withEventsField_DateTimePicker1 = value;
				if (withEventsField_DateTimePicker1 != null) {
					withEventsField_DateTimePicker1.Validating += DateTimePicker1_Validating;
				}
			}
		}
		internal System.Windows.Forms.DateTimePicker DateTimePicker2;
		private System.Windows.Forms.Button withEventsField_Button2;
		private System.Windows.Forms.Button Button2 {
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
		private System.Windows.Forms.DataGridView withEventsField_DataGridView1;
		internal System.Windows.Forms.DataGridView DataGridView1 {
			get { return withEventsField_DataGridView1; }
			set {
				if (withEventsField_DataGridView1 != null) {
					withEventsField_DataGridView1.RowPostPaint -= DataGridView1_RowPostPaint;
				}
				withEventsField_DataGridView1 = value;
				if (withEventsField_DataGridView1 != null) {
					withEventsField_DataGridView1.RowPostPaint += DataGridView1_RowPostPaint;
				}
			}
		}
		internal System.Windows.Forms.Panel Panel1;
		private System.Windows.Forms.Button withEventsField_btnExportExcel;
		public System.Windows.Forms.Button btnExportExcel {
			get { return withEventsField_btnExportExcel; }
			set {
				if (withEventsField_btnExportExcel != null) {
					withEventsField_btnExportExcel.Click -= btnExportExcel_Click;
				}
				withEventsField_btnExportExcel = value;
				if (withEventsField_btnExportExcel != null) {
					withEventsField_btnExportExcel.Click += btnExportExcel_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnReset;
		private System.Windows.Forms.Button btnReset {
			get { return withEventsField_btnReset; }
			set {
				if (withEventsField_btnReset != null) {
					withEventsField_btnReset.Click -= btnReset_Click;
				}
				withEventsField_btnReset = value;
				if (withEventsField_btnReset != null) {
					withEventsField_btnReset.Click += btnReset_Click;
				}
			}
		}
		internal System.Windows.Forms.GroupBox GroupBox2;
		private System.Windows.Forms.TextBox withEventsField_txtStudentName;
		internal System.Windows.Forms.TextBox txtStudentName {
			get { return withEventsField_txtStudentName; }
			set {
				if (withEventsField_txtStudentName != null) {
					withEventsField_txtStudentName.TextChanged -= txtStudentName_TextChanged;
				}
				withEventsField_txtStudentName = value;
				if (withEventsField_txtStudentName != null) {
					withEventsField_txtStudentName.TextChanged += txtStudentName_TextChanged;
				}
			}
		}
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
		private System.Windows.Forms.Button withEventsField_Button6;
		public System.Windows.Forms.Button Button6 {
			get { return withEventsField_Button6; }
			set {
				if (withEventsField_Button6 != null) {
					withEventsField_Button6.Click -= Button6_Click;
				}
				withEventsField_Button6 = value;
				if (withEventsField_Button6 != null) {
					withEventsField_Button6.Click += Button6_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_Button5;
		public System.Windows.Forms.Button Button5 {
			get { return withEventsField_Button5; }
			set {
				if (withEventsField_Button5 != null) {
					withEventsField_Button5.Click -= Button5_Click;
				}
				withEventsField_Button5 = value;
				if (withEventsField_Button5 != null) {
					withEventsField_Button5.Click += Button5_Click;
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
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		private System.Windows.Forms.Button withEventsField_Button7;
		private System.Windows.Forms.Button Button7 {
			get { return withEventsField_Button7; }
			set {
				if (withEventsField_Button7 != null) {
					withEventsField_Button7.Click -= Button7_Click;
				}
				withEventsField_Button7 = value;
				if (withEventsField_Button7 != null) {
					withEventsField_Button7.Click += Button7_Click;
				}
			}
		}
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
		internal System.Windows.Forms.GroupBox GroupBox4;
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
		private System.Windows.Forms.TextBox withEventsField_txtProjectTitle;
		internal System.Windows.Forms.TextBox txtProjectTitle {
			get { return withEventsField_txtProjectTitle; }
			set {
				if (withEventsField_txtProjectTitle != null) {
					withEventsField_txtProjectTitle.TextChanged -= txtProjectTitle_TextChanged;
				}
				withEventsField_txtProjectTitle = value;
				if (withEventsField_txtProjectTitle != null) {
					withEventsField_txtProjectTitle.TextChanged += txtProjectTitle_TextChanged;
				}
			}
		}
	}
}

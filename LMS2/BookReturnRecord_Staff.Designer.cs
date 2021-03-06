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
	partial class frmBookReturnRecord_Staff : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookReturnRecord_Staff));
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtBookName = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
			this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbStaffName = new System.Windows.Forms.ComboBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.DateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.DateTimePicker4 = new System.Windows.Forms.DateTimePicker();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.DateTimePicker7 = new System.Windows.Forms.DateTimePicker();
			this.DateTimePicker8 = new System.Windows.Forms.DateTimePicker();
			this.GroupBox6 = new System.Windows.Forms.GroupBox();
			this.txtStaffName = new System.Windows.Forms.TextBox();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.btnExportExcel = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Button2 = new System.Windows.Forms.Button();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.GroupBox4.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			this.GroupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.Panel1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox4
			//
			this.GroupBox4.Controls.Add(this.Label3);
			this.GroupBox4.Controls.Add(this.txtBookName);
			this.GroupBox4.Controls.Add(this.Label2);
			this.GroupBox4.Controls.Add(this.Label1);
			this.GroupBox4.Controls.Add(this.dtpDateTo);
			this.GroupBox4.Controls.Add(this.dtpDateFrom);
			this.GroupBox4.Location = new System.Drawing.Point(12, 13);
			this.GroupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox4.Size = new System.Drawing.Size(501, 88);
			this.GroupBox4.TabIndex = 6;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "By Return Date and Book Name";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(318, 17);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(68, 16);
			this.Label3.TabIndex = 34;
			this.Label3.Text = "Book Name";
			//
			//txtBookName
			//
			this.txtBookName.Location = new System.Drawing.Point(321, 39);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.Size = new System.Drawing.Size(163, 24);
			this.txtBookName.TabIndex = 34;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(172, 17);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(22, 16);
			this.Label2.TabIndex = 33;
			this.Label2.Text = "To";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(24, 19);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(33, 16);
			this.Label1.TabIndex = 6;
			this.Label1.Text = "From";
			//
			//dtpDateTo
			//
			this.dtpDateTo.CustomFormat = "dd/MMM/yyyy";
			this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateTo.Location = new System.Drawing.Point(175, 39);
			this.dtpDateTo.Name = "dtpDateTo";
			this.dtpDateTo.Size = new System.Drawing.Size(123, 24);
			this.dtpDateTo.TabIndex = 5;
			//
			//dtpDateFrom
			//
			this.dtpDateFrom.CustomFormat = "dd/MMM/yyyy";
			this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateFrom.Location = new System.Drawing.Point(24, 38);
			this.dtpDateFrom.Name = "dtpDateFrom";
			this.dtpDateFrom.Size = new System.Drawing.Size(131, 24);
			this.dtpDateFrom.TabIndex = 4;
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.cmbStaffName);
			this.GroupBox2.Controls.Add(this.Label7);
			this.GroupBox2.Controls.Add(this.Label8);
			this.GroupBox2.Controls.Add(this.Label9);
			this.GroupBox2.Controls.Add(this.DateTimePicker3);
			this.GroupBox2.Controls.Add(this.DateTimePicker4);
			this.GroupBox2.Location = new System.Drawing.Point(12, 109);
			this.GroupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox2.Size = new System.Drawing.Size(501, 88);
			this.GroupBox2.TabIndex = 8;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "By Returned Date and Staff Name";
			//
			//cmbStaffName
			//
			this.cmbStaffName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbStaffName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbStaffName.FormattingEnabled = true;
			this.cmbStaffName.Items.AddRange(new object[] {
				"Student",
				"Staff"
			});
			this.cmbStaffName.Location = new System.Drawing.Point(321, 38);
			this.cmbStaffName.Name = "cmbStaffName";
			this.cmbStaffName.Size = new System.Drawing.Size(163, 25);
			this.cmbStaffName.TabIndex = 35;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label7.Location = new System.Drawing.Point(318, 17);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(65, 16);
			this.Label7.TabIndex = 34;
			this.Label7.Text = "Staff Name";
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label8.Location = new System.Drawing.Point(172, 17);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(22, 16);
			this.Label8.TabIndex = 33;
			this.Label8.Text = "To";
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label9.Location = new System.Drawing.Point(24, 19);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(33, 16);
			this.Label9.TabIndex = 6;
			this.Label9.Text = "From";
			//
			//DateTimePicker3
			//
			this.DateTimePicker3.CustomFormat = "dd/MMM/yyyy";
			this.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimePicker3.Location = new System.Drawing.Point(175, 38);
			this.DateTimePicker3.Name = "DateTimePicker3";
			this.DateTimePicker3.Size = new System.Drawing.Size(123, 24);
			this.DateTimePicker3.TabIndex = 5;
			//
			//DateTimePicker4
			//
			this.DateTimePicker4.CustomFormat = "dd/MMM/yyyy";
			this.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimePicker4.Location = new System.Drawing.Point(24, 38);
			this.DateTimePicker4.Name = "DateTimePicker4";
			this.DateTimePicker4.Size = new System.Drawing.Size(131, 24);
			this.DateTimePicker4.TabIndex = 4;
			//
			//GroupBox5
			//
			this.GroupBox5.Controls.Add(this.Button1);
			this.GroupBox5.Controls.Add(this.Label13);
			this.GroupBox5.Controls.Add(this.Label14);
			this.GroupBox5.Controls.Add(this.DateTimePicker7);
			this.GroupBox5.Controls.Add(this.DateTimePicker8);
			this.GroupBox5.Location = new System.Drawing.Point(532, 13);
			this.GroupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox5.Name = "GroupBox5";
			this.GroupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox5.Size = new System.Drawing.Size(332, 88);
			this.GroupBox5.TabIndex = 10;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "Return Date";
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(264, 42);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(62, 25);
			this.Button1.TabIndex = 15;
			this.Button1.Text = "&Search";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label13.Location = new System.Drawing.Point(142, 21);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(22, 16);
			this.Label13.TabIndex = 37;
			this.Label13.Text = "To";
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label14.Location = new System.Drawing.Point(17, 24);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(33, 16);
			this.Label14.TabIndex = 36;
			this.Label14.Text = "From";
			//
			//DateTimePicker7
			//
			this.DateTimePicker7.CustomFormat = "dd/MMM/yyyy";
			this.DateTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimePicker7.Location = new System.Drawing.Point(144, 43);
			this.DateTimePicker7.Name = "DateTimePicker7";
			this.DateTimePicker7.Size = new System.Drawing.Size(113, 24);
			this.DateTimePicker7.TabIndex = 35;
			//
			//DateTimePicker8
			//
			this.DateTimePicker8.CustomFormat = "dd/MMM/yyyy";
			this.DateTimePicker8.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimePicker8.Location = new System.Drawing.Point(20, 43);
			this.DateTimePicker8.Name = "DateTimePicker8";
			this.DateTimePicker8.Size = new System.Drawing.Size(112, 24);
			this.DateTimePicker8.TabIndex = 34;
			//
			//GroupBox6
			//
			this.GroupBox6.Controls.Add(this.txtStaffName);
			this.GroupBox6.Location = new System.Drawing.Point(883, 13);
			this.GroupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox6.Name = "GroupBox6";
			this.GroupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox6.Size = new System.Drawing.Size(209, 88);
			this.GroupBox6.TabIndex = 12;
			this.GroupBox6.TabStop = false;
			this.GroupBox6.Text = "By Staff Name";
			//
			//txtStaffName
			//
			this.txtStaffName.Location = new System.Drawing.Point(19, 35);
			this.txtStaffName.Name = "txtStaffName";
			this.txtStaffName.Size = new System.Drawing.Size(163, 24);
			this.txtStaffName.TabIndex = 35;
			//
			//DataGridView1
			//
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(13, 205);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.Size = new System.Drawing.Size(1158, 479);
			this.DataGridView1.TabIndex = 13;
			//
			//Panel1
			//
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.btnExportExcel);
			this.Panel1.Controls.Add(this.btnReset);
			this.Panel1.Location = new System.Drawing.Point(1181, 205);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(124, 106);
			this.Panel1.TabIndex = 14;
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
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.DateTimePicker1);
			this.GroupBox1.Controls.Add(this.DateTimePicker2);
			this.GroupBox1.Location = new System.Drawing.Point(532, 109);
			this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Size = new System.Drawing.Size(332, 88);
			this.GroupBox1.TabIndex = 15;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Return Date and Fine";
			//
			//Button2
			//
			this.Button2.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button2.Location = new System.Drawing.Point(264, 42);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(62, 25);
			this.Button2.TabIndex = 15;
			this.Button2.Text = "&Search";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(142, 21);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(22, 16);
			this.Label4.TabIndex = 37;
			this.Label4.Text = "To";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(17, 24);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(33, 16);
			this.Label5.TabIndex = 36;
			this.Label5.Text = "From";
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.CustomFormat = "dd/MMM/yyyy";
			this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimePicker1.Location = new System.Drawing.Point(144, 43);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(113, 24);
			this.DateTimePicker1.TabIndex = 35;
			//
			//DateTimePicker2
			//
			this.DateTimePicker2.CustomFormat = "dd/MMM/yyyy";
			this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimePicker2.Location = new System.Drawing.Point(20, 43);
			this.DateTimePicker2.Name = "DateTimePicker2";
			this.DateTimePicker2.Size = new System.Drawing.Size(112, 24);
			this.DateTimePicker2.TabIndex = 34;
			//
			//frmBookReturnRecord_Staff
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1362, 684);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.GroupBox6);
			this.Controls.Add(this.GroupBox5);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox4);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "frmBookReturnRecord_Staff";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search Returned Books Record [Staff]";
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.GroupBox6.ResumeLayout(false);
			this.GroupBox6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.Label Label3;
		private System.Windows.Forms.TextBox withEventsField_txtBookName;
		internal System.Windows.Forms.TextBox txtBookName {
			get { return withEventsField_txtBookName; }
			set {
				if (withEventsField_txtBookName != null) {
					withEventsField_txtBookName.TextChanged -= txtBookName_TextChanged;
				}
				withEventsField_txtBookName = value;
				if (withEventsField_txtBookName != null) {
					withEventsField_txtBookName.TextChanged += txtBookName_TextChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		private System.Windows.Forms.DateTimePicker withEventsField_dtpDateTo;
		internal System.Windows.Forms.DateTimePicker dtpDateTo {
			get { return withEventsField_dtpDateTo; }
			set {
				if (withEventsField_dtpDateTo != null) {
					withEventsField_dtpDateTo.Validating -= dtpDateTo_Validating;
				}
				withEventsField_dtpDateTo = value;
				if (withEventsField_dtpDateTo != null) {
					withEventsField_dtpDateTo.Validating += dtpDateTo_Validating;
				}
			}
		}
		internal System.Windows.Forms.DateTimePicker dtpDateFrom;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		private System.Windows.Forms.DateTimePicker withEventsField_DateTimePicker3;
		internal System.Windows.Forms.DateTimePicker DateTimePicker3 {
			get { return withEventsField_DateTimePicker3; }
			set {
				if (withEventsField_DateTimePicker3 != null) {
					withEventsField_DateTimePicker3.Validating -= DateTimePicker3_Validating;
				}
				withEventsField_DateTimePicker3 = value;
				if (withEventsField_DateTimePicker3 != null) {
					withEventsField_DateTimePicker3.Validating += DateTimePicker3_Validating;
				}
			}
		}
		internal System.Windows.Forms.DateTimePicker DateTimePicker4;
		private System.Windows.Forms.ComboBox withEventsField_cmbStaffName;
		internal System.Windows.Forms.ComboBox cmbStaffName {
			get { return withEventsField_cmbStaffName; }
			set {
				if (withEventsField_cmbStaffName != null) {
					withEventsField_cmbStaffName.SelectedIndexChanged -= cmbStaffName_SelectedIndexChanged;
				}
				withEventsField_cmbStaffName = value;
				if (withEventsField_cmbStaffName != null) {
					withEventsField_cmbStaffName.SelectedIndexChanged += cmbStaffName_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.GroupBox GroupBox5;
		internal System.Windows.Forms.GroupBox GroupBox6;
		private System.Windows.Forms.TextBox withEventsField_txtStaffName;
		internal System.Windows.Forms.TextBox txtStaffName {
			get { return withEventsField_txtStaffName; }
			set {
				if (withEventsField_txtStaffName != null) {
					withEventsField_txtStaffName.TextChanged -= txtStaffName_TextChanged;
				}
				withEventsField_txtStaffName = value;
				if (withEventsField_txtStaffName != null) {
					withEventsField_txtStaffName.TextChanged += txtStaffName_TextChanged;
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
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label14;
		private System.Windows.Forms.DateTimePicker withEventsField_DateTimePicker7;
		internal System.Windows.Forms.DateTimePicker DateTimePicker7 {
			get { return withEventsField_DateTimePicker7; }
			set {
				if (withEventsField_DateTimePicker7 != null) {
					withEventsField_DateTimePicker7.Validating -= DateTimePicker7_Validating;
				}
				withEventsField_DateTimePicker7 = value;
				if (withEventsField_DateTimePicker7 != null) {
					withEventsField_DateTimePicker7.Validating += DateTimePicker7_Validating;
				}
			}
		}
		internal System.Windows.Forms.DateTimePicker DateTimePicker8;
		private System.Windows.Forms.Button withEventsField_Button1;
		private System.Windows.Forms.Button Button1 {
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
		internal System.Windows.Forms.GroupBox GroupBox1;
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
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
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
	}
}

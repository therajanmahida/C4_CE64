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
	partial class frmJournalsMagzinesRecord : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJournalsMagzinesRecord));
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
			this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
			this.Button1 = new System.Windows.Forms.Button();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
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
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.DateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.DateTimePicker4 = new System.Windows.Forms.DateTimePicker();
			this.Button3 = new System.Windows.Forms.Button();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.DateTimePicker5 = new System.Windows.Forms.DateTimePicker();
			this.DateTimePicker6 = new System.Windows.Forms.DateTimePicker();
			this.Button4 = new System.Windows.Forms.Button();
			this.GroupBox6 = new System.Windows.Forms.GroupBox();
			this.cmbDepartment = new System.Windows.Forms.ComboBox();
			this.GroupBox4.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.Panel1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			this.GroupBox6.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox4
			//
			this.GroupBox4.Controls.Add(this.Label2);
			this.GroupBox4.Controls.Add(this.Label1);
			this.GroupBox4.Controls.Add(this.dtpDateTo);
			this.GroupBox4.Controls.Add(this.dtpDateFrom);
			this.GroupBox4.Controls.Add(this.Button1);
			this.GroupBox4.Location = new System.Drawing.Point(300, 13);
			this.GroupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox4.Size = new System.Drawing.Size(399, 88);
			this.GroupBox4.TabIndex = 5;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "By Issue Date";
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
			this.dtpDateTo.Location = new System.Drawing.Point(175, 37);
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
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(313, 35);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(69, 25);
			this.Button1.TabIndex = 3;
			this.Button1.Text = "&Search";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.txtName);
			this.GroupBox3.Location = new System.Drawing.Point(16, 12);
			this.GroupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox3.Size = new System.Drawing.Size(269, 88);
			this.GroupBox3.TabIndex = 4;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "By Title";
			//
			//txtName
			//
			this.txtName.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtName.Location = new System.Drawing.Point(19, 37);
			this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(222, 24);
			this.txtName.TabIndex = 0;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.DateTimePicker1);
			this.GroupBox1.Controls.Add(this.DateTimePicker2);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Location = new System.Drawing.Point(717, 13);
			this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Size = new System.Drawing.Size(399, 88);
			this.GroupBox1.TabIndex = 6;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "By Date Of Receipt";
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
			this.DateTimePicker1.Location = new System.Drawing.Point(175, 37);
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
			this.DataGridView1.Location = new System.Drawing.Point(16, 198);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.Size = new System.Drawing.Size(1126, 458);
			this.DataGridView1.TabIndex = 33;
			//
			//Panel1
			//
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.btnExportExcel);
			this.Panel1.Controls.Add(this.btnReset);
			this.Panel1.Location = new System.Drawing.Point(1157, 198);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(124, 106);
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
			this.GroupBox2.Controls.Add(this.Label5);
			this.GroupBox2.Controls.Add(this.Label6);
			this.GroupBox2.Controls.Add(this.DateTimePicker3);
			this.GroupBox2.Controls.Add(this.DateTimePicker4);
			this.GroupBox2.Controls.Add(this.Button3);
			this.GroupBox2.Location = new System.Drawing.Point(300, 103);
			this.GroupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox2.Size = new System.Drawing.Size(399, 88);
			this.GroupBox2.TabIndex = 35;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "By Bill Date";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(172, 17);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(22, 16);
			this.Label5.TabIndex = 33;
			this.Label5.Text = "To";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label6.Location = new System.Drawing.Point(24, 19);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(33, 16);
			this.Label6.TabIndex = 6;
			this.Label6.Text = "From";
			//
			//DateTimePicker3
			//
			this.DateTimePicker3.CustomFormat = "dd/MMM/yyyy";
			this.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimePicker3.Location = new System.Drawing.Point(175, 37);
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
			//Button3
			//
			this.Button3.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button3.Location = new System.Drawing.Point(313, 35);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(69, 25);
			this.Button3.TabIndex = 3;
			this.Button3.Text = "&Search";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//GroupBox5
			//
			this.GroupBox5.Controls.Add(this.Label7);
			this.GroupBox5.Controls.Add(this.Label8);
			this.GroupBox5.Controls.Add(this.DateTimePicker5);
			this.GroupBox5.Controls.Add(this.DateTimePicker6);
			this.GroupBox5.Controls.Add(this.Button4);
			this.GroupBox5.Location = new System.Drawing.Point(717, 103);
			this.GroupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox5.Name = "GroupBox5";
			this.GroupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox5.Size = new System.Drawing.Size(399, 88);
			this.GroupBox5.TabIndex = 36;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "By Subscription End Date";
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label7.Location = new System.Drawing.Point(172, 17);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(22, 16);
			this.Label7.TabIndex = 33;
			this.Label7.Text = "To";
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label8.Location = new System.Drawing.Point(24, 19);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(33, 16);
			this.Label8.TabIndex = 6;
			this.Label8.Text = "From";
			//
			//DateTimePicker5
			//
			this.DateTimePicker5.CustomFormat = "dd/MMM/yyyy";
			this.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimePicker5.Location = new System.Drawing.Point(175, 37);
			this.DateTimePicker5.Name = "DateTimePicker5";
			this.DateTimePicker5.Size = new System.Drawing.Size(123, 24);
			this.DateTimePicker5.TabIndex = 5;
			//
			//DateTimePicker6
			//
			this.DateTimePicker6.CustomFormat = "dd/MMM/yyyy";
			this.DateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimePicker6.Location = new System.Drawing.Point(24, 38);
			this.DateTimePicker6.Name = "DateTimePicker6";
			this.DateTimePicker6.Size = new System.Drawing.Size(131, 24);
			this.DateTimePicker6.TabIndex = 4;
			//
			//Button4
			//
			this.Button4.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button4.Location = new System.Drawing.Point(313, 35);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(69, 25);
			this.Button4.TabIndex = 3;
			this.Button4.Text = "&Search";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//GroupBox6
			//
			this.GroupBox6.Controls.Add(this.cmbDepartment);
			this.GroupBox6.Location = new System.Drawing.Point(16, 103);
			this.GroupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox6.Name = "GroupBox6";
			this.GroupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox6.Size = new System.Drawing.Size(269, 88);
			this.GroupBox6.TabIndex = 37;
			this.GroupBox6.TabStop = false;
			this.GroupBox6.Text = "By Department";
			//
			//cmbDepartment
			//
			this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbDepartment.FormattingEnabled = true;
			this.cmbDepartment.Location = new System.Drawing.Point(19, 38);
			this.cmbDepartment.Name = "cmbDepartment";
			this.cmbDepartment.Size = new System.Drawing.Size(222, 25);
			this.cmbDepartment.TabIndex = 0;
			//
			//frmJournalsMagzinesRecord
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1303, 660);
			this.Controls.Add(this.GroupBox6);
			this.Controls.Add(this.GroupBox5);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.GroupBox4);
			this.Controls.Add(this.GroupBox3);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "frmJournalsMagzinesRecord";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search Journals and Magazines Record";
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.GroupBox6.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.GroupBox GroupBox4;
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
		internal System.Windows.Forms.GroupBox GroupBox3;
		private System.Windows.Forms.TextBox withEventsField_txtName;
		internal System.Windows.Forms.TextBox txtName {
			get { return withEventsField_txtName; }
			set {
				if (withEventsField_txtName != null) {
					withEventsField_txtName.TextChanged -= txtName_TextChanged;
				}
				withEventsField_txtName = value;
				if (withEventsField_txtName != null) {
					withEventsField_txtName.TextChanged += txtName_TextChanged;
				}
			}
		}
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
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
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
		private System.Windows.Forms.Button withEventsField_Button3;
		private System.Windows.Forms.Button Button3 {
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
		internal System.Windows.Forms.GroupBox GroupBox5;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		private System.Windows.Forms.DateTimePicker withEventsField_DateTimePicker5;
		internal System.Windows.Forms.DateTimePicker DateTimePicker5 {
			get { return withEventsField_DateTimePicker5; }
			set {
				if (withEventsField_DateTimePicker5 != null) {
					withEventsField_DateTimePicker5.Validating -= DateTimePicker5_Validating;
				}
				withEventsField_DateTimePicker5 = value;
				if (withEventsField_DateTimePicker5 != null) {
					withEventsField_DateTimePicker5.Validating += DateTimePicker5_Validating;
				}
			}
		}
		internal System.Windows.Forms.DateTimePicker DateTimePicker6;
		private System.Windows.Forms.Button withEventsField_Button4;
		private System.Windows.Forms.Button Button4 {
			get { return withEventsField_Button4; }
			set {
				if (withEventsField_Button4 != null) {
					withEventsField_Button4.Click -= Button4_Click;
				}
				withEventsField_Button4 = value;
				if (withEventsField_Button4 != null) {
					withEventsField_Button4.Click += Button4_Click;
				}
			}
		}
		internal System.Windows.Forms.GroupBox GroupBox6;
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
	}
}

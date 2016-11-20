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
	partial class frmNewsPaperRecord1 : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewsPaperRecord1));
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
			this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.cmbPaperName = new System.Windows.Forms.ComboBox();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnExportExcel = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.Button1 = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.GroupBox4.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox4
			//
			this.GroupBox4.Controls.Add(this.Label2);
			this.GroupBox4.Controls.Add(this.Label1);
			this.GroupBox4.Controls.Add(this.dtpDateTo);
			this.GroupBox4.Controls.Add(this.dtpDateFrom);
			this.GroupBox4.Location = new System.Drawing.Point(300, 13);
			this.GroupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox4.Size = new System.Drawing.Size(318, 88);
			this.GroupBox4.TabIndex = 1;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "By Date";
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
			this.dtpDateTo.Location = new System.Drawing.Point(175, 36);
			this.dtpDateTo.Name = "dtpDateTo";
			this.dtpDateTo.Size = new System.Drawing.Size(123, 24);
			this.dtpDateTo.TabIndex = 1;
			//
			//dtpDateFrom
			//
			this.dtpDateFrom.CustomFormat = "dd/MMM/yyyy";
			this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateFrom.Location = new System.Drawing.Point(24, 38);
			this.dtpDateFrom.Name = "dtpDateFrom";
			this.dtpDateFrom.Size = new System.Drawing.Size(131, 24);
			this.dtpDateFrom.TabIndex = 0;
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.cmbPaperName);
			this.GroupBox3.Location = new System.Drawing.Point(16, 12);
			this.GroupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox3.Size = new System.Drawing.Size(269, 88);
			this.GroupBox3.TabIndex = 0;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "By Paper Name";
			//
			//cmbPaperName
			//
			this.cmbPaperName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbPaperName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbPaperName.FormattingEnabled = true;
			this.cmbPaperName.Location = new System.Drawing.Point(18, 39);
			this.cmbPaperName.Name = "cmbPaperName";
			this.cmbPaperName.Size = new System.Drawing.Size(227, 25);
			this.cmbPaperName.TabIndex = 0;
			//
			//DataGridView1
			//
			this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(16, 108);
			this.DataGridView1.MultiSelect = false;
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DataGridView1.Size = new System.Drawing.Size(560, 547);
			this.DataGridView1.TabIndex = 33;
			//
			//btnExportExcel
			//
			this.btnExportExcel.Font = new System.Drawing.Font("Palatino Linotype", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnExportExcel.Location = new System.Drawing.Point(213, 30);
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(93, 36);
			this.btnExportExcel.TabIndex = 1;
			this.btnExportExcel.Text = "&Export Excel";
			this.btnExportExcel.UseVisualStyleBackColor = true;
			//
			//btnReset
			//
			this.btnReset.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnReset.Location = new System.Drawing.Point(114, 31);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(93, 33);
			this.btnReset.TabIndex = 0;
			this.btnReset.Text = "&Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(15, 31);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(93, 33);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "&Get Data";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.btnExportExcel);
			this.GroupBox1.Controls.Add(this.btnReset);
			this.GroupBox1.Location = new System.Drawing.Point(633, 12);
			this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Size = new System.Drawing.Size(317, 88);
			this.GroupBox1.TabIndex = 2;
			this.GroupBox1.TabStop = false;
			//
			//frmNewsPaperRecord1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(973, 656);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.GroupBox4);
			this.Controls.Add(this.GroupBox3);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "frmNewsPaperRecord1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search News Paper Record";
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.GroupBox1.ResumeLayout(false);
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
		internal System.Windows.Forms.GroupBox GroupBox3;
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
		internal System.Windows.Forms.ComboBox cmbPaperName;
		private System.Windows.Forms.Button withEventsField_Button1;
		private System.Windows.Forms.Button Button1 {
			get { return withEventsField_Button1; }
			set {
				if (withEventsField_Button1 != null) {
					withEventsField_Button1.Click -= Button1_Click_1;
				}
				withEventsField_Button1 = value;
				if (withEventsField_Button1 != null) {
					withEventsField_Button1.Click += Button1_Click_1;
				}
			}
		}
		internal System.Windows.Forms.GroupBox GroupBox1;
	}
}

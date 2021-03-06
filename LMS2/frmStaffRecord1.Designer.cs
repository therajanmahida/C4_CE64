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
	partial class frmStaffRecord1 : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffRecord1));
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.txtStaffName = new System.Windows.Forms.TextBox();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbDepartment = new System.Windows.Forms.ComboBox();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
			this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
			this.Button1 = new System.Windows.Forms.Button();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.btnExportExcel = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.GroupBox3.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.txtStaffName);
			this.GroupBox3.Location = new System.Drawing.Point(14, 16);
			this.GroupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox3.Size = new System.Drawing.Size(269, 88);
			this.GroupBox3.TabIndex = 0;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "By Staff Name";
			//
			//txtStaffName
			//
			this.txtStaffName.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtStaffName.Location = new System.Drawing.Point(19, 37);
			this.txtStaffName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtStaffName.Name = "txtStaffName";
			this.txtStaffName.Size = new System.Drawing.Size(222, 24);
			this.txtStaffName.TabIndex = 0;
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.cmbDepartment);
			this.GroupBox2.Location = new System.Drawing.Point(301, 17);
			this.GroupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox2.Size = new System.Drawing.Size(247, 88);
			this.GroupBox2.TabIndex = 2;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "By Department";
			//
			//cmbDepartment
			//
			this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbDepartment.FormattingEnabled = true;
			this.cmbDepartment.Location = new System.Drawing.Point(24, 37);
			this.cmbDepartment.Name = "cmbDepartment";
			this.cmbDepartment.Size = new System.Drawing.Size(202, 25);
			this.cmbDepartment.TabIndex = 0;
			//
			//GroupBox4
			//
			this.GroupBox4.Controls.Add(this.Label2);
			this.GroupBox4.Controls.Add(this.Label1);
			this.GroupBox4.Controls.Add(this.dtpDateTo);
			this.GroupBox4.Controls.Add(this.dtpDateFrom);
			this.GroupBox4.Controls.Add(this.Button1);
			this.GroupBox4.Location = new System.Drawing.Point(563, 17);
			this.GroupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox4.Size = new System.Drawing.Size(399, 88);
			this.GroupBox4.TabIndex = 3;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "By Date Of Joining";
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
			//DataGridView1
			//
			this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(14, 112);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.Size = new System.Drawing.Size(1167, 567);
			this.DataGridView1.TabIndex = 32;
			//
			//Panel1
			//
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.btnExportExcel);
			this.Panel1.Controls.Add(this.btnReset);
			this.Panel1.Location = new System.Drawing.Point(1197, 112);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(124, 106);
			this.Panel1.TabIndex = 4;
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
			//frmStaffRecord1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1355, 680);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.GroupBox4);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox3);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "frmStaffRecord1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search Staff Record";
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.GroupBox GroupBox3;
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
		internal System.Windows.Forms.GroupBox GroupBox2;
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
		internal System.Windows.Forms.GroupBox GroupBox4;
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
		public frmStaffRecord1()
		{
			Load += frmStaffRecord_Load;
			InitializeComponent();
		}
	}
}

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
	partial class frmStaffCardRecord : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffCardRecord));
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.cmbDepartment = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Button1 = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.txtStaffName = new System.Windows.Forms.TextBox();
			this.GroupBox3.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.Label2);
			this.GroupBox3.Controls.Add(this.cmbDepartment);
			this.GroupBox3.Location = new System.Drawing.Point(14, 13);
			this.GroupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox3.Size = new System.Drawing.Size(255, 88);
			this.GroupBox3.TabIndex = 1;
			this.GroupBox3.TabStop = false;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(12, 20);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(74, 17);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Department";
			//
			//cmbDepartment
			//
			this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbDepartment.FormattingEnabled = true;
			this.cmbDepartment.Location = new System.Drawing.Point(15, 43);
			this.cmbDepartment.Name = "cmbDepartment";
			this.cmbDepartment.Size = new System.Drawing.Size(216, 25);
			this.cmbDepartment.TabIndex = 2;
			//
			//panel1
			//
			this.panel1.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.Button1);
			this.panel1.Controls.Add(this.btnReset);
			this.panel1.Location = new System.Drawing.Point(524, 109);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(129, 101);
			this.panel1.TabIndex = 8;
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(16, 53);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(95, 33);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "&Export Excel";
			this.Button1.UseVisualStyleBackColor = true;
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
			//DataGridView1
			//
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
				this.Column1,
				this.Column2,
				this.Column3
			});
			this.DataGridView1.Location = new System.Drawing.Point(14, 109);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DataGridView1.Size = new System.Drawing.Size(495, 555);
			this.DataGridView1.TabIndex = 11;
			//
			//Column1
			//
			this.Column1.HeaderText = "Staff ID";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			//
			//Column2
			//
			this.Column2.HeaderText = "Staff Name";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 250;
			//
			//Column3
			//
			this.Column3.HeaderText = "Status";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.txtStaffName);
			this.GroupBox1.Location = new System.Drawing.Point(289, 13);
			this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Size = new System.Drawing.Size(256, 88);
			this.GroupBox1.TabIndex = 12;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "By Staff Name";
			//
			//txtStaffName
			//
			this.txtStaffName.Location = new System.Drawing.Point(22, 40);
			this.txtStaffName.Name = "txtStaffName";
			this.txtStaffName.Size = new System.Drawing.Size(208, 24);
			this.txtStaffName.TabIndex = 0;
			//
			//frmStaffCardRecord
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(679, 668);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.GroupBox3);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "frmStaffCardRecord";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Staffs [Cards Search]";
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Label Label2;
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
		private System.Windows.Forms.Panel panel1;
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
		internal System.Windows.Forms.Timer Timer1;
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
		internal System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.TextBox withEventsField_txtStaffName;
		internal System.Windows.Forms.TextBox txtStaffName {
			get { return withEventsField_txtStaffName; }
			set {
				if (withEventsField_txtStaffName != null) {
					withEventsField_txtStaffName.TextChanged -= txtStaffName_TextChanged_1;
				}
				withEventsField_txtStaffName = value;
				if (withEventsField_txtStaffName != null) {
					withEventsField_txtStaffName.TextChanged += txtStaffName_TextChanged_1;
				}
			}
		}
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
	}
}

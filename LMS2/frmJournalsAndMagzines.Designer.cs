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
	partial class frmJournalsAndMagzines : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJournalsAndMagzines));
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbDepartment = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.cmbSupplierName = new System.Windows.Forms.ComboBox();
			this.txtNumber = new System.Windows.Forms.TextBox();
			this.Label21 = new System.Windows.Forms.Label();
			this.dtpPaidOn = new System.Windows.Forms.DateTimePicker();
			this.Label18 = new System.Windows.Forms.Label();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
			this.Label17 = new System.Windows.Forms.Label();
			this.txtBillNo = new System.Windows.Forms.TextBox();
			this.dtpSubDateTo = new System.Windows.Forms.DateTimePicker();
			this.Label16 = new System.Windows.Forms.Label();
			this.dtpSubDateFrom = new System.Windows.Forms.DateTimePicker();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.txtSub = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.dtpSubDate = new System.Windows.Forms.DateTimePicker();
			this.txtSubNo = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.dtpDateOfReceipt = new System.Windows.Forms.DateTimePicker();
			this.Label2 = new System.Windows.Forms.Label();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.Label20 = new System.Windows.Forms.Label();
			this.txtVolume = new System.Windows.Forms.TextBox();
			this.Label19 = new System.Windows.Forms.Label();
			this.txtRemarks = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.cmbMonth = new System.Windows.Forms.ComboBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.txtIssueNo = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnGetDetails = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.NewRecord = new System.Windows.Forms.Button();
			this.txtID = new System.Windows.Forms.TextBox();
			this.GroupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox1.Controls.Add(this.cmbDepartment);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.cmbSupplierName);
			this.GroupBox1.Controls.Add(this.txtNumber);
			this.GroupBox1.Controls.Add(this.Label21);
			this.GroupBox1.Controls.Add(this.dtpPaidOn);
			this.GroupBox1.Controls.Add(this.Label18);
			this.GroupBox1.Controls.Add(this.txtAmount);
			this.GroupBox1.Controls.Add(this.dtpBillDate);
			this.GroupBox1.Controls.Add(this.Label17);
			this.GroupBox1.Controls.Add(this.txtBillNo);
			this.GroupBox1.Controls.Add(this.dtpSubDateTo);
			this.GroupBox1.Controls.Add(this.Label16);
			this.GroupBox1.Controls.Add(this.dtpSubDateFrom);
			this.GroupBox1.Controls.Add(this.Label15);
			this.GroupBox1.Controls.Add(this.Label14);
			this.GroupBox1.Controls.Add(this.txtSub);
			this.GroupBox1.Controls.Add(this.Label13);
			this.GroupBox1.Controls.Add(this.dtpSubDate);
			this.GroupBox1.Controls.Add(this.txtSubNo);
			this.GroupBox1.Controls.Add(this.Label12);
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.txtName);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.dtpDateOfReceipt);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.dtpDate);
			this.GroupBox1.Controls.Add(this.Label20);
			this.GroupBox1.Controls.Add(this.txtVolume);
			this.GroupBox1.Controls.Add(this.Label19);
			this.GroupBox1.Controls.Add(this.txtRemarks);
			this.GroupBox1.Controls.Add(this.Label11);
			this.GroupBox1.Controls.Add(this.cmbMonth);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.txtYear);
			this.GroupBox1.Controls.Add(this.txtIssueNo);
			this.GroupBox1.Controls.Add(this.Label10);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(21, 18);
			this.GroupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.GroupBox1.Size = new System.Drawing.Size(647, 587);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Journals And Magazines";
			//
			//cmbDepartment
			//
			this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbDepartment.FormattingEnabled = true;
			this.cmbDepartment.Location = new System.Drawing.Point(211, 447);
			this.cmbDepartment.Name = "cmbDepartment";
			this.cmbDepartment.Size = new System.Drawing.Size(228, 26);
			this.cmbDepartment.TabIndex = 18;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.Location = new System.Drawing.Point(36, 450);
			this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(81, 18);
			this.Label4.TabIndex = 109;
			this.Label4.Text = "Department";
			//
			//cmbSupplierName
			//
			this.cmbSupplierName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbSupplierName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSupplierName.FormattingEnabled = true;
			this.cmbSupplierName.Location = new System.Drawing.Point(210, 406);
			this.cmbSupplierName.Name = "cmbSupplierName";
			this.cmbSupplierName.Size = new System.Drawing.Size(228, 26);
			this.cmbSupplierName.TabIndex = 17;
			//
			//txtNumber
			//
			this.txtNumber.Location = new System.Drawing.Point(461, 329);
			this.txtNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtNumber.Name = "txtNumber";
			this.txtNumber.Size = new System.Drawing.Size(118, 25);
			this.txtNumber.TabIndex = 15;
			//
			//Label21
			//
			this.Label21.AutoSize = true;
			this.Label21.BackColor = System.Drawing.Color.Transparent;
			this.Label21.Location = new System.Drawing.Point(377, 332);
			this.Label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(59, 18);
			this.Label21.TabIndex = 106;
			this.Label21.Text = "Number";
			//
			//dtpPaidOn
			//
			this.dtpPaidOn.CustomFormat = "dd/MMM/yyyy";
			this.dtpPaidOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPaidOn.Location = new System.Drawing.Point(461, 197);
			this.dtpPaidOn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.dtpPaidOn.Name = "dtpPaidOn";
			this.dtpPaidOn.Size = new System.Drawing.Size(159, 25);
			this.dtpPaidOn.TabIndex = 9;
			//
			//Label18
			//
			this.Label18.AutoSize = true;
			this.Label18.BackColor = System.Drawing.Color.Transparent;
			this.Label18.Location = new System.Drawing.Point(377, 197);
			this.Label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(57, 18);
			this.Label18.TabIndex = 104;
			this.Label18.Text = "Paid On";
			//
			//txtAmount
			//
			this.txtAmount.Location = new System.Drawing.Point(211, 196);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(100, 25);
			this.txtAmount.TabIndex = 8;
			//
			//dtpBillDate
			//
			this.dtpBillDate.CustomFormat = "dd/MMM/yyyy";
			this.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpBillDate.Location = new System.Drawing.Point(461, 161);
			this.dtpBillDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.dtpBillDate.Name = "dtpBillDate";
			this.dtpBillDate.Size = new System.Drawing.Size(159, 25);
			this.dtpBillDate.TabIndex = 7;
			//
			//Label17
			//
			this.Label17.AutoSize = true;
			this.Label17.BackColor = System.Drawing.Color.Transparent;
			this.Label17.Location = new System.Drawing.Point(377, 168);
			this.Label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(61, 18);
			this.Label17.TabIndex = 101;
			this.Label17.Text = "Bill Date";
			//
			//txtBillNo
			//
			this.txtBillNo.Location = new System.Drawing.Point(211, 164);
			this.txtBillNo.Name = "txtBillNo";
			this.txtBillNo.Size = new System.Drawing.Size(100, 25);
			this.txtBillNo.TabIndex = 6;
			//
			//dtpSubDateTo
			//
			this.dtpSubDateTo.CustomFormat = "dd/MMM/yyyy";
			this.dtpSubDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpSubDateTo.Location = new System.Drawing.Point(461, 124);
			this.dtpSubDateTo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.dtpSubDateTo.Name = "dtpSubDateTo";
			this.dtpSubDateTo.Size = new System.Drawing.Size(159, 25);
			this.dtpSubDateTo.TabIndex = 5;
			//
			//Label16
			//
			this.Label16.AutoSize = true;
			this.Label16.BackColor = System.Drawing.Color.Transparent;
			this.Label16.Location = new System.Drawing.Point(425, 129);
			this.Label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(25, 18);
			this.Label16.TabIndex = 98;
			this.Label16.Text = "To";
			//
			//dtpSubDateFrom
			//
			this.dtpSubDateFrom.CustomFormat = "dd/MMM/yyyy";
			this.dtpSubDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpSubDateFrom.Location = new System.Drawing.Point(265, 126);
			this.dtpSubDateFrom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.dtpSubDateFrom.Name = "dtpSubDateFrom";
			this.dtpSubDateFrom.Size = new System.Drawing.Size(135, 25);
			this.dtpSubDateFrom.TabIndex = 4;
			//
			//Label15
			//
			this.Label15.AutoSize = true;
			this.Label15.BackColor = System.Drawing.Color.Transparent;
			this.Label15.Location = new System.Drawing.Point(211, 129);
			this.Label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(41, 18);
			this.Label15.TabIndex = 96;
			this.Label15.Text = "From";
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.BackColor = System.Drawing.Color.Transparent;
			this.Label14.Location = new System.Drawing.Point(37, 129);
			this.Label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(157, 18);
			this.Label14.TabIndex = 95;
			this.Label14.Text = "Subscription Per Annum";
			//
			//txtSub
			//
			this.txtSub.Location = new System.Drawing.Point(211, 95);
			this.txtSub.Name = "txtSub";
			this.txtSub.Size = new System.Drawing.Size(100, 25);
			this.txtSub.TabIndex = 3;
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.BackColor = System.Drawing.Color.Transparent;
			this.Label13.Location = new System.Drawing.Point(37, 98);
			this.Label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(85, 18);
			this.Label13.TabIndex = 93;
			this.Label13.Text = "Subscription";
			//
			//dtpSubDate
			//
			this.dtpSubDate.CustomFormat = "dd/MMM/yyyy";
			this.dtpSubDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpSubDate.Location = new System.Drawing.Point(461, 62);
			this.dtpSubDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.dtpSubDate.Name = "dtpSubDate";
			this.dtpSubDate.Size = new System.Drawing.Size(159, 25);
			this.dtpSubDate.TabIndex = 2;
			//
			//txtSubNo
			//
			this.txtSubNo.Location = new System.Drawing.Point(211, 64);
			this.txtSubNo.Name = "txtSubNo";
			this.txtSubNo.Size = new System.Drawing.Size(100, 25);
			this.txtSubNo.TabIndex = 1;
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.BackColor = System.Drawing.Color.Transparent;
			this.Label12.Location = new System.Drawing.Point(37, 164);
			this.Label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(55, 18);
			this.Label12.TabIndex = 90;
			this.Label12.Text = "Bill No.";
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.BackColor = System.Drawing.Color.Transparent;
			this.Label9.Location = new System.Drawing.Point(37, 197);
			this.Label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(58, 18);
			this.Label9.TabIndex = 89;
			this.Label9.Text = "Amount";
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.BackColor = System.Drawing.Color.Transparent;
			this.Label8.Location = new System.Drawing.Point(331, 67);
			this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(117, 18);
			this.Label8.TabIndex = 88;
			this.Label8.Text = "Subscription Date";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.BackColor = System.Drawing.Color.Transparent;
			this.Label6.Location = new System.Drawing.Point(37, 67);
			this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(111, 18);
			this.Label6.TabIndex = 87;
			this.Label6.Text = "Subscription No.";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.BackColor = System.Drawing.Color.Transparent;
			this.Label5.Location = new System.Drawing.Point(36, 411);
			this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(100, 18);
			this.Label5.TabIndex = 86;
			this.Label5.Text = "Supplier Name";
			//
			//txtName
			//
			this.txtName.Location = new System.Drawing.Point(211, 33);
			this.txtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(245, 25);
			this.txtName.TabIndex = 0;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Location = new System.Drawing.Point(36, 36);
			this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(36, 18);
			this.Label3.TabIndex = 84;
			this.Label3.Text = "Title";
			//
			//dtpDateOfReceipt
			//
			this.dtpDateOfReceipt.CustomFormat = "dd/MMM/yyyy";
			this.dtpDateOfReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateOfReceipt.Location = new System.Drawing.Point(210, 368);
			this.dtpDateOfReceipt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.dtpDateOfReceipt.Name = "dtpDateOfReceipt";
			this.dtpDateOfReceipt.Size = new System.Drawing.Size(159, 25);
			this.dtpDateOfReceipt.TabIndex = 16;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Location = new System.Drawing.Point(38, 370);
			this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(104, 18);
			this.Label2.TabIndex = 83;
			this.Label2.Text = "Date Of Receipt";
			//
			//dtpDate
			//
			this.dtpDate.CustomFormat = "dd/MMM/yyyy";
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDate.Location = new System.Drawing.Point(211, 261);
			this.dtpDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(133, 25);
			this.dtpDate.TabIndex = 11;
			//
			//Label20
			//
			this.Label20.AutoSize = true;
			this.Label20.BackColor = System.Drawing.Color.Transparent;
			this.Label20.Location = new System.Drawing.Point(37, 261);
			this.Label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(37, 18);
			this.Label20.TabIndex = 81;
			this.Label20.Text = "Date";
			//
			//txtVolume
			//
			this.txtVolume.Location = new System.Drawing.Point(210, 332);
			this.txtVolume.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtVolume.Name = "txtVolume";
			this.txtVolume.Size = new System.Drawing.Size(118, 25);
			this.txtVolume.TabIndex = 14;
			//
			//Label19
			//
			this.Label19.AutoSize = true;
			this.Label19.BackColor = System.Drawing.Color.Transparent;
			this.Label19.Location = new System.Drawing.Point(36, 332);
			this.Label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(57, 18);
			this.Label19.TabIndex = 79;
			this.Label19.Text = "Volume";
			//
			//txtRemarks
			//
			this.txtRemarks.Location = new System.Drawing.Point(210, 489);
			this.txtRemarks.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtRemarks.Multiline = true;
			this.txtRemarks.Name = "txtRemarks";
			this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtRemarks.Size = new System.Drawing.Size(245, 79);
			this.txtRemarks.TabIndex = 19;
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.BackColor = System.Drawing.Color.Transparent;
			this.Label11.Location = new System.Drawing.Point(37, 489);
			this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(62, 18);
			this.Label11.TabIndex = 77;
			this.Label11.Text = "Remarks";
			//
			//cmbMonth
			//
			this.cmbMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbMonth.FormattingEnabled = true;
			this.cmbMonth.Items.AddRange(new object[] {
				"January",
				"February",
				"March",
				"April",
				"May",
				"June",
				"July",
				"August",
				"September",
				"October",
				"November",
				"December"
			});
			this.cmbMonth.Location = new System.Drawing.Point(461, 258);
			this.cmbMonth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.cmbMonth.Name = "cmbMonth";
			this.cmbMonth.Size = new System.Drawing.Size(159, 26);
			this.cmbMonth.TabIndex = 12;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.BackColor = System.Drawing.Color.Transparent;
			this.Label7.Location = new System.Drawing.Point(377, 261);
			this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(49, 18);
			this.Label7.TabIndex = 76;
			this.Label7.Text = "Month";
			//
			//txtYear
			//
			this.txtYear.Location = new System.Drawing.Point(211, 297);
			this.txtYear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(99, 25);
			this.txtYear.TabIndex = 13;
			//
			//txtIssueNo
			//
			this.txtIssueNo.Location = new System.Drawing.Point(211, 228);
			this.txtIssueNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtIssueNo.Name = "txtIssueNo";
			this.txtIssueNo.Size = new System.Drawing.Size(159, 25);
			this.txtIssueNo.TabIndex = 10;
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.BackColor = System.Drawing.Color.Transparent;
			this.Label10.Location = new System.Drawing.Point(38, 299);
			this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(35, 18);
			this.Label10.TabIndex = 75;
			this.Label10.Text = "Year";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Location = new System.Drawing.Point(37, 228);
			this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(66, 18);
			this.Label1.TabIndex = 72;
			this.Label1.Text = "Issue No.";
			//
			//panel1
			//
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnGetDetails);
			this.panel1.Controls.Add(this.btnUpdate);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.NewRecord);
			this.panel1.Location = new System.Drawing.Point(692, 28);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(128, 223);
			this.panel1.TabIndex = 1;
			//
			//btnGetDetails
			//
			this.btnGetDetails.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnGetDetails.Location = new System.Drawing.Point(11, 169);
			this.btnGetDetails.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnGetDetails.Name = "btnGetDetails";
			this.btnGetDetails.Size = new System.Drawing.Size(97, 36);
			this.btnGetDetails.TabIndex = 4;
			this.btnGetDetails.Text = "&Get Data";
			this.btnGetDetails.UseVisualStyleBackColor = true;
			//
			//btnUpdate
			//
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnUpdate.Location = new System.Drawing.Point(11, 128);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(97, 36);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "&Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			//
			//btnDelete
			//
			this.btnDelete.Enabled = false;
			this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnDelete.Location = new System.Drawing.Point(11, 88);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(97, 36);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			//
			//btnSave
			//
			this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnSave.Location = new System.Drawing.Point(11, 48);
			this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(97, 36);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			//
			//NewRecord
			//
			this.NewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.NewRecord.Location = new System.Drawing.Point(11, 8);
			this.NewRecord.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.NewRecord.Name = "NewRecord";
			this.NewRecord.Size = new System.Drawing.Size(97, 36);
			this.NewRecord.TabIndex = 1;
			this.NewRecord.Text = "&New";
			this.NewRecord.UseVisualStyleBackColor = true;
			//
			//txtID
			//
			this.txtID.Location = new System.Drawing.Point(702, 268);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(128, 25);
			this.txtID.TabIndex = 2;
			this.txtID.Visible = false;
			//
			//frmJournalsAndMagzines
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::LibraryManagementSystem.My.Resources.Resources.textures_wallpapers_simple_and_beautifull_wood_texture_backgrounds1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(862, 623);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.GroupBox1);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "frmJournalsAndMagzines";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Journals and Magazines Entry";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.DateTimePicker dtpDateOfReceipt;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.DateTimePicker dtpDate;
		internal System.Windows.Forms.Label Label20;
		internal System.Windows.Forms.TextBox txtVolume;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.TextBox txtRemarks;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.ComboBox cmbMonth;
		internal System.Windows.Forms.Label Label7;
		private System.Windows.Forms.TextBox withEventsField_txtYear;
		internal System.Windows.Forms.TextBox txtYear {
			get { return withEventsField_txtYear; }
			set {
				if (withEventsField_txtYear != null) {
					withEventsField_txtYear.KeyPress -= txtYear_KeyPress;
				}
				withEventsField_txtYear = value;
				if (withEventsField_txtYear != null) {
					withEventsField_txtYear.KeyPress += txtYear_KeyPress;
				}
			}
		}
		internal System.Windows.Forms.TextBox TextBox1;
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
		private System.Windows.Forms.Button withEventsField_btnUpdate;
		public System.Windows.Forms.Button btnUpdate {
			get { return withEventsField_btnUpdate; }
			set {
				if (withEventsField_btnUpdate != null) {
					withEventsField_btnUpdate.Click -= btnUpdate_Click;
				}
				withEventsField_btnUpdate = value;
				if (withEventsField_btnUpdate != null) {
					withEventsField_btnUpdate.Click += btnUpdate_Click;
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
		internal System.Windows.Forms.TextBox txtIssueNo;
		internal System.Windows.Forms.TextBox txtID;
		internal System.Windows.Forms.TextBox txtName;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.TextBox txtSub;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.DateTimePicker dtpSubDate;
		internal System.Windows.Forms.TextBox txtSubNo;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.DateTimePicker dtpPaidOn;
		internal System.Windows.Forms.Label Label18;
		private System.Windows.Forms.TextBox withEventsField_txtAmount;
		internal System.Windows.Forms.TextBox txtAmount {
			get { return withEventsField_txtAmount; }
			set {
				if (withEventsField_txtAmount != null) {
					withEventsField_txtAmount.KeyPress -= txtAmount_KeyPress;
				}
				withEventsField_txtAmount = value;
				if (withEventsField_txtAmount != null) {
					withEventsField_txtAmount.KeyPress += txtAmount_KeyPress;
				}
			}
		}
		internal System.Windows.Forms.DateTimePicker dtpBillDate;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.TextBox txtBillNo;
		internal System.Windows.Forms.DateTimePicker dtpSubDateTo;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.DateTimePicker dtpSubDateFrom;
		internal System.Windows.Forms.ComboBox cmbDepartment;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.ComboBox cmbSupplierName;
		internal System.Windows.Forms.TextBox txtNumber;
		internal System.Windows.Forms.Label Label21;
	}
}

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
	partial class frmBookEntry : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookEntry));
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbSupplierName = new System.Windows.Forms.ComboBox();
			this.Label22 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.cmbSubject = new System.Windows.Forms.ComboBox();
			this.txtBarcode = new System.Windows.Forms.TextBox();
			this.Label21 = new System.Windows.Forms.Label();
			this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
			this.Label20 = new System.Windows.Forms.Label();
			this.txtCD = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.txtVolume = new System.Windows.Forms.TextBox();
			this.Label19 = new System.Windows.Forms.Label();
			this.txtAlmiraPosition = new System.Windows.Forms.TextBox();
			this.Label18 = new System.Windows.Forms.Label();
			this.txtReference = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.txtRemarks = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.cmbDepartment = new System.Windows.Forms.ComboBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtNoOfBooks = new System.Windows.Forms.TextBox();
			this.txtPublishingYear = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.txtClassNo = new System.Windows.Forms.TextBox();
			this.txtPlaceOfPublisher = new System.Windows.Forms.TextBox();
			this.txtPublisherName = new System.Windows.Forms.TextBox();
			this.txtEdition = new System.Windows.Forms.TextBox();
			this.txtISBN = new System.Windows.Forms.TextBox();
			this.txtJointAuthor = new System.Windows.Forms.TextBox();
			this.txtAuthor = new System.Windows.Forms.TextBox();
			this.txtBookTitle = new System.Windows.Forms.TextBox();
			this.txtAccessionNo = new System.Windows.Forms.TextBox();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnUpdate_record = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnNewRecord = new System.Windows.Forms.Button();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.GroupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.GroupBox1.Controls.Add(this.cmbSupplierName);
			this.GroupBox1.Controls.Add(this.Label22);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.cmbSubject);
			this.GroupBox1.Controls.Add(this.txtBarcode);
			this.GroupBox1.Controls.Add(this.Label21);
			this.GroupBox1.Controls.Add(this.dtpBillDate);
			this.GroupBox1.Controls.Add(this.Label20);
			this.GroupBox1.Controls.Add(this.txtCD);
			this.GroupBox1.Controls.Add(this.Label13);
			this.GroupBox1.Controls.Add(this.txtVolume);
			this.GroupBox1.Controls.Add(this.Label19);
			this.GroupBox1.Controls.Add(this.txtAlmiraPosition);
			this.GroupBox1.Controls.Add(this.Label18);
			this.GroupBox1.Controls.Add(this.txtReference);
			this.GroupBox1.Controls.Add(this.Label12);
			this.GroupBox1.Controls.Add(this.txtRemarks);
			this.GroupBox1.Controls.Add(this.Label11);
			this.GroupBox1.Controls.Add(this.cmbDepartment);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.txtPrice);
			this.GroupBox1.Controls.Add(this.txtNoOfBooks);
			this.GroupBox1.Controls.Add(this.txtPublishingYear);
			this.GroupBox1.Controls.Add(this.Label15);
			this.GroupBox1.Controls.Add(this.txtClassNo);
			this.GroupBox1.Controls.Add(this.txtPlaceOfPublisher);
			this.GroupBox1.Controls.Add(this.txtPublisherName);
			this.GroupBox1.Controls.Add(this.txtEdition);
			this.GroupBox1.Controls.Add(this.txtISBN);
			this.GroupBox1.Controls.Add(this.txtJointAuthor);
			this.GroupBox1.Controls.Add(this.txtAuthor);
			this.GroupBox1.Controls.Add(this.txtBookTitle);
			this.GroupBox1.Controls.Add(this.txtAccessionNo);
			this.GroupBox1.Controls.Add(this.Label17);
			this.GroupBox1.Controls.Add(this.Label16);
			this.GroupBox1.Controls.Add(this.Label14);
			this.GroupBox1.Controls.Add(this.Label10);
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.GroupBox1.Location = new System.Drawing.Point(31, 7);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(694, 667);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Book Details";
			//
			//cmbSupplierName
			//
			this.cmbSupplierName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbSupplierName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSupplierName.FormattingEnabled = true;
			this.cmbSupplierName.Location = new System.Drawing.Point(186, 557);
			this.cmbSupplierName.Name = "cmbSupplierName";
			this.cmbSupplierName.Size = new System.Drawing.Size(253, 26);
			this.cmbSupplierName.TabIndex = 21;
			//
			//Label22
			//
			this.Label22.AutoSize = true;
			this.Label22.BackColor = System.Drawing.Color.Transparent;
			this.Label22.Location = new System.Drawing.Point(32, 565);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(106, 18);
			this.Label22.TabIndex = 73;
			this.Label22.Text = "*Supplier Name";
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(396, 24);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(28, 23);
			this.Button1.TabIndex = 72;
			this.Button1.Text = ">";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//cmbSubject
			//
			this.cmbSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSubject.FormattingEnabled = true;
			this.cmbSubject.Location = new System.Drawing.Point(186, 178);
			this.cmbSubject.Name = "cmbSubject";
			this.cmbSubject.Size = new System.Drawing.Size(342, 26);
			this.cmbSubject.TabIndex = 5;
			//
			//txtBarcode
			//
			this.txtBarcode.Location = new System.Drawing.Point(495, 222);
			this.txtBarcode.Name = "txtBarcode";
			this.txtBarcode.Size = new System.Drawing.Size(156, 25);
			this.txtBarcode.TabIndex = 7;
			//
			//Label21
			//
			this.Label21.AutoSize = true;
			this.Label21.BackColor = System.Drawing.Color.Transparent;
			this.Label21.Location = new System.Drawing.Point(411, 229);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(58, 18);
			this.Label21.TabIndex = 71;
			this.Label21.Text = "Barcode";
			//
			//dtpBillDate
			//
			this.dtpBillDate.CustomFormat = "dd/MMM/yyyy";
			this.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpBillDate.Location = new System.Drawing.Point(435, 519);
			this.dtpBillDate.Name = "dtpBillDate";
			this.dtpBillDate.Size = new System.Drawing.Size(135, 25);
			this.dtpBillDate.TabIndex = 20;
			//
			//Label20
			//
			this.Label20.AutoSize = true;
			this.Label20.BackColor = System.Drawing.Color.Transparent;
			this.Label20.Location = new System.Drawing.Point(315, 522);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(61, 18);
			this.Label20.TabIndex = 69;
			this.Label20.Text = "Bill Date";
			//
			//txtCD
			//
			this.txtCD.Location = new System.Drawing.Point(495, 392);
			this.txtCD.Name = "txtCD";
			this.txtCD.Size = new System.Drawing.Size(156, 25);
			this.txtCD.TabIndex = 14;
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.BackColor = System.Drawing.Color.Transparent;
			this.Label13.Location = new System.Drawing.Point(411, 399);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(28, 18);
			this.Label13.TabIndex = 67;
			this.Label13.Text = "CD";
			//
			//txtVolume
			//
			this.txtVolume.Location = new System.Drawing.Point(495, 267);
			this.txtVolume.Name = "txtVolume";
			this.txtVolume.Size = new System.Drawing.Size(156, 25);
			this.txtVolume.TabIndex = 9;
			//
			//Label19
			//
			this.Label19.AutoSize = true;
			this.Label19.BackColor = System.Drawing.Color.Transparent;
			this.Label19.Location = new System.Drawing.Point(411, 273);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(57, 18);
			this.Label19.TabIndex = 65;
			this.Label19.Text = "Volume";
			//
			//txtAlmiraPosition
			//
			this.txtAlmiraPosition.Location = new System.Drawing.Point(435, 482);
			this.txtAlmiraPosition.Name = "txtAlmiraPosition";
			this.txtAlmiraPosition.Size = new System.Drawing.Size(216, 25);
			this.txtAlmiraPosition.TabIndex = 18;
			//
			//Label18
			//
			this.Label18.AutoSize = true;
			this.Label18.BackColor = System.Drawing.Color.Transparent;
			this.Label18.Location = new System.Drawing.Point(315, 485);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(109, 18);
			this.Label18.TabIndex = 63;
			this.Label18.Text = "*Almira Position";
			//
			//txtReference
			//
			this.txtReference.Location = new System.Drawing.Point(435, 441);
			this.txtReference.Name = "txtReference";
			this.txtReference.Size = new System.Drawing.Size(216, 25);
			this.txtReference.TabIndex = 16;
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.BackColor = System.Drawing.Color.Transparent;
			this.Label12.Location = new System.Drawing.Point(32, 188);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(59, 18);
			this.Label12.TabIndex = 58;
			this.Label12.Text = "*Subject";
			//
			//txtRemarks
			//
			this.txtRemarks.Location = new System.Drawing.Point(186, 598);
			this.txtRemarks.Multiline = true;
			this.txtRemarks.Name = "txtRemarks";
			this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtRemarks.Size = new System.Drawing.Size(465, 52);
			this.txtRemarks.TabIndex = 22;
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.BackColor = System.Drawing.Color.Transparent;
			this.Label11.Location = new System.Drawing.Point(32, 612);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(62, 18);
			this.Label11.TabIndex = 55;
			this.Label11.Text = "Remarks";
			//
			//cmbDepartment
			//
			this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDepartment.FormattingEnabled = true;
			this.cmbDepartment.Location = new System.Drawing.Point(186, 222);
			this.cmbDepartment.Name = "cmbDepartment";
			this.cmbDepartment.Size = new System.Drawing.Size(204, 26);
			this.cmbDepartment.TabIndex = 6;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.BackColor = System.Drawing.Color.Transparent;
			this.Label7.Location = new System.Drawing.Point(30, 227);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(87, 18);
			this.Label7.TabIndex = 54;
			this.Label7.Text = "*Department";
			//
			//txtPrice
			//
			this.txtPrice.Location = new System.Drawing.Point(186, 517);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(110, 25);
			this.txtPrice.TabIndex = 19;
			//
			//txtNoOfBooks
			//
			this.txtNoOfBooks.Location = new System.Drawing.Point(186, 478);
			this.txtNoOfBooks.Name = "txtNoOfBooks";
			this.txtNoOfBooks.Size = new System.Drawing.Size(110, 25);
			this.txtNoOfBooks.TabIndex = 17;
			//
			//txtPublishingYear
			//
			this.txtPublishingYear.Location = new System.Drawing.Point(186, 437);
			this.txtPublishingYear.Name = "txtPublishingYear";
			this.txtPublishingYear.Size = new System.Drawing.Size(110, 25);
			this.txtPublishingYear.TabIndex = 15;
			//
			//Label15
			//
			this.Label15.AutoSize = true;
			this.Label15.BackColor = System.Drawing.Color.Transparent;
			this.Label15.Location = new System.Drawing.Point(411, 313);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(66, 18);
			this.Label15.TabIndex = 23;
			this.Label15.Text = "Class No.";
			//
			//txtClassNo
			//
			this.txtClassNo.Location = new System.Drawing.Point(495, 310);
			this.txtClassNo.Name = "txtClassNo";
			this.txtClassNo.Size = new System.Drawing.Size(156, 25);
			this.txtClassNo.TabIndex = 11;
			//
			//txtPlaceOfPublisher
			//
			this.txtPlaceOfPublisher.Location = new System.Drawing.Point(186, 392);
			this.txtPlaceOfPublisher.Name = "txtPlaceOfPublisher";
			this.txtPlaceOfPublisher.Size = new System.Drawing.Size(204, 25);
			this.txtPlaceOfPublisher.TabIndex = 13;
			//
			//txtPublisherName
			//
			this.txtPublisherName.Location = new System.Drawing.Point(186, 351);
			this.txtPublisherName.Name = "txtPublisherName";
			this.txtPublisherName.Size = new System.Drawing.Size(342, 25);
			this.txtPublisherName.TabIndex = 12;
			//
			//txtEdition
			//
			this.txtEdition.Location = new System.Drawing.Point(186, 306);
			this.txtEdition.Name = "txtEdition";
			this.txtEdition.Size = new System.Drawing.Size(110, 25);
			this.txtEdition.TabIndex = 10;
			//
			//txtISBN
			//
			this.txtISBN.Location = new System.Drawing.Point(186, 266);
			this.txtISBN.Name = "txtISBN";
			this.txtISBN.Size = new System.Drawing.Size(204, 25);
			this.txtISBN.TabIndex = 8;
			//
			//txtJointAuthor
			//
			this.txtJointAuthor.Location = new System.Drawing.Point(186, 140);
			this.txtJointAuthor.Name = "txtJointAuthor";
			this.txtJointAuthor.Size = new System.Drawing.Size(342, 25);
			this.txtJointAuthor.TabIndex = 3;
			//
			//txtAuthor
			//
			this.txtAuthor.Location = new System.Drawing.Point(186, 102);
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.Size = new System.Drawing.Size(342, 25);
			this.txtAuthor.TabIndex = 2;
			//
			//txtBookTitle
			//
			this.txtBookTitle.Location = new System.Drawing.Point(186, 61);
			this.txtBookTitle.Name = "txtBookTitle";
			this.txtBookTitle.Size = new System.Drawing.Size(465, 25);
			this.txtBookTitle.TabIndex = 1;
			//
			//txtAccessionNo
			//
			this.txtAccessionNo.Location = new System.Drawing.Point(186, 23);
			this.txtAccessionNo.Name = "txtAccessionNo";
			this.txtAccessionNo.Size = new System.Drawing.Size(198, 25);
			this.txtAccessionNo.TabIndex = 0;
			//
			//Label17
			//
			this.Label17.AutoSize = true;
			this.Label17.BackColor = System.Drawing.Color.Transparent;
			this.Label17.Location = new System.Drawing.Point(32, 270);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(41, 18);
			this.Label17.TabIndex = 25;
			this.Label17.Text = "ISBN";
			//
			//Label16
			//
			this.Label16.AutoSize = true;
			this.Label16.BackColor = System.Drawing.Color.Transparent;
			this.Label16.Location = new System.Drawing.Point(32, 482);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(98, 18);
			this.Label16.TabIndex = 24;
			this.Label16.Text = "*No. Of Books";
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.BackColor = System.Drawing.Color.Transparent;
			this.Label14.Location = new System.Drawing.Point(32, 522);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(44, 18);
			this.Label14.TabIndex = 22;
			this.Label14.Text = "*Price";
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.BackColor = System.Drawing.Color.Transparent;
			this.Label10.Location = new System.Drawing.Point(32, 441);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(104, 18);
			this.Label10.TabIndex = 18;
			this.Label10.Text = "Publishing Year";
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.BackColor = System.Drawing.Color.Transparent;
			this.Label9.Location = new System.Drawing.Point(32, 399);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(126, 18);
			this.Label9.TabIndex = 8;
			this.Label9.Text = "*Place Of Publisher";
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.BackColor = System.Drawing.Color.Transparent;
			this.Label8.Location = new System.Drawing.Point(32, 358);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(72, 18);
			this.Label8.TabIndex = 7;
			this.Label8.Text = "*Publisher";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.BackColor = System.Drawing.Color.Transparent;
			this.Label6.Location = new System.Drawing.Point(32, 313);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(58, 18);
			this.Label6.TabIndex = 5;
			this.Label6.Text = "*Edition";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.BackColor = System.Drawing.Color.Transparent;
			this.Label5.Location = new System.Drawing.Point(30, 142);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(88, 18);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Joint Authors";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.Location = new System.Drawing.Point(32, 102);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(56, 18);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "*Author";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Location = new System.Drawing.Point(315, 444);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(69, 18);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Reference";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Location = new System.Drawing.Point(32, 64);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(78, 18);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "*Book Title";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Location = new System.Drawing.Point(30, 26);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(101, 18);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "*Accession No.";
			//
			//panel1
			//
			this.panel1.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.btnUpdate_record);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnNewRecord);
			this.panel1.Location = new System.Drawing.Point(740, 17);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(129, 182);
			this.panel1.TabIndex = 3;
			//
			//btnSave
			//
			this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnSave.Location = new System.Drawing.Point(15, 53);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(95, 33);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			//
			//btnUpdate_record
			//
			this.btnUpdate_record.Enabled = false;
			this.btnUpdate_record.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnUpdate_record.Location = new System.Drawing.Point(16, 133);
			this.btnUpdate_record.Name = "btnUpdate_record";
			this.btnUpdate_record.Size = new System.Drawing.Size(95, 33);
			this.btnUpdate_record.TabIndex = 3;
			this.btnUpdate_record.Text = "&Update";
			this.btnUpdate_record.UseVisualStyleBackColor = true;
			//
			//btnDelete
			//
			this.btnDelete.Enabled = false;
			this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnDelete.Location = new System.Drawing.Point(16, 93);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(95, 33);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			//
			//btnNewRecord
			//
			this.btnNewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnNewRecord.Location = new System.Drawing.Point(16, 14);
			this.btnNewRecord.Name = "btnNewRecord";
			this.btnNewRecord.Size = new System.Drawing.Size(95, 33);
			this.btnNewRecord.TabIndex = 0;
			this.btnNewRecord.Text = "&New";
			this.btnNewRecord.UseVisualStyleBackColor = true;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(740, 204);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(100, 20);
			this.TextBox1.TabIndex = 4;
			this.TextBox1.Visible = false;
			//
			//frmBookEntry
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::LibraryManagementSystem.My.Resources.Resources.textures_wallpapers_simple_and_beautifull_wood_texture_backgrounds;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(897, 686);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "frmBookEntry";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Books Entry";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.TextBox txtClassNo;
		internal System.Windows.Forms.TextBox txtPlaceOfPublisher;
		internal System.Windows.Forms.TextBox txtPublisherName;
		internal System.Windows.Forms.TextBox txtEdition;
		internal System.Windows.Forms.TextBox txtISBN;
		internal System.Windows.Forms.TextBox txtJointAuthor;
		internal System.Windows.Forms.TextBox txtAuthor;
		internal System.Windows.Forms.TextBox txtBookTitle;
		internal System.Windows.Forms.TextBox txtAccessionNo;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		private System.Windows.Forms.TextBox withEventsField_txtPublishingYear;
		internal System.Windows.Forms.TextBox txtPublishingYear {
			get { return withEventsField_txtPublishingYear; }
			set {
				if (withEventsField_txtPublishingYear != null) {
					withEventsField_txtPublishingYear.KeyPress -= txtPublishingYear_KeyPress;
				}
				withEventsField_txtPublishingYear = value;
				if (withEventsField_txtPublishingYear != null) {
					withEventsField_txtPublishingYear.KeyPress += txtPublishingYear_KeyPress;
				}
			}
		}
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.ComboBox cmbDepartment;
		internal System.Windows.Forms.Label Label7;
		private System.Windows.Forms.TextBox withEventsField_txtPrice;
		internal System.Windows.Forms.TextBox txtPrice {
			get { return withEventsField_txtPrice; }
			set {
				if (withEventsField_txtPrice != null) {
					withEventsField_txtPrice.KeyPress -= txtPrice_KeyPress;
				}
				withEventsField_txtPrice = value;
				if (withEventsField_txtPrice != null) {
					withEventsField_txtPrice.KeyPress += txtPrice_KeyPress;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_txtNoOfBooks;
		internal System.Windows.Forms.TextBox txtNoOfBooks {
			get { return withEventsField_txtNoOfBooks; }
			set {
				if (withEventsField_txtNoOfBooks != null) {
					withEventsField_txtNoOfBooks.KeyPress -= txtNoOfBooks_KeyPress;
				}
				withEventsField_txtNoOfBooks = value;
				if (withEventsField_txtNoOfBooks != null) {
					withEventsField_txtNoOfBooks.KeyPress += txtNoOfBooks_KeyPress;
				}
			}
		}
		internal System.Windows.Forms.TextBox txtRemarks;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.DateTimePicker dtpBillDate;
		internal System.Windows.Forms.Label Label20;
		private System.Windows.Forms.TextBox withEventsField_txtCD;
		internal System.Windows.Forms.TextBox txtCD {
			get { return withEventsField_txtCD; }
			set {
				if (withEventsField_txtCD != null) {
					withEventsField_txtCD.KeyPress -= txtCD_KeyPress;
				}
				withEventsField_txtCD = value;
				if (withEventsField_txtCD != null) {
					withEventsField_txtCD.KeyPress += txtCD_KeyPress;
				}
			}
		}
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.TextBox txtVolume;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.TextBox txtAlmiraPosition;
		internal System.Windows.Forms.Label Label18;
		private System.Windows.Forms.TextBox withEventsField_txtReference;
		internal System.Windows.Forms.TextBox txtReference {
			get { return withEventsField_txtReference; }
			set {
				if (withEventsField_txtReference != null) {
					withEventsField_txtReference.KeyPress -= txtReference_KeyPress;
				}
				withEventsField_txtReference = value;
				if (withEventsField_txtReference != null) {
					withEventsField_txtReference.KeyPress += txtReference_KeyPress;
				}
			}
		}
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox txtBarcode;
		internal System.Windows.Forms.Label Label21;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button withEventsField_btnSave;
		internal System.Windows.Forms.Button btnSave {
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
		private System.Windows.Forms.Button withEventsField_btnNewRecord;
		private System.Windows.Forms.Button btnNewRecord {
			get { return withEventsField_btnNewRecord; }
			set {
				if (withEventsField_btnNewRecord != null) {
					withEventsField_btnNewRecord.Click -= btnNewRecord_Click;
				}
				withEventsField_btnNewRecord = value;
				if (withEventsField_btnNewRecord != null) {
					withEventsField_btnNewRecord.Click += btnNewRecord_Click;
				}
			}
		}
		internal System.Windows.Forms.ComboBox cmbSubject;
		private System.Windows.Forms.Button withEventsField_Button1;
		internal System.Windows.Forms.Button Button1 {
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
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label22;
		internal System.Windows.Forms.ComboBox cmbSupplierName;
	}
}

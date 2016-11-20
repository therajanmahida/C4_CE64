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
	partial class frmBookIssue : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookIssue));
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Button3 = new System.Windows.Forms.Button();
			this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
			this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
			this.Label19 = new System.Windows.Forms.Label();
			this.Label20 = new System.Windows.Forms.Label();
			this.txtTransactionID = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnUpdate_record = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnNewRecord = new System.Windows.Forms.Button();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.txtStudentName = new System.Windows.Forms.TextBox();
			this.Button2 = new System.Windows.Forms.Button();
			this.txtCourse = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.txtDepartment = new System.Windows.Forms.TextBox();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.cmbStudentID = new System.Windows.Forms.ComboBox();
			this.Label18 = new System.Windows.Forms.Label();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.txtAuthor = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.txtEdition = new System.Windows.Forms.TextBox();
			this.txtISBN = new System.Windows.Forms.TextBox();
			this.txtCategory = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtBookTitle = new System.Windows.Forms.TextBox();
			this.cmbAccessionNo = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.btnUpdate1 = new System.Windows.Forms.Button();
			this.btnDelete1 = new System.Windows.Forms.Button();
			this.btnSave1 = new System.Windows.Forms.Button();
			this.btnNewRecord1 = new System.Windows.Forms.Button();
			this.GroupBox6 = new System.Windows.Forms.GroupBox();
			this.Button6 = new System.Windows.Forms.Button();
			this.txtAuthor1 = new System.Windows.Forms.TextBox();
			this.Label21 = new System.Windows.Forms.Label();
			this.txtEdition1 = new System.Windows.Forms.TextBox();
			this.txtISBN1 = new System.Windows.Forms.TextBox();
			this.txtCategory1 = new System.Windows.Forms.TextBox();
			this.Label22 = new System.Windows.Forms.Label();
			this.Label23 = new System.Windows.Forms.Label();
			this.Label24 = new System.Windows.Forms.Label();
			this.Label25 = new System.Windows.Forms.Label();
			this.txtBookTitle1 = new System.Windows.Forms.TextBox();
			this.cmbAccessionNo1 = new System.Windows.Forms.ComboBox();
			this.Label26 = new System.Windows.Forms.Label();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.txtStaffName = new System.Windows.Forms.TextBox();
			this.Button5 = new System.Windows.Forms.Button();
			this.txtDepartment1 = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.cmbStaffID = new System.Windows.Forms.ComboBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.Button4 = new System.Windows.Forms.Button();
			this.dtpDueDate1 = new System.Windows.Forms.DateTimePicker();
			this.dtpIssueDate1 = new System.Windows.Forms.DateTimePicker();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtTransactionID1 = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.txtStatus1 = new System.Windows.Forms.TextBox();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.GroupBox6.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.SuspendLayout();
			//
			//TabControl1
			//
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Location = new System.Drawing.Point(0, 0);
			this.TabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(763, 676);
			this.TabControl1.TabIndex = 0;
			//
			//TabPage1
			//
			this.TabPage1.BackgroundImage = global::LibraryManagementSystem.My.Resources.Resources.textures_wallpapers_simple_and_beautifull_wood_texture_backgrounds;
			this.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.TabPage1.Controls.Add(this.txtStatus);
			this.TabPage1.Controls.Add(this.TextBox1);
			this.TabPage1.Controls.Add(this.GroupBox1);
			this.TabPage1.Controls.Add(this.panel1);
			this.TabPage1.Controls.Add(this.GroupBox3);
			this.TabPage1.Controls.Add(this.GroupBox2);
			this.TabPage1.Location = new System.Drawing.Point(4, 26);
			this.TabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.TabPage1.Size = new System.Drawing.Size(755, 646);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Students";
			this.TabPage1.UseVisualStyleBackColor = true;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(600, 202);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(100, 24);
			this.TextBox1.TabIndex = 8;
			this.TextBox1.Visible = false;
			//
			//GroupBox1
			//
			this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox1.Controls.Add(this.Button3);
			this.GroupBox1.Controls.Add(this.dtpDueDate);
			this.GroupBox1.Controls.Add(this.dtpIssueDate);
			this.GroupBox1.Controls.Add(this.Label19);
			this.GroupBox1.Controls.Add(this.Label20);
			this.GroupBox1.Controls.Add(this.txtTransactionID);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.GroupBox1.Location = new System.Drawing.Point(24, 7);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(390, 153);
			this.GroupBox1.TabIndex = 4;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Issue Details";
			//
			//Button3
			//
			this.Button3.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button3.Location = new System.Drawing.Point(348, 32);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(28, 23);
			this.Button3.TabIndex = 30;
			this.Button3.Text = ">";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//dtpDueDate
			//
			this.dtpDueDate.CustomFormat = "dd/MMM/yyyy";
			this.dtpDueDate.Enabled = false;
			this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDueDate.Location = new System.Drawing.Point(138, 107);
			this.dtpDueDate.Name = "dtpDueDate";
			this.dtpDueDate.Size = new System.Drawing.Size(149, 25);
			this.dtpDueDate.TabIndex = 2;
			//
			//dtpIssueDate
			//
			this.dtpIssueDate.CustomFormat = "dd/MMM/yyyy";
			this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpIssueDate.Location = new System.Drawing.Point(138, 69);
			this.dtpIssueDate.Name = "dtpIssueDate";
			this.dtpIssueDate.Size = new System.Drawing.Size(149, 25);
			this.dtpIssueDate.TabIndex = 1;
			//
			//Label19
			//
			this.Label19.AutoSize = true;
			this.Label19.Location = new System.Drawing.Point(18, 73);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(72, 18);
			this.Label19.TabIndex = 29;
			this.Label19.Text = "Issue Date";
			//
			//Label20
			//
			this.Label20.AutoSize = true;
			this.Label20.Location = new System.Drawing.Point(18, 106);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(66, 18);
			this.Label20.TabIndex = 28;
			this.Label20.Text = "Due Date";
			//
			//txtTransactionID
			//
			this.txtTransactionID.Location = new System.Drawing.Point(138, 31);
			this.txtTransactionID.Name = "txtTransactionID";
			this.txtTransactionID.ReadOnly = true;
			this.txtTransactionID.Size = new System.Drawing.Size(204, 25);
			this.txtTransactionID.TabIndex = 0;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(17, 34);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(99, 18);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Transaction ID";
			//
			//panel1
			//
			this.panel1.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnUpdate_record);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.btnNewRecord);
			this.panel1.Location = new System.Drawing.Point(600, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(129, 180);
			this.panel1.TabIndex = 7;
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
			//btnSave
			//
			this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnSave.Location = new System.Drawing.Point(16, 53);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(95, 33);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
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
			//GroupBox3
			//
			this.GroupBox3.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox3.Controls.Add(this.txtStudentName);
			this.GroupBox3.Controls.Add(this.Button2);
			this.GroupBox3.Controls.Add(this.txtCourse);
			this.GroupBox3.Controls.Add(this.Label13);
			this.GroupBox3.Controls.Add(this.txtDepartment);
			this.GroupBox3.Controls.Add(this.Label16);
			this.GroupBox3.Controls.Add(this.Label17);
			this.GroupBox3.Controls.Add(this.cmbStudentID);
			this.GroupBox3.Controls.Add(this.Label18);
			this.GroupBox3.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.GroupBox3.Location = new System.Drawing.Point(24, 167);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(540, 183);
			this.GroupBox3.TabIndex = 5;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Student Details";
			//
			//txtStudentName
			//
			this.txtStudentName.Location = new System.Drawing.Point(155, 68);
			this.txtStudentName.Name = "txtStudentName";
			this.txtStudentName.ReadOnly = true;
			this.txtStudentName.Size = new System.Drawing.Size(357, 25);
			this.txtStudentName.TabIndex = 1;
			//
			//Button2
			//
			this.Button2.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button2.Location = new System.Drawing.Point(314, 30);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(28, 23);
			this.Button2.TabIndex = 26;
			this.Button2.Text = ">";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//txtCourse
			//
			this.txtCourse.Location = new System.Drawing.Point(155, 102);
			this.txtCourse.Name = "txtCourse";
			this.txtCourse.ReadOnly = true;
			this.txtCourse.Size = new System.Drawing.Size(270, 25);
			this.txtCourse.TabIndex = 2;
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Location = new System.Drawing.Point(43, 102);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(51, 18);
			this.Label13.TabIndex = 23;
			this.Label13.Text = "Course";
			//
			//txtDepartment
			//
			this.txtDepartment.Location = new System.Drawing.Point(155, 137);
			this.txtDepartment.Name = "txtDepartment";
			this.txtDepartment.ReadOnly = true;
			this.txtDepartment.Size = new System.Drawing.Size(270, 25);
			this.txtDepartment.TabIndex = 3;
			//
			//Label16
			//
			this.Label16.AutoSize = true;
			this.Label16.Location = new System.Drawing.Point(43, 138);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(81, 18);
			this.Label16.TabIndex = 17;
			this.Label16.Text = "Department";
			//
			//Label17
			//
			this.Label17.AutoSize = true;
			this.Label17.Location = new System.Drawing.Point(43, 35);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(74, 18);
			this.Label17.TabIndex = 3;
			this.Label17.Text = "Student ID";
			//
			//cmbStudentID
			//
			this.cmbStudentID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbStudentID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbStudentID.FormattingEnabled = true;
			this.cmbStudentID.Location = new System.Drawing.Point(155, 30);
			this.cmbStudentID.Name = "cmbStudentID";
			this.cmbStudentID.Size = new System.Drawing.Size(140, 26);
			this.cmbStudentID.TabIndex = 0;
			//
			//Label18
			//
			this.Label18.AutoSize = true;
			this.Label18.Location = new System.Drawing.Point(43, 68);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(95, 18);
			this.Label18.TabIndex = 1;
			this.Label18.Text = "Student Name";
			//
			//GroupBox2
			//
			this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox2.Controls.Add(this.Button1);
			this.GroupBox2.Controls.Add(this.txtAuthor);
			this.GroupBox2.Controls.Add(this.Label12);
			this.GroupBox2.Controls.Add(this.txtEdition);
			this.GroupBox2.Controls.Add(this.txtISBN);
			this.GroupBox2.Controls.Add(this.txtCategory);
			this.GroupBox2.Controls.Add(this.Label11);
			this.GroupBox2.Controls.Add(this.Label10);
			this.GroupBox2.Controls.Add(this.Label9);
			this.GroupBox2.Controls.Add(this.Label4);
			this.GroupBox2.Controls.Add(this.txtBookTitle);
			this.GroupBox2.Controls.Add(this.cmbAccessionNo);
			this.GroupBox2.Controls.Add(this.Label2);
			this.GroupBox2.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.GroupBox2.Location = new System.Drawing.Point(24, 358);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(540, 267);
			this.GroupBox2.TabIndex = 6;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Book Details";
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(304, 28);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(28, 23);
			this.Button1.TabIndex = 25;
			this.Button1.Text = ">";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//txtAuthor
			//
			this.txtAuthor.Location = new System.Drawing.Point(149, 100);
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.ReadOnly = true;
			this.txtAuthor.Size = new System.Drawing.Size(374, 25);
			this.txtAuthor.TabIndex = 2;
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Location = new System.Drawing.Point(43, 100);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(50, 18);
			this.Label12.TabIndex = 23;
			this.Label12.Text = "Author";
			//
			//txtEdition
			//
			this.txtEdition.Location = new System.Drawing.Point(147, 218);
			this.txtEdition.Name = "txtEdition";
			this.txtEdition.ReadOnly = true;
			this.txtEdition.Size = new System.Drawing.Size(121, 25);
			this.txtEdition.TabIndex = 5;
			//
			//txtISBN
			//
			this.txtISBN.Location = new System.Drawing.Point(149, 176);
			this.txtISBN.Name = "txtISBN";
			this.txtISBN.ReadOnly = true;
			this.txtISBN.Size = new System.Drawing.Size(298, 25);
			this.txtISBN.TabIndex = 4;
			//
			//txtCategory
			//
			this.txtCategory.Location = new System.Drawing.Point(149, 136);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.ReadOnly = true;
			this.txtCategory.Size = new System.Drawing.Size(374, 25);
			this.txtCategory.TabIndex = 3;
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Location = new System.Drawing.Point(43, 179);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(41, 18);
			this.Label11.TabIndex = 19;
			this.Label11.Text = "ISBN";
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Location = new System.Drawing.Point(43, 221);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(52, 18);
			this.Label10.TabIndex = 18;
			this.Label10.Text = "Edition";
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Location = new System.Drawing.Point(43, 139);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(63, 18);
			this.Label9.TabIndex = 17;
			this.Label9.Text = "Category";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(43, 35);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(95, 18);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Accession No.";
			//
			//txtBookTitle
			//
			this.txtBookTitle.Location = new System.Drawing.Point(149, 65);
			this.txtBookTitle.Name = "txtBookTitle";
			this.txtBookTitle.ReadOnly = true;
			this.txtBookTitle.Size = new System.Drawing.Size(374, 25);
			this.txtBookTitle.TabIndex = 1;
			//
			//cmbAccessionNo
			//
			this.cmbAccessionNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbAccessionNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbAccessionNo.FormattingEnabled = true;
			this.cmbAccessionNo.Location = new System.Drawing.Point(149, 27);
			this.cmbAccessionNo.Name = "cmbAccessionNo";
			this.cmbAccessionNo.Size = new System.Drawing.Size(140, 26);
			this.cmbAccessionNo.TabIndex = 0;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(43, 68);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(72, 18);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Book Title";
			//
			//TabPage2
			//
			this.TabPage2.BackgroundImage = global::LibraryManagementSystem.My.Resources.Resources.textures_wallpapers_simple_and_beautifull_wood_texture_backgrounds;
			this.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.TabPage2.Controls.Add(this.txtStatus1);
			this.TabPage2.Controls.Add(this.TextBox2);
			this.TabPage2.Controls.Add(this.Panel2);
			this.TabPage2.Controls.Add(this.GroupBox6);
			this.TabPage2.Controls.Add(this.GroupBox5);
			this.TabPage2.Controls.Add(this.GroupBox4);
			this.TabPage2.Location = new System.Drawing.Point(4, 26);
			this.TabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.TabPage2.Size = new System.Drawing.Size(755, 646);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Staff";
			this.TabPage2.UseVisualStyleBackColor = true;
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(600, 213);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(100, 24);
			this.TextBox2.TabIndex = 10;
			this.TextBox2.Visible = false;
			//
			//Panel2
			//
			this.Panel2.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.Panel2.BackColor = System.Drawing.Color.Transparent;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.btnUpdate1);
			this.Panel2.Controls.Add(this.btnDelete1);
			this.Panel2.Controls.Add(this.btnSave1);
			this.Panel2.Controls.Add(this.btnNewRecord1);
			this.Panel2.Location = new System.Drawing.Point(597, 27);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(129, 180);
			this.Panel2.TabIndex = 9;
			//
			//btnUpdate1
			//
			this.btnUpdate1.Enabled = false;
			this.btnUpdate1.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnUpdate1.Location = new System.Drawing.Point(16, 133);
			this.btnUpdate1.Name = "btnUpdate1";
			this.btnUpdate1.Size = new System.Drawing.Size(95, 33);
			this.btnUpdate1.TabIndex = 3;
			this.btnUpdate1.Text = "&Update";
			this.btnUpdate1.UseVisualStyleBackColor = true;
			//
			//btnDelete1
			//
			this.btnDelete1.Enabled = false;
			this.btnDelete1.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnDelete1.Location = new System.Drawing.Point(16, 93);
			this.btnDelete1.Name = "btnDelete1";
			this.btnDelete1.Size = new System.Drawing.Size(95, 33);
			this.btnDelete1.TabIndex = 2;
			this.btnDelete1.Text = "&Delete";
			this.btnDelete1.UseVisualStyleBackColor = true;
			//
			//btnSave1
			//
			this.btnSave1.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnSave1.Location = new System.Drawing.Point(16, 53);
			this.btnSave1.Name = "btnSave1";
			this.btnSave1.Size = new System.Drawing.Size(95, 33);
			this.btnSave1.TabIndex = 1;
			this.btnSave1.Text = "&Save";
			this.btnSave1.UseVisualStyleBackColor = true;
			//
			//btnNewRecord1
			//
			this.btnNewRecord1.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnNewRecord1.Location = new System.Drawing.Point(16, 14);
			this.btnNewRecord1.Name = "btnNewRecord1";
			this.btnNewRecord1.Size = new System.Drawing.Size(95, 33);
			this.btnNewRecord1.TabIndex = 0;
			this.btnNewRecord1.Text = "&New";
			this.btnNewRecord1.UseVisualStyleBackColor = true;
			//
			//GroupBox6
			//
			this.GroupBox6.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox6.Controls.Add(this.Button6);
			this.GroupBox6.Controls.Add(this.txtAuthor1);
			this.GroupBox6.Controls.Add(this.Label21);
			this.GroupBox6.Controls.Add(this.txtEdition1);
			this.GroupBox6.Controls.Add(this.txtISBN1);
			this.GroupBox6.Controls.Add(this.txtCategory1);
			this.GroupBox6.Controls.Add(this.Label22);
			this.GroupBox6.Controls.Add(this.Label23);
			this.GroupBox6.Controls.Add(this.Label24);
			this.GroupBox6.Controls.Add(this.Label25);
			this.GroupBox6.Controls.Add(this.txtBookTitle1);
			this.GroupBox6.Controls.Add(this.cmbAccessionNo1);
			this.GroupBox6.Controls.Add(this.Label26);
			this.GroupBox6.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.GroupBox6.Location = new System.Drawing.Point(27, 345);
			this.GroupBox6.Name = "GroupBox6";
			this.GroupBox6.Size = new System.Drawing.Size(540, 267);
			this.GroupBox6.TabIndex = 7;
			this.GroupBox6.TabStop = false;
			this.GroupBox6.Text = "Book Details";
			//
			//Button6
			//
			this.Button6.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button6.Location = new System.Drawing.Point(304, 28);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(28, 23);
			this.Button6.TabIndex = 25;
			this.Button6.Text = ">";
			this.Button6.UseVisualStyleBackColor = true;
			//
			//txtAuthor1
			//
			this.txtAuthor1.Location = new System.Drawing.Point(149, 100);
			this.txtAuthor1.Name = "txtAuthor1";
			this.txtAuthor1.ReadOnly = true;
			this.txtAuthor1.Size = new System.Drawing.Size(374, 25);
			this.txtAuthor1.TabIndex = 2;
			//
			//Label21
			//
			this.Label21.AutoSize = true;
			this.Label21.Location = new System.Drawing.Point(43, 100);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(50, 18);
			this.Label21.TabIndex = 23;
			this.Label21.Text = "Author";
			//
			//txtEdition1
			//
			this.txtEdition1.Location = new System.Drawing.Point(149, 218);
			this.txtEdition1.Name = "txtEdition1";
			this.txtEdition1.ReadOnly = true;
			this.txtEdition1.Size = new System.Drawing.Size(121, 25);
			this.txtEdition1.TabIndex = 5;
			//
			//txtISBN1
			//
			this.txtISBN1.Location = new System.Drawing.Point(149, 179);
			this.txtISBN1.Name = "txtISBN1";
			this.txtISBN1.ReadOnly = true;
			this.txtISBN1.Size = new System.Drawing.Size(298, 25);
			this.txtISBN1.TabIndex = 4;
			//
			//txtCategory1
			//
			this.txtCategory1.Location = new System.Drawing.Point(149, 138);
			this.txtCategory1.Name = "txtCategory1";
			this.txtCategory1.ReadOnly = true;
			this.txtCategory1.Size = new System.Drawing.Size(374, 25);
			this.txtCategory1.TabIndex = 3;
			//
			//Label22
			//
			this.Label22.AutoSize = true;
			this.Label22.Location = new System.Drawing.Point(43, 179);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(41, 18);
			this.Label22.TabIndex = 19;
			this.Label22.Text = "ISBN";
			//
			//Label23
			//
			this.Label23.AutoSize = true;
			this.Label23.Location = new System.Drawing.Point(43, 221);
			this.Label23.Name = "Label23";
			this.Label23.Size = new System.Drawing.Size(52, 18);
			this.Label23.TabIndex = 18;
			this.Label23.Text = "Edition";
			//
			//Label24
			//
			this.Label24.AutoSize = true;
			this.Label24.Location = new System.Drawing.Point(43, 139);
			this.Label24.Name = "Label24";
			this.Label24.Size = new System.Drawing.Size(63, 18);
			this.Label24.TabIndex = 17;
			this.Label24.Text = "Category";
			//
			//Label25
			//
			this.Label25.AutoSize = true;
			this.Label25.Location = new System.Drawing.Point(43, 35);
			this.Label25.Name = "Label25";
			this.Label25.Size = new System.Drawing.Size(95, 18);
			this.Label25.TabIndex = 3;
			this.Label25.Text = "Accession No.";
			//
			//txtBookTitle1
			//
			this.txtBookTitle1.Location = new System.Drawing.Point(149, 65);
			this.txtBookTitle1.Name = "txtBookTitle1";
			this.txtBookTitle1.ReadOnly = true;
			this.txtBookTitle1.Size = new System.Drawing.Size(374, 25);
			this.txtBookTitle1.TabIndex = 1;
			//
			//cmbAccessionNo1
			//
			this.cmbAccessionNo1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbAccessionNo1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbAccessionNo1.FormattingEnabled = true;
			this.cmbAccessionNo1.Location = new System.Drawing.Point(149, 27);
			this.cmbAccessionNo1.Name = "cmbAccessionNo1";
			this.cmbAccessionNo1.Size = new System.Drawing.Size(140, 26);
			this.cmbAccessionNo1.TabIndex = 0;
			//
			//Label26
			//
			this.Label26.AutoSize = true;
			this.Label26.Location = new System.Drawing.Point(43, 68);
			this.Label26.Name = "Label26";
			this.Label26.Size = new System.Drawing.Size(72, 18);
			this.Label26.TabIndex = 1;
			this.Label26.Text = "Book Title";
			//
			//GroupBox5
			//
			this.GroupBox5.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox5.Controls.Add(this.txtStaffName);
			this.GroupBox5.Controls.Add(this.Button5);
			this.GroupBox5.Controls.Add(this.txtDepartment1);
			this.GroupBox5.Controls.Add(this.Label8);
			this.GroupBox5.Controls.Add(this.Label14);
			this.GroupBox5.Controls.Add(this.cmbStaffID);
			this.GroupBox5.Controls.Add(this.Label15);
			this.GroupBox5.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.GroupBox5.Location = new System.Drawing.Point(27, 176);
			this.GroupBox5.Name = "GroupBox5";
			this.GroupBox5.Size = new System.Drawing.Size(540, 152);
			this.GroupBox5.TabIndex = 6;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "Staff Details";
			//
			//txtStaffName
			//
			this.txtStaffName.Location = new System.Drawing.Point(155, 68);
			this.txtStaffName.Name = "txtStaffName";
			this.txtStaffName.ReadOnly = true;
			this.txtStaffName.Size = new System.Drawing.Size(357, 25);
			this.txtStaffName.TabIndex = 1;
			//
			//Button5
			//
			this.Button5.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button5.Location = new System.Drawing.Point(314, 30);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(28, 23);
			this.Button5.TabIndex = 26;
			this.Button5.Text = ">";
			this.Button5.UseVisualStyleBackColor = true;
			//
			//txtDepartment1
			//
			this.txtDepartment1.Location = new System.Drawing.Point(155, 106);
			this.txtDepartment1.Name = "txtDepartment1";
			this.txtDepartment1.ReadOnly = true;
			this.txtDepartment1.Size = new System.Drawing.Size(270, 25);
			this.txtDepartment1.TabIndex = 3;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(43, 106);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(81, 18);
			this.Label8.TabIndex = 17;
			this.Label8.Text = "Department";
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.Location = new System.Drawing.Point(43, 35);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(55, 18);
			this.Label14.TabIndex = 3;
			this.Label14.Text = "Staff ID";
			//
			//cmbStaffID
			//
			this.cmbStaffID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbStaffID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbStaffID.FormattingEnabled = true;
			this.cmbStaffID.Location = new System.Drawing.Point(155, 30);
			this.cmbStaffID.Name = "cmbStaffID";
			this.cmbStaffID.Size = new System.Drawing.Size(140, 26);
			this.cmbStaffID.TabIndex = 0;
			//
			//Label15
			//
			this.Label15.AutoSize = true;
			this.Label15.Location = new System.Drawing.Point(43, 68);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(76, 18);
			this.Label15.TabIndex = 1;
			this.Label15.Text = "Staff Name";
			//
			//GroupBox4
			//
			this.GroupBox4.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox4.Controls.Add(this.Button4);
			this.GroupBox4.Controls.Add(this.dtpDueDate1);
			this.GroupBox4.Controls.Add(this.dtpIssueDate1);
			this.GroupBox4.Controls.Add(this.Label3);
			this.GroupBox4.Controls.Add(this.Label5);
			this.GroupBox4.Controls.Add(this.txtTransactionID1);
			this.GroupBox4.Controls.Add(this.Label6);
			this.GroupBox4.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.GroupBox4.Location = new System.Drawing.Point(27, 17);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new System.Drawing.Size(390, 153);
			this.GroupBox4.TabIndex = 5;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Issue Details";
			//
			//Button4
			//
			this.Button4.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button4.Location = new System.Drawing.Point(348, 32);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(28, 23);
			this.Button4.TabIndex = 30;
			this.Button4.Text = ">";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//dtpDueDate1
			//
			this.dtpDueDate1.CustomFormat = "dd/MMM/yyyy";
			this.dtpDueDate1.Enabled = false;
			this.dtpDueDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDueDate1.Location = new System.Drawing.Point(138, 107);
			this.dtpDueDate1.Name = "dtpDueDate1";
			this.dtpDueDate1.Size = new System.Drawing.Size(149, 25);
			this.dtpDueDate1.TabIndex = 2;
			//
			//dtpIssueDate1
			//
			this.dtpIssueDate1.CustomFormat = "dd/MMM/yyyy";
			this.dtpIssueDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpIssueDate1.Location = new System.Drawing.Point(138, 69);
			this.dtpIssueDate1.Name = "dtpIssueDate1";
			this.dtpIssueDate1.Size = new System.Drawing.Size(149, 25);
			this.dtpIssueDate1.TabIndex = 1;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(18, 73);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(72, 18);
			this.Label3.TabIndex = 29;
			this.Label3.Text = "Issue Date";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(18, 106);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(66, 18);
			this.Label5.TabIndex = 28;
			this.Label5.Text = "Due Date";
			//
			//txtTransactionID1
			//
			this.txtTransactionID1.Location = new System.Drawing.Point(138, 31);
			this.txtTransactionID1.Name = "txtTransactionID1";
			this.txtTransactionID1.ReadOnly = true;
			this.txtTransactionID1.Size = new System.Drawing.Size(204, 25);
			this.txtTransactionID1.TabIndex = 0;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(17, 34);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(99, 18);
			this.Label6.TabIndex = 0;
			this.Label6.Text = "Transaction ID";
			//
			//txtStatus
			//
			this.txtStatus.Location = new System.Drawing.Point(600, 232);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(100, 24);
			this.txtStatus.TabIndex = 9;
			this.txtStatus.Visible = false;
			//
			//txtStatus1
			//
			this.txtStatus1.Location = new System.Drawing.Point(597, 245);
			this.txtStatus1.Name = "txtStatus1";
			this.txtStatus1.Size = new System.Drawing.Size(100, 24);
			this.txtStatus1.TabIndex = 11;
			this.txtStatus1.Visible = false;
			//
			//frmBookIssue
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(765, 675);
			this.Controls.Add(this.TabControl1);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "frmBookIssue";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Book Issue";
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.GroupBox6.ResumeLayout(false);
			this.GroupBox6.PerformLayout();
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.Button withEventsField_Button3;
		internal System.Windows.Forms.Button Button3 {
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
		internal System.Windows.Forms.DateTimePicker dtpDueDate;
		private System.Windows.Forms.DateTimePicker withEventsField_dtpIssueDate;
		internal System.Windows.Forms.DateTimePicker dtpIssueDate {
			get { return withEventsField_dtpIssueDate; }
			set {
				if (withEventsField_dtpIssueDate != null) {
					withEventsField_dtpIssueDate.ValueChanged -= dtpIssueDate_ValueChanged;
				}
				withEventsField_dtpIssueDate = value;
				if (withEventsField_dtpIssueDate != null) {
					withEventsField_dtpIssueDate.ValueChanged += dtpIssueDate_ValueChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.Label Label20;
		internal System.Windows.Forms.TextBox txtTransactionID;
		internal System.Windows.Forms.Label Label1;
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
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.TextBox txtStudentName;
		private System.Windows.Forms.Button withEventsField_Button2;
		internal System.Windows.Forms.Button Button2 {
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
		internal System.Windows.Forms.TextBox txtCourse;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.TextBox txtDepartment;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.GroupBox GroupBox2;
		private System.Windows.Forms.Button withEventsField_Button1;
		internal System.Windows.Forms.Button Button1 {
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
		internal System.Windows.Forms.TextBox txtAuthor;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox txtEdition;
		internal System.Windows.Forms.TextBox txtISBN;
		internal System.Windows.Forms.TextBox txtCategory;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox txtBookTitle;
		private System.Windows.Forms.ComboBox withEventsField_cmbAccessionNo;
		internal System.Windows.Forms.ComboBox cmbAccessionNo {
			get { return withEventsField_cmbAccessionNo; }
			set {
				if (withEventsField_cmbAccessionNo != null) {
					withEventsField_cmbAccessionNo.SelectedIndexChanged -= cmbAccessionNo_SelectedIndexChanged;
				}
				withEventsField_cmbAccessionNo = value;
				if (withEventsField_cmbAccessionNo != null) {
					withEventsField_cmbAccessionNo.SelectedIndexChanged += cmbAccessionNo_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label17;
		private System.Windows.Forms.ComboBox withEventsField_cmbStudentID;
		internal System.Windows.Forms.ComboBox cmbStudentID {
			get { return withEventsField_cmbStudentID; }
			set {
				if (withEventsField_cmbStudentID != null) {
					withEventsField_cmbStudentID.SelectedIndexChanged -= cmbStudentID_SelectedIndexChanged;
				}
				withEventsField_cmbStudentID = value;
				if (withEventsField_cmbStudentID != null) {
					withEventsField_cmbStudentID.SelectedIndexChanged += cmbStudentID_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		private System.Windows.Forms.Panel Panel2;
		private System.Windows.Forms.Button withEventsField_btnUpdate1;
		public System.Windows.Forms.Button btnUpdate1 {
			get { return withEventsField_btnUpdate1; }
			set {
				if (withEventsField_btnUpdate1 != null) {
					withEventsField_btnUpdate1.Click -= btnUpdate1_Click;
				}
				withEventsField_btnUpdate1 = value;
				if (withEventsField_btnUpdate1 != null) {
					withEventsField_btnUpdate1.Click += btnUpdate1_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnDelete1;
		public System.Windows.Forms.Button btnDelete1 {
			get { return withEventsField_btnDelete1; }
			set {
				if (withEventsField_btnDelete1 != null) {
					withEventsField_btnDelete1.Click -= btnDelete1_Click;
				}
				withEventsField_btnDelete1 = value;
				if (withEventsField_btnDelete1 != null) {
					withEventsField_btnDelete1.Click += btnDelete1_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnSave1;
		public System.Windows.Forms.Button btnSave1 {
			get { return withEventsField_btnSave1; }
			set {
				if (withEventsField_btnSave1 != null) {
					withEventsField_btnSave1.Click -= btnSave1_Click;
				}
				withEventsField_btnSave1 = value;
				if (withEventsField_btnSave1 != null) {
					withEventsField_btnSave1.Click += btnSave1_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnNewRecord1;
		private System.Windows.Forms.Button btnNewRecord1 {
			get { return withEventsField_btnNewRecord1; }
			set {
				if (withEventsField_btnNewRecord1 != null) {
					withEventsField_btnNewRecord1.Click -= btnNewRecord1_Click;
				}
				withEventsField_btnNewRecord1 = value;
				if (withEventsField_btnNewRecord1 != null) {
					withEventsField_btnNewRecord1.Click += btnNewRecord1_Click;
				}
			}
		}
		internal System.Windows.Forms.GroupBox GroupBox6;
		internal System.Windows.Forms.TextBox txtAuthor1;
		internal System.Windows.Forms.Label Label21;
		internal System.Windows.Forms.TextBox txtEdition1;
		internal System.Windows.Forms.TextBox txtISBN1;
		internal System.Windows.Forms.TextBox txtCategory1;
		internal System.Windows.Forms.Label Label22;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.Label Label24;
		internal System.Windows.Forms.Label Label25;
		internal System.Windows.Forms.TextBox txtBookTitle1;
		internal System.Windows.Forms.Label Label26;
		internal System.Windows.Forms.GroupBox GroupBox5;
		internal System.Windows.Forms.TextBox txtStaffName;
		internal System.Windows.Forms.TextBox txtDepartment1;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.GroupBox GroupBox4;
		private System.Windows.Forms.Button withEventsField_Button4;
		internal System.Windows.Forms.Button Button4 {
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
		internal System.Windows.Forms.DateTimePicker dtpDueDate1;
		private System.Windows.Forms.DateTimePicker withEventsField_dtpIssueDate1;
		internal System.Windows.Forms.DateTimePicker dtpIssueDate1 {
			get { return withEventsField_dtpIssueDate1; }
			set {
				if (withEventsField_dtpIssueDate1 != null) {
					withEventsField_dtpIssueDate1.ValueChanged -= dtpIssueDate1_ValueChanged;
				}
				withEventsField_dtpIssueDate1 = value;
				if (withEventsField_dtpIssueDate1 != null) {
					withEventsField_dtpIssueDate1.ValueChanged += dtpIssueDate1_ValueChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtTransactionID1;
		internal System.Windows.Forms.Label Label6;
		private System.Windows.Forms.ComboBox withEventsField_cmbAccessionNo1;
		internal System.Windows.Forms.ComboBox cmbAccessionNo1 {
			get { return withEventsField_cmbAccessionNo1; }
			set {
				if (withEventsField_cmbAccessionNo1 != null) {
					withEventsField_cmbAccessionNo1.SelectedIndexChanged -= cmbAccessionNo1_SelectedIndexChanged;
				}
				withEventsField_cmbAccessionNo1 = value;
				if (withEventsField_cmbAccessionNo1 != null) {
					withEventsField_cmbAccessionNo1.SelectedIndexChanged += cmbAccessionNo1_SelectedIndexChanged;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_Button6;
		internal System.Windows.Forms.Button Button6 {
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
		internal System.Windows.Forms.Button Button5 {
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
		private System.Windows.Forms.ComboBox withEventsField_cmbStaffID;
		internal System.Windows.Forms.ComboBox cmbStaffID {
			get { return withEventsField_cmbStaffID; }
			set {
				if (withEventsField_cmbStaffID != null) {
					withEventsField_cmbStaffID.SelectedIndexChanged -= cmbStaffID_SelectedIndexChanged;
				}
				withEventsField_cmbStaffID = value;
				if (withEventsField_cmbStaffID != null) {
					withEventsField_cmbStaffID.SelectedIndexChanged += cmbStaffID_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.TextBox txtStatus;
		internal System.Windows.Forms.TextBox txtStatus1;
	}
}

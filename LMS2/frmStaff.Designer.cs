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
	partial class frmStaff : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.txtContactNo = new System.Windows.Forms.GroupBox();
			this.dtpDateOfJoining = new System.Windows.Forms.DateTimePicker();
			this.Label11 = new System.Windows.Forms.Label();
			this.rbFemale = new System.Windows.Forms.RadioButton();
			this.rbMale = new System.Windows.Forms.RadioButton();
			this.Label13 = new System.Windows.Forms.Label();
			this.txtStaffID = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtMobileNo = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.txtStaffName = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtPhoneNo = new System.Windows.Forms.TextBox();
			this.txtPermanentAddress = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.dtpDOB = new System.Windows.Forms.DateTimePicker();
			this.Browse = new System.Windows.Forms.Button();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.cmbDepartment = new System.Windows.Forms.ComboBox();
			this.txtTempAddress = new System.Windows.Forms.TextBox();
			this.txtFatherName = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.Picture = new System.Windows.Forms.PictureBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnUpdate_record = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnNewRecord = new System.Windows.Forms.Button();
			this.txtContactNo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.Picture).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//OpenFileDialog1
			//
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			//
			//txtContactNo
			//
			this.txtContactNo.BackColor = System.Drawing.Color.Transparent;
			this.txtContactNo.Controls.Add(this.dtpDateOfJoining);
			this.txtContactNo.Controls.Add(this.Label11);
			this.txtContactNo.Controls.Add(this.rbFemale);
			this.txtContactNo.Controls.Add(this.rbMale);
			this.txtContactNo.Controls.Add(this.Label13);
			this.txtContactNo.Controls.Add(this.txtStaffID);
			this.txtContactNo.Controls.Add(this.Label5);
			this.txtContactNo.Controls.Add(this.txtMobileNo);
			this.txtContactNo.Controls.Add(this.Label4);
			this.txtContactNo.Controls.Add(this.Button1);
			this.txtContactNo.Controls.Add(this.txtStaffName);
			this.txtContactNo.Controls.Add(this.Label7);
			this.txtContactNo.Controls.Add(this.txtPhoneNo);
			this.txtContactNo.Controls.Add(this.txtPermanentAddress);
			this.txtContactNo.Controls.Add(this.Label3);
			this.txtContactNo.Controls.Add(this.dtpDOB);
			this.txtContactNo.Controls.Add(this.Browse);
			this.txtContactNo.Controls.Add(this.txtEmail);
			this.txtContactNo.Controls.Add(this.cmbDepartment);
			this.txtContactNo.Controls.Add(this.txtTempAddress);
			this.txtContactNo.Controls.Add(this.txtFatherName);
			this.txtContactNo.Controls.Add(this.label29);
			this.txtContactNo.Controls.Add(this.label28);
			this.txtContactNo.Controls.Add(this.label25);
			this.txtContactNo.Controls.Add(this.label12);
			this.txtContactNo.Controls.Add(this.Picture);
			this.txtContactNo.Controls.Add(this.Label10);
			this.txtContactNo.Controls.Add(this.label6);
			this.txtContactNo.Controls.Add(this.label1);
			this.txtContactNo.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtContactNo.ForeColor = System.Drawing.Color.Black;
			this.txtContactNo.Location = new System.Drawing.Point(41, 29);
			this.txtContactNo.Name = "txtContactNo";
			this.txtContactNo.Size = new System.Drawing.Size(770, 486);
			this.txtContactNo.TabIndex = 0;
			this.txtContactNo.TabStop = false;
			this.txtContactNo.Text = "Staff Profile";
			//
			//dtpDateOfJoining
			//
			this.dtpDateOfJoining.CustomFormat = "dd/MMM/yyyy";
			this.dtpDateOfJoining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.dtpDateOfJoining.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateOfJoining.Location = new System.Drawing.Point(228, 155);
			this.dtpDateOfJoining.Name = "dtpDateOfJoining";
			this.dtpDateOfJoining.Size = new System.Drawing.Size(122, 22);
			this.dtpDateOfJoining.TabIndex = 3;
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label11.ForeColor = System.Drawing.Color.Black;
			this.Label11.Location = new System.Drawing.Point(34, 159);
			this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(110, 18);
			this.Label11.TabIndex = 105;
			this.Label11.Text = "*Date Of Joining";
			//
			//rbFemale
			//
			this.rbFemale.AutoSize = true;
			this.rbFemale.Location = new System.Drawing.Point(306, 113);
			this.rbFemale.Name = "rbFemale";
			this.rbFemale.Size = new System.Drawing.Size(65, 21);
			this.rbFemale.TabIndex = 2;
			this.rbFemale.TabStop = true;
			this.rbFemale.Text = "Female";
			this.rbFemale.UseVisualStyleBackColor = true;
			//
			//rbMale
			//
			this.rbMale.AutoSize = true;
			this.rbMale.Location = new System.Drawing.Point(228, 113);
			this.rbMale.Name = "rbMale";
			this.rbMale.Size = new System.Drawing.Size(53, 21);
			this.rbMale.TabIndex = 1;
			this.rbMale.TabStop = true;
			this.rbMale.Text = "Male";
			this.rbMale.UseVisualStyleBackColor = true;
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label13.ForeColor = System.Drawing.Color.Black;
			this.Label13.Location = new System.Drawing.Point(34, 116);
			this.Label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(60, 18);
			this.Label13.TabIndex = 104;
			this.Label13.Text = "*Gender";
			//
			//txtStaffID
			//
			this.txtStaffID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtStaffID.Location = new System.Drawing.Point(228, 36);
			this.txtStaffID.Name = "txtStaffID";
			this.txtStaffID.ReadOnly = true;
			this.txtStaffID.Size = new System.Drawing.Size(143, 22);
			this.txtStaffID.TabIndex = 14;
			//
			//Label5
			//
			this.Label5.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label5.ForeColor = System.Drawing.Color.Black;
			this.Label5.Location = new System.Drawing.Point(34, 41);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(55, 18);
			this.Label5.TabIndex = 61;
			this.Label5.Text = "Staff ID";
			//
			//txtMobileNo
			//
			this.txtMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtMobileNo.Location = new System.Drawing.Point(510, 398);
			this.txtMobileNo.Name = "txtMobileNo";
			this.txtMobileNo.Size = new System.Drawing.Size(166, 22);
			this.txtMobileNo.TabIndex = 10;
			//
			//Label4
			//
			this.Label4.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.Black;
			this.Label4.Location = new System.Drawing.Point(410, 402);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(84, 18);
			this.Label4.TabIndex = 14;
			this.Label4.Text = "*Mobile No.";
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(386, 36);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(28, 23);
			this.Button1.TabIndex = 13;
			this.Button1.Text = ">";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//txtStaffName
			//
			this.txtStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtStaffName.Location = new System.Drawing.Point(228, 75);
			this.txtStaffName.Name = "txtStaffName";
			this.txtStaffName.Size = new System.Drawing.Size(286, 22);
			this.txtStaffName.TabIndex = 0;
			//
			//Label7
			//
			this.Label7.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label7.ForeColor = System.Drawing.Color.Black;
			this.Label7.Location = new System.Drawing.Point(31, 442);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(43, 18);
			this.Label7.TabIndex = 49;
			this.Label7.Text = "Email";
			//
			//txtPhoneNo
			//
			this.txtPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtPhoneNo.Location = new System.Drawing.Point(228, 398);
			this.txtPhoneNo.Name = "txtPhoneNo";
			this.txtPhoneNo.Size = new System.Drawing.Size(166, 22);
			this.txtPhoneNo.TabIndex = 9;
			//
			//txtPermanentAddress
			//
			this.txtPermanentAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtPermanentAddress.Location = new System.Drawing.Point(228, 316);
			this.txtPermanentAddress.Multiline = true;
			this.txtPermanentAddress.Name = "txtPermanentAddress";
			this.txtPermanentAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtPermanentAddress.Size = new System.Drawing.Size(469, 24);
			this.txtPermanentAddress.TabIndex = 7;
			//
			//Label3
			//
			this.Label3.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.Black;
			this.Label3.Location = new System.Drawing.Point(31, 318);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(133, 18);
			this.Label3.TabIndex = 46;
			this.Label3.Text = "*Permanent Address";
			//
			//dtpDOB
			//
			this.dtpDOB.CustomFormat = "dd/MMM/yyyy";
			this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOB.Location = new System.Drawing.Point(228, 358);
			this.dtpDOB.Name = "dtpDOB";
			this.dtpDOB.Size = new System.Drawing.Size(122, 22);
			this.dtpDOB.TabIndex = 8;
			//
			//Browse
			//
			this.Browse.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Browse.ForeColor = System.Drawing.Color.Black;
			this.Browse.Location = new System.Drawing.Point(549, 195);
			this.Browse.Name = "Browse";
			this.Browse.Size = new System.Drawing.Size(197, 23);
			this.Browse.TabIndex = 12;
			this.Browse.Text = "Browse...";
			this.Browse.UseVisualStyleBackColor = true;
			//
			//txtEmail
			//
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtEmail.Location = new System.Drawing.Point(228, 440);
			this.txtEmail.Multiline = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(307, 22);
			this.txtEmail.TabIndex = 11;
			//
			//cmbDepartment
			//
			this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.cmbDepartment.FormattingEnabled = true;
			this.cmbDepartment.Location = new System.Drawing.Point(228, 236);
			this.cmbDepartment.Name = "cmbDepartment";
			this.cmbDepartment.Size = new System.Drawing.Size(222, 23);
			this.cmbDepartment.TabIndex = 5;
			//
			//txtTempAddress
			//
			this.txtTempAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtTempAddress.Location = new System.Drawing.Point(228, 274);
			this.txtTempAddress.Multiline = true;
			this.txtTempAddress.Name = "txtTempAddress";
			this.txtTempAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtTempAddress.Size = new System.Drawing.Size(469, 24);
			this.txtTempAddress.TabIndex = 6;
			//
			//txtFatherName
			//
			this.txtFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtFatherName.Location = new System.Drawing.Point(228, 195);
			this.txtFatherName.Name = "txtFatherName";
			this.txtFatherName.Size = new System.Drawing.Size(286, 22);
			this.txtFatherName.TabIndex = 4;
			//
			//label29
			//
			this.label29.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.label29.AutoSize = true;
			this.label29.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.label29.ForeColor = System.Drawing.Color.Black;
			this.label29.Location = new System.Drawing.Point(33, 402);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(73, 18);
			this.label29.TabIndex = 25;
			this.label29.Text = "Phone No.";
			//
			//label28
			//
			this.label28.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.label28.Location = new System.Drawing.Point(-338, 510);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(43, 18);
			this.label28.TabIndex = 24;
			this.label28.Text = "Email";
			//
			//label25
			//
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.label25.Location = new System.Drawing.Point(31, 241);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(87, 18);
			this.label25.TabIndex = 21;
			this.label25.Text = "*Department";
			//
			//label12
			//
			this.label12.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(34, 280);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(134, 18);
			this.label12.TabIndex = 15;
			this.label12.Text = "*Temporary Address";
			//
			//Picture
			//
			this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Picture.Image = global::LibraryManagementSystem.My.Resources.Resources.photo;
			this.Picture.Location = new System.Drawing.Point(549, 27);
			this.Picture.Name = "Picture";
			this.Picture.Size = new System.Drawing.Size(197, 163);
			this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Picture.TabIndex = 13;
			this.Picture.TabStop = false;
			//
			//Label10
			//
			this.Label10.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Label10.AutoSize = true;
			this.Label10.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label10.ForeColor = System.Drawing.Color.Black;
			this.Label10.Location = new System.Drawing.Point(31, 200);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(102, 18);
			this.Label10.TabIndex = 6;
			this.Label10.Text = "*Father's Name";
			//
			//label6
			//
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.label6.Location = new System.Drawing.Point(31, 362);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 18);
			this.label6.TabIndex = 7;
			this.label6.Text = "*DOB";
			//
			//label1
			//
			this.label1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(31, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "*Staff Name";
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
			this.panel1.Location = new System.Drawing.Point(826, 37);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(129, 180);
			this.panel1.TabIndex = 1;
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
			//frmStaff
			//
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BackgroundImage = global::LibraryManagementSystem.My.Resources.Resources.textures_wallpapers_simple_and_beautifull_wood_texture_backgrounds;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(982, 538);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtContactNo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "frmStaff";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Staff";
			this.txtContactNo.ResumeLayout(false);
			this.txtContactNo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.Picture).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		internal System.Windows.Forms.Timer Timer1;
		private System.Windows.Forms.GroupBox txtContactNo;
		private System.Windows.Forms.Button withEventsField_Browse;
		private System.Windows.Forms.Button Browse {
			get { return withEventsField_Browse; }
			set {
				if (withEventsField_Browse != null) {
					withEventsField_Browse.Click -= Browse_Click_1;
				}
				withEventsField_Browse = value;
				if (withEventsField_Browse != null) {
					withEventsField_Browse.Click += Browse_Click_1;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_txtEmail;
		public System.Windows.Forms.TextBox txtEmail {
			get { return withEventsField_txtEmail; }
			set {
				if (withEventsField_txtEmail != null) {
					withEventsField_txtEmail.Validating -= txtEmail_Validating;
				}
				withEventsField_txtEmail = value;
				if (withEventsField_txtEmail != null) {
					withEventsField_txtEmail.Validating += txtEmail_Validating;
				}
			}
		}
		public System.Windows.Forms.ComboBox cmbDepartment;
		public System.Windows.Forms.TextBox txtTempAddress;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label12;
		public System.Windows.Forms.PictureBox Picture;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		internal System.Windows.Forms.DateTimePicker dtpDOB;
		private System.Windows.Forms.Label Label7;
		private System.Windows.Forms.TextBox withEventsField_txtPhoneNo;
		public System.Windows.Forms.TextBox txtPhoneNo {
			get { return withEventsField_txtPhoneNo; }
			set {
				if (withEventsField_txtPhoneNo != null) {
					withEventsField_txtPhoneNo.KeyPress -= txtPhoneNo_KeyPress;
				}
				withEventsField_txtPhoneNo = value;
				if (withEventsField_txtPhoneNo != null) {
					withEventsField_txtPhoneNo.KeyPress += txtPhoneNo_KeyPress;
				}
			}
		}
		public System.Windows.Forms.TextBox txtPermanentAddress;
		private System.Windows.Forms.Label Label3;
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
		public System.Windows.Forms.TextBox txtStaffName;
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
		public System.Windows.Forms.TextBox txtFatherName;
		private System.Windows.Forms.Label Label10;
		private System.Windows.Forms.TextBox withEventsField_txtMobileNo;
		public System.Windows.Forms.TextBox txtMobileNo {
			get { return withEventsField_txtMobileNo; }
			set {
				if (withEventsField_txtMobileNo != null) {
					withEventsField_txtMobileNo.Validating -= txtMobileNo_Validating;
					withEventsField_txtMobileNo.KeyPress -= txtMobileNo_KeyPress;
				}
				withEventsField_txtMobileNo = value;
				if (withEventsField_txtMobileNo != null) {
					withEventsField_txtMobileNo.Validating += txtMobileNo_Validating;
					withEventsField_txtMobileNo.KeyPress += txtMobileNo_KeyPress;
				}
			}
		}
		private System.Windows.Forms.Label Label4;
		public System.Windows.Forms.TextBox txtStaffID;
		private System.Windows.Forms.Label Label5;
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
		internal System.Windows.Forms.RadioButton rbFemale;
		internal System.Windows.Forms.RadioButton rbMale;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.DateTimePicker dtpDateOfJoining;
		internal System.Windows.Forms.Label Label11;
	}
}

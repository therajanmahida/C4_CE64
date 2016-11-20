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
	partial class frmBookRecord3 : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookRecord3));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.GroupBox15 = new System.Windows.Forms.GroupBox();
			this.txtBookTitle = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.ExportExcel = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.cmbBookTitle = new System.Windows.Forms.ComboBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.GroupBox19 = new System.Windows.Forms.GroupBox();
			this.txtJointAuthors = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.GroupBox14 = new System.Windows.Forms.GroupBox();
			this.txtAuthor = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbAuthor = new System.Windows.Forms.ComboBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.button7 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtAccessionNo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbAccessionNo = new System.Windows.Forms.ComboBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox9 = new System.Windows.Forms.GroupBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.cmbSubject = new System.Windows.Forms.ComboBox();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.dataGridView4 = new System.Windows.Forms.DataGridView();
			this.TabPage5 = new System.Windows.Forms.TabPage();
			this.GroupBox12 = new System.Windows.Forms.GroupBox();
			this.txtPOP = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.GroupBox13 = new System.Windows.Forms.GroupBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.cmbPOP = new System.Windows.Forms.ComboBox();
			this.GroupBox11 = new System.Windows.Forms.GroupBox();
			this.Button10 = new System.Windows.Forms.Button();
			this.Button12 = new System.Windows.Forms.Button();
			this.DataGridView5 = new System.Windows.Forms.DataGridView();
			this.TabPage6 = new System.Windows.Forms.TabPage();
			this.GroupBox16 = new System.Windows.Forms.GroupBox();
			this.txtDepartment = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.GroupBox17 = new System.Windows.Forms.GroupBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.cmbDepartment = new System.Windows.Forms.ComboBox();
			this.GroupBox18 = new System.Windows.Forms.GroupBox();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button11 = new System.Windows.Forms.Button();
			this.DataGridView6 = new System.Windows.Forms.DataGridView();
			this.TabPage7 = new System.Windows.Forms.TabPage();
			this.GroupBox22 = new System.Windows.Forms.GroupBox();
			this.Button5 = new System.Windows.Forms.Button();
			this.Button13 = new System.Windows.Forms.Button();
			this.DataGridView7 = new System.Windows.Forms.DataGridView();
			this.GroupBox20 = new System.Windows.Forms.GroupBox();
			this.txtRFBooks = new System.Windows.Forms.TextBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.GroupBox21 = new System.Windows.Forms.GroupBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.cmbRfBook = new System.Windows.Forms.ComboBox();
			this.TabPage8 = new System.Windows.Forms.TabPage();
			this.DataGridView8 = new System.Windows.Forms.DataGridView();
			this.GroupBox23 = new System.Windows.Forms.GroupBox();
			this.Button16 = new System.Windows.Forms.Button();
			this.Button14 = new System.Windows.Forms.Button();
			this.Button15 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.GroupBox15.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			this.groupBox6.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.GroupBox19.SuspendLayout();
			this.GroupBox14.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dataGridView2).BeginInit();
			this.groupBox8.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dataGridView3).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			this.GroupBox9.SuspendLayout();
			this.groupBox10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dataGridView4).BeginInit();
			this.TabPage5.SuspendLayout();
			this.GroupBox12.SuspendLayout();
			this.GroupBox13.SuspendLayout();
			this.GroupBox11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView5).BeginInit();
			this.TabPage6.SuspendLayout();
			this.GroupBox16.SuspendLayout();
			this.GroupBox17.SuspendLayout();
			this.GroupBox18.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView6).BeginInit();
			this.TabPage7.SuspendLayout();
			this.GroupBox22.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView7).BeginInit();
			this.GroupBox20.SuspendLayout();
			this.GroupBox21.SuspendLayout();
			this.TabPage8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView8).BeginInit();
			this.GroupBox23.SuspendLayout();
			this.SuspendLayout();
			//
			//tabControl1
			//
			this.tabControl1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.TabPage5);
			this.tabControl1.Controls.Add(this.TabPage6);
			this.tabControl1.Controls.Add(this.TabPage7);
			this.tabControl1.Controls.Add(this.TabPage8);
			this.tabControl1.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.tabControl1.Location = new System.Drawing.Point(-2, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1225, 657);
			this.tabControl1.TabIndex = 2;
			//
			//tabPage1
			//
			this.tabPage1.Controls.Add(this.GroupBox15);
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Controls.Add(this.groupBox6);
			this.tabPage1.Controls.Add(this.GroupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 26);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1217, 627);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "By Book Title";
			this.tabPage1.UseVisualStyleBackColor = true;
			//
			//GroupBox15
			//
			this.GroupBox15.Controls.Add(this.txtBookTitle);
			this.GroupBox15.Controls.Add(this.Label10);
			this.GroupBox15.Location = new System.Drawing.Point(345, 7);
			this.GroupBox15.Name = "GroupBox15";
			this.GroupBox15.Size = new System.Drawing.Size(322, 87);
			this.GroupBox15.TabIndex = 22;
			this.GroupBox15.TabStop = false;
			//
			//txtBookTitle
			//
			this.txtBookTitle.Location = new System.Drawing.Point(28, 44);
			this.txtBookTitle.Name = "txtBookTitle";
			this.txtBookTitle.Size = new System.Drawing.Size(263, 24);
			this.txtBookTitle.TabIndex = 9;
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label10.Location = new System.Drawing.Point(25, 20);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(72, 18);
			this.Label10.TabIndex = 8;
			this.Label10.Text = "Book Title";
			//
			//dataGridView1
			//
			this.dataGridView1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(7, 100);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1207, 531);
			this.dataGridView1.TabIndex = 21;
			//
			//groupBox6
			//
			this.groupBox6.Controls.Add(this.ExportExcel);
			this.groupBox6.Controls.Add(this.button6);
			this.groupBox6.Location = new System.Drawing.Point(676, 7);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(218, 87);
			this.groupBox6.TabIndex = 20;
			this.groupBox6.TabStop = false;
			//
			//ExportExcel
			//
			this.ExportExcel.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.ExportExcel.Location = new System.Drawing.Point(113, 26);
			this.ExportExcel.Name = "ExportExcel";
			this.ExportExcel.Size = new System.Drawing.Size(90, 40);
			this.ExportExcel.TabIndex = 4;
			this.ExportExcel.Text = "&Export Excel";
			this.ExportExcel.UseVisualStyleBackColor = true;
			//
			//button6
			//
			this.button6.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.button6.Location = new System.Drawing.Point(17, 26);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(90, 40);
			this.button6.TabIndex = 1;
			this.button6.Text = "&Reset";
			this.button6.UseVisualStyleBackColor = true;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.cmbBookTitle);
			this.GroupBox1.Location = new System.Drawing.Point(6, 6);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(333, 87);
			this.GroupBox1.TabIndex = 18;
			this.GroupBox1.TabStop = false;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(24, 18);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(72, 18);
			this.Label3.TabIndex = 10;
			this.Label3.Text = "Book Title";
			//
			//cmbBookTitle
			//
			this.cmbBookTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbBookTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.cmbBookTitle.FormattingEnabled = true;
			this.cmbBookTitle.Location = new System.Drawing.Point(27, 43);
			this.cmbBookTitle.Name = "cmbBookTitle";
			this.cmbBookTitle.Size = new System.Drawing.Size(269, 23);
			this.cmbBookTitle.TabIndex = 9;
			//
			//tabPage2
			//
			this.tabPage2.Controls.Add(this.GroupBox19);
			this.tabPage2.Controls.Add(this.GroupBox14);
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Controls.Add(this.groupBox8);
			this.tabPage2.Controls.Add(this.groupBox7);
			this.tabPage2.Location = new System.Drawing.Point(4, 26);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1217, 627);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "By Author";
			this.tabPage2.UseVisualStyleBackColor = true;
			//
			//GroupBox19
			//
			this.GroupBox19.Controls.Add(this.txtJointAuthors);
			this.GroupBox19.Controls.Add(this.Label13);
			this.GroupBox19.Location = new System.Drawing.Point(658, 7);
			this.GroupBox19.Name = "GroupBox19";
			this.GroupBox19.Size = new System.Drawing.Size(254, 87);
			this.GroupBox19.TabIndex = 24;
			this.GroupBox19.TabStop = false;
			//
			//txtJointAuthors
			//
			this.txtJointAuthors.Location = new System.Drawing.Point(28, 42);
			this.txtJointAuthors.Name = "txtJointAuthors";
			this.txtJointAuthors.Size = new System.Drawing.Size(206, 24);
			this.txtJointAuthors.TabIndex = 9;
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label13.Location = new System.Drawing.Point(25, 20);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(88, 18);
			this.Label13.TabIndex = 8;
			this.Label13.Text = "Joint Authors";
			//
			//GroupBox14
			//
			this.GroupBox14.Controls.Add(this.txtAuthor);
			this.GroupBox14.Controls.Add(this.Label9);
			this.GroupBox14.Location = new System.Drawing.Point(387, 6);
			this.GroupBox14.Name = "GroupBox14";
			this.GroupBox14.Size = new System.Drawing.Size(254, 87);
			this.GroupBox14.TabIndex = 23;
			this.GroupBox14.TabStop = false;
			//
			//txtAuthor
			//
			this.txtAuthor.Location = new System.Drawing.Point(28, 42);
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.Size = new System.Drawing.Size(206, 24);
			this.txtAuthor.TabIndex = 9;
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label9.Location = new System.Drawing.Point(25, 20);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(50, 18);
			this.Label9.TabIndex = 8;
			this.Label9.Text = "Author";
			//
			//dataGridView2
			//
			this.dataGridView2.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(8, 100);
			this.dataGridView2.MultiSelect = false;
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(1213, 531);
			this.dataGridView2.TabIndex = 22;
			//
			//groupBox8
			//
			this.groupBox8.Controls.Add(this.label6);
			this.groupBox8.Controls.Add(this.cmbAuthor);
			this.groupBox8.Location = new System.Drawing.Point(8, 6);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(357, 87);
			this.groupBox8.TabIndex = 16;
			this.groupBox8.TabStop = false;
			//
			//label6
			//
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.label6.Location = new System.Drawing.Point(25, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 18);
			this.label6.TabIndex = 8;
			this.label6.Text = "Author";
			//
			//cmbAuthor
			//
			this.cmbAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbAuthor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.cmbAuthor.FormattingEnabled = true;
			this.cmbAuthor.Location = new System.Drawing.Point(28, 44);
			this.cmbAuthor.Name = "cmbAuthor";
			this.cmbAuthor.Size = new System.Drawing.Size(295, 23);
			this.cmbAuthor.TabIndex = 7;
			//
			//groupBox7
			//
			this.groupBox7.Controls.Add(this.button7);
			this.groupBox7.Controls.Add(this.button9);
			this.groupBox7.Location = new System.Drawing.Point(929, 7);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(216, 87);
			this.groupBox7.TabIndex = 17;
			this.groupBox7.TabStop = false;
			//
			//button7
			//
			this.button7.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.button7.Location = new System.Drawing.Point(112, 26);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(90, 40);
			this.button7.TabIndex = 4;
			this.button7.Text = "&Export Excel";
			this.button7.UseVisualStyleBackColor = true;
			//
			//button9
			//
			this.button9.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.button9.Location = new System.Drawing.Point(16, 27);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(90, 40);
			this.button9.TabIndex = 1;
			this.button9.Text = "&Reset";
			this.button9.UseVisualStyleBackColor = true;
			//
			//tabPage3
			//
			this.tabPage3.Controls.Add(this.groupBox4);
			this.tabPage3.Controls.Add(this.dataGridView3);
			this.tabPage3.Controls.Add(this.groupBox3);
			this.tabPage3.Controls.Add(this.groupBox2);
			this.tabPage3.Location = new System.Drawing.Point(4, 26);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1217, 627);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "By Accession No.";
			this.tabPage3.UseVisualStyleBackColor = true;
			//
			//groupBox4
			//
			this.groupBox4.Controls.Add(this.button1);
			this.groupBox4.Controls.Add(this.button2);
			this.groupBox4.Location = new System.Drawing.Point(577, 15);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(227, 87);
			this.groupBox4.TabIndex = 24;
			this.groupBox4.TabStop = false;
			//
			//button1
			//
			this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.button1.Location = new System.Drawing.Point(112, 27);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 40);
			this.button1.TabIndex = 4;
			this.button1.Text = "&Export Excel";
			this.button1.UseVisualStyleBackColor = true;
			//
			//button2
			//
			this.button2.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.button2.Location = new System.Drawing.Point(16, 27);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 40);
			this.button2.TabIndex = 1;
			this.button2.Text = "&Reset";
			this.button2.UseVisualStyleBackColor = true;
			//
			//dataGridView3
			//
			this.dataGridView3.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Location = new System.Drawing.Point(8, 108);
			this.dataGridView3.MultiSelect = false;
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.ReadOnly = true;
			this.dataGridView3.Size = new System.Drawing.Size(1206, 531);
			this.dataGridView3.TabIndex = 23;
			//
			//groupBox3
			//
			this.groupBox3.Controls.Add(this.txtAccessionNo);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Location = new System.Drawing.Point(291, 15);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(272, 87);
			this.groupBox3.TabIndex = 18;
			this.groupBox3.TabStop = false;
			//
			//txtAccessionNo
			//
			this.txtAccessionNo.Location = new System.Drawing.Point(28, 44);
			this.txtAccessionNo.Name = "txtAccessionNo";
			this.txtAccessionNo.Size = new System.Drawing.Size(221, 24);
			this.txtAccessionNo.TabIndex = 9;
			//
			//label8
			//
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.label8.Location = new System.Drawing.Point(25, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(95, 18);
			this.label8.TabIndex = 8;
			this.label8.Text = "Accession No.";
			//
			//groupBox2
			//
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.cmbAccessionNo);
			this.groupBox2.Location = new System.Drawing.Point(8, 15);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(266, 87);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			//
			//label7
			//
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.label7.Location = new System.Drawing.Point(25, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 18);
			this.label7.TabIndex = 8;
			this.label7.Text = "Accession No.";
			//
			//cmbAccessionNo
			//
			this.cmbAccessionNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbAccessionNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbAccessionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.cmbAccessionNo.FormattingEnabled = true;
			this.cmbAccessionNo.Location = new System.Drawing.Point(28, 44);
			this.cmbAccessionNo.Name = "cmbAccessionNo";
			this.cmbAccessionNo.Size = new System.Drawing.Size(216, 23);
			this.cmbAccessionNo.TabIndex = 7;
			//
			//tabPage4
			//
			this.tabPage4.Controls.Add(this.GroupBox5);
			this.tabPage4.Controls.Add(this.GroupBox9);
			this.tabPage4.Controls.Add(this.groupBox10);
			this.tabPage4.Controls.Add(this.dataGridView4);
			this.tabPage4.Location = new System.Drawing.Point(4, 26);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(1217, 627);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "By Subject";
			this.tabPage4.UseVisualStyleBackColor = true;
			//
			//GroupBox5
			//
			this.GroupBox5.Controls.Add(this.txtSubject);
			this.GroupBox5.Controls.Add(this.Label1);
			this.GroupBox5.Location = new System.Drawing.Point(349, 6);
			this.GroupBox5.Name = "GroupBox5";
			this.GroupBox5.Size = new System.Drawing.Size(305, 87);
			this.GroupBox5.TabIndex = 26;
			this.GroupBox5.TabStop = false;
			//
			//txtSubject
			//
			this.txtSubject.Location = new System.Drawing.Point(27, 45);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(246, 24);
			this.txtSubject.TabIndex = 9;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(25, 20);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(93, 18);
			this.Label1.TabIndex = 8;
			this.Label1.Text = "Subject Name";
			//
			//GroupBox9
			//
			this.GroupBox9.Controls.Add(this.Label2);
			this.GroupBox9.Controls.Add(this.cmbSubject);
			this.GroupBox9.Location = new System.Drawing.Point(8, 6);
			this.GroupBox9.Name = "GroupBox9";
			this.GroupBox9.Size = new System.Drawing.Size(322, 87);
			this.GroupBox9.TabIndex = 25;
			this.GroupBox9.TabStop = false;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(25, 20);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(93, 18);
			this.Label2.TabIndex = 8;
			this.Label2.Text = "Subject Name";
			//
			//cmbSubject
			//
			this.cmbSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.cmbSubject.FormattingEnabled = true;
			this.cmbSubject.Location = new System.Drawing.Point(28, 46);
			this.cmbSubject.Name = "cmbSubject";
			this.cmbSubject.Size = new System.Drawing.Size(259, 23);
			this.cmbSubject.TabIndex = 7;
			//
			//groupBox10
			//
			this.groupBox10.Controls.Add(this.button3);
			this.groupBox10.Controls.Add(this.button8);
			this.groupBox10.Location = new System.Drawing.Point(660, 6);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(219, 87);
			this.groupBox10.TabIndex = 24;
			this.groupBox10.TabStop = false;
			//
			//button3
			//
			this.button3.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.button3.Location = new System.Drawing.Point(114, 23);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(90, 40);
			this.button3.TabIndex = 4;
			this.button3.Text = "&Export Excel";
			this.button3.UseVisualStyleBackColor = true;
			//
			//button8
			//
			this.button8.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.button8.Location = new System.Drawing.Point(18, 23);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(90, 40);
			this.button8.TabIndex = 1;
			this.button8.Text = "&Reset";
			this.button8.UseVisualStyleBackColor = true;
			//
			//dataGridView4
			//
			this.dataGridView4.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView4.Location = new System.Drawing.Point(8, 98);
			this.dataGridView4.MultiSelect = false;
			this.dataGridView4.Name = "dataGridView4";
			this.dataGridView4.ReadOnly = true;
			this.dataGridView4.Size = new System.Drawing.Size(1206, 531);
			this.dataGridView4.TabIndex = 22;
			//
			//TabPage5
			//
			this.TabPage5.Controls.Add(this.GroupBox12);
			this.TabPage5.Controls.Add(this.GroupBox13);
			this.TabPage5.Controls.Add(this.GroupBox11);
			this.TabPage5.Controls.Add(this.DataGridView5);
			this.TabPage5.Location = new System.Drawing.Point(4, 26);
			this.TabPage5.Name = "TabPage5";
			this.TabPage5.Size = new System.Drawing.Size(1217, 627);
			this.TabPage5.TabIndex = 4;
			this.TabPage5.Text = "By Place Of Publisher";
			this.TabPage5.UseVisualStyleBackColor = true;
			//
			//GroupBox12
			//
			this.GroupBox12.Controls.Add(this.txtPOP);
			this.GroupBox12.Controls.Add(this.Label4);
			this.GroupBox12.Location = new System.Drawing.Point(339, 3);
			this.GroupBox12.Name = "GroupBox12";
			this.GroupBox12.Size = new System.Drawing.Size(322, 87);
			this.GroupBox12.TabIndex = 28;
			this.GroupBox12.TabStop = false;
			//
			//txtPOP
			//
			this.txtPOP.Location = new System.Drawing.Point(28, 44);
			this.txtPOP.Name = "txtPOP";
			this.txtPOP.Size = new System.Drawing.Size(263, 24);
			this.txtPOP.TabIndex = 9;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(25, 20);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(120, 18);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "Place Of Publisher";
			//
			//GroupBox13
			//
			this.GroupBox13.Controls.Add(this.Label5);
			this.GroupBox13.Controls.Add(this.cmbPOP);
			this.GroupBox13.Location = new System.Drawing.Point(6, 3);
			this.GroupBox13.Name = "GroupBox13";
			this.GroupBox13.Size = new System.Drawing.Size(322, 87);
			this.GroupBox13.TabIndex = 27;
			this.GroupBox13.TabStop = false;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(25, 20);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(120, 18);
			this.Label5.TabIndex = 8;
			this.Label5.Text = "Place Of Publisher";
			//
			//cmbPOP
			//
			this.cmbPOP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbPOP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbPOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.cmbPOP.FormattingEnabled = true;
			this.cmbPOP.Location = new System.Drawing.Point(28, 44);
			this.cmbPOP.Name = "cmbPOP";
			this.cmbPOP.Size = new System.Drawing.Size(267, 23);
			this.cmbPOP.TabIndex = 7;
			//
			//GroupBox11
			//
			this.GroupBox11.Controls.Add(this.Button10);
			this.GroupBox11.Controls.Add(this.Button12);
			this.GroupBox11.Location = new System.Drawing.Point(669, 3);
			this.GroupBox11.Name = "GroupBox11";
			this.GroupBox11.Size = new System.Drawing.Size(222, 87);
			this.GroupBox11.TabIndex = 23;
			this.GroupBox11.TabStop = false;
			//
			//Button10
			//
			this.Button10.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button10.Location = new System.Drawing.Point(114, 28);
			this.Button10.Name = "Button10";
			this.Button10.Size = new System.Drawing.Size(90, 40);
			this.Button10.TabIndex = 4;
			this.Button10.Text = "&Export Excel";
			this.Button10.UseVisualStyleBackColor = true;
			//
			//Button12
			//
			this.Button12.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button12.Location = new System.Drawing.Point(18, 28);
			this.Button12.Name = "Button12";
			this.Button12.Size = new System.Drawing.Size(90, 40);
			this.Button12.TabIndex = 1;
			this.Button12.Text = "&Reset";
			this.Button12.UseVisualStyleBackColor = true;
			//
			//DataGridView5
			//
			this.DataGridView5.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView5.Location = new System.Drawing.Point(6, 95);
			this.DataGridView5.MultiSelect = false;
			this.DataGridView5.Name = "DataGridView5";
			this.DataGridView5.ReadOnly = true;
			this.DataGridView5.Size = new System.Drawing.Size(1208, 531);
			this.DataGridView5.TabIndex = 24;
			//
			//TabPage6
			//
			this.TabPage6.Controls.Add(this.GroupBox16);
			this.TabPage6.Controls.Add(this.GroupBox17);
			this.TabPage6.Controls.Add(this.GroupBox18);
			this.TabPage6.Controls.Add(this.DataGridView6);
			this.TabPage6.Location = new System.Drawing.Point(4, 26);
			this.TabPage6.Name = "TabPage6";
			this.TabPage6.Size = new System.Drawing.Size(1217, 627);
			this.TabPage6.TabIndex = 5;
			this.TabPage6.Text = "By Department";
			this.TabPage6.UseVisualStyleBackColor = true;
			//
			//GroupBox16
			//
			this.GroupBox16.Controls.Add(this.txtDepartment);
			this.GroupBox16.Controls.Add(this.Label11);
			this.GroupBox16.Location = new System.Drawing.Point(340, 2);
			this.GroupBox16.Name = "GroupBox16";
			this.GroupBox16.Size = new System.Drawing.Size(322, 87);
			this.GroupBox16.TabIndex = 32;
			this.GroupBox16.TabStop = false;
			//
			//txtDepartment
			//
			this.txtDepartment.Location = new System.Drawing.Point(28, 44);
			this.txtDepartment.Name = "txtDepartment";
			this.txtDepartment.Size = new System.Drawing.Size(263, 24);
			this.txtDepartment.TabIndex = 9;
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label11.Location = new System.Drawing.Point(25, 20);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(81, 18);
			this.Label11.TabIndex = 8;
			this.Label11.Text = "Department";
			//
			//GroupBox17
			//
			this.GroupBox17.Controls.Add(this.Label12);
			this.GroupBox17.Controls.Add(this.cmbDepartment);
			this.GroupBox17.Location = new System.Drawing.Point(7, 2);
			this.GroupBox17.Name = "GroupBox17";
			this.GroupBox17.Size = new System.Drawing.Size(322, 87);
			this.GroupBox17.TabIndex = 31;
			this.GroupBox17.TabStop = false;
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label12.Location = new System.Drawing.Point(25, 20);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(81, 18);
			this.Label12.TabIndex = 8;
			this.Label12.Text = "Department";
			//
			//cmbDepartment
			//
			this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.cmbDepartment.FormattingEnabled = true;
			this.cmbDepartment.Location = new System.Drawing.Point(28, 44);
			this.cmbDepartment.Name = "cmbDepartment";
			this.cmbDepartment.Size = new System.Drawing.Size(267, 23);
			this.cmbDepartment.TabIndex = 7;
			//
			//GroupBox18
			//
			this.GroupBox18.Controls.Add(this.Button4);
			this.GroupBox18.Controls.Add(this.Button11);
			this.GroupBox18.Location = new System.Drawing.Point(674, 3);
			this.GroupBox18.Name = "GroupBox18";
			this.GroupBox18.Size = new System.Drawing.Size(217, 86);
			this.GroupBox18.TabIndex = 29;
			this.GroupBox18.TabStop = false;
			//
			//Button4
			//
			this.Button4.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button4.Location = new System.Drawing.Point(111, 23);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(90, 40);
			this.Button4.TabIndex = 4;
			this.Button4.Text = "&Export Excel";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//Button11
			//
			this.Button11.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button11.Location = new System.Drawing.Point(15, 23);
			this.Button11.Name = "Button11";
			this.Button11.Size = new System.Drawing.Size(90, 40);
			this.Button11.TabIndex = 1;
			this.Button11.Text = "&Reset";
			this.Button11.UseVisualStyleBackColor = true;
			//
			//DataGridView6
			//
			this.DataGridView6.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView6.Location = new System.Drawing.Point(7, 94);
			this.DataGridView6.MultiSelect = false;
			this.DataGridView6.Name = "DataGridView6";
			this.DataGridView6.Size = new System.Drawing.Size(1207, 531);
			this.DataGridView6.TabIndex = 30;
			//
			//TabPage7
			//
			this.TabPage7.Controls.Add(this.GroupBox22);
			this.TabPage7.Controls.Add(this.DataGridView7);
			this.TabPage7.Controls.Add(this.GroupBox20);
			this.TabPage7.Controls.Add(this.GroupBox21);
			this.TabPage7.Location = new System.Drawing.Point(4, 26);
			this.TabPage7.Name = "TabPage7";
			this.TabPage7.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage7.Size = new System.Drawing.Size(1217, 627);
			this.TabPage7.TabIndex = 6;
			this.TabPage7.Text = "By Reference Books";
			this.TabPage7.UseVisualStyleBackColor = true;
			//
			//GroupBox22
			//
			this.GroupBox22.Controls.Add(this.Button5);
			this.GroupBox22.Controls.Add(this.Button13);
			this.GroupBox22.Location = new System.Drawing.Point(680, 7);
			this.GroupBox22.Name = "GroupBox22";
			this.GroupBox22.Size = new System.Drawing.Size(218, 87);
			this.GroupBox22.TabIndex = 26;
			this.GroupBox22.TabStop = false;
			//
			//Button5
			//
			this.Button5.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button5.Location = new System.Drawing.Point(113, 26);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(90, 40);
			this.Button5.TabIndex = 4;
			this.Button5.Text = "&Export Excel";
			this.Button5.UseVisualStyleBackColor = true;
			//
			//Button13
			//
			this.Button13.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button13.Location = new System.Drawing.Point(17, 26);
			this.Button13.Name = "Button13";
			this.Button13.Size = new System.Drawing.Size(90, 40);
			this.Button13.TabIndex = 1;
			this.Button13.Text = "&Reset";
			this.Button13.UseVisualStyleBackColor = true;
			//
			//DataGridView7
			//
			this.DataGridView7.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView7.Location = new System.Drawing.Point(10, 100);
			this.DataGridView7.MultiSelect = false;
			this.DataGridView7.Name = "DataGridView7";
			this.DataGridView7.Size = new System.Drawing.Size(1207, 531);
			this.DataGridView7.TabIndex = 25;
			//
			//GroupBox20
			//
			this.GroupBox20.Controls.Add(this.txtRFBooks);
			this.GroupBox20.Controls.Add(this.Label14);
			this.GroupBox20.Location = new System.Drawing.Point(349, 7);
			this.GroupBox20.Name = "GroupBox20";
			this.GroupBox20.Size = new System.Drawing.Size(322, 87);
			this.GroupBox20.TabIndex = 24;
			this.GroupBox20.TabStop = false;
			//
			//txtRFBooks
			//
			this.txtRFBooks.Location = new System.Drawing.Point(28, 44);
			this.txtRFBooks.Name = "txtRFBooks";
			this.txtRFBooks.Size = new System.Drawing.Size(263, 24);
			this.txtRFBooks.TabIndex = 9;
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label14.Location = new System.Drawing.Point(25, 20);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(105, 18);
			this.Label14.TabIndex = 8;
			this.Label14.Text = "Reference Book";
			//
			//GroupBox21
			//
			this.GroupBox21.Controls.Add(this.Label15);
			this.GroupBox21.Controls.Add(this.cmbRfBook);
			this.GroupBox21.Location = new System.Drawing.Point(10, 6);
			this.GroupBox21.Name = "GroupBox21";
			this.GroupBox21.Size = new System.Drawing.Size(333, 87);
			this.GroupBox21.TabIndex = 23;
			this.GroupBox21.TabStop = false;
			//
			//Label15
			//
			this.Label15.AutoSize = true;
			this.Label15.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label15.Location = new System.Drawing.Point(24, 18);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(105, 18);
			this.Label15.TabIndex = 10;
			this.Label15.Text = "Reference Book";
			//
			//cmbRfBook
			//
			this.cmbRfBook.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbRfBook.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbRfBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.cmbRfBook.FormattingEnabled = true;
			this.cmbRfBook.Location = new System.Drawing.Point(27, 43);
			this.cmbRfBook.Name = "cmbRfBook";
			this.cmbRfBook.Size = new System.Drawing.Size(269, 23);
			this.cmbRfBook.TabIndex = 9;
			//
			//TabPage8
			//
			this.TabPage8.Controls.Add(this.DataGridView8);
			this.TabPage8.Controls.Add(this.GroupBox23);
			this.TabPage8.Location = new System.Drawing.Point(4, 26);
			this.TabPage8.Name = "TabPage8";
			this.TabPage8.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage8.Size = new System.Drawing.Size(1217, 627);
			this.TabPage8.TabIndex = 7;
			this.TabPage8.Text = "All Books";
			this.TabPage8.UseVisualStyleBackColor = true;
			//
			//DataGridView8
			//
			this.DataGridView8.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.DataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView8.Location = new System.Drawing.Point(10, 100);
			this.DataGridView8.MultiSelect = false;
			this.DataGridView8.Name = "DataGridView8";
			this.DataGridView8.Size = new System.Drawing.Size(1207, 531);
			this.DataGridView8.TabIndex = 28;
			//
			//GroupBox23
			//
			this.GroupBox23.Controls.Add(this.Button16);
			this.GroupBox23.Controls.Add(this.Button14);
			this.GroupBox23.Controls.Add(this.Button15);
			this.GroupBox23.Location = new System.Drawing.Point(10, 6);
			this.GroupBox23.Name = "GroupBox23";
			this.GroupBox23.Size = new System.Drawing.Size(308, 87);
			this.GroupBox23.TabIndex = 27;
			this.GroupBox23.TabStop = false;
			//
			//Button16
			//
			this.Button16.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button16.Location = new System.Drawing.Point(11, 26);
			this.Button16.Name = "Button16";
			this.Button16.Size = new System.Drawing.Size(90, 40);
			this.Button16.TabIndex = 5;
			this.Button16.Text = "&Get Data";
			this.Button16.UseVisualStyleBackColor = true;
			//
			//Button14
			//
			this.Button14.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button14.Location = new System.Drawing.Point(203, 26);
			this.Button14.Name = "Button14";
			this.Button14.Size = new System.Drawing.Size(90, 40);
			this.Button14.TabIndex = 4;
			this.Button14.Text = "&Export Excel";
			this.Button14.UseVisualStyleBackColor = true;
			//
			//Button15
			//
			this.Button15.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button15.Location = new System.Drawing.Point(107, 26);
			this.Button15.Name = "Button15";
			this.Button15.Size = new System.Drawing.Size(90, 40);
			this.Button15.TabIndex = 1;
			this.Button15.Text = "&Reset";
			this.Button15.UseVisualStyleBackColor = true;
			//
			//frmBookRecord
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1222, 656);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "frmBookRecord";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search Books";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.GroupBox15.ResumeLayout(false);
			this.GroupBox15.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			this.groupBox6.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.GroupBox19.ResumeLayout(false);
			this.GroupBox19.PerformLayout();
			this.GroupBox14.ResumeLayout(false);
			this.GroupBox14.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dataGridView2).EndInit();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dataGridView3).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.GroupBox9.ResumeLayout(false);
			this.GroupBox9.PerformLayout();
			this.groupBox10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dataGridView4).EndInit();
			this.TabPage5.ResumeLayout(false);
			this.GroupBox12.ResumeLayout(false);
			this.GroupBox12.PerformLayout();
			this.GroupBox13.ResumeLayout(false);
			this.GroupBox13.PerformLayout();
			this.GroupBox11.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView5).EndInit();
			this.TabPage6.ResumeLayout(false);
			this.GroupBox16.ResumeLayout(false);
			this.GroupBox16.PerformLayout();
			this.GroupBox17.ResumeLayout(false);
			this.GroupBox17.PerformLayout();
			this.GroupBox18.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView6).EndInit();
			this.TabPage7.ResumeLayout(false);
			this.GroupBox22.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView7).EndInit();
			this.GroupBox20.ResumeLayout(false);
			this.GroupBox20.PerformLayout();
			this.GroupBox21.ResumeLayout(false);
			this.GroupBox21.PerformLayout();
			this.TabPage8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView8).EndInit();
			this.GroupBox23.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.TabControl withEventsField_tabControl1;
		private System.Windows.Forms.TabControl tabControl1 {
			get { return withEventsField_tabControl1; }
			set {
				if (withEventsField_tabControl1 != null) {
					withEventsField_tabControl1.Click -= tabControl1_Click;
				}
				withEventsField_tabControl1 = value;
				if (withEventsField_tabControl1 != null) {
					withEventsField_tabControl1.Click += tabControl1_Click;
				}
			}
		}
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DataGridView withEventsField_dataGridView1;
		public System.Windows.Forms.DataGridView dataGridView1 {
			get { return withEventsField_dataGridView1; }
			set {
				if (withEventsField_dataGridView1 != null) {
					withEventsField_dataGridView1.RowHeaderMouseClick -= dataGridView1_RowHeaderMouseClick;
					withEventsField_dataGridView1.RowPostPaint -= dataGridView1_RowPostPaint;
				}
				withEventsField_dataGridView1 = value;
				if (withEventsField_dataGridView1 != null) {
					withEventsField_dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
					withEventsField_dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
				}
			}
		}
		internal System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button withEventsField_ExportExcel;
		internal System.Windows.Forms.Button ExportExcel {
			get { return withEventsField_ExportExcel; }
			set {
				if (withEventsField_ExportExcel != null) {
					withEventsField_ExportExcel.Click -= ExportExcel_Click;
				}
				withEventsField_ExportExcel = value;
				if (withEventsField_ExportExcel != null) {
					withEventsField_ExportExcel.Click += ExportExcel_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_button6;
		internal System.Windows.Forms.Button button6 {
			get { return withEventsField_button6; }
			set {
				if (withEventsField_button6 != null) {
					withEventsField_button6.Click -= button6_Click;
				}
				withEventsField_button6 = value;
				if (withEventsField_button6 != null) {
					withEventsField_button6.Click += button6_Click;
				}
			}
		}
		internal System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.ComboBox withEventsField_cmbBookTitle;
		public System.Windows.Forms.ComboBox cmbBookTitle {
			get { return withEventsField_cmbBookTitle; }
			set {
				if (withEventsField_cmbBookTitle != null) {
					withEventsField_cmbBookTitle.SelectedIndexChanged -= cmbBookTitle_SelectedIndexChanged;
				}
				withEventsField_cmbBookTitle = value;
				if (withEventsField_cmbBookTitle != null) {
					withEventsField_cmbBookTitle.SelectedIndexChanged += cmbBookTitle_SelectedIndexChanged;
				}
			}
		}
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView withEventsField_dataGridView2;
		public System.Windows.Forms.DataGridView dataGridView2 {
			get { return withEventsField_dataGridView2; }
			set {
				if (withEventsField_dataGridView2 != null) {
					withEventsField_dataGridView2.RowHeaderMouseClick -= dataGridView2_RowHeaderMouseClick;
					withEventsField_dataGridView2.RowPostPaint -= dataGridView2_RowPostPaint;
				}
				withEventsField_dataGridView2 = value;
				if (withEventsField_dataGridView2 != null) {
					withEventsField_dataGridView2.RowHeaderMouseClick += dataGridView2_RowHeaderMouseClick;
					withEventsField_dataGridView2.RowPostPaint += dataGridView2_RowPostPaint;
				}
			}
		}
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox withEventsField_cmbAuthor;
		public System.Windows.Forms.ComboBox cmbAuthor {
			get { return withEventsField_cmbAuthor; }
			set {
				if (withEventsField_cmbAuthor != null) {
					withEventsField_cmbAuthor.SelectedIndexChanged -= cmbAuthor_SelectedIndexChanged;
				}
				withEventsField_cmbAuthor = value;
				if (withEventsField_cmbAuthor != null) {
					withEventsField_cmbAuthor.SelectedIndexChanged += cmbAuthor_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Button withEventsField_button7;
		internal System.Windows.Forms.Button button7 {
			get { return withEventsField_button7; }
			set {
				if (withEventsField_button7 != null) {
					withEventsField_button7.Click -= button7_Click;
				}
				withEventsField_button7 = value;
				if (withEventsField_button7 != null) {
					withEventsField_button7.Click += button7_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_button9;
		internal System.Windows.Forms.Button button9 {
			get { return withEventsField_button9; }
			set {
				if (withEventsField_button9 != null) {
					withEventsField_button9.Click -= button9_Click;
				}
				withEventsField_button9 = value;
				if (withEventsField_button9 != null) {
					withEventsField_button9.Click += button9_Click;
				}
			}
		}
		private System.Windows.Forms.TabPage tabPage3;
		internal System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button withEventsField_button1;
		internal System.Windows.Forms.Button button1 {
			get { return withEventsField_button1; }
			set {
				if (withEventsField_button1 != null) {
					withEventsField_button1.Click -= button1_Click;
				}
				withEventsField_button1 = value;
				if (withEventsField_button1 != null) {
					withEventsField_button1.Click += button1_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_button2;
		internal System.Windows.Forms.Button button2 {
			get { return withEventsField_button2; }
			set {
				if (withEventsField_button2 != null) {
					withEventsField_button2.Click -= button2_Click;
				}
				withEventsField_button2 = value;
				if (withEventsField_button2 != null) {
					withEventsField_button2.Click += button2_Click;
				}
			}
		}
		private System.Windows.Forms.DataGridView withEventsField_dataGridView3;
		public System.Windows.Forms.DataGridView dataGridView3 {
			get { return withEventsField_dataGridView3; }
			set {
				if (withEventsField_dataGridView3 != null) {
					withEventsField_dataGridView3.RowHeaderMouseClick -= dataGridView3_RowHeaderMouseClick;
					withEventsField_dataGridView3.RowPostPaint -= dataGridView3_RowPostPaint;
				}
				withEventsField_dataGridView3 = value;
				if (withEventsField_dataGridView3 != null) {
					withEventsField_dataGridView3.RowHeaderMouseClick += dataGridView3_RowHeaderMouseClick;
					withEventsField_dataGridView3.RowPostPaint += dataGridView3_RowPostPaint;
				}
			}
		}
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox withEventsField_txtAccessionNo;
		private System.Windows.Forms.TextBox txtAccessionNo {
			get { return withEventsField_txtAccessionNo; }
			set {
				if (withEventsField_txtAccessionNo != null) {
					withEventsField_txtAccessionNo.TextChanged -= txtAccessionNo_TextChanged;
				}
				withEventsField_txtAccessionNo = value;
				if (withEventsField_txtAccessionNo != null) {
					withEventsField_txtAccessionNo.TextChanged += txtAccessionNo_TextChanged;
				}
			}
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox withEventsField_cmbAccessionNo;
		public System.Windows.Forms.ComboBox cmbAccessionNo {
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
		private System.Windows.Forms.TabPage tabPage4;
		internal System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.Button withEventsField_button3;
		internal System.Windows.Forms.Button button3 {
			get { return withEventsField_button3; }
			set {
				if (withEventsField_button3 != null) {
					withEventsField_button3.Click -= button3_Click;
				}
				withEventsField_button3 = value;
				if (withEventsField_button3 != null) {
					withEventsField_button3.Click += button3_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_button8;
		internal System.Windows.Forms.Button button8 {
			get { return withEventsField_button8; }
			set {
				if (withEventsField_button8 != null) {
					withEventsField_button8.Click -= button8_Click;
				}
				withEventsField_button8 = value;
				if (withEventsField_button8 != null) {
					withEventsField_button8.Click += button8_Click;
				}
			}
		}
		private System.Windows.Forms.DataGridView withEventsField_dataGridView4;
		public System.Windows.Forms.DataGridView dataGridView4 {
			get { return withEventsField_dataGridView4; }
			set {
				if (withEventsField_dataGridView4 != null) {
					withEventsField_dataGridView4.RowHeaderMouseClick -= dataGridView4_RowHeaderMouseClick;
					withEventsField_dataGridView4.RowPostPaint -= dataGridView4_RowPostPaint;
				}
				withEventsField_dataGridView4 = value;
				if (withEventsField_dataGridView4 != null) {
					withEventsField_dataGridView4.RowHeaderMouseClick += dataGridView4_RowHeaderMouseClick;
					withEventsField_dataGridView4.RowPostPaint += dataGridView4_RowPostPaint;
				}
			}
		}
		internal System.Windows.Forms.TabPage TabPage5;
		internal System.Windows.Forms.GroupBox GroupBox11;
		private System.Windows.Forms.Button withEventsField_Button10;
		internal System.Windows.Forms.Button Button10 {
			get { return withEventsField_Button10; }
			set {
				if (withEventsField_Button10 != null) {
					withEventsField_Button10.Click -= Button10_Click;
				}
				withEventsField_Button10 = value;
				if (withEventsField_Button10 != null) {
					withEventsField_Button10.Click += Button10_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_Button12;
		internal System.Windows.Forms.Button Button12 {
			get { return withEventsField_Button12; }
			set {
				if (withEventsField_Button12 != null) {
					withEventsField_Button12.Click -= Button12_Click;
				}
				withEventsField_Button12 = value;
				if (withEventsField_Button12 != null) {
					withEventsField_Button12.Click += Button12_Click;
				}
			}
		}
		private System.Windows.Forms.DataGridView withEventsField_DataGridView5;
		public System.Windows.Forms.DataGridView DataGridView5 {
			get { return withEventsField_DataGridView5; }
			set {
				if (withEventsField_DataGridView5 != null) {
					withEventsField_DataGridView5.RowHeaderMouseClick -= DataGridView5_RowHeaderMouseClick;
					withEventsField_DataGridView5.RowPostPaint -= DataGridView5_RowPostPaint;
				}
				withEventsField_DataGridView5 = value;
				if (withEventsField_DataGridView5 != null) {
					withEventsField_DataGridView5.RowHeaderMouseClick += DataGridView5_RowHeaderMouseClick;
					withEventsField_DataGridView5.RowPostPaint += DataGridView5_RowPostPaint;
				}
			}
		}
		private System.Windows.Forms.GroupBox GroupBox15;
		private System.Windows.Forms.TextBox withEventsField_txtBookTitle;
		private System.Windows.Forms.TextBox txtBookTitle {
			get { return withEventsField_txtBookTitle; }
			set {
				if (withEventsField_txtBookTitle != null) {
					withEventsField_txtBookTitle.TextChanged -= txtBookTitle_TextChanged;
				}
				withEventsField_txtBookTitle = value;
				if (withEventsField_txtBookTitle != null) {
					withEventsField_txtBookTitle.TextChanged += txtBookTitle_TextChanged;
				}
			}
		}
		private System.Windows.Forms.Label Label10;
		private System.Windows.Forms.GroupBox GroupBox14;
		private System.Windows.Forms.TextBox withEventsField_txtAuthor;
		private System.Windows.Forms.TextBox txtAuthor {
			get { return withEventsField_txtAuthor; }
			set {
				if (withEventsField_txtAuthor != null) {
					withEventsField_txtAuthor.TextChanged -= txtAuthor_TextChanged;
				}
				withEventsField_txtAuthor = value;
				if (withEventsField_txtAuthor != null) {
					withEventsField_txtAuthor.TextChanged += txtAuthor_TextChanged;
				}
			}
		}
		private System.Windows.Forms.Label Label9;
		private System.Windows.Forms.GroupBox GroupBox5;
		private System.Windows.Forms.TextBox withEventsField_txtSubject;
		private System.Windows.Forms.TextBox txtSubject {
			get { return withEventsField_txtSubject; }
			set {
				if (withEventsField_txtSubject != null) {
					withEventsField_txtSubject.TextChanged -= txtSubject_TextChanged;
				}
				withEventsField_txtSubject = value;
				if (withEventsField_txtSubject != null) {
					withEventsField_txtSubject.TextChanged += txtSubject_TextChanged;
				}
			}
		}
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.GroupBox GroupBox9;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.ComboBox withEventsField_cmbSubject;
		public System.Windows.Forms.ComboBox cmbSubject {
			get { return withEventsField_cmbSubject; }
			set {
				if (withEventsField_cmbSubject != null) {
					withEventsField_cmbSubject.SelectedIndexChanged -= cmbSubject_SelectedIndexChanged;
				}
				withEventsField_cmbSubject = value;
				if (withEventsField_cmbSubject != null) {
					withEventsField_cmbSubject.SelectedIndexChanged += cmbSubject_SelectedIndexChanged;
				}
			}
		}
		private System.Windows.Forms.GroupBox GroupBox12;
		private System.Windows.Forms.TextBox withEventsField_txtPOP;
		private System.Windows.Forms.TextBox txtPOP {
			get { return withEventsField_txtPOP; }
			set {
				if (withEventsField_txtPOP != null) {
					withEventsField_txtPOP.TextChanged -= txtPOP_TextChanged;
				}
				withEventsField_txtPOP = value;
				if (withEventsField_txtPOP != null) {
					withEventsField_txtPOP.TextChanged += txtPOP_TextChanged;
				}
			}
		}
		private System.Windows.Forms.Label Label4;
		private System.Windows.Forms.GroupBox GroupBox13;
		private System.Windows.Forms.Label Label5;
		private System.Windows.Forms.ComboBox withEventsField_cmbPOP;
		public System.Windows.Forms.ComboBox cmbPOP {
			get { return withEventsField_cmbPOP; }
			set {
				if (withEventsField_cmbPOP != null) {
					withEventsField_cmbPOP.SelectedIndexChanged -= cmbPOP_SelectedIndexChanged;
				}
				withEventsField_cmbPOP = value;
				if (withEventsField_cmbPOP != null) {
					withEventsField_cmbPOP.SelectedIndexChanged += cmbPOP_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.TabPage TabPage6;
		private System.Windows.Forms.GroupBox GroupBox16;
		private System.Windows.Forms.TextBox withEventsField_txtDepartment;
		private System.Windows.Forms.TextBox txtDepartment {
			get { return withEventsField_txtDepartment; }
			set {
				if (withEventsField_txtDepartment != null) {
					withEventsField_txtDepartment.TextChanged -= txtDepartment_TextChanged;
				}
				withEventsField_txtDepartment = value;
				if (withEventsField_txtDepartment != null) {
					withEventsField_txtDepartment.TextChanged += txtDepartment_TextChanged;
				}
			}
		}
		private System.Windows.Forms.Label Label11;
		private System.Windows.Forms.GroupBox GroupBox17;
		private System.Windows.Forms.Label Label12;
		private System.Windows.Forms.ComboBox withEventsField_cmbDepartment;
		public System.Windows.Forms.ComboBox cmbDepartment {
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
		internal System.Windows.Forms.GroupBox GroupBox18;
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
		private System.Windows.Forms.Button withEventsField_Button11;
		internal System.Windows.Forms.Button Button11 {
			get { return withEventsField_Button11; }
			set {
				if (withEventsField_Button11 != null) {
					withEventsField_Button11.Click -= Button11_Click;
				}
				withEventsField_Button11 = value;
				if (withEventsField_Button11 != null) {
					withEventsField_Button11.Click += Button11_Click;
				}
			}
		}
		private System.Windows.Forms.DataGridView withEventsField_DataGridView6;
		public System.Windows.Forms.DataGridView DataGridView6 {
			get { return withEventsField_DataGridView6; }
			set {
				if (withEventsField_DataGridView6 != null) {
					withEventsField_DataGridView6.RowHeaderMouseClick -= DataGridView6_RowHeaderMouseClick;
					withEventsField_DataGridView6.RowPostPaint -= DataGridView6_RowPostPaint;
				}
				withEventsField_DataGridView6 = value;
				if (withEventsField_DataGridView6 != null) {
					withEventsField_DataGridView6.RowHeaderMouseClick += DataGridView6_RowHeaderMouseClick;
					withEventsField_DataGridView6.RowPostPaint += DataGridView6_RowPostPaint;
				}
			}
		}
		private System.Windows.Forms.GroupBox GroupBox19;
		private System.Windows.Forms.TextBox withEventsField_txtJointAuthors;
		private System.Windows.Forms.TextBox txtJointAuthors {
			get { return withEventsField_txtJointAuthors; }
			set {
				if (withEventsField_txtJointAuthors != null) {
					withEventsField_txtJointAuthors.TextChanged -= txtJointAuthors_TextChanged;
				}
				withEventsField_txtJointAuthors = value;
				if (withEventsField_txtJointAuthors != null) {
					withEventsField_txtJointAuthors.TextChanged += txtJointAuthors_TextChanged;
				}
			}
		}
		private System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.TabPage TabPage7;
		internal System.Windows.Forms.TabPage TabPage8;
		internal System.Windows.Forms.GroupBox GroupBox22;
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
		private System.Windows.Forms.Button withEventsField_Button13;
		internal System.Windows.Forms.Button Button13 {
			get { return withEventsField_Button13; }
			set {
				if (withEventsField_Button13 != null) {
					withEventsField_Button13.Click -= Button13_Click;
				}
				withEventsField_Button13 = value;
				if (withEventsField_Button13 != null) {
					withEventsField_Button13.Click += Button13_Click;
				}
			}
		}
		private System.Windows.Forms.DataGridView withEventsField_DataGridView7;
		public System.Windows.Forms.DataGridView DataGridView7 {
			get { return withEventsField_DataGridView7; }
			set {
				if (withEventsField_DataGridView7 != null) {
					withEventsField_DataGridView7.RowHeaderMouseClick -= DataGridView7_RowHeaderMouseClick;
					withEventsField_DataGridView7.RowPostPaint -= DataGridView7_RowPostPaint;
				}
				withEventsField_DataGridView7 = value;
				if (withEventsField_DataGridView7 != null) {
					withEventsField_DataGridView7.RowHeaderMouseClick += DataGridView7_RowHeaderMouseClick;
					withEventsField_DataGridView7.RowPostPaint += DataGridView7_RowPostPaint;
				}
			}
		}
		private System.Windows.Forms.GroupBox GroupBox20;
		private System.Windows.Forms.TextBox withEventsField_txtRFBooks;
		private System.Windows.Forms.TextBox txtRFBooks {
			get { return withEventsField_txtRFBooks; }
			set {
				if (withEventsField_txtRFBooks != null) {
					withEventsField_txtRFBooks.TextChanged -= txtRFBooks_TextChanged;
				}
				withEventsField_txtRFBooks = value;
				if (withEventsField_txtRFBooks != null) {
					withEventsField_txtRFBooks.TextChanged += txtRFBooks_TextChanged;
				}
			}
		}
		private System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.GroupBox GroupBox21;
		private System.Windows.Forms.Label Label15;
		private System.Windows.Forms.ComboBox withEventsField_cmbRfBook;
		public System.Windows.Forms.ComboBox cmbRfBook {
			get { return withEventsField_cmbRfBook; }
			set {
				if (withEventsField_cmbRfBook != null) {
					withEventsField_cmbRfBook.SelectedIndexChanged -= cmbRfBook_SelectedIndexChanged;
				}
				withEventsField_cmbRfBook = value;
				if (withEventsField_cmbRfBook != null) {
					withEventsField_cmbRfBook.SelectedIndexChanged += cmbRfBook_SelectedIndexChanged;
				}
			}
		}
		private System.Windows.Forms.DataGridView withEventsField_DataGridView8;
		public System.Windows.Forms.DataGridView DataGridView8 {
			get { return withEventsField_DataGridView8; }
			set {
				if (withEventsField_DataGridView8 != null) {
					withEventsField_DataGridView8.RowHeaderMouseClick -= DataGridView8_RowHeaderMouseClick;
					withEventsField_DataGridView8.RowPostPaint -= DataGridView8_RowPostPaint;
				}
				withEventsField_DataGridView8 = value;
				if (withEventsField_DataGridView8 != null) {
					withEventsField_DataGridView8.RowHeaderMouseClick += DataGridView8_RowHeaderMouseClick;
					withEventsField_DataGridView8.RowPostPaint += DataGridView8_RowPostPaint;
				}
			}
		}
		internal System.Windows.Forms.GroupBox GroupBox23;
		private System.Windows.Forms.Button withEventsField_Button16;
		internal System.Windows.Forms.Button Button16 {
			get { return withEventsField_Button16; }
			set {
				if (withEventsField_Button16 != null) {
					withEventsField_Button16.Click -= Button16_Click;
				}
				withEventsField_Button16 = value;
				if (withEventsField_Button16 != null) {
					withEventsField_Button16.Click += Button16_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_Button14;
		internal System.Windows.Forms.Button Button14 {
			get { return withEventsField_Button14; }
			set {
				if (withEventsField_Button14 != null) {
					withEventsField_Button14.Click -= Button14_Click;
				}
				withEventsField_Button14 = value;
				if (withEventsField_Button14 != null) {
					withEventsField_Button14.Click += Button14_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_Button15;
		internal System.Windows.Forms.Button Button15 {
			get { return withEventsField_Button15; }
			set {
				if (withEventsField_Button15 != null) {
					withEventsField_Button15.Click -= Button15_Click;
				}
				withEventsField_Button15 = value;
				if (withEventsField_Button15 != null) {
					withEventsField_Button15.Click += Button15_Click;
				}
			}
		}
	}
}

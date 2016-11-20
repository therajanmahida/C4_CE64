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
	partial class frmMain : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.MasterEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SerialControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NoDuesDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BooksToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.MasterEntryToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.IssueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.StudentsToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.StaffsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ReturnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.StudentsToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.StaffsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.SerialBoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.JournalsAndMagzinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BooksToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.ProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StudentsToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.FacultiesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.SuppliersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.StudentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.MenuStrip2 = new System.Windows.Forms.MenuStrip();
			this.StudentsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.StaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StudentsToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.StaffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.CardsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.StudentsToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.StaffToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.NoDuesDocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.StudentsToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.StaffToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.RegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FacultiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.IssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BookReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SearchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.CourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.YearsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BooksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.StudentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.FacultiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.SuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StudentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RegistrationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.LoginDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.JournalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NewPapersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SubscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BooksIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BooksReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TaskManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MSWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.WordpadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SystemInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuStrip1.SuspendLayout();
			this.StatusStrip1.SuspendLayout();
			this.MenuStrip2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			//
			//MenuStrip1
			//
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.MasterEntryToolStripMenuItem,
				this.UsersToolStripMenuItem,
				this.SerialControlToolStripMenuItem,
				this.TransactionToolStripMenuItem,
				this.RecordsToolStripMenuItem,
				this.ToolsToolStripMenuItem,
				this.AboutToolStripMenuItem
			});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new System.Drawing.Size(991, 24);
			this.MenuStrip1.TabIndex = 0;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//MasterEntryToolStripMenuItem
			//
			this.MasterEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.CourseToolStripMenuItem,
				this.DepartmentToolStripMenuItem,
				this.YearsToolStripMenuItem,
				this.BooksToolStripMenuItem1,
				this.StudentsToolStripMenuItem1,
				this.FacultiesToolStripMenuItem1,
				this.SuppliersToolStripMenuItem,
				this.StudentListToolStripMenuItem
			});
			this.MasterEntryToolStripMenuItem.Name = "MasterEntryToolStripMenuItem";
			this.MasterEntryToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
			this.MasterEntryToolStripMenuItem.Text = "Master Entry";
			//
			//UsersToolStripMenuItem
			//
			this.UsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.RegistrationToolStripMenuItem1,
				this.LoginDetailsToolStripMenuItem
			});
			this.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
			this.UsersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.UsersToolStripMenuItem.Text = "Users";
			//
			//SerialControlToolStripMenuItem
			//
			this.SerialControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.JournalsToolStripMenuItem,
				this.NewPapersToolStripMenuItem,
				this.SubscriptionToolStripMenuItem,
				this.CardsToolStripMenuItem,
				this.NoDuesDocToolStripMenuItem
			});
			this.SerialControlToolStripMenuItem.Name = "SerialControlToolStripMenuItem";
			this.SerialControlToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.SerialControlToolStripMenuItem.Text = "Serial Control";
			//
			//NoDuesDocToolStripMenuItem
			//
			this.NoDuesDocToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.images3;
			this.NoDuesDocToolStripMenuItem.Name = "NoDuesDocToolStripMenuItem";
			this.NoDuesDocToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.NoDuesDocToolStripMenuItem.Text = "No Dues Doc";
			//
			//TransactionToolStripMenuItem
			//
			this.TransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.BooksIssueToolStripMenuItem,
				this.BooksReturnToolStripMenuItem
			});
			this.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem";
			this.TransactionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
			this.TransactionToolStripMenuItem.Text = "Transaction";
			//
			//RecordsToolStripMenuItem
			//
			this.RecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.BooksToolStripMenuItem3,
				this.SerialBoundToolStripMenuItem,
				this.StudentsToolStripMenuItem3,
				this.FacultiesToolStripMenuItem3,
				this.SuppliersToolStripMenuItem1,
				this.StudentsListToolStripMenuItem
			});
			this.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem";
			this.RecordsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.RecordsToolStripMenuItem.Text = "Records";
			//
			//BooksToolStripMenuItem3
			//
			this.BooksToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.MasterEntryToolStripMenuItem2,
				this.IssueToolStripMenuItem2,
				this.ReturnToolStripMenuItem1
			});
			this.BooksToolStripMenuItem3.Name = "BooksToolStripMenuItem3";
			this.BooksToolStripMenuItem3.Size = new System.Drawing.Size(141, 22);
			this.BooksToolStripMenuItem3.Text = "Books";
			//
			//MasterEntryToolStripMenuItem2
			//
			this.MasterEntryToolStripMenuItem2.Name = "MasterEntryToolStripMenuItem2";
			this.MasterEntryToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
			this.MasterEntryToolStripMenuItem2.Text = "Master Entry";
			//
			//IssueToolStripMenuItem2
			//
			this.IssueToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.StudentsToolStripMenuItem5,
				this.StaffsToolStripMenuItem
			});
			this.IssueToolStripMenuItem2.Name = "IssueToolStripMenuItem2";
			this.IssueToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
			this.IssueToolStripMenuItem2.Text = "Issue";
			//
			//StudentsToolStripMenuItem5
			//
			this.StudentsToolStripMenuItem5.Name = "StudentsToolStripMenuItem5";
			this.StudentsToolStripMenuItem5.Size = new System.Drawing.Size(120, 22);
			this.StudentsToolStripMenuItem5.Text = "Students";
			//
			//StaffsToolStripMenuItem
			//
			this.StaffsToolStripMenuItem.Name = "StaffsToolStripMenuItem";
			this.StaffsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.StaffsToolStripMenuItem.Text = "Staffs";
			//
			//ReturnToolStripMenuItem1
			//
			this.ReturnToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.StudentsToolStripMenuItem6,
				this.StaffsToolStripMenuItem1
			});
			this.ReturnToolStripMenuItem1.Name = "ReturnToolStripMenuItem1";
			this.ReturnToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
			this.ReturnToolStripMenuItem1.Text = "Return";
			//
			//StudentsToolStripMenuItem6
			//
			this.StudentsToolStripMenuItem6.Name = "StudentsToolStripMenuItem6";
			this.StudentsToolStripMenuItem6.Size = new System.Drawing.Size(120, 22);
			this.StudentsToolStripMenuItem6.Text = "Students";
			//
			//StaffsToolStripMenuItem1
			//
			this.StaffsToolStripMenuItem1.Name = "StaffsToolStripMenuItem1";
			this.StaffsToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
			this.StaffsToolStripMenuItem1.Text = "Staffs";
			//
			//SerialBoundToolStripMenuItem
			//
			this.SerialBoundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.JournalsAndMagzinesToolStripMenuItem,
				this.BooksToolStripMenuItem4,
				this.ProjectsToolStripMenuItem,
				this.CardsToolStripMenuItem1,
				this.NoDuesDocToolStripMenuItem1
			});
			this.SerialBoundToolStripMenuItem.Name = "SerialBoundToolStripMenuItem";
			this.SerialBoundToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.SerialBoundToolStripMenuItem.Text = "Serial Bound";
			//
			//JournalsAndMagzinesToolStripMenuItem
			//
			this.JournalsAndMagzinesToolStripMenuItem.Name = "JournalsAndMagzinesToolStripMenuItem";
			this.JournalsAndMagzinesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.JournalsAndMagzinesToolStripMenuItem.Text = "Journals and Magazines";
			//
			//BooksToolStripMenuItem4
			//
			this.BooksToolStripMenuItem4.Name = "BooksToolStripMenuItem4";
			this.BooksToolStripMenuItem4.Size = new System.Drawing.Size(199, 22);
			this.BooksToolStripMenuItem4.Text = "News Paper";
			//
			//ProjectsToolStripMenuItem
			//
			this.ProjectsToolStripMenuItem.Name = "ProjectsToolStripMenuItem";
			this.ProjectsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.ProjectsToolStripMenuItem.Text = "Projects";
			//
			//StudentsToolStripMenuItem3
			//
			this.StudentsToolStripMenuItem3.Name = "StudentsToolStripMenuItem3";
			this.StudentsToolStripMenuItem3.Size = new System.Drawing.Size(141, 22);
			this.StudentsToolStripMenuItem3.Text = "Students";
			//
			//FacultiesToolStripMenuItem3
			//
			this.FacultiesToolStripMenuItem3.Name = "FacultiesToolStripMenuItem3";
			this.FacultiesToolStripMenuItem3.Size = new System.Drawing.Size(141, 22);
			this.FacultiesToolStripMenuItem3.Text = "Faculties";
			//
			//SuppliersToolStripMenuItem1
			//
			this.SuppliersToolStripMenuItem1.Name = "SuppliersToolStripMenuItem1";
			this.SuppliersToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
			this.SuppliersToolStripMenuItem1.Text = "Suppliers";
			//
			//StudentsListToolStripMenuItem
			//
			this.StudentsListToolStripMenuItem.Name = "StudentsListToolStripMenuItem";
			this.StudentsListToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.StudentsListToolStripMenuItem.Text = "Students List";
			//
			//ToolsToolStripMenuItem
			//
			this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.CalculatorToolStripMenuItem,
				this.NotepadToolStripMenuItem,
				this.TaskManagerToolStripMenuItem,
				this.MSWordToolStripMenuItem,
				this.WordpadToolStripMenuItem,
				this.SystemInfoToolStripMenuItem
			});
			this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
			this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.ToolsToolStripMenuItem.Text = "Tools";
			//
			//AboutToolStripMenuItem
			//
			this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
			this.AboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.AboutToolStripMenuItem.Text = "About";
			//
			//StatusStrip1
			//
			this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.ToolStripStatusLabel1,
				this.lblUser,
				this.ToolStripStatusLabel3,
				this.lblDateTime
			});
			this.StatusStrip1.Location = new System.Drawing.Point(0, 605);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Size = new System.Drawing.Size(991, 22);
			this.StatusStrip1.TabIndex = 2;
			this.StatusStrip1.Text = "StatusStrip1";
			//
			//ToolStripStatusLabel1
			//
			this.ToolStripStatusLabel1.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new System.Drawing.Size(86, 17);
			this.ToolStripStatusLabel1.Text = "Logged in As :";
			//
			//ToolStripStatusLabel3
			//
			this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
			this.ToolStripStatusLabel3.Size = new System.Drawing.Size(600, 17);
			this.ToolStripStatusLabel3.Spring = true;
			//
			//Timer1
			//
			this.Timer1.Enabled = true;
			//
			//MenuStrip2
			//
			this.MenuStrip2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.MenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.RegistrationToolStripMenuItem,
				this.BooksToolStripMenuItem,
				this.StudentsToolStripMenuItem,
				this.FacultiesToolStripMenuItem,
				this.IssueToolStripMenuItem,
				this.BookReturnToolStripMenuItem,
				this.SearchToolStripMenuItem1,
				this.LogoutToolStripMenuItem
			});
			this.MenuStrip2.Location = new System.Drawing.Point(0, 24);
			this.MenuStrip2.Name = "MenuStrip2";
			this.MenuStrip2.Size = new System.Drawing.Size(991, 77);
			this.MenuStrip2.TabIndex = 3;
			this.MenuStrip2.Text = "MenuStrip2";
			//
			//StudentsToolStripMenuItem2
			//
			this.StudentsToolStripMenuItem2.Name = "StudentsToolStripMenuItem2";
			this.StudentsToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
			this.StudentsToolStripMenuItem2.Text = "Students";
			//
			//StaffToolStripMenuItem
			//
			this.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem";
			this.StaffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.StaffToolStripMenuItem.Text = "Staffs";
			//
			//StudentsToolStripMenuItem4
			//
			this.StudentsToolStripMenuItem4.Name = "StudentsToolStripMenuItem4";
			this.StudentsToolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
			this.StudentsToolStripMenuItem4.Text = "Students";
			//
			//StaffToolStripMenuItem1
			//
			this.StaffToolStripMenuItem1.Name = "StaffToolStripMenuItem1";
			this.StaffToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.StaffToolStripMenuItem1.Text = "Staff";
			//
			//CardsToolStripMenuItem1
			//
			this.CardsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.StudentsToolStripMenuItem7,
				this.StaffToolStripMenuItem2
			});
			this.CardsToolStripMenuItem1.Name = "CardsToolStripMenuItem1";
			this.CardsToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
			this.CardsToolStripMenuItem1.Text = "Cards";
			//
			//StudentsToolStripMenuItem7
			//
			this.StudentsToolStripMenuItem7.Name = "StudentsToolStripMenuItem7";
			this.StudentsToolStripMenuItem7.Size = new System.Drawing.Size(120, 22);
			this.StudentsToolStripMenuItem7.Text = "Students";
			//
			//StaffToolStripMenuItem2
			//
			this.StaffToolStripMenuItem2.Name = "StaffToolStripMenuItem2";
			this.StaffToolStripMenuItem2.Size = new System.Drawing.Size(120, 22);
			this.StaffToolStripMenuItem2.Text = "Staff";
			//
			//NoDuesDocToolStripMenuItem1
			//
			this.NoDuesDocToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.StudentsToolStripMenuItem8,
				this.StaffToolStripMenuItem3
			});
			this.NoDuesDocToolStripMenuItem1.Name = "NoDuesDocToolStripMenuItem1";
			this.NoDuesDocToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
			this.NoDuesDocToolStripMenuItem1.Text = "No Dues Doc";
			//
			//StudentsToolStripMenuItem8
			//
			this.StudentsToolStripMenuItem8.Name = "StudentsToolStripMenuItem8";
			this.StudentsToolStripMenuItem8.Size = new System.Drawing.Size(120, 22);
			this.StudentsToolStripMenuItem8.Text = "Students";
			//
			//StaffToolStripMenuItem3
			//
			this.StaffToolStripMenuItem3.Name = "StaffToolStripMenuItem3";
			this.StaffToolStripMenuItem3.Size = new System.Drawing.Size(120, 22);
			this.StaffToolStripMenuItem3.Text = "Staff";
			//
			//PictureBox1
			//
			this.PictureBox1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.PictureBox1.Image = global::LibraryManagementSystem.My.Resources.Resources.mainfrm;
			this.PictureBox1.Location = new System.Drawing.Point(0, 103);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(991, 499);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 4;
			this.PictureBox1.TabStop = false;
			//
			//RegistrationToolStripMenuItem
			//
			this.RegistrationToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.RegistrationToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.registration_icon_up;
			this.RegistrationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem";
			this.RegistrationToolStripMenuItem.Size = new System.Drawing.Size(113, 73);
			this.RegistrationToolStripMenuItem.Text = "Registration";
			this.RegistrationToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//BooksToolStripMenuItem
			//
			this.BooksToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.BooksToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.folder_home21;
			this.BooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem";
			this.BooksToolStripMenuItem.Size = new System.Drawing.Size(65, 73);
			this.BooksToolStripMenuItem.Text = "Books";
			this.BooksToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//StudentsToolStripMenuItem
			//
			this.StudentsToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.StudentsToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.images52;
			this.StudentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem";
			this.StudentsToolStripMenuItem.Size = new System.Drawing.Size(89, 73);
			this.StudentsToolStripMenuItem.Text = "Students";
			this.StudentsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//FacultiesToolStripMenuItem
			//
			this.FacultiesToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FacultiesToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.admissions_icon;
			this.FacultiesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.FacultiesToolStripMenuItem.Name = "FacultiesToolStripMenuItem";
			this.FacultiesToolStripMenuItem.Size = new System.Drawing.Size(91, 73);
			this.FacultiesToolStripMenuItem.Text = "Faculties";
			this.FacultiesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//IssueToolStripMenuItem
			//
			this.IssueToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.IssueToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.Picture1;
			this.IssueToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.IssueToolStripMenuItem.Name = "IssueToolStripMenuItem";
			this.IssueToolStripMenuItem.Size = new System.Drawing.Size(102, 73);
			this.IssueToolStripMenuItem.Text = "Book Issue";
			this.IssueToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//BookReturnToolStripMenuItem
			//
			this.BookReturnToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.BookReturnToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.yellow_comment_bubbles_icon_culture_book21;
			this.BookReturnToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.BookReturnToolStripMenuItem.Name = "BookReturnToolStripMenuItem";
			this.BookReturnToolStripMenuItem.Size = new System.Drawing.Size(115, 73);
			this.BookReturnToolStripMenuItem.Text = "Book Return";
			this.BookReturnToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//SearchToolStripMenuItem1
			//
			this.SearchToolStripMenuItem1.Font = new System.Drawing.Font("Bookman Old Style", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.SearchToolStripMenuItem1.Image = global::LibraryManagementSystem.My.Resources.Resources._8314929977_28fd740070_z1;
			this.SearchToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1";
			this.SearchToolStripMenuItem1.Size = new System.Drawing.Size(123, 73);
			this.SearchToolStripMenuItem1.Text = "Books Search";
			this.SearchToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//LogoutToolStripMenuItem
			//
			this.LogoutToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.LogoutToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.logout;
			this.LogoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
			this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(70, 73);
			this.LogoutToolStripMenuItem.Text = "Logout";
			this.LogoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//lblUser
			//
			this.lblUser.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.lblUser.Image = global::LibraryManagementSystem.My.Resources.Resources.User_icon;
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(145, 17);
			this.lblUser.Text = "ToolStripStatusLabel2";
			//
			//lblDateTime
			//
			this.lblDateTime.Font = new System.Drawing.Font("Palatino Linotype", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.lblDateTime.Image = global::LibraryManagementSystem.My.Resources.Resources.time_1920x1200;
			this.lblDateTime.Name = "lblDateTime";
			this.lblDateTime.Size = new System.Drawing.Size(145, 17);
			this.lblDateTime.Text = "ToolStripStatusLabel4";
			//
			//CourseToolStripMenuItem
			//
			this.CourseToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources._56928_256x256_courses_icon;
			this.CourseToolStripMenuItem.Name = "CourseToolStripMenuItem";
			this.CourseToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C);
			this.CourseToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.CourseToolStripMenuItem.Text = "Course";
			//
			//DepartmentToolStripMenuItem
			//
			this.DepartmentToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.images;
			this.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem";
			this.DepartmentToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D);
			this.DepartmentToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.DepartmentToolStripMenuItem.Text = "Department";
			//
			//YearsToolStripMenuItem
			//
			this.YearsToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.calendar_year_icon;
			this.YearsToolStripMenuItem.Name = "YearsToolStripMenuItem";
			this.YearsToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Y);
			this.YearsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.YearsToolStripMenuItem.Text = "Years";
			//
			//BooksToolStripMenuItem1
			//
			this.BooksToolStripMenuItem1.Image = global::LibraryManagementSystem.My.Resources.Resources.folder_home2;
			this.BooksToolStripMenuItem1.Name = "BooksToolStripMenuItem1";
			this.BooksToolStripMenuItem1.ShortcutKeys = (System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B);
			this.BooksToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
			this.BooksToolStripMenuItem1.Text = "Books";
			//
			//StudentsToolStripMenuItem1
			//
			this.StudentsToolStripMenuItem1.Image = global::LibraryManagementSystem.My.Resources.Resources.images51;
			this.StudentsToolStripMenuItem1.Name = "StudentsToolStripMenuItem1";
			this.StudentsToolStripMenuItem1.ShortcutKeys = (System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S);
			this.StudentsToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
			this.StudentsToolStripMenuItem1.Text = "Students";
			//
			//FacultiesToolStripMenuItem1
			//
			this.FacultiesToolStripMenuItem1.Image = global::LibraryManagementSystem.My.Resources.Resources.admissions_icon1;
			this.FacultiesToolStripMenuItem1.Name = "FacultiesToolStripMenuItem1";
			this.FacultiesToolStripMenuItem1.ShortcutKeys = (System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F);
			this.FacultiesToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
			this.FacultiesToolStripMenuItem1.Text = "Faculties";
			//
			//SuppliersToolStripMenuItem
			//
			this.SuppliersToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.supplierIcon2;
			this.SuppliersToolStripMenuItem.Name = "SuppliersToolStripMenuItem";
			this.SuppliersToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) | System.Windows.Forms.Keys.S);
			this.SuppliersToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.SuppliersToolStripMenuItem.Text = "Suppliers";
			//
			//StudentListToolStripMenuItem
			//
			this.StudentListToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.images4;
			this.StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem";
			this.StudentListToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S);
			this.StudentListToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.StudentListToolStripMenuItem.Text = "Student List";
			//
			//RegistrationToolStripMenuItem1
			//
			this.RegistrationToolStripMenuItem1.Image = global::LibraryManagementSystem.My.Resources.Resources.registration_icon_up1;
			this.RegistrationToolStripMenuItem1.Name = "RegistrationToolStripMenuItem1";
			this.RegistrationToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
			this.RegistrationToolStripMenuItem1.Text = "Registration";
			//
			//LoginDetailsToolStripMenuItem
			//
			this.LoginDetailsToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.Log_Details;
			this.LoginDetailsToolStripMenuItem.Name = "LoginDetailsToolStripMenuItem";
			this.LoginDetailsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.LoginDetailsToolStripMenuItem.Text = "Login Details";
			//
			//JournalsToolStripMenuItem
			//
			this.JournalsToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.magazinesIcon;
			this.JournalsToolStripMenuItem.Name = "JournalsToolStripMenuItem";
			this.JournalsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.JournalsToolStripMenuItem.Text = "Journals and Magazines";
			//
			//NewPapersToolStripMenuItem
			//
			this.NewPapersToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.images1;
			this.NewPapersToolStripMenuItem.Name = "NewPapersToolStripMenuItem";
			this.NewPapersToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.NewPapersToolStripMenuItem.Text = "New Papers";
			//
			//SubscriptionToolStripMenuItem
			//
			this.SubscriptionToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.images2;
			this.SubscriptionToolStripMenuItem.Name = "SubscriptionToolStripMenuItem";
			this.SubscriptionToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.SubscriptionToolStripMenuItem.Text = "Project";
			//
			//CardsToolStripMenuItem
			//
			this.CardsToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.System_Security_Card_icon;
			this.CardsToolStripMenuItem.Name = "CardsToolStripMenuItem";
			this.CardsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.CardsToolStripMenuItem.Text = "Cards";
			//
			//BooksIssueToolStripMenuItem
			//
			this.BooksIssueToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.Picture11;
			this.BooksIssueToolStripMenuItem.Name = "BooksIssueToolStripMenuItem";
			this.BooksIssueToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.BooksIssueToolStripMenuItem.Text = "Books Issue";
			//
			//BooksReturnToolStripMenuItem
			//
			this.BooksReturnToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.yellow_comment_bubbles_icon_culture_book22;
			this.BooksReturnToolStripMenuItem.Name = "BooksReturnToolStripMenuItem";
			this.BooksReturnToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.BooksReturnToolStripMenuItem.Text = "Books Return";
			//
			//CalculatorToolStripMenuItem
			//
			this.CalculatorToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.calc;
			this.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem";
			this.CalculatorToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.CalculatorToolStripMenuItem.Text = "Calculator";
			//
			//NotepadToolStripMenuItem
			//
			this.NotepadToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.Notepad1;
			this.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem";
			this.NotepadToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.NotepadToolStripMenuItem.Text = "Notepad";
			//
			//TaskManagerToolStripMenuItem
			//
			this.TaskManagerToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.task_manager1;
			this.TaskManagerToolStripMenuItem.Name = "TaskManagerToolStripMenuItem";
			this.TaskManagerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.TaskManagerToolStripMenuItem.Text = "Task Manager";
			//
			//MSWordToolStripMenuItem
			//
			this.MSWordToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.MS_Word_2_icon1;
			this.MSWordToolStripMenuItem.Name = "MSWordToolStripMenuItem";
			this.MSWordToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.MSWordToolStripMenuItem.Text = "MS Word";
			//
			//WordpadToolStripMenuItem
			//
			this.WordpadToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.Wordpad_icon__Windows_7_;
			this.WordpadToolStripMenuItem.Name = "WordpadToolStripMenuItem";
			this.WordpadToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.WordpadToolStripMenuItem.Text = "Wordpad";
			//
			//SystemInfoToolStripMenuItem
			//
			this.SystemInfoToolStripMenuItem.Image = global::LibraryManagementSystem.My.Resources.Resources.system_information_icon;
			this.SystemInfoToolStripMenuItem.Name = "SystemInfoToolStripMenuItem";
			this.SystemInfoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.SystemInfoToolStripMenuItem.Text = "System Info";
			//
			//frmMain
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(991, 627);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.MenuStrip2);
			this.Controls.Add(this.StatusStrip1);
			this.Controls.Add(this.MenuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MainMenuStrip = this.MenuStrip1;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main Form";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.MenuStrip2.ResumeLayout(false);
			this.MenuStrip2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem MasterEntryToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem UsersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_AboutToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem {
			get { return withEventsField_AboutToolStripMenuItem; }
			set {
				if (withEventsField_AboutToolStripMenuItem != null) {
					withEventsField_AboutToolStripMenuItem.Click -= AboutToolStripMenuItem_Click;
				}
				withEventsField_AboutToolStripMenuItem = value;
				if (withEventsField_AboutToolStripMenuItem != null) {
					withEventsField_AboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem RecordsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem TransactionToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
		internal System.Windows.Forms.StatusStrip StatusStrip1;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
		internal System.Windows.Forms.ToolStripStatusLabel lblUser;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel3;
		internal System.Windows.Forms.ToolStripStatusLabel lblDateTime;
		private System.Windows.Forms.Timer withEventsField_Timer1;
		internal System.Windows.Forms.Timer Timer1 {
			get { return withEventsField_Timer1; }
			set {
				if (withEventsField_Timer1 != null) {
					withEventsField_Timer1.Tick -= Timer1_Tick;
				}
				withEventsField_Timer1 = value;
				if (withEventsField_Timer1 != null) {
					withEventsField_Timer1.Tick += Timer1_Tick;
				}
			}
		}
		internal System.Windows.Forms.MenuStrip MenuStrip2;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_CalculatorToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem CalculatorToolStripMenuItem {
			get { return withEventsField_CalculatorToolStripMenuItem; }
			set {
				if (withEventsField_CalculatorToolStripMenuItem != null) {
					withEventsField_CalculatorToolStripMenuItem.Click -= CalculatorToolStripMenuItem_Click;
				}
				withEventsField_CalculatorToolStripMenuItem = value;
				if (withEventsField_CalculatorToolStripMenuItem != null) {
					withEventsField_CalculatorToolStripMenuItem.Click += CalculatorToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_NotepadToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem NotepadToolStripMenuItem {
			get { return withEventsField_NotepadToolStripMenuItem; }
			set {
				if (withEventsField_NotepadToolStripMenuItem != null) {
					withEventsField_NotepadToolStripMenuItem.Click -= NotepadToolStripMenuItem_Click;
				}
				withEventsField_NotepadToolStripMenuItem = value;
				if (withEventsField_NotepadToolStripMenuItem != null) {
					withEventsField_NotepadToolStripMenuItem.Click += NotepadToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_TaskManagerToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem TaskManagerToolStripMenuItem {
			get { return withEventsField_TaskManagerToolStripMenuItem; }
			set {
				if (withEventsField_TaskManagerToolStripMenuItem != null) {
					withEventsField_TaskManagerToolStripMenuItem.Click -= TaskManagerToolStripMenuItem_Click;
				}
				withEventsField_TaskManagerToolStripMenuItem = value;
				if (withEventsField_TaskManagerToolStripMenuItem != null) {
					withEventsField_TaskManagerToolStripMenuItem.Click += TaskManagerToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_MSWordToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem MSWordToolStripMenuItem {
			get { return withEventsField_MSWordToolStripMenuItem; }
			set {
				if (withEventsField_MSWordToolStripMenuItem != null) {
					withEventsField_MSWordToolStripMenuItem.Click -= MSWordToolStripMenuItem_Click;
				}
				withEventsField_MSWordToolStripMenuItem = value;
				if (withEventsField_MSWordToolStripMenuItem != null) {
					withEventsField_MSWordToolStripMenuItem.Click += MSWordToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_WordpadToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem WordpadToolStripMenuItem {
			get { return withEventsField_WordpadToolStripMenuItem; }
			set {
				if (withEventsField_WordpadToolStripMenuItem != null) {
					withEventsField_WordpadToolStripMenuItem.Click -= WordpadToolStripMenuItem_Click;
				}
				withEventsField_WordpadToolStripMenuItem = value;
				if (withEventsField_WordpadToolStripMenuItem != null) {
					withEventsField_WordpadToolStripMenuItem.Click += WordpadToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_SystemInfoToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem SystemInfoToolStripMenuItem {
			get { return withEventsField_SystemInfoToolStripMenuItem; }
			set {
				if (withEventsField_SystemInfoToolStripMenuItem != null) {
					withEventsField_SystemInfoToolStripMenuItem.Click -= SystemInfoToolStripMenuItem_Click;
				}
				withEventsField_SystemInfoToolStripMenuItem = value;
				if (withEventsField_SystemInfoToolStripMenuItem != null) {
					withEventsField_SystemInfoToolStripMenuItem.Click += SystemInfoToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_RegistrationToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem RegistrationToolStripMenuItem {
			get { return withEventsField_RegistrationToolStripMenuItem; }
			set {
				if (withEventsField_RegistrationToolStripMenuItem != null) {
					withEventsField_RegistrationToolStripMenuItem.Click -= RegistrationToolStripMenuItem_Click;
				}
				withEventsField_RegistrationToolStripMenuItem = value;
				if (withEventsField_RegistrationToolStripMenuItem != null) {
					withEventsField_RegistrationToolStripMenuItem.Click += RegistrationToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_BooksToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem BooksToolStripMenuItem {
			get { return withEventsField_BooksToolStripMenuItem; }
			set {
				if (withEventsField_BooksToolStripMenuItem != null) {
					withEventsField_BooksToolStripMenuItem.Click -= BooksToolStripMenuItem_Click;
				}
				withEventsField_BooksToolStripMenuItem = value;
				if (withEventsField_BooksToolStripMenuItem != null) {
					withEventsField_BooksToolStripMenuItem.Click += BooksToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_StudentsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem StudentsToolStripMenuItem {
			get { return withEventsField_StudentsToolStripMenuItem; }
			set {
				if (withEventsField_StudentsToolStripMenuItem != null) {
					withEventsField_StudentsToolStripMenuItem.Click -= StudentsToolStripMenuItem_Click;
				}
				withEventsField_StudentsToolStripMenuItem = value;
				if (withEventsField_StudentsToolStripMenuItem != null) {
					withEventsField_StudentsToolStripMenuItem.Click += StudentsToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_FacultiesToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FacultiesToolStripMenuItem {
			get { return withEventsField_FacultiesToolStripMenuItem; }
			set {
				if (withEventsField_FacultiesToolStripMenuItem != null) {
					withEventsField_FacultiesToolStripMenuItem.Click -= FacultiesToolStripMenuItem_Click;
				}
				withEventsField_FacultiesToolStripMenuItem = value;
				if (withEventsField_FacultiesToolStripMenuItem != null) {
					withEventsField_FacultiesToolStripMenuItem.Click += FacultiesToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_IssueToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem IssueToolStripMenuItem {
			get { return withEventsField_IssueToolStripMenuItem; }
			set {
				if (withEventsField_IssueToolStripMenuItem != null) {
					withEventsField_IssueToolStripMenuItem.Click -= IssueToolStripMenuItem_Click;
				}
				withEventsField_IssueToolStripMenuItem = value;
				if (withEventsField_IssueToolStripMenuItem != null) {
					withEventsField_IssueToolStripMenuItem.Click += IssueToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_BookReturnToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem BookReturnToolStripMenuItem {
			get { return withEventsField_BookReturnToolStripMenuItem; }
			set {
				if (withEventsField_BookReturnToolStripMenuItem != null) {
					withEventsField_BookReturnToolStripMenuItem.Click -= BookReturnToolStripMenuItem_Click;
				}
				withEventsField_BookReturnToolStripMenuItem = value;
				if (withEventsField_BookReturnToolStripMenuItem != null) {
					withEventsField_BookReturnToolStripMenuItem.Click += BookReturnToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_LogoutToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem {
			get { return withEventsField_LogoutToolStripMenuItem; }
			set {
				if (withEventsField_LogoutToolStripMenuItem != null) {
					withEventsField_LogoutToolStripMenuItem.Click -= LogoutToolStripMenuItem_Click;
				}
				withEventsField_LogoutToolStripMenuItem = value;
				if (withEventsField_LogoutToolStripMenuItem != null) {
					withEventsField_LogoutToolStripMenuItem.Click += LogoutToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.PictureBox PictureBox1;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_BooksToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem BooksToolStripMenuItem1 {
			get { return withEventsField_BooksToolStripMenuItem1; }
			set {
				if (withEventsField_BooksToolStripMenuItem1 != null) {
					withEventsField_BooksToolStripMenuItem1.Click -= BooksToolStripMenuItem1_Click;
				}
				withEventsField_BooksToolStripMenuItem1 = value;
				if (withEventsField_BooksToolStripMenuItem1 != null) {
					withEventsField_BooksToolStripMenuItem1.Click += BooksToolStripMenuItem1_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_StudentsToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem StudentsToolStripMenuItem1 {
			get { return withEventsField_StudentsToolStripMenuItem1; }
			set {
				if (withEventsField_StudentsToolStripMenuItem1 != null) {
					withEventsField_StudentsToolStripMenuItem1.Click -= StudentsToolStripMenuItem1_Click;
				}
				withEventsField_StudentsToolStripMenuItem1 = value;
				if (withEventsField_StudentsToolStripMenuItem1 != null) {
					withEventsField_StudentsToolStripMenuItem1.Click += StudentsToolStripMenuItem1_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_FacultiesToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem FacultiesToolStripMenuItem1 {
			get { return withEventsField_FacultiesToolStripMenuItem1; }
			set {
				if (withEventsField_FacultiesToolStripMenuItem1 != null) {
					withEventsField_FacultiesToolStripMenuItem1.Click -= FacultiesToolStripMenuItem1_Click;
				}
				withEventsField_FacultiesToolStripMenuItem1 = value;
				if (withEventsField_FacultiesToolStripMenuItem1 != null) {
					withEventsField_FacultiesToolStripMenuItem1.Click += FacultiesToolStripMenuItem1_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_RegistrationToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem RegistrationToolStripMenuItem1 {
			get { return withEventsField_RegistrationToolStripMenuItem1; }
			set {
				if (withEventsField_RegistrationToolStripMenuItem1 != null) {
					withEventsField_RegistrationToolStripMenuItem1.Click -= RegistrationToolStripMenuItem1_Click;
				}
				withEventsField_RegistrationToolStripMenuItem1 = value;
				if (withEventsField_RegistrationToolStripMenuItem1 != null) {
					withEventsField_RegistrationToolStripMenuItem1.Click += RegistrationToolStripMenuItem1_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_LoginDetailsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem LoginDetailsToolStripMenuItem {
			get { return withEventsField_LoginDetailsToolStripMenuItem; }
			set {
				if (withEventsField_LoginDetailsToolStripMenuItem != null) {
					withEventsField_LoginDetailsToolStripMenuItem.Click -= LoginDetailsToolStripMenuItem_Click;
				}
				withEventsField_LoginDetailsToolStripMenuItem = value;
				if (withEventsField_LoginDetailsToolStripMenuItem != null) {
					withEventsField_LoginDetailsToolStripMenuItem.Click += LoginDetailsToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_CourseToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem CourseToolStripMenuItem {
			get { return withEventsField_CourseToolStripMenuItem; }
			set {
				if (withEventsField_CourseToolStripMenuItem != null) {
					withEventsField_CourseToolStripMenuItem.Click -= CourseToolStripMenuItem_Click;
				}
				withEventsField_CourseToolStripMenuItem = value;
				if (withEventsField_CourseToolStripMenuItem != null) {
					withEventsField_CourseToolStripMenuItem.Click += CourseToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_BooksIssueToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem BooksIssueToolStripMenuItem {
			get { return withEventsField_BooksIssueToolStripMenuItem; }
			set {
				if (withEventsField_BooksIssueToolStripMenuItem != null) {
					withEventsField_BooksIssueToolStripMenuItem.Click -= BooksIssueToolStripMenuItem_Click;
				}
				withEventsField_BooksIssueToolStripMenuItem = value;
				if (withEventsField_BooksIssueToolStripMenuItem != null) {
					withEventsField_BooksIssueToolStripMenuItem.Click += BooksIssueToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_BooksReturnToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem BooksReturnToolStripMenuItem {
			get { return withEventsField_BooksReturnToolStripMenuItem; }
			set {
				if (withEventsField_BooksReturnToolStripMenuItem != null) {
					withEventsField_BooksReturnToolStripMenuItem.Click -= BooksReturnToolStripMenuItem_Click;
				}
				withEventsField_BooksReturnToolStripMenuItem = value;
				if (withEventsField_BooksReturnToolStripMenuItem != null) {
					withEventsField_BooksReturnToolStripMenuItem.Click += BooksReturnToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_SuppliersToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem SuppliersToolStripMenuItem {
			get { return withEventsField_SuppliersToolStripMenuItem; }
			set {
				if (withEventsField_SuppliersToolStripMenuItem != null) {
					withEventsField_SuppliersToolStripMenuItem.Click -= SuppliersToolStripMenuItem_Click;
				}
				withEventsField_SuppliersToolStripMenuItem = value;
				if (withEventsField_SuppliersToolStripMenuItem != null) {
					withEventsField_SuppliersToolStripMenuItem.Click += SuppliersToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_StudentsToolStripMenuItem3;
		internal System.Windows.Forms.ToolStripMenuItem StudentsToolStripMenuItem3 {
			get { return withEventsField_StudentsToolStripMenuItem3; }
			set {
				if (withEventsField_StudentsToolStripMenuItem3 != null) {
					withEventsField_StudentsToolStripMenuItem3.Click -= StudentsToolStripMenuItem3_Click;
				}
				withEventsField_StudentsToolStripMenuItem3 = value;
				if (withEventsField_StudentsToolStripMenuItem3 != null) {
					withEventsField_StudentsToolStripMenuItem3.Click += StudentsToolStripMenuItem3_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_FacultiesToolStripMenuItem3;
		internal System.Windows.Forms.ToolStripMenuItem FacultiesToolStripMenuItem3 {
			get { return withEventsField_FacultiesToolStripMenuItem3; }
			set {
				if (withEventsField_FacultiesToolStripMenuItem3 != null) {
					withEventsField_FacultiesToolStripMenuItem3.Click -= FacultiesToolStripMenuItem3_Click;
				}
				withEventsField_FacultiesToolStripMenuItem3 = value;
				if (withEventsField_FacultiesToolStripMenuItem3 != null) {
					withEventsField_FacultiesToolStripMenuItem3.Click += FacultiesToolStripMenuItem3_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem SerialControlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_NewPapersToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem NewPapersToolStripMenuItem {
			get { return withEventsField_NewPapersToolStripMenuItem; }
			set {
				if (withEventsField_NewPapersToolStripMenuItem != null) {
					withEventsField_NewPapersToolStripMenuItem.Click -= NewPapersToolStripMenuItem_Click;
				}
				withEventsField_NewPapersToolStripMenuItem = value;
				if (withEventsField_NewPapersToolStripMenuItem != null) {
					withEventsField_NewPapersToolStripMenuItem.Click += NewPapersToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_SubscriptionToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem SubscriptionToolStripMenuItem {
			get { return withEventsField_SubscriptionToolStripMenuItem; }
			set {
				if (withEventsField_SubscriptionToolStripMenuItem != null) {
					withEventsField_SubscriptionToolStripMenuItem.Click -= SubscriptionToolStripMenuItem_Click;
				}
				withEventsField_SubscriptionToolStripMenuItem = value;
				if (withEventsField_SubscriptionToolStripMenuItem != null) {
					withEventsField_SubscriptionToolStripMenuItem.Click += SubscriptionToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_SearchToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem1 {
			get { return withEventsField_SearchToolStripMenuItem1; }
			set {
				if (withEventsField_SearchToolStripMenuItem1 != null) {
					withEventsField_SearchToolStripMenuItem1.Click -= SearchToolStripMenuItem1_Click;
				}
				withEventsField_SearchToolStripMenuItem1 = value;
				if (withEventsField_SearchToolStripMenuItem1 != null) {
					withEventsField_SearchToolStripMenuItem1.Click += SearchToolStripMenuItem1_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_DepartmentToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem DepartmentToolStripMenuItem {
			get { return withEventsField_DepartmentToolStripMenuItem; }
			set {
				if (withEventsField_DepartmentToolStripMenuItem != null) {
					withEventsField_DepartmentToolStripMenuItem.Click -= DepartmentToolStripMenuItem_Click;
				}
				withEventsField_DepartmentToolStripMenuItem = value;
				if (withEventsField_DepartmentToolStripMenuItem != null) {
					withEventsField_DepartmentToolStripMenuItem.Click += DepartmentToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_YearsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem YearsToolStripMenuItem {
			get { return withEventsField_YearsToolStripMenuItem; }
			set {
				if (withEventsField_YearsToolStripMenuItem != null) {
					withEventsField_YearsToolStripMenuItem.Click -= YearsToolStripMenuItem_Click;
				}
				withEventsField_YearsToolStripMenuItem = value;
				if (withEventsField_YearsToolStripMenuItem != null) {
					withEventsField_YearsToolStripMenuItem.Click += YearsToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem SerialBoundToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_JournalsAndMagzinesToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem JournalsAndMagzinesToolStripMenuItem {
			get { return withEventsField_JournalsAndMagzinesToolStripMenuItem; }
			set {
				if (withEventsField_JournalsAndMagzinesToolStripMenuItem != null) {
					withEventsField_JournalsAndMagzinesToolStripMenuItem.Click -= JournalsAndMagzinesToolStripMenuItem_Click;
				}
				withEventsField_JournalsAndMagzinesToolStripMenuItem = value;
				if (withEventsField_JournalsAndMagzinesToolStripMenuItem != null) {
					withEventsField_JournalsAndMagzinesToolStripMenuItem.Click += JournalsAndMagzinesToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_BooksToolStripMenuItem4;
		internal System.Windows.Forms.ToolStripMenuItem BooksToolStripMenuItem4 {
			get { return withEventsField_BooksToolStripMenuItem4; }
			set {
				if (withEventsField_BooksToolStripMenuItem4 != null) {
					withEventsField_BooksToolStripMenuItem4.Click -= BooksToolStripMenuItem4_Click;
				}
				withEventsField_BooksToolStripMenuItem4 = value;
				if (withEventsField_BooksToolStripMenuItem4 != null) {
					withEventsField_BooksToolStripMenuItem4.Click += BooksToolStripMenuItem4_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ProjectsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ProjectsToolStripMenuItem {
			get { return withEventsField_ProjectsToolStripMenuItem; }
			set {
				if (withEventsField_ProjectsToolStripMenuItem != null) {
					withEventsField_ProjectsToolStripMenuItem.Click -= ProjectsToolStripMenuItem_Click;
				}
				withEventsField_ProjectsToolStripMenuItem = value;
				if (withEventsField_ProjectsToolStripMenuItem != null) {
					withEventsField_ProjectsToolStripMenuItem.Click += ProjectsToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_SuppliersToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem SuppliersToolStripMenuItem1 {
			get { return withEventsField_SuppliersToolStripMenuItem1; }
			set {
				if (withEventsField_SuppliersToolStripMenuItem1 != null) {
					withEventsField_SuppliersToolStripMenuItem1.Click -= SuppliersToolStripMenuItem1_Click;
				}
				withEventsField_SuppliersToolStripMenuItem1 = value;
				if (withEventsField_SuppliersToolStripMenuItem1 != null) {
					withEventsField_SuppliersToolStripMenuItem1.Click += SuppliersToolStripMenuItem1_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_StudentListToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem StudentListToolStripMenuItem {
			get { return withEventsField_StudentListToolStripMenuItem; }
			set {
				if (withEventsField_StudentListToolStripMenuItem != null) {
					withEventsField_StudentListToolStripMenuItem.Click -= StudentListToolStripMenuItem_Click;
				}
				withEventsField_StudentListToolStripMenuItem = value;
				if (withEventsField_StudentListToolStripMenuItem != null) {
					withEventsField_StudentListToolStripMenuItem.Click += StudentListToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem BooksToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_MasterEntryToolStripMenuItem2;
		internal System.Windows.Forms.ToolStripMenuItem MasterEntryToolStripMenuItem2 {
			get { return withEventsField_MasterEntryToolStripMenuItem2; }
			set {
				if (withEventsField_MasterEntryToolStripMenuItem2 != null) {
					withEventsField_MasterEntryToolStripMenuItem2.Click -= MasterEntryToolStripMenuItem2_Click;
				}
				withEventsField_MasterEntryToolStripMenuItem2 = value;
				if (withEventsField_MasterEntryToolStripMenuItem2 != null) {
					withEventsField_MasterEntryToolStripMenuItem2.Click += MasterEntryToolStripMenuItem2_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem IssueToolStripMenuItem2;
		internal System.Windows.Forms.ToolStripMenuItem ReturnToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_StudentsToolStripMenuItem2;
		internal System.Windows.Forms.ToolStripMenuItem StudentsToolStripMenuItem2 {
			get { return withEventsField_StudentsToolStripMenuItem2; }
			set {
				if (withEventsField_StudentsToolStripMenuItem2 != null) {
					withEventsField_StudentsToolStripMenuItem2.Click -= StudentsToolStripMenuItem2_Click;
				}
				withEventsField_StudentsToolStripMenuItem2 = value;
				if (withEventsField_StudentsToolStripMenuItem2 != null) {
					withEventsField_StudentsToolStripMenuItem2.Click += StudentsToolStripMenuItem2_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_StaffToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem StaffToolStripMenuItem {
			get { return withEventsField_StaffToolStripMenuItem; }
			set {
				if (withEventsField_StaffToolStripMenuItem != null) {
					withEventsField_StaffToolStripMenuItem.Click -= StaffToolStripMenuItem_Click;
				}
				withEventsField_StaffToolStripMenuItem = value;
				if (withEventsField_StaffToolStripMenuItem != null) {
					withEventsField_StaffToolStripMenuItem.Click += StaffToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem StudentsToolStripMenuItem4;
		internal System.Windows.Forms.ToolStripMenuItem StaffToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_StudentsListToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem StudentsListToolStripMenuItem {
			get { return withEventsField_StudentsListToolStripMenuItem; }
			set {
				if (withEventsField_StudentsListToolStripMenuItem != null) {
					withEventsField_StudentsListToolStripMenuItem.Click -= StudentsListToolStripMenuItem_Click;
				}
				withEventsField_StudentsListToolStripMenuItem = value;
				if (withEventsField_StudentsListToolStripMenuItem != null) {
					withEventsField_StudentsListToolStripMenuItem.Click += StudentsListToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_StudentsToolStripMenuItem5;
		internal System.Windows.Forms.ToolStripMenuItem StudentsToolStripMenuItem5 {
			get { return withEventsField_StudentsToolStripMenuItem5; }
			set {
				if (withEventsField_StudentsToolStripMenuItem5 != null) {
					withEventsField_StudentsToolStripMenuItem5.Click -= StudentsToolStripMenuItem5_Click;
				}
				withEventsField_StudentsToolStripMenuItem5 = value;
				if (withEventsField_StudentsToolStripMenuItem5 != null) {
					withEventsField_StudentsToolStripMenuItem5.Click += StudentsToolStripMenuItem5_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_StaffsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem StaffsToolStripMenuItem {
			get { return withEventsField_StaffsToolStripMenuItem; }
			set {
				if (withEventsField_StaffsToolStripMenuItem != null) {
					withEventsField_StaffsToolStripMenuItem.Click -= StaffsToolStripMenuItem_Click;
				}
				withEventsField_StaffsToolStripMenuItem = value;
				if (withEventsField_StaffsToolStripMenuItem != null) {
					withEventsField_StaffsToolStripMenuItem.Click += StaffsToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_StudentsToolStripMenuItem6;
		internal System.Windows.Forms.ToolStripMenuItem StudentsToolStripMenuItem6 {
			get { return withEventsField_StudentsToolStripMenuItem6; }
			set {
				if (withEventsField_StudentsToolStripMenuItem6 != null) {
					withEventsField_StudentsToolStripMenuItem6.Click -= StudentsToolStripMenuItem6_Click;
				}
				withEventsField_StudentsToolStripMenuItem6 = value;
				if (withEventsField_StudentsToolStripMenuItem6 != null) {
					withEventsField_StudentsToolStripMenuItem6.Click += StudentsToolStripMenuItem6_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_StaffsToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem StaffsToolStripMenuItem1 {
			get { return withEventsField_StaffsToolStripMenuItem1; }
			set {
				if (withEventsField_StaffsToolStripMenuItem1 != null) {
					withEventsField_StaffsToolStripMenuItem1.Click -= StaffsToolStripMenuItem1_Click;
				}
				withEventsField_StaffsToolStripMenuItem1 = value;
				if (withEventsField_StaffsToolStripMenuItem1 != null) {
					withEventsField_StaffsToolStripMenuItem1.Click += StaffsToolStripMenuItem1_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_JournalsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem JournalsToolStripMenuItem {
			get { return withEventsField_JournalsToolStripMenuItem; }
			set {
				if (withEventsField_JournalsToolStripMenuItem != null) {
					withEventsField_JournalsToolStripMenuItem.Click -= JournalsToolStripMenuItem_Click;
				}
				withEventsField_JournalsToolStripMenuItem = value;
				if (withEventsField_JournalsToolStripMenuItem != null) {
					withEventsField_JournalsToolStripMenuItem.Click += JournalsToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_CardsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem CardsToolStripMenuItem {
			get { return withEventsField_CardsToolStripMenuItem; }
			set {
				if (withEventsField_CardsToolStripMenuItem != null) {
					withEventsField_CardsToolStripMenuItem.Click -= CardsToolStripMenuItem_Click;
				}
				withEventsField_CardsToolStripMenuItem = value;
				if (withEventsField_CardsToolStripMenuItem != null) {
					withEventsField_CardsToolStripMenuItem.Click += CardsToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_NoDuesDocToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem NoDuesDocToolStripMenuItem {
			get { return withEventsField_NoDuesDocToolStripMenuItem; }
			set {
				if (withEventsField_NoDuesDocToolStripMenuItem != null) {
					withEventsField_NoDuesDocToolStripMenuItem.Click -= NoDuesDocToolStripMenuItem_Click;
				}
				withEventsField_NoDuesDocToolStripMenuItem = value;
				if (withEventsField_NoDuesDocToolStripMenuItem != null) {
					withEventsField_NoDuesDocToolStripMenuItem.Click += NoDuesDocToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem CardsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_StudentsToolStripMenuItem7;
		internal System.Windows.Forms.ToolStripMenuItem StudentsToolStripMenuItem7 {
			get { return withEventsField_StudentsToolStripMenuItem7; }
			set {
				if (withEventsField_StudentsToolStripMenuItem7 != null) {
					withEventsField_StudentsToolStripMenuItem7.Click -= StudentsToolStripMenuItem7_Click;
				}
				withEventsField_StudentsToolStripMenuItem7 = value;
				if (withEventsField_StudentsToolStripMenuItem7 != null) {
					withEventsField_StudentsToolStripMenuItem7.Click += StudentsToolStripMenuItem7_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_StaffToolStripMenuItem2;
		internal System.Windows.Forms.ToolStripMenuItem StaffToolStripMenuItem2 {
			get { return withEventsField_StaffToolStripMenuItem2; }
			set {
				if (withEventsField_StaffToolStripMenuItem2 != null) {
					withEventsField_StaffToolStripMenuItem2.Click -= StaffToolStripMenuItem2_Click;
				}
				withEventsField_StaffToolStripMenuItem2 = value;
				if (withEventsField_StaffToolStripMenuItem2 != null) {
					withEventsField_StaffToolStripMenuItem2.Click += StaffToolStripMenuItem2_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem NoDuesDocToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_StudentsToolStripMenuItem8;
		internal System.Windows.Forms.ToolStripMenuItem StudentsToolStripMenuItem8 {
			get { return withEventsField_StudentsToolStripMenuItem8; }
			set {
				if (withEventsField_StudentsToolStripMenuItem8 != null) {
					withEventsField_StudentsToolStripMenuItem8.Click -= StudentsToolStripMenuItem8_Click;
				}
				withEventsField_StudentsToolStripMenuItem8 = value;
				if (withEventsField_StudentsToolStripMenuItem8 != null) {
					withEventsField_StudentsToolStripMenuItem8.Click += StudentsToolStripMenuItem8_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_StaffToolStripMenuItem3;
		internal System.Windows.Forms.ToolStripMenuItem StaffToolStripMenuItem3 {
			get { return withEventsField_StaffToolStripMenuItem3; }
			set {
				if (withEventsField_StaffToolStripMenuItem3 != null) {
					withEventsField_StaffToolStripMenuItem3.Click -= StaffToolStripMenuItem3_Click;
				}
				withEventsField_StaffToolStripMenuItem3 = value;
				if (withEventsField_StaffToolStripMenuItem3 != null) {
					withEventsField_StaffToolStripMenuItem3.Click += StaffToolStripMenuItem3_Click;
				}
			}

		}
		public frmMain()
		{
			FormClosing += frmMain_FormClosing;
			InitializeComponent();
		}
	}
}

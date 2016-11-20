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
	partial class frmSystemInfo : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemInfo));
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.txtProcessorFamily = new System.Windows.Forms.TextBox();
			this.txtProcessorExtClock = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtProcessorClockSpeed = new System.Windows.Forms.TextBox();
			this.txtProcessorDataWidth = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtProcessorL2CacheSize = new System.Windows.Forms.TextBox();
			this.txtProcessorManufacturer = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtProcessorDescription = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtProcessorID = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtProcessorName = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.txtBoardSerialNumber = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.txtBoardDescription = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.txtBoardManufacturer = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.txtBoardName = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.MenuStrip1.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.SuspendLayout();
			//
			//MenuStrip1
			//
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.FileToolStripMenuItem });
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new System.Drawing.Size(394, 24);
			this.MenuStrip1.TabIndex = 0;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//FileToolStripMenuItem
			//
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.SaveToFileToolStripMenuItem,
				this.ToolStripMenuItem1,
				this.ExitToolStripMenuItem
			});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.FileToolStripMenuItem.Text = "&File";
			//
			//SaveToFileToolStripMenuItem
			//
			this.SaveToFileToolStripMenuItem.Name = "SaveToFileToolStripMenuItem";
			this.SaveToFileToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.SaveToFileToolStripMenuItem.Text = "&Save to file";
			//
			//ToolStripMenuItem1
			//
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new System.Drawing.Size(128, 6);
			//
			//ExitToolStripMenuItem
			//
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.ExitToolStripMenuItem.Text = "E&xit";
			//
			//TabControl1
			//
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Location = new System.Drawing.Point(12, 27);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(370, 333);
			this.TabControl1.TabIndex = 1;
			//
			//TabPage1
			//
			this.TabPage1.Controls.Add(this.txtProcessorFamily);
			this.TabPage1.Controls.Add(this.txtProcessorExtClock);
			this.TabPage1.Controls.Add(this.Label9);
			this.TabPage1.Controls.Add(this.Label8);
			this.TabPage1.Controls.Add(this.Label7);
			this.TabPage1.Controls.Add(this.txtProcessorClockSpeed);
			this.TabPage1.Controls.Add(this.txtProcessorDataWidth);
			this.TabPage1.Controls.Add(this.Label6);
			this.TabPage1.Controls.Add(this.Label5);
			this.TabPage1.Controls.Add(this.txtProcessorL2CacheSize);
			this.TabPage1.Controls.Add(this.txtProcessorManufacturer);
			this.TabPage1.Controls.Add(this.Label4);
			this.TabPage1.Controls.Add(this.txtProcessorDescription);
			this.TabPage1.Controls.Add(this.Label3);
			this.TabPage1.Controls.Add(this.txtProcessorID);
			this.TabPage1.Controls.Add(this.Label2);
			this.TabPage1.Controls.Add(this.txtProcessorName);
			this.TabPage1.Controls.Add(this.Label1);
			this.TabPage1.Location = new System.Drawing.Point(4, 25);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(362, 304);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Processor";
			this.TabPage1.UseVisualStyleBackColor = true;
			//
			//txtProcessorFamily
			//
			this.txtProcessorFamily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProcessorFamily.Location = new System.Drawing.Point(186, 252);
			this.txtProcessorFamily.Name = "txtProcessorFamily";
			this.txtProcessorFamily.ReadOnly = true;
			this.txtProcessorFamily.Size = new System.Drawing.Size(165, 22);
			this.txtProcessorFamily.TabIndex = 37;
			this.txtProcessorFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//txtProcessorExtClock
			//
			this.txtProcessorExtClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProcessorExtClock.Location = new System.Drawing.Point(15, 252);
			this.txtProcessorExtClock.Name = "txtProcessorExtClock";
			this.txtProcessorExtClock.ReadOnly = true;
			this.txtProcessorExtClock.Size = new System.Drawing.Size(165, 22);
			this.txtProcessorExtClock.TabIndex = 36;
			this.txtProcessorExtClock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Location = new System.Drawing.Point(183, 236);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(48, 16);
			this.Label9.TabIndex = 35;
			this.Label9.Text = "Family";
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(11, 236);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(63, 16);
			this.Label8.TabIndex = 34;
			this.Label8.Text = "Ext Clock";
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(183, 195);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(74, 16);
			this.Label7.TabIndex = 33;
			this.Label7.Text = "Data Width";
			//
			//txtProcessorClockSpeed
			//
			this.txtProcessorClockSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProcessorClockSpeed.Location = new System.Drawing.Point(15, 211);
			this.txtProcessorClockSpeed.Name = "txtProcessorClockSpeed";
			this.txtProcessorClockSpeed.ReadOnly = true;
			this.txtProcessorClockSpeed.Size = new System.Drawing.Size(165, 22);
			this.txtProcessorClockSpeed.TabIndex = 32;
			this.txtProcessorClockSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//txtProcessorDataWidth
			//
			this.txtProcessorDataWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProcessorDataWidth.Location = new System.Drawing.Point(186, 211);
			this.txtProcessorDataWidth.Name = "txtProcessorDataWidth";
			this.txtProcessorDataWidth.ReadOnly = true;
			this.txtProcessorDataWidth.Size = new System.Drawing.Size(165, 22);
			this.txtProcessorDataWidth.TabIndex = 31;
			this.txtProcessorDataWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(11, 195);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(86, 16);
			this.Label6.TabIndex = 30;
			this.Label6.Text = "Clock Speed";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(183, 153);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(93, 16);
			this.Label5.TabIndex = 29;
			this.Label5.Text = "L2 Cache Size";
			//
			//txtProcessorL2CacheSize
			//
			this.txtProcessorL2CacheSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProcessorL2CacheSize.Location = new System.Drawing.Point(186, 169);
			this.txtProcessorL2CacheSize.Name = "txtProcessorL2CacheSize";
			this.txtProcessorL2CacheSize.ReadOnly = true;
			this.txtProcessorL2CacheSize.Size = new System.Drawing.Size(165, 22);
			this.txtProcessorL2CacheSize.TabIndex = 28;
			this.txtProcessorL2CacheSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//txtProcessorManufacturer
			//
			this.txtProcessorManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProcessorManufacturer.Location = new System.Drawing.Point(14, 169);
			this.txtProcessorManufacturer.Name = "txtProcessorManufacturer";
			this.txtProcessorManufacturer.ReadOnly = true;
			this.txtProcessorManufacturer.Size = new System.Drawing.Size(165, 22);
			this.txtProcessorManufacturer.TabIndex = 27;
			this.txtProcessorManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(11, 153);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(85, 16);
			this.Label4.TabIndex = 26;
			this.Label4.Text = "Manufacturer";
			//
			//txtProcessorDescription
			//
			this.txtProcessorDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProcessorDescription.Location = new System.Drawing.Point(14, 128);
			this.txtProcessorDescription.Name = "txtProcessorDescription";
			this.txtProcessorDescription.ReadOnly = true;
			this.txtProcessorDescription.Size = new System.Drawing.Size(337, 22);
			this.txtProcessorDescription.TabIndex = 25;
			this.txtProcessorDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(11, 112);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(76, 16);
			this.Label3.TabIndex = 24;
			this.Label3.Text = "Description";
			//
			//txtProcessorID
			//
			this.txtProcessorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProcessorID.Location = new System.Drawing.Point(14, 87);
			this.txtProcessorID.Name = "txtProcessorID";
			this.txtProcessorID.ReadOnly = true;
			this.txtProcessorID.Size = new System.Drawing.Size(337, 22);
			this.txtProcessorID.TabIndex = 23;
			this.txtProcessorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(11, 71);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(86, 16);
			this.Label2.TabIndex = 22;
			this.Label2.Text = "Processor ID";
			//
			//txtProcessorName
			//
			this.txtProcessorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProcessorName.Location = new System.Drawing.Point(14, 46);
			this.txtProcessorName.Name = "txtProcessorName";
			this.txtProcessorName.ReadOnly = true;
			this.txtProcessorName.Size = new System.Drawing.Size(337, 22);
			this.txtProcessorName.TabIndex = 21;
			this.txtProcessorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(11, 30);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(110, 16);
			this.Label1.TabIndex = 20;
			this.Label1.Text = "Processor Name";
			//
			//TabPage2
			//
			this.TabPage2.Controls.Add(this.txtBoardSerialNumber);
			this.TabPage2.Controls.Add(this.Label13);
			this.TabPage2.Controls.Add(this.txtBoardDescription);
			this.TabPage2.Controls.Add(this.Label12);
			this.TabPage2.Controls.Add(this.txtBoardManufacturer);
			this.TabPage2.Controls.Add(this.Label11);
			this.TabPage2.Controls.Add(this.txtBoardName);
			this.TabPage2.Controls.Add(this.Label10);
			this.TabPage2.Location = new System.Drawing.Point(4, 25);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new System.Drawing.Size(362, 304);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Motherboard";
			this.TabPage2.UseVisualStyleBackColor = true;
			//
			//txtBoardSerialNumber
			//
			this.txtBoardSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBoardSerialNumber.Location = new System.Drawing.Point(14, 235);
			this.txtBoardSerialNumber.Name = "txtBoardSerialNumber";
			this.txtBoardSerialNumber.ReadOnly = true;
			this.txtBoardSerialNumber.Size = new System.Drawing.Size(337, 22);
			this.txtBoardSerialNumber.TabIndex = 23;
			this.txtBoardSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Location = new System.Drawing.Point(11, 216);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(94, 16);
			this.Label13.TabIndex = 22;
			this.Label13.Text = "Serial Number";
			//
			//txtBoardDescription
			//
			this.txtBoardDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBoardDescription.Location = new System.Drawing.Point(14, 179);
			this.txtBoardDescription.Name = "txtBoardDescription";
			this.txtBoardDescription.ReadOnly = true;
			this.txtBoardDescription.Size = new System.Drawing.Size(337, 22);
			this.txtBoardDescription.TabIndex = 21;
			this.txtBoardDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Location = new System.Drawing.Point(11, 160);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(76, 16);
			this.Label12.TabIndex = 20;
			this.Label12.Text = "Description";
			//
			//txtBoardManufacturer
			//
			this.txtBoardManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBoardManufacturer.Location = new System.Drawing.Point(14, 123);
			this.txtBoardManufacturer.Name = "txtBoardManufacturer";
			this.txtBoardManufacturer.ReadOnly = true;
			this.txtBoardManufacturer.Size = new System.Drawing.Size(337, 22);
			this.txtBoardManufacturer.TabIndex = 19;
			this.txtBoardManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Location = new System.Drawing.Point(11, 104);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(85, 16);
			this.Label11.TabIndex = 18;
			this.Label11.Text = "Manufacturer";
			//
			//txtBoardName
			//
			this.txtBoardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBoardName.Location = new System.Drawing.Point(14, 67);
			this.txtBoardName.Name = "txtBoardName";
			this.txtBoardName.ReadOnly = true;
			this.txtBoardName.Size = new System.Drawing.Size(337, 22);
			this.txtBoardName.TabIndex = 17;
			this.txtBoardName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Location = new System.Drawing.Point(11, 48);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(125, 16);
			this.Label10.TabIndex = 16;
			this.Label10.Text = "Motherboard Name";
			//
			//frmSystemInfo
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 372);
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.MenuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MainMenuStrip = this.MenuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSystemInfo";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "System Info";
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_SaveToFileToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem SaveToFileToolStripMenuItem {
			get { return withEventsField_SaveToFileToolStripMenuItem; }
			set {
				if (withEventsField_SaveToFileToolStripMenuItem != null) {
					withEventsField_SaveToFileToolStripMenuItem.Click -= SaveToFileToolStripMenuItem_Click;
				}
				withEventsField_SaveToFileToolStripMenuItem = value;
				if (withEventsField_SaveToFileToolStripMenuItem != null) {
					withEventsField_SaveToFileToolStripMenuItem.Click += SaveToFileToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ExitToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem {
			get { return withEventsField_ExitToolStripMenuItem; }
			set {
				if (withEventsField_ExitToolStripMenuItem != null) {
					withEventsField_ExitToolStripMenuItem.Click -= ExitToolStripMenuItem_Click;
				}
				withEventsField_ExitToolStripMenuItem = value;
				if (withEventsField_ExitToolStripMenuItem != null) {
					withEventsField_ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.TextBox txtProcessorFamily;
		internal System.Windows.Forms.TextBox txtProcessorExtClock;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox txtProcessorClockSpeed;
		internal System.Windows.Forms.TextBox txtProcessorDataWidth;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtProcessorL2CacheSize;
		internal System.Windows.Forms.TextBox txtProcessorManufacturer;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox txtProcessorDescription;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtProcessorID;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtProcessorName;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtBoardSerialNumber;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.TextBox txtBoardDescription;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox txtBoardManufacturer;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.TextBox txtBoardName;

		internal System.Windows.Forms.Label Label10;
	}
}

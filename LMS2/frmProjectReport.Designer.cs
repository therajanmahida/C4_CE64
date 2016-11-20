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
	partial class frmProjectReport : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectReport));
			this.CrystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SuspendLayout();
			//
			//CrystalReportViewer1
			//
			this.CrystalReportViewer1.ActiveViewIndex = -1;
			this.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
			this.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CrystalReportViewer1.Location = new System.Drawing.Point(0, 0);
			this.CrystalReportViewer1.Name = "CrystalReportViewer1";
			this.CrystalReportViewer1.Size = new System.Drawing.Size(970, 446);
			this.CrystalReportViewer1.TabIndex = 0;
			//
			//frmProjectReport
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(970, 446);
			this.Controls.Add(this.CrystalReportViewer1);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "frmProjectReport";
			this.Text = "Project Report";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);

		}
		internal CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportViewer1;
	}
}

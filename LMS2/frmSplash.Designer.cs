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
	partial class frmSplash : System.Windows.Forms.Form
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
			this.label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.Label3 = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			//
			//label2
			//
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
			this.label2.Location = new System.Drawing.Point(208, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 22);
			this.label2.TabIndex = 5;
			this.label2.Text = "Version 1.0";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.Label1.Location = new System.Drawing.Point(36, 20);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(467, 32);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "Library Information Management System";
			//
			//ProgressBar1
			//
			this.ProgressBar1.Location = new System.Drawing.Point(0, 303);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(529, 6);
			this.ProgressBar1.TabIndex = 6;
			this.ProgressBar1.Visible = false;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.PaleTurquoise;
			this.Label3.Location = new System.Drawing.Point(79, 262);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(0, 18);
			this.Label3.TabIndex = 7;
			//
			//Timer1
			//
			this.Timer1.Enabled = true;
			//
			//frmSplash
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::LibraryManagementSystem.My.Resources.Resources.library_books_desks_bookshelf_objects_antique_2560x1600_wallpaper_wallpaperbeautiful_67;
			this.ClientSize = new System.Drawing.Size(528, 310);
			this.ControlBox = false;
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSplash";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ProgressBar ProgressBar1;
		private System.Windows.Forms.Label Label3;
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
	}
}

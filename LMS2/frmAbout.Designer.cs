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
	partial class frmAbout : System.Windows.Forms.Form
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

		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
		internal System.Windows.Forms.PictureBox LogoPictureBox;
		private System.Windows.Forms.Label withEventsField_LabelProductName;
		internal System.Windows.Forms.Label LabelProductName {
			get { return withEventsField_LabelProductName; }
			set {
				if (withEventsField_LabelProductName != null) {
					withEventsField_LabelProductName.Click -= LabelProductName_Click;
				}
				withEventsField_LabelProductName = value;
				if (withEventsField_LabelProductName != null) {
					withEventsField_LabelProductName.Click += LabelProductName_Click;
				}
			}
		}
		internal System.Windows.Forms.Label LabelVersion;
		internal System.Windows.Forms.Label LabelCompanyName;
		internal System.Windows.Forms.TextBox TextBoxDescription;
		private System.Windows.Forms.Button withEventsField_OKButton;
		internal System.Windows.Forms.Button OKButton {
			get { return withEventsField_OKButton; }
			set {
				if (withEventsField_OKButton != null) {
					withEventsField_OKButton.Click -= OKButton_Click;
				}
				withEventsField_OKButton = value;
				if (withEventsField_OKButton != null) {
					withEventsField_OKButton.Click += OKButton_Click;
				}
			}
		}

		internal System.Windows.Forms.Label LabelCopyright;
		//Required by the Windows Form Designer

		private System.ComponentModel.IContainer components;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
			this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.LogoPictureBox = new System.Windows.Forms.PictureBox();
			this.LabelProductName = new System.Windows.Forms.Label();
			this.LabelVersion = new System.Windows.Forms.Label();
			this.LabelCopyright = new System.Windows.Forms.Label();
			this.LabelCompanyName = new System.Windows.Forms.Label();
			this.TextBoxDescription = new System.Windows.Forms.TextBox();
			this.OKButton = new System.Windows.Forms.Button();
			this.TableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.LogoPictureBox).BeginInit();
			this.SuspendLayout();
			//
			//TableLayoutPanel
			//
			this.TableLayoutPanel.ColumnCount = 2;
			this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.89899f));
			this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.10101f));
			this.TableLayoutPanel.Controls.Add(this.LogoPictureBox, 0, 0);
			this.TableLayoutPanel.Controls.Add(this.LabelProductName, 1, 0);
			this.TableLayoutPanel.Controls.Add(this.LabelVersion, 1, 1);
			this.TableLayoutPanel.Controls.Add(this.LabelCopyright, 1, 2);
			this.TableLayoutPanel.Controls.Add(this.LabelCompanyName, 1, 3);
			this.TableLayoutPanel.Controls.Add(this.TextBoxDescription, 1, 4);
			this.TableLayoutPanel.Controls.Add(this.OKButton, 1, 5);
			this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel.Location = new System.Drawing.Point(9, 9);
			this.TableLayoutPanel.Name = "TableLayoutPanel";
			this.TableLayoutPanel.RowCount = 6;
			this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10f));
			this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10f));
			this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10f));
			this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10f));
			this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10f));
			this.TableLayoutPanel.Size = new System.Drawing.Size(413, 258);
			this.TableLayoutPanel.TabIndex = 0;
			//
			//LogoPictureBox
			//
			this.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LogoPictureBox.Image = global::LibraryManagementSystem.My.Resources.Resources.stock_footage_library_table_full_of_books_isolated_on_white;
			this.LogoPictureBox.Location = new System.Drawing.Point(3, 3);
			this.LogoPictureBox.Name = "LogoPictureBox";
			this.TableLayoutPanel.SetRowSpan(this.LogoPictureBox, 6);
			this.LogoPictureBox.Size = new System.Drawing.Size(158, 252);
			this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.LogoPictureBox.TabIndex = 0;
			this.LogoPictureBox.TabStop = false;
			//
			//LabelProductName
			//
			this.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelProductName.Location = new System.Drawing.Point(170, 0);
			this.LabelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.LabelProductName.MaximumSize = new System.Drawing.Size(0, 17);
			this.LabelProductName.Name = "LabelProductName";
			this.LabelProductName.Size = new System.Drawing.Size(240, 17);
			this.LabelProductName.TabIndex = 0;
			this.LabelProductName.Text = "Product Name";
			this.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//LabelVersion
			//
			this.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelVersion.Location = new System.Drawing.Point(170, 25);
			this.LabelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.LabelVersion.MaximumSize = new System.Drawing.Size(0, 17);
			this.LabelVersion.Name = "LabelVersion";
			this.LabelVersion.Size = new System.Drawing.Size(240, 17);
			this.LabelVersion.TabIndex = 0;
			this.LabelVersion.Text = "Version";
			this.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//LabelCopyright
			//
			this.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelCopyright.Location = new System.Drawing.Point(170, 50);
			this.LabelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.LabelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
			this.LabelCopyright.Name = "LabelCopyright";
			this.LabelCopyright.Size = new System.Drawing.Size(240, 17);
			this.LabelCopyright.TabIndex = 0;
			this.LabelCopyright.Text = "Copyright";
			this.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//LabelCompanyName
			//
			this.LabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelCompanyName.Location = new System.Drawing.Point(170, 75);
			this.LabelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.LabelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
			this.LabelCompanyName.Name = "LabelCompanyName";
			this.LabelCompanyName.Size = new System.Drawing.Size(240, 17);
			this.LabelCompanyName.TabIndex = 0;
			this.LabelCompanyName.Text = "Company Name";
			this.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//TextBoxDescription
			//
			this.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxDescription.Location = new System.Drawing.Point(170, 103);
			this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
			this.TextBoxDescription.Multiline = true;
			this.TextBoxDescription.Name = "TextBoxDescription";
			this.TextBoxDescription.ReadOnly = true;
			this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TextBoxDescription.Size = new System.Drawing.Size(240, 123);
			this.TextBoxDescription.TabIndex = 0;
			this.TextBoxDescription.TabStop = false;
			this.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text");
			//
			//OKButton
			//
			this.OKButton.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.OKButton.Location = new System.Drawing.Point(335, 232);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(75, 23);
			this.OKButton.TabIndex = 0;
			this.OKButton.Text = "&OK";
			//
			//frmAbout
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.OKButton;
			this.ClientSize = new System.Drawing.Size(431, 276);
			this.Controls.Add(this.TableLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAbout";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAbout";
			this.TableLayoutPanel.ResumeLayout(false);
			this.TableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.LogoPictureBox).EndInit();
			this.ResumeLayout(false);

		}

	}
}

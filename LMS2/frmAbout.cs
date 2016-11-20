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
	public sealed partial class frmAbout
	{

		private void frmAbout_Load(System.Object sender, System.EventArgs e)
		{
			// Set the title of the form.
			string ApplicationTitle = null;
			if (LibraryManagementSystem.My.MyProject.Application.Info.Title != "Rajan CE64") {
				ApplicationTitle = LibraryManagementSystem.My.MyProject.Application.Info.Title;
			} else {
				ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(LibraryManagementSystem.My.MyProject.Application.Info.AssemblyName);
			}
			this.Text = string.Format("About {0}", ApplicationTitle);
			// Initialize all of the text displayed on the About Box.
			// TODO: Customize the application's assembly information in the "Application" pane of the project 
			//    properties dialog (under the "Project" menu).
			this.LabelProductName.Text = LibraryManagementSystem.My.MyProject.Application.Info.ProductName;
			this.LabelVersion.Text = string.Format("Version {0}", LibraryManagementSystem.My.MyProject.Application.Info.Version.ToString());
			this.LabelCopyright.Text = LibraryManagementSystem.My.MyProject.Application.Info.Copyright;
			this.LabelCompanyName.Text = LibraryManagementSystem.My.MyProject.Application.Info.CompanyName;
			this.TextBoxDescription.Text = LibraryManagementSystem.My.MyProject.Application.Info.Description;
		}

		private void OKButton_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}


		private void LabelProductName_Click(object sender, EventArgs e)
		{
		}
		public frmAbout()
		{
			Load += frmAbout_Load;
			InitializeComponent();
		}
	}
}

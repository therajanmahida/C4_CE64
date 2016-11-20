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
	public partial class frmSplash
	{


		private void Timer1_Tick(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.Frmlogin.Show();
			Timer1.Enabled = false;
			this.Hide();

		}
		public frmSplash()
		{
			InitializeComponent();
		}
	}
}

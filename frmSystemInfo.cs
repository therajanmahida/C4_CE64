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
using System.IO;
namespace LibraryManagementSystem
{

	public partial class frmSystemInfo
	{

		private void MainForm_Load(System.Object sender, System.EventArgs e)
		{
			try {
				System.Management.ManagementObject i = null;
				System.Management.ManagementObjectSearcher searchInfo_Processor = new System.Management.ManagementObjectSearcher("Select * from Win32_Processor");
				foreach (System.Management.ManagementObject i_loopVariable in searchInfo_Processor.Get()) {
					i = i_loopVariable;
					txtProcessorName.Text = i["Name"].ToString();
					txtProcessorID.Text = i["ProcessorID"].ToString();
					txtProcessorDescription.Text = i["Description"].ToString();
					txtProcessorManufacturer.Text = i["Manufacturer"].ToString();
					txtProcessorL2CacheSize.Text = i["L2CacheSize"].ToString();
					txtProcessorClockSpeed.Text = i["CurrentClockSpeed"].ToString() + " Mhz";
					txtProcessorDataWidth.Text = i["DataWidth"].ToString();
					txtProcessorExtClock.Text = i["ExtClock"].ToString() + " Mhz";
					txtProcessorFamily.Text = i["Family"].ToString();
				}
				System.Management.ManagementObjectSearcher searchInfo_Board = new System.Management.ManagementObjectSearcher("Select * from Win32_BaseBoard");
				foreach (System.Management.ManagementObject i_loopVariable in searchInfo_Board.Get()) {
					i = i_loopVariable;
					txtBoardDescription.Text = i["Description"].ToString();
					txtBoardManufacturer.Text = i["Manufacturer"].ToString();
					txtBoardName.Text = i["Name"].ToString();
					txtBoardSerialNumber.Text = i["SerialNumber"].ToString();
				}
			} catch (Exception ex) {
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!");
				System.Environment.Exit(0);
			}
		}

		private void SaveToFileToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			try {
				FileStream fs = new FileStream("temp.txt", FileMode.Create, FileAccess.Write);
				StreamWriter w = new StreamWriter(fs);
				w.Write("****** Processor Information ******");
				w.WriteLine();
				w.WriteLine();
				w.WriteLine("Name");
				w.WriteLine(txtProcessorName.Text);
				w.WriteLine();
				w.WriteLine("ID");
				w.WriteLine(txtProcessorID.Text);
				w.WriteLine();
				w.WriteLine("Description");
				w.WriteLine(txtProcessorDescription.Text);
				w.WriteLine();
				w.WriteLine("Manufacturer");
				w.WriteLine(txtProcessorManufacturer.Text);
				w.WriteLine();
				w.WriteLine("L2 Cache Size");
				w.WriteLine(txtProcessorL2CacheSize.Text);
				w.WriteLine();
				w.WriteLine("Clock Speed");
				w.WriteLine(txtProcessorClockSpeed.Text);
				w.WriteLine();
				w.WriteLine("Data Width");
				w.WriteLine(txtProcessorDataWidth.Text);
				w.WriteLine();
				w.WriteLine("Ext Clock");
				w.WriteLine(txtProcessorExtClock.Text);
				w.WriteLine();
				w.WriteLine("Family");
				w.WriteLine(txtProcessorFamily.Text);
				w.WriteLine();
				w.WriteLine("****** MotherBoard Information *****");
				w.WriteLine();
				w.WriteLine("Name");
				w.WriteLine(txtBoardDescription.Text);
				w.WriteLine();
				w.WriteLine("Manufacturer");
				w.WriteLine(txtBoardManufacturer.Text);
				w.WriteLine();
				w.WriteLine("Description");
				w.WriteLine(txtBoardDescription.Text);
				w.WriteLine();
				w.WriteLine("Serial Number");
				w.WriteLine(txtBoardSerialNumber.Text);
				w.Flush();
				w.Close();
				var _with1 = SaveFileDialog1;
				_with1.AddExtension = true;
				_with1.OverwritePrompt = true;
				_with1.DefaultExt = "txt";
				_with1.InitialDirectory = LibraryManagementSystem.My.MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments;
				_with1.FileName = "SystemInfo";
				_with1.Filter = "Text files (*.txt)|*.txt|All files|*.*";
				_with1.FilterIndex = 1;
				_with1.Title = "SystemInfo - Save file";
				if (_with1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
					LibraryManagementSystem.My.MyProject.Computer.FileSystem.MoveFile("temp.txt", _with1.FileName, true);
				}
			} catch (Exception ex) {
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!");
			}
		}

		private void ExitToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			Close();
		}
		public frmSystemInfo()
		{
			Load += MainForm_Load;
			InitializeComponent();
		}
	}
}

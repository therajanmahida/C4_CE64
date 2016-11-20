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
using System.Data.OleDb;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
namespace LibraryManagementSystem
{
	public partial class frmNewsPaperRecord
	{
		OleDbDataReader rdr = null;
		DataTable dtable;
		OleDbConnection con = null;
		OleDbDataAdapter adp;
		DataSet ds;
		OleDbCommand cmd = null;
		DataTable dt = new DataTable();

		string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;";

		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT   ID, JM_Name as [Title], SubscriptionNo as [Subscription No], SubscriptionDate as [Subscription Date], Subscription, SubscriptionDateFrom as [Subscription Date From], SubscriptionDateTo as [Subscription Date To], BillNo as [Bill No], BillDate as [Bill Date], Amount, PaidOn as [Paid On], IssueNo as [Issue No],IssueDate as [Issue Date], Months as [Month], Jm_Year as [Year], Volume, V_num as [Number], DateOfReceipt as [Date Of Receipt], Supplier.SupplierName as [Supplier Name], Department, Remarks from JournalAndMagzines left join supplier on JournalAndMagzines.SupplierID=Supplier.SupplierID where IssueDate between #" + dtpDateFrom.Text + "# and #" + dtpDateTo.Text + "#  order by IssueDate desc", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "JournalAndMagzines");
				DataGridView1.DataSource = myDataSet.Tables["JournalAndMagzines"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnExportExcel_Click(System.Object sender, System.EventArgs e)
		{
			if (DataGridView1.RowCount == null) {
				MessageBox.Show("Sorry nothing to export into excel sheet.." + Constants.vbCrLf + "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			short rowsTotal = 0;
			short colsTotal = 0;
			short I = 0;
			short j = 0;
			short iC = 0;
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
			Excel.Application xlApp = new Excel.Application();
			try {
				Excel.Workbook excelBook = xlApp.Workbooks.Add();
				Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
				xlApp.Visible = true;

				rowsTotal = DataGridView1.RowCount - 1;
				colsTotal = DataGridView1.Columns.Count - 1;
				var _with1 = excelWorksheet;
				_with1.Cells.Select();
				_with1.Cells.Delete();
				for (iC = 0; iC <= colsTotal; iC++) {
					_with1.Cells(1, iC + 1).Value = DataGridView1.Columns[iC].HeaderText;
				}
				for (I = 0; I <= rowsTotal - 1; I++) {
					for (j = 0; j <= colsTotal; j++) {
						_with1.Cells(I + 2, j + 1).value = DataGridView1.Rows[I].Cells[j].Value;
					}
				}
				_with1.Rows("1:1").Font.FontStyle = "Bold";
				_with1.Rows("1:1").Font.Size = 12;

				_with1.Cells.Columns.AutoFit();
				_with1.Cells.Select();
				_with1.Cells.EntireColumn.AutoFit();
				_with1.Cells(1, 1).Select();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				//RELEASE ALLOACTED RESOURCES
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
				xlApp = null;
			}
		}
		public void Reset()
		{
			cmbPaperName.Text = "";
			dtpDateFrom.Text = DateAndTime.Today;
			dtpDateTo.Text = DateAndTime.Today;
			DataGridView1.DataSource = null;
		}
		private void btnReset_Click(System.Object sender, System.EventArgs e)
		{
			FileSystem.Reset();
		}

		private void DataGridView1_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			try {
				DataGridViewRow dr = DataGridView1.SelectedRows[0];
				this.Hide();
				My.MyProject.Forms.frmNewsPaper.Show();
				// or simply use column name instead of index
				//dr.Cells["id"].Value.ToString();
				My.MyProject.Forms.frmNewsPaper.txtID.Text = dr.Cells[0].Value.ToString();
				My.MyProject.Forms.frmNewsPaper.txtPaperName.Text = dr.Cells[1].Value.ToString();
				My.MyProject.Forms.frmNewsPaper.dtpDate.Text = dr.Cells[2].Value.ToString();
				if ((dr.Cells[3].Value.ToString() == "P")) {
					My.MyProject.Forms.frmNewsPaper.RadioButton1.Checked = true;
				}
				if ((dr.Cells[3].Value.ToString() == "A")) {
					My.MyProject.Forms.frmNewsPaper.RadioButton2.Checked = true;
				}
				My.MyProject.Forms.frmNewsPaper.txtRemarks.Text = dr.Cells[4].Value.ToString();
				My.MyProject.Forms.frmNewsPaper.btnUpdate_record.Enabled = true;
				My.MyProject.Forms.frmNewsPaper.btnDelete.Enabled = true;
				My.MyProject.Forms.frmNewsPaper.btnSave.Enabled = false;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DataGridView1_RowPostPaint(object sender, System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
		{
			string strRowNumber = (e.RowIndex + 1).ToString();
			SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
			if (DataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20))) {
				DataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
			}
			Brush b = SystemBrushes.ControlText;
			e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

		}

		private void Button1_Click_1(System.Object sender, System.EventArgs e)
		{
			try {
				if (Strings.Len(Strings.Trim(cmbPaperName.Text)) == 0) {
					MessageBox.Show("Please Select Paper Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbPaperName.Focus();
					return;
				}
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT ID,PaperName as [Paper Name],N_Date as [Date],Status,Remarks from NewsPaper where N_Date between #" + dtpDateFrom.Text + "# and #" + dtpDateTo.Text + "# and PaperName='" + cmbPaperName.Text + "'  order by N_Date", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "NewsPaper");
				DataGridView1.DataSource = myDataSet.Tables["NewsPaper"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void fillcombo()
		{
			try {
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct RTRIM(PaperName) FROM NewsPaper", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbPaperName.Items.Clear();
				foreach (DataRow drow in dtable.Rows) {
					cmbPaperName.Items.Add(drow[0].ToString());
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void frmNewsPaperRecord_Load(System.Object sender, System.EventArgs e)
		{
			fillcombo();
		}

		private void dtpDateTo_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			if ((dtpDateFrom.Value.Date) > (dtpDateTo.Value.Date)) {
				MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dtpDateTo.Focus();
			}
		}
		public frmNewsPaperRecord()
		{
			Load += frmNewsPaperRecord_Load;
			InitializeComponent();
		}
	}
}

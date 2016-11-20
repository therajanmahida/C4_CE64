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
using Excel = Microsoft.Office.Interop.Excel;
namespace LibraryManagementSystem
{
	public partial class frmBookRecord2
	{
		OleDbDataReader rdr = null;
		DataTable dtable;
		OleDbConnection con = null;
		OleDbDataAdapter adp;
		DataSet ds;
		OleDbCommand cmd = null;
		DataTable dt = new DataTable();
		string gender;

		string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;";
		private void ExportExcel_Click(System.Object sender, System.EventArgs e)
		{
			if (dataGridView1.RowCount == null) {
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

				rowsTotal = dataGridView1.RowCount - 1;
				colsTotal = dataGridView1.Columns.Count - 1;
				var _with1 = excelWorksheet;
				_with1.Cells.Select();
				_with1.Cells.Delete();
				for (iC = 0; iC <= colsTotal; iC++) {
					_with1.Cells(1, iC + 1).Value = dataGridView1.Columns[iC].HeaderText;
				}
				for (I = 0; I <= rowsTotal - 1; I++) {
					for (j = 0; j <= colsTotal; j++) {
						_with1.Cells(I + 2, j + 1).value = dataGridView1.Rows[I].Cells[j].Value;
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

		private void button7_Click(System.Object sender, System.EventArgs e)
		{
			if (dataGridView2.RowCount == null) {
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

				rowsTotal = dataGridView2.RowCount - 1;
				colsTotal = dataGridView2.Columns.Count - 1;
				var _with2 = excelWorksheet;
				_with2.Cells.Select();
				_with2.Cells.Delete();
				for (iC = 0; iC <= colsTotal; iC++) {
					_with2.Cells(1, iC + 1).Value = dataGridView2.Columns[iC].HeaderText;
				}
				for (I = 0; I <= rowsTotal - 1; I++) {
					for (j = 0; j <= colsTotal; j++) {
						_with2.Cells(I + 2, j + 1).value = dataGridView2.Rows[I].Cells[j].Value;
					}
				}
				_with2.Rows("1:1").Font.FontStyle = "Bold";
				_with2.Rows("1:1").Font.Size = 12;

				_with2.Cells.Columns.AutoFit();
				_with2.Cells.Select();
				_with2.Cells.EntireColumn.AutoFit();
				_with2.Cells(1, 1).Select();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				//RELEASE ALLOACTED RESOURCES
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
				xlApp = null;
			}
		}

		private void button1_Click(System.Object sender, System.EventArgs e)
		{
			if (dataGridView3.RowCount == null) {
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

				rowsTotal = dataGridView3.RowCount - 1;
				colsTotal = dataGridView3.Columns.Count - 1;
				var _with3 = excelWorksheet;
				_with3.Cells.Select();
				_with3.Cells.Delete();
				for (iC = 0; iC <= colsTotal; iC++) {
					_with3.Cells(1, iC + 1).Value = dataGridView3.Columns[iC].HeaderText;
				}
				for (I = 0; I <= rowsTotal - 1; I++) {
					for (j = 0; j <= colsTotal; j++) {
						_with3.Cells(I + 2, j + 1).value = dataGridView3.Rows[I].Cells[j].Value;
					}
				}
				_with3.Rows("1:1").Font.FontStyle = "Bold";
				_with3.Rows("1:1").Font.Size = 12;

				_with3.Cells.Columns.AutoFit();
				_with3.Cells.Select();
				_with3.Cells.EntireColumn.AutoFit();
				_with3.Cells(1, 1).Select();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				//RELEASE ALLOACTED RESOURCES
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
				xlApp = null;
			}
		}

		private void button3_Click(System.Object sender, System.EventArgs e)
		{
			if (dataGridView4.RowCount == null) {
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

				rowsTotal = dataGridView4.RowCount - 1;
				colsTotal = dataGridView4.Columns.Count - 1;
				var _with4 = excelWorksheet;
				_with4.Cells.Select();
				_with4.Cells.Delete();
				for (iC = 0; iC <= colsTotal; iC++) {
					_with4.Cells(1, iC + 1).Value = dataGridView4.Columns[iC].HeaderText;
				}
				for (I = 0; I <= rowsTotal - 1; I++) {
					for (j = 0; j <= colsTotal; j++) {
						_with4.Cells(I + 2, j + 1).value = dataGridView4.Rows[I].Cells[j].Value;
					}
				}
				_with4.Rows("1:1").Font.FontStyle = "Bold";
				_with4.Rows("1:1").Font.Size = 12;

				_with4.Cells.Columns.AutoFit();
				_with4.Cells.Select();
				_with4.Cells.EntireColumn.AutoFit();
				_with4.Cells(1, 1).Select();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				//RELEASE ALLOACTED RESOURCES
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
				xlApp = null;
			}
		}

		private void Button10_Click(System.Object sender, System.EventArgs e)
		{
			if (DataGridView5.RowCount == null) {
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

				rowsTotal = DataGridView5.RowCount - 1;
				colsTotal = DataGridView5.Columns.Count - 1;
				var _with5 = excelWorksheet;
				_with5.Cells.Select();
				_with5.Cells.Delete();
				for (iC = 0; iC <= colsTotal; iC++) {
					_with5.Cells(1, iC + 1).Value = DataGridView5.Columns[iC].HeaderText;
				}
				for (I = 0; I <= rowsTotal - 1; I++) {
					for (j = 0; j <= colsTotal; j++) {
						_with5.Cells(I + 2, j + 1).value = DataGridView5.Rows[I].Cells[j].Value;
					}
				}
				_with5.Rows("1:1").Font.FontStyle = "Bold";
				_with5.Rows("1:1").Font.Size = 12;

				_with5.Cells.Columns.AutoFit();
				_with5.Cells.Select();
				_with5.Cells.EntireColumn.AutoFit();
				_with5.Cells(1, 1).Select();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				//RELEASE ALLOACTED RESOURCES
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
				xlApp = null;
			}
		}

		private void Button4_Click(System.Object sender, System.EventArgs e)
		{
			if (DataGridView6.RowCount == null) {
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

				rowsTotal = DataGridView6.RowCount - 1;
				colsTotal = DataGridView6.Columns.Count - 1;
				var _with6 = excelWorksheet;
				_with6.Cells.Select();
				_with6.Cells.Delete();
				for (iC = 0; iC <= colsTotal; iC++) {
					_with6.Cells(1, iC + 1).Value = DataGridView6.Columns[iC].HeaderText;
				}
				for (I = 0; I <= rowsTotal - 1; I++) {
					for (j = 0; j <= colsTotal; j++) {
						_with6.Cells(I + 2, j + 1).value = DataGridView6.Rows[I].Cells[j].Value;
					}
				}
				_with6.Rows("1:1").Font.FontStyle = "Bold";
				_with6.Rows("1:1").Font.Size = 12;

				_with6.Cells.Columns.AutoFit();
				_with6.Cells.Select();
				_with6.Cells.EntireColumn.AutoFit();
				_with6.Cells(1, 1).Select();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				//RELEASE ALLOACTED RESOURCES
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
				xlApp = null;
			}
		}

		private void cmbBookTitle_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where bookTitle='" + cmbBookTitle.Text + "' order by BookTitle", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Book");
				dataGridView1.DataSource = myDataSet.Tables["Book"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtBookTitle_TextChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where bookTitle like '" + txtBookTitle.Text + "%' order by BookTitle", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Book");
				dataGridView1.DataSource = myDataSet.Tables["Book"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button6_Click(System.Object sender, System.EventArgs e)
		{
			cmbBookTitle.Text = "";
			txtBookTitle.Text = "";
			dataGridView1.DataSource = null;
		}

		private void cmbAuthor_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where Author='" + cmbAuthor.Text + "' order by BookTitle", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Book");
				dataGridView2.DataSource = myDataSet.Tables["Book"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtAuthor_TextChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where Author like '" + txtAuthor.Text + "%' order by BookTitle", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Book");
				dataGridView2.DataSource = myDataSet.Tables["Book"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button9_Click(System.Object sender, System.EventArgs e)
		{
			txtAuthor.Text = "";
			txtJointAuthors.Text = "";
			cmbAuthor.Text = "";
			dataGridView2.DataSource = null;
		}

		private void cmbAccessionNo_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where AccessionNo='" + cmbAccessionNo.Text + "' order by BookTitle", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Book");
				dataGridView3.DataSource = myDataSet.Tables["Book"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtAccessionNo_TextChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where AccessionNo like '" + txtAccessionNo.Text + "%' order by BookTitle", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Book");
				dataGridView3.DataSource = myDataSet.Tables["Book"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button2_Click(System.Object sender, System.EventArgs e)
		{
			txtAccessionNo.Text = "";
			cmbAccessionNo.Text = "";
			dataGridView3.DataSource = null;
		}

		private void cmbSubject_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where Subject='" + cmbSubject.Text + "' order by BookTitle", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Book");
				dataGridView4.DataSource = myDataSet.Tables["Book"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtSubject_TextChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where Subject like '" + txtSubject.Text + "%' order by BookTitle", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Book");
				dataGridView4.DataSource = myDataSet.Tables["Book"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button8_Click(System.Object sender, System.EventArgs e)
		{
			txtSubject.Text = "";
			cmbSubject.Text = "";
			dataGridView4.DataSource = null;
		}

		private void Button12_Click(System.Object sender, System.EventArgs e)
		{
			txtPOP.Text = "";
			cmbPOP.Text = "";
			DataGridView5.DataSource = null;
		}

		private void Button11_Click(System.Object sender, System.EventArgs e)
		{
			txtDepartment.Text = "";
			cmbDepartment.Text = "";
			DataGridView6.DataSource = null;
		}

		private void tabControl1_Click(System.Object sender, System.EventArgs e)
		{
			Clear();
		}
		public void Clear()
		{
			DataGridView8.DataSource = null;
			cmbRfBook.Text = "";
			txtRFBooks.Text = "";
			DataGridView7.DataSource = null;
			txtPOP.Text = "";
			cmbPOP.Text = "";
			DataGridView5.DataSource = null;
			txtDepartment.Text = "";
			cmbDepartment.Text = "";
			DataGridView6.DataSource = null;
			txtSubject.Text = "";
			cmbSubject.Text = "";
			dataGridView4.DataSource = null;
			txtAccessionNo.Text = "";
			cmbAccessionNo.Text = "";
			dataGridView3.DataSource = null;
			txtAuthor.Text = "";
			txtJointAuthors.Text = "";
			cmbAuthor.Text = "";
			dataGridView2.DataSource = null;
			cmbBookTitle.Text = "";
			txtBookTitle.Text = "";
			dataGridView1.DataSource = null;
		}

		private void cmbPOP_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks as [No Of Books], AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date], Remarks from book where PlaceOfPublisher= '" + cmbPOP.Text + "' order by BookTitle", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Book");
				DataGridView5.DataSource = myDataSet.Tables["Book"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtPOP_TextChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where PlaceOfPublisher like '" + txtPOP.Text + "%' order by BookTitle", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Book");
				DataGridView5.DataSource = myDataSet.Tables["Book"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtDepartment_TextChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where Department like '" + txtDepartment.Text + "%' order by BookTitle", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Book");
				DataGridView6.DataSource = myDataSet.Tables["Book"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmbDepartment_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where Department= '" + cmbDepartment.Text + "' order by BookTitle", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Book");
				DataGridView6.DataSource = myDataSet.Tables["Book"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void fillSubject()
		{
			try {
				cmbSubject.DataSource = null;
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct Subject FROM Book where subject is not null", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbSubject.DisplayMember = "Subject";
				cmbSubject.DataSource = dtable;
				cmbSubject.SelectedIndex = -1;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void fillBookTitle()
		{
			try {
				cmbBookTitle.DataSource = null;
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct BookTitle FROM Book where BookTitle is not null", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbBookTitle.DisplayMember = "BookTitle";
				cmbBookTitle.DataSource = dtable;
				cmbBookTitle.SelectedIndex = -1;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void fillAuthor()
		{
			try {
				cmbAuthor.DataSource = null;
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct Author FROM Book where Author is not null", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbAuthor.DisplayMember = "Author";
				cmbAuthor.DataSource = dtable;
				cmbAuthor.SelectedIndex = -1;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void fillAccessionNo()
		{
			try {
				cmbAccessionNo.DataSource = null;
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct AccessionNo FROM Book where AccessionNo is not null", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbAccessionNo.DisplayMember = "AccessionNo";
				cmbAccessionNo.DataSource = dtable;
				cmbAccessionNo.SelectedIndex = -1;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void fillPOP()
		{
			try {
				cmbPOP.DataSource = null;
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct PlaceOfPublisher FROM Book where PlaceOfPublisher is not null", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbPOP.DisplayMember = "PlaceOfPublisher";
				cmbPOP.DataSource = dtable;
				cmbPOP.SelectedIndex = -1;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void fillDepartment()
		{
			try {
				cmbDepartment.DataSource = null;
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct Department FROM Book where Department is not null", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbDepartment.DisplayMember = "Department";
				cmbDepartment.DataSource = dtable;
				cmbDepartment.SelectedIndex = -1;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void frmBookRecord_Load(System.Object sender, System.EventArgs e)
		{
			fillAccessionNo();
			fillAuthor();
			fillBookTitle();
			fillDepartment();
			fillPOP();
			fillSubject();
			fillReferenceBook();
			Clear();
		}

		private void dataGridView1_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			try {
				DataGridViewRow dr = dataGridView1.SelectedRows[0];
				this.Hide();
				My.MyProject.Forms.frmBookIssue.Show();
				// or simply use column name instead of index
				//dr.Cells["id"].Value.ToString();
				My.MyProject.Forms.frmBookIssue.cmbAccessionNo.Text = dr.Cells[0].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtBookTitle.Text = dr.Cells[1].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtAuthor.Text = dr.Cells[2].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtCategory.Text = dr.Cells[4].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtISBN.Text = dr.Cells[7].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtEdition.Text = dr.Cells[9].Value.ToString();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dataGridView1_RowPostPaint(object sender, System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
		{
			string strRowNumber = (e.RowIndex + 1).ToString();
			SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
			if (dataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20))) {
				dataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
			}
			Brush b = SystemBrushes.ControlText;
			e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

		}

		private void dataGridView2_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			try {
				DataGridViewRow dr = dataGridView2.SelectedRows[0];
				this.Hide();
				My.MyProject.Forms.frmBookIssue.Show();
				// or simply use column name instead of index
				//dr.Cells["id"].Value.ToString();
				My.MyProject.Forms.frmBookIssue.cmbAccessionNo.Text = dr.Cells[0].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtBookTitle.Text = dr.Cells[1].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtAuthor.Text = dr.Cells[2].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtCategory.Text = dr.Cells[4].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtISBN.Text = dr.Cells[7].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtEdition.Text = dr.Cells[9].Value.ToString();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void dataGridView2_RowPostPaint(object sender, System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
		{
			string strRowNumber = (e.RowIndex + 1).ToString();
			SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
			if (dataGridView2.RowHeadersWidth < Convert.ToInt32((size.Width + 20))) {
				dataGridView2.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
			}
			Brush b = SystemBrushes.ControlText;
			e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

		}

		private void dataGridView3_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			try {
				DataGridViewRow dr = dataGridView3.SelectedRows[0];
				this.Hide();
				My.MyProject.Forms.frmBookIssue.Show();
				// or simply use column name instead of index
				//dr.Cells["id"].Value.ToString();
				My.MyProject.Forms.frmBookIssue.cmbAccessionNo.Text = dr.Cells[0].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtBookTitle.Text = dr.Cells[1].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtAuthor.Text = dr.Cells[2].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtCategory.Text = dr.Cells[4].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtISBN.Text = dr.Cells[7].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtEdition.Text = dr.Cells[9].Value.ToString();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dataGridView3_RowPostPaint(object sender, System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
		{
			string strRowNumber = (e.RowIndex + 1).ToString();
			SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
			if (dataGridView3.RowHeadersWidth < Convert.ToInt32((size.Width + 20))) {
				dataGridView3.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
			}
			Brush b = SystemBrushes.ControlText;
			e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

		}

		private void dataGridView4_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			try {
				DataGridViewRow dr = dataGridView4.SelectedRows[0];
				this.Hide();
				My.MyProject.Forms.frmBookIssue.Show();
				// or simply use column name instead of index
				//dr.Cells["id"].Value.ToString();
				My.MyProject.Forms.frmBookIssue.cmbAccessionNo.Text = dr.Cells[0].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtBookTitle.Text = dr.Cells[1].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtAuthor.Text = dr.Cells[2].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtCategory.Text = dr.Cells[4].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtISBN.Text = dr.Cells[7].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtEdition.Text = dr.Cells[9].Value.ToString();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dataGridView4_RowPostPaint(object sender, System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
		{
			string strRowNumber = (e.RowIndex + 1).ToString();
			SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
			if (dataGridView4.RowHeadersWidth < Convert.ToInt32((size.Width + 20))) {
				dataGridView4.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
			}
			Brush b = SystemBrushes.ControlText;
			e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

		}

		private void DataGridView5_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			try {
				DataGridViewRow dr = DataGridView5.SelectedRows[0];
				this.Hide();
				My.MyProject.Forms.frmBookIssue.Show();
				// or simply use column name instead of index
				//dr.Cells["id"].Value.ToString();
				My.MyProject.Forms.frmBookIssue.cmbAccessionNo.Text = dr.Cells[0].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtBookTitle.Text = dr.Cells[1].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtAuthor.Text = dr.Cells[2].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtCategory.Text = dr.Cells[4].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtISBN.Text = dr.Cells[7].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtEdition.Text = dr.Cells[9].Value.ToString();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DataGridView5_RowPostPaint(object sender, System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
		{
			string strRowNumber = (e.RowIndex + 1).ToString();
			SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
			if (DataGridView5.RowHeadersWidth < Convert.ToInt32((size.Width + 20))) {
				DataGridView5.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
			}
			Brush b = SystemBrushes.ControlText;
			e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

		}

		private void DataGridView6_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			try {
				DataGridViewRow dr = DataGridView6.SelectedRows[0];
				this.Hide();
				My.MyProject.Forms.frmBookIssue.Show();
				// or simply use column name instead of index
				//dr.Cells["id"].Value.ToString();
				My.MyProject.Forms.frmBookIssue.cmbAccessionNo.Text = dr.Cells[0].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtBookTitle.Text = dr.Cells[1].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtAuthor.Text = dr.Cells[2].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtCategory.Text = dr.Cells[4].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtISBN.Text = dr.Cells[7].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtEdition.Text = dr.Cells[9].Value.ToString();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void DataGridView6_RowPostPaint(object sender, System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
		{
			string strRowNumber = (e.RowIndex + 1).ToString();
			SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
			if (DataGridView6.RowHeadersWidth < Convert.ToInt32((size.Width + 20))) {
				DataGridView6.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
			}
			Brush b = SystemBrushes.ControlText;
			e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
		}


		private void txtJointAuthors_TextChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  where JointAuthors like '%" + txtJointAuthors.Text + "%' order by BookTitle", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Book");
				dataGridView2.DataSource = myDataSet.Tables["Book"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DataGridView7_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			try {
				DataGridViewRow dr = DataGridView7.SelectedRows[0];
				this.Hide();
				My.MyProject.Forms.frmBookIssue.Show();
				// or simply use column name instead of index
				//dr.Cells["id"].Value.ToString();
				My.MyProject.Forms.frmBookIssue.cmbAccessionNo.Text = dr.Cells[0].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtBookTitle.Text = dr.Cells[1].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtAuthor.Text = dr.Cells[2].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtCategory.Text = dr.Cells[4].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtISBN.Text = dr.Cells[7].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtEdition.Text = dr.Cells[9].Value.ToString();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DataGridView7_RowPostPaint(object sender, System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
		{
			string strRowNumber = (e.RowIndex + 1).ToString();
			SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
			if (DataGridView7.RowHeadersWidth < Convert.ToInt32((size.Width + 20))) {
				DataGridView7.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
			}
			Brush b = SystemBrushes.ControlText;
			e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

		}

		private void DataGridView8_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			try {
				DataGridViewRow dr = DataGridView8.SelectedRows[0];
				this.Hide();
				My.MyProject.Forms.frmBookIssue.Show();
				// or simply use column name instead of index
				//dr.Cells["id"].Value.ToString();
				My.MyProject.Forms.frmBookIssue.cmbAccessionNo.Text = dr.Cells[0].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtBookTitle.Text = dr.Cells[1].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtAuthor.Text = dr.Cells[2].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtCategory.Text = dr.Cells[4].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtISBN.Text = dr.Cells[7].Value.ToString();
				My.MyProject.Forms.frmBookIssue.txtEdition.Text = dr.Cells[9].Value.ToString();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DataGridView8_RowPostPaint(object sender, System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
		{
			string strRowNumber = (e.RowIndex + 1).ToString();
			SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
			if (DataGridView8.RowHeadersWidth < Convert.ToInt32((size.Width + 20))) {
				DataGridView8.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
			}
			Brush b = SystemBrushes.ControlText;
			e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

		}

		private void Button5_Click(System.Object sender, System.EventArgs e)
		{
			if (DataGridView7.RowCount == null) {
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

				rowsTotal = DataGridView7.RowCount - 1;
				colsTotal = DataGridView7.Columns.Count - 1;
				var _with7 = excelWorksheet;
				_with7.Cells.Select();
				_with7.Cells.Delete();
				for (iC = 0; iC <= colsTotal; iC++) {
					_with7.Cells(1, iC + 1).Value = DataGridView7.Columns[iC].HeaderText;
				}
				for (I = 0; I <= rowsTotal - 1; I++) {
					for (j = 0; j <= colsTotal; j++) {
						_with7.Cells(I + 2, j + 1).value = DataGridView7.Rows[I].Cells[j].Value;
					}
				}
				_with7.Rows("1:1").Font.FontStyle = "Bold";
				_with7.Rows("1:1").Font.Size = 12;

				_with7.Cells.Columns.AutoFit();
				_with7.Cells.Select();
				_with7.Cells.EntireColumn.AutoFit();
				_with7.Cells(1, 1).Select();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				//RELEASE ALLOACTED RESOURCES
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
				xlApp = null;
			}
		}

		private void Button14_Click(System.Object sender, System.EventArgs e)
		{
			if (DataGridView8.RowCount == null) {
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

				rowsTotal = DataGridView8.RowCount - 1;
				colsTotal = DataGridView8.Columns.Count - 1;
				var _with8 = excelWorksheet;
				_with8.Cells.Select();
				_with8.Cells.Delete();
				for (iC = 0; iC <= colsTotal; iC++) {
					_with8.Cells(1, iC + 1).Value = DataGridView8.Columns[iC].HeaderText;
				}
				for (I = 0; I <= rowsTotal - 1; I++) {
					for (j = 0; j <= colsTotal; j++) {
						_with8.Cells(I + 2, j + 1).value = DataGridView8.Rows[I].Cells[j].Value;
					}
				}
				_with8.Rows("1:1").Font.FontStyle = "Bold";
				_with8.Rows("1:1").Font.Size = 12;

				_with8.Cells.Columns.AutoFit();
				_with8.Cells.Select();
				_with8.Cells.EntireColumn.AutoFit();
				_with8.Cells(1, 1).Select();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				//RELEASE ALLOACTED RESOURCES
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
				xlApp = null;
			}
		}

		private void Button16_Click(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book  order by BookTitle", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Book");
				DataGridView8.DataSource = myDataSet.Tables["Book"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Button15_Click(System.Object sender, System.EventArgs e)
		{
			DataGridView8.DataSource = null;
		}

		private void txtRFBooks_TextChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book where reference > 0 and BookTitle like '" + txtRFBooks.Text + "%' order by BookTitle", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Book");
				DataGridView7.DataSource = myDataSet.Tables["Book"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmbRfBook_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT AccessionNo as [Accession No], BookTitle as [Book Title], Author, JointAuthors as [Joint Authors], Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo as [Class No], Publisher, PlaceOfPublisher as [Place Of Publisher], CD,PublishingYear as [Publishing Year], Reference, NoOfBooks, AlmiraPosition as [Almira Position], Price, BillDate as [Bill Date],SupplierName,Remarks from book where reference > 0 and BookTitle = '" + cmbRfBook.Text + "' order by BookTitle", con);
				OleDbDataAdapter myDA = new OleDbDataAdapter(cmd);
				DataSet myDataSet = new DataSet();
				myDA.Fill(myDataSet, "Book");
				DataGridView7.DataSource = myDataSet.Tables["Book"].DefaultView;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void fillReferenceBook()
		{
			try {
				cmbRfBook.DataSource = null;
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct BookTitle FROM Book where Reference > 0", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbRfBook.DisplayMember = "BookTitle";
				cmbRfBook.DataSource = dtable;
				cmbRfBook.SelectedIndex = -1;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void Button13_Click(System.Object sender, System.EventArgs e)
		{
			cmbRfBook.Text = "";
			txtRFBooks.Text = "";
			DataGridView7.DataSource = null;
		}
		public frmBookRecord2()
		{
			Load += frmBookRecord_Load;
			InitializeComponent();
		}
	}
}

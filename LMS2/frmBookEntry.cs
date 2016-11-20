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
namespace LibraryManagementSystem
{
	public partial class frmBookEntry
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
		public void fillSupplier()
		{
			try {
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct RTRIM(SupplierName) FROM Supplier", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbSupplierName.Items.Clear();
				foreach (DataRow drow in dtable.Rows) {
					cmbSupplierName.Items.Add(drow[0].ToString());
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void fillDepartment()
		{
			try {
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct RTRIM(Departmentname) FROM Department", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbDepartment.Items.Clear();
				foreach (DataRow drow in dtable.Rows) {
					cmbDepartment.Items.Add(drow[0].ToString());
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void fillSubject()
		{
			try {
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct RTRIM(Subject) FROM Book", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbSubject.Items.Clear();
				foreach (DataRow drow in dtable.Rows) {
					cmbSubject.Items.Add(drow[0].ToString());
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookRecord1.Show();
		}
		public void Reset()
		{
			txtAccessionNo.Text = "";
			txtAlmiraPosition.Text = "";
			txtAuthor.Text = "";
			txtBarcode.Text = "";
			txtBookTitle.Text = "";
			txtCD.Text = "";
			txtClassNo.Text = "";
			txtEdition.Text = "";
			txtISBN.Text = "";
			txtJointAuthor.Text = "";
			txtNoOfBooks.Text = "";
			txtPlaceOfPublisher.Text = "";
			txtPrice.Text = "";
			txtPublisherName.Text = "";
			txtPublishingYear.Text = "";
			txtReference.Text = "";
			txtRemarks.Text = "";
			txtVolume.Text = "";
			cmbDepartment.SelectedIndex = -1;
			cmbSubject.Text = "";
			cmbSupplierName.Text = "";
			dtpBillDate.Text = DateAndTime.Today;
			btnDelete.Enabled = false;
			btnUpdate_record.Enabled = false;
			btnSave.Enabled = true;
			txtAccessionNo.Focus();
		}
		public void AutocompleteBookTitle()
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				OleDbCommand cmd = new OleDbCommand("SELECT distinct BookTitle FROM Book", con);
				DataSet ds = new DataSet();
				OleDbDataAdapter da = new OleDbDataAdapter(cmd);
				da.Fill(ds, "ds");
				AutoCompleteStringCollection col = new AutoCompleteStringCollection();
				int i = 0;
				for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++) {
					col.Add(ds.Tables[0].Rows[i]["BookTitle"].ToString());
				}
				txtBookTitle.AutoCompleteSource = AutoCompleteSource.CustomSource;
				txtBookTitle.AutoCompleteCustomSource = col;
				txtBookTitle.AutoCompleteMode = AutoCompleteMode.Suggest;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void AutocompleteJointAuthors()
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				OleDbCommand cmd = new OleDbCommand("SELECT distinct JointAuthors FROM Book", con);
				DataSet ds = new DataSet();
				OleDbDataAdapter da = new OleDbDataAdapter(cmd);
				da.Fill(ds, "ds");
				AutoCompleteStringCollection col = new AutoCompleteStringCollection();
				int i = 0;
				for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++) {
					col.Add(ds.Tables[0].Rows[i]["JointAuthors"].ToString());
				}
				txtJointAuthor.AutoCompleteSource = AutoCompleteSource.CustomSource;
				txtJointAuthor.AutoCompleteCustomSource = col;
				txtJointAuthor.AutoCompleteMode = AutoCompleteMode.Suggest;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void AutocompleteAuthor()
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				OleDbCommand cmd = new OleDbCommand("SELECT distinct Author FROM Book", con);
				DataSet ds = new DataSet();
				OleDbDataAdapter da = new OleDbDataAdapter(cmd);
				da.Fill(ds, "ds");
				AutoCompleteStringCollection col = new AutoCompleteStringCollection();
				int i = 0;
				for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++) {
					col.Add(ds.Tables[0].Rows[i]["Author"].ToString());
				}
				txtAuthor.AutoCompleteSource = AutoCompleteSource.CustomSource;
				txtAuthor.AutoCompleteCustomSource = col;
				txtAuthor.AutoCompleteMode = AutoCompleteMode.Suggest;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void AutocompletePublisher()
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				OleDbCommand cmd = new OleDbCommand("SELECT distinct Publisher FROM Book", con);
				DataSet ds = new DataSet();
				OleDbDataAdapter da = new OleDbDataAdapter(cmd);
				da.Fill(ds, "ds");
				AutoCompleteStringCollection col = new AutoCompleteStringCollection();
				int i = 0;
				for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++) {
					col.Add(ds.Tables[0].Rows[i]["Publisher"].ToString());
				}
				txtPublisherName.AutoCompleteSource = AutoCompleteSource.CustomSource;
				txtPublisherName.AutoCompleteCustomSource = col;
				txtPublisherName.AutoCompleteMode = AutoCompleteMode.Suggest;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void AutocompletePlaceOfPublisher()
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				OleDbCommand cmd = new OleDbCommand("SELECT distinct PlaceOfPublisher FROM Book", con);
				DataSet ds = new DataSet();
				OleDbDataAdapter da = new OleDbDataAdapter(cmd);
				da.Fill(ds, "ds");
				AutoCompleteStringCollection col = new AutoCompleteStringCollection();
				int i = 0;
				for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++) {
					col.Add(ds.Tables[0].Rows[i]["PlaceOfPublisher"].ToString());
				}
				txtPlaceOfPublisher.AutoCompleteSource = AutoCompleteSource.CustomSource;
				txtPlaceOfPublisher.AutoCompleteCustomSource = col;
				txtPlaceOfPublisher.AutoCompleteMode = AutoCompleteMode.Suggest;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void AutocompleteAccessionNo()
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				OleDbCommand cmd = new OleDbCommand("SELECT distinct AccessionNo FROM Book", con);
				DataSet ds = new DataSet();
				OleDbDataAdapter da = new OleDbDataAdapter(cmd);
				da.Fill(ds, "ds");
				AutoCompleteStringCollection col = new AutoCompleteStringCollection();
				int i = 0;
				for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++) {
					col.Add(ds.Tables[0].Rows[i]["AccessionNo"].ToString());
				}
				txtAccessionNo.AutoCompleteSource = AutoCompleteSource.CustomSource;
				txtAccessionNo.AutoCompleteCustomSource = col;
				txtAccessionNo.AutoCompleteMode = AutoCompleteMode.Suggest;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void frmBookEntry_Load(System.Object sender, System.EventArgs e)
		{
			fillDepartment();
			fillSubject();
			fillSupplier();
			AutocompleteAccessionNo();
			AutocompleteBookTitle();
			AutocompleteJointAuthors();
			AutocompletePlaceOfPublisher();
			AutocompletePublisher();
			AutocompleteAuthor();
		}

		private void btnNewRecord_Click(System.Object sender, System.EventArgs e)
		{
			FileSystem.Reset();
		}

		private void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (Strings.Len(Strings.Trim(txtAccessionNo.Text)) == 0) {
					MessageBox.Show("Please enter Accession no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtAccessionNo.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtBookTitle.Text)) == 0) {
					MessageBox.Show("Please enter book title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtBookTitle.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtAuthor.Text)) == 0) {
					MessageBox.Show("Please enter author name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtAuthor.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbSubject.Text)) == 0) {
					MessageBox.Show("Please enetr/select subject", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbSubject.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbDepartment.Text)) == 0) {
					MessageBox.Show("Please select department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbDepartment.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtEdition.Text)) == 0) {
					MessageBox.Show("Please enter edition", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtEdition.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtPublisherName.Text)) == 0) {
					MessageBox.Show("Please enter publisher name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtPublisherName.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtPlaceOfPublisher.Text)) == 0) {
					MessageBox.Show("Please enter place of  publisher", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtPlaceOfPublisher.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtNoOfBooks.Text)) == 0) {
					MessageBox.Show("Please enter no. of books", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtNoOfBooks.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtAlmiraPosition.Text)) == 0) {
					MessageBox.Show("Please enter almira position", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtAlmiraPosition.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtPrice.Text)) == 0) {
					MessageBox.Show("Please enter price", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtPrice.Focus();
					return;
				}
				if ((string.IsNullOrEmpty(txtReference.Text))) {
					txtReference.Text = 0;
				}
				if (Strings.Len(Strings.Trim(cmbSupplierName.Text)) == 0) {
					MessageBox.Show("Please select supplier", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbSupplierName.Focus();
					return;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "select AccessionNo from Book where AccessionNo='" + txtAccessionNo.Text + "'";
				cmd = new OleDbCommand(ct);
				cmd.Connection = con;
				rdr = cmd.ExecuteReader();
				if (rdr.Read()) {
					MessageBox.Show("Accession no. already exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtAccessionNo.Text = "";
					txtAccessionNo.Focus();
					if ((rdr != null)) {
						rdr.Close();
					}
					return;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "insert into Book(AccessionNo, BookTitle, Author, JointAuthors, Subject, Department, Barcode, ISBN, Volume, Edition, ClassNo, Publisher, PlaceOfPublisher, CD,PublishingYear, Reference, NoOfBooks, AlmiraPosition, Price, BillDate, Remarks,SupplierName) VALUES('" + txtAccessionNo.Text + "','" + txtBookTitle.Text + "','" + txtAuthor.Text + "','" + txtJointAuthor.Text + "','" + cmbSubject.Text + "','" + cmbDepartment.Text + "','" + txtBarcode.Text + "','" + txtISBN.Text + "','" + txtVolume.Text + "','" + txtEdition.Text + "','" + txtClassNo.Text + "','" + txtPublisherName.Text + "','" + txtPlaceOfPublisher.Text + "','" + txtCD.Text + "','" + txtPublishingYear.Text + "'," + txtReference.Text + "," + txtNoOfBooks.Text + ",'" + txtAlmiraPosition.Text + "'," + txtPrice.Text + ",#" + dtpBillDate.Text + "#,'" + txtRemarks.Text + "','" + cmbSupplierName.Text + "')";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Successfully saved", "Book Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				fillSubject();
				AutocompleteAccessionNo();
				AutocompleteBookTitle();
				AutocompleteJointAuthors();
				AutocompletePlaceOfPublisher();
				AutocompletePublisher();
				AutocompleteAuthor();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDelete_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes) {
					DeleteRecord();
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void DeleteRecord()
		{
			try {
				int RowsAffected = 0;
				con = new OleDbConnection(cs);
				con.Open();
				string cq = "delete from Book where AccessionNo= '" + txtAccessionNo.Text + "'";
				cmd = new OleDbCommand(cq);
				cmd.Connection = con;
				RowsAffected = cmd.ExecuteNonQuery();
				if (RowsAffected > 0) {
					MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
					fillSubject();
					FileSystem.Reset();
				} else {
					MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
					fillSubject();
					AutocompleteAccessionNo();
					AutocompleteBookTitle();
					AutocompleteJointAuthors();
					AutocompletePlaceOfPublisher();
					AutocompletePublisher();
					AutocompleteAuthor();
					FileSystem.Reset();
					if (con.State == ConnectionState.Open) {
						con.Close();
					}
					con.Close();
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnUpdate_record_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (Strings.Len(Strings.Trim(txtAccessionNo.Text)) == 0) {
					MessageBox.Show("Please enter Accession no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtAccessionNo.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtBookTitle.Text)) == 0) {
					MessageBox.Show("Please enter book title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtBookTitle.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtAuthor.Text)) == 0) {
					MessageBox.Show("Please enter author name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtAuthor.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbSubject.Text)) == 0) {
					MessageBox.Show("Please enetr/select subject", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbSubject.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbDepartment.Text)) == 0) {
					MessageBox.Show("Please select department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbDepartment.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtEdition.Text)) == 0) {
					MessageBox.Show("Please enter edition", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtEdition.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtPublisherName.Text)) == 0) {
					MessageBox.Show("Please enter publisher name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtPublisherName.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtNoOfBooks.Text)) == 0) {
					MessageBox.Show("Please enter no. of books", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtNoOfBooks.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtAlmiraPosition.Text)) == 0) {
					MessageBox.Show("Please enter almira position", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtAlmiraPosition.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtPrice.Text)) == 0) {
					MessageBox.Show("Please enter price", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtPrice.Focus();
					return;
				}
				if ((string.IsNullOrEmpty(txtReference.Text))) {
					txtReference.Text = 0;
				}
				if (Strings.Len(Strings.Trim(cmbSupplierName.Text)) == 0) {
					MessageBox.Show("Please select supplier", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbSupplierName.Focus();
					return;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "update Book set AccessionNo='" + txtAccessionNo.Text + "', BookTitle='" + txtBookTitle.Text + "',Author='" + txtAuthor.Text + "',JointAuthors='" + txtJointAuthor.Text + "',Subject='" + cmbSubject.Text + "',Department='" + cmbDepartment.Text + "',Barcode='" + txtBarcode.Text + "',ISBN='" + txtISBN.Text + "',Volume='" + txtVolume.Text + "',Edition='" + txtEdition.Text + "',ClassNo='" + txtClassNo.Text + "',Publisher='" + txtPublisherName.Text + "',PlaceOfPublisher='" + txtPlaceOfPublisher.Text + "',CD='" + txtCD.Text + "',PublishingYear='" + txtPublishingYear.Text + "',Reference=" + txtReference.Text + ",NoOfBooks=" + txtNoOfBooks.Text + ",AlmiraPosition='" + txtAlmiraPosition.Text + "',Price=" + txtPrice.Text + ",BillDate=#" + dtpBillDate.Text + "#,Remarks='" + txtRemarks.Text + "',SupplierName='" + cmbSupplierName.Text + "' where AccessionNo='" + TextBox1.Text + "'";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Successfully updated", "Book Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnUpdate_record.Enabled = false;
				fillSubject();
				AutocompleteAccessionNo();
				AutocompleteBookTitle();
				AutocompleteJointAuthors();
				AutocompletePlaceOfPublisher();
				AutocompletePublisher();
				AutocompleteAuthor();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtPublishingYear_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar < Strings.Chr(48) | e.KeyChar > Strings.Chr(57)) & e.KeyChar != Strings.Chr(8)) {
				e.Handled = true;
			}
		}

		private void txtCD_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar < Strings.Chr(48) | e.KeyChar > Strings.Chr(57)) & e.KeyChar != Strings.Chr(8)) {
				e.Handled = true;
			}
		}

		private void txtReference_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar < Strings.Chr(48) | e.KeyChar > Strings.Chr(57)) & e.KeyChar != Strings.Chr(8)) {
				e.Handled = true;
			}
		}

		private void txtNoOfBooks_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar < Strings.Chr(48) | e.KeyChar > Strings.Chr(57)) & e.KeyChar != Strings.Chr(8)) {
				e.Handled = true;
			}
		}

		private void txtPrice_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar < Strings.Chr(48) | e.KeyChar > Strings.Chr(57)) & e.KeyChar != Strings.Chr(8)) {
				e.Handled = true;
			}
		}

		private void Button1_Click_1(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookRecord1.Show();
			My.MyProject.Forms.frmBookRecord1.Clear();
			My.MyProject.Forms.frmBookRecord1.fillAccessionNo();
			My.MyProject.Forms.frmBookRecord1.fillAuthor();
			My.MyProject.Forms.frmBookRecord1.fillDepartment();
			My.MyProject.Forms.frmBookRecord1.fillBookTitle();
			My.MyProject.Forms.frmBookRecord1.fillPOP();
			My.MyProject.Forms.frmBookRecord1.fillSubject();
			My.MyProject.Forms.frmBookRecord1.fillReferenceBook();
		}
		public frmBookEntry()
		{
			Load += frmBookEntry_Load;
			InitializeComponent();
		}
	}
}

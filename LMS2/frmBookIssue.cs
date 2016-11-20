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
using System.Security.Cryptography;
using System.Text;
namespace LibraryManagementSystem
{
	public partial class frmBookIssue
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
		public static string GetUniqueKey(int maxSize)
		{
			char[] chars = new char[62];
			chars = "123456789".ToCharArray();
			byte[] data = new byte[1];
			RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
			crypto.GetNonZeroBytes(data);
			data = new byte[maxSize];
			crypto.GetNonZeroBytes(data);
			StringBuilder result = new StringBuilder(maxSize);
			foreach (byte b in data) {
				result.Append(chars[b % (chars.Length)]);
			}
			return result.ToString();
		}
		public void Reset()
		{
			cmbStudentID.Text = "";
			txtTransactionID.Text = "";
			txtAuthor.Text = "";
			txtBookTitle.Text = "";
			txtCategory.Text = "";
			txtDepartment.Text = "";
			txtEdition.Text = "";
			txtISBN.Text = "";
			txtCourse.Text = "";
			txtStudentName.Text = "";
			cmbAccessionNo.Text = "";
			dtpDueDate.Text = "";
			dtpIssueDate.Text = "";
			btnSave.Enabled = true;
			btnDelete.Enabled = false;
			btnUpdate_record.Enabled = false;
		}
		public void Reset1()
		{
			cmbStaffID.Text = "";
			txtTransactionID1.Text = "";
			txtAuthor1.Text = "";
			txtBookTitle1.Text = "";
			txtCategory1.Text = "";
			txtDepartment1.Text = "";
			txtEdition1.Text = "";
			txtISBN1.Text = "";
			txtStaffName.Text = "";
			cmbAccessionNo1.Text = "";
			dtpDueDate1.Text = "";
			dtpIssueDate1.Text = "";
			btnSave1.Enabled = true;
			btnDelete1.Enabled = false;
			btnUpdate1.Enabled = false;
		}
		private void frmBookIssue_Load(System.Object sender, System.EventArgs e)
		{
			fillANo();
			fillANo1();
			fillStudentID();
			fillStaffID();
			FileSystem.Reset();
			Reset1();
		}

		public void DeleteRecord()
		{
			try {
				int RowsAffected = 0;
				con = new OleDbConnection(cs);
				con.Open();
				string cq = "delete from BookIssue_Student where TransactionID = '" + txtTransactionID.Text + "'";
				cmd = new OleDbCommand(cq);
				cmd.Connection = con;
				RowsAffected = cmd.ExecuteNonQuery();
				if (RowsAffected > 0) {
					MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
					FileSystem.Reset();
				} else {
					MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
		public void DeleteRecord1()
		{
			try {
				int RowsAffected = 0;
				con = new OleDbConnection(cs);
				con.Open();
				string cq = "delete from BookIssue_Staff where TransactionID = '" + txtTransactionID1.Text + "'";
				cmd = new OleDbCommand(cq);
				cmd.Connection = con;
				RowsAffected = cmd.ExecuteNonQuery();
				if (RowsAffected > 0) {
					MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Reset1();
				} else {
					MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Reset1();
					if (con.State == ConnectionState.Open) {
						con.Close();
					}
					con.Close();
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void fillANo()
		{
			try {
				cmbAccessionNo.DataSource = null;
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct AccessionNo FROM Book", CN);
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
		public void fillANo1()
		{
			try {
				cmbAccessionNo1.DataSource = null;
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct AccessionNo FROM Book ", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbAccessionNo1.DisplayMember = "AccessionNo";
				cmbAccessionNo1.DataSource = dtable;
				cmbAccessionNo1.SelectedIndex = -1;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmStudentRecord3.Show();
			My.MyProject.Forms.frmStudentRecord3.txtStudentName.Text = "";
			My.MyProject.Forms.frmStudentRecord3.cmbCourse.Text = "";
			My.MyProject.Forms.frmStudentRecord3.cmbDepartment.Text = "";
			My.MyProject.Forms.frmStudentRecord3.cmbCourse1.Text = "";
			My.MyProject.Forms.frmStudentRecord3.cmbDepartment1.Text = "";
			My.MyProject.Forms.frmStudentRecord3.cmbSession.Text = "";
			My.MyProject.Forms.frmStudentRecord3.GetData();
		}

		private void cmbAccessionNo_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "select BookTitle,Author,Subject,ISBN,Edition from book where AccessionNo='" + cmbAccessionNo.Text + "'";
				cmd = new OleDbCommand(ct);
				cmd.Connection = con;
				rdr = cmd.ExecuteReader();
				if (rdr.Read()) {
					txtBookTitle.Text = rdr["BookTitle"].ToString();
					txtAuthor.Text = rdr["Author"].ToString();
					txtCategory.Text = rdr["Subject"].ToString();
					txtISBN.Text = rdr["ISBN"].ToString();
					txtEdition.Text = rdr["Edition"].ToString();
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dtpIssueDate_ValueChanged(System.Object sender, System.EventArgs e)
		{
			dtpDueDate.Text = dtpIssueDate.Value.Date.AddDays(4);
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

		private void btnUpdate_record_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if ((string.IsNullOrEmpty(cmbStudentID.Text))) {
					MessageBox.Show("Please retrieve student id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbStudentID.Focus();
					return;
				}
				if ((string.IsNullOrEmpty(txtStudentName.Text))) {
					MessageBox.Show("Please retrieve student name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtStudentName.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbAccessionNo.Text)) == 0) {
					MessageBox.Show("Please select accession no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbAccessionNo.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtBookTitle.Text)) == 0) {
					MessageBox.Show("Please retrieve book title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtBookTitle.Focus();
					return;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "select NoOfBooks from Book where AccessionNo='" + cmbAccessionNo.Text + "' and NoOfBooks <=0";
				cmd = new OleDbCommand(ct);
				cmd.Connection = con;
				rdr = cmd.ExecuteReader();
				if (rdr.Read()) {
					MessageBox.Show("Book is not available for issue", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					FileSystem.Reset();
					if ((rdr != null)) {
						rdr.Close();
					}
					return;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "update Bookissue_student set IssueDate=#" + dtpIssueDate.Text + "#,DueDate=#" + dtpDueDate.Text + "#,AccessionNo='" + cmbAccessionNo.Text + "',StudentID= '" + cmbStudentID.Text + "' where TransactionID='" + txtTransactionID.Text + "'";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				if ((cmbAccessionNo.Text != TextBox1.Text) & (txtStatus.Text == "Issued")) {
					con = new OleDbConnection(cs);
					con.Open();
					string cb1 = "Update book set NoOfBooks = NoOfBooks + 1 where AccessionNo='" + TextBox1.Text + "'";
					cmd = new OleDbCommand(cb1);
					cmd.Connection = con;
					cmd.ExecuteNonQuery();
					con.Close();
					con = new OleDbConnection(cs);
					con.Open();
					string cb2 = "Update book set NoOfBooks = NoOfBooks - 1 where AccessionNo='" + cmbAccessionNo.Text + "'";
					cmd = new OleDbCommand(cb2);
					cmd.Connection = con;
					cmd.ExecuteNonQuery();
					con.Close();
				}
				MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnUpdate_record.Enabled = false;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if ((string.IsNullOrEmpty(cmbStudentID.Text))) {
					MessageBox.Show("Please retrieve student id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbStudentID.Focus();
					return;
				}
				if ((string.IsNullOrEmpty(txtStudentName.Text))) {
					MessageBox.Show("Please retrieve student name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtStudentName.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbAccessionNo.Text)) == 0) {
					MessageBox.Show("Please select accession no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbAccessionNo.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtBookTitle.Text)) == 0) {
					MessageBox.Show("Please retrieve book title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtBookTitle.Focus();
					return;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "select NoOfBooks from Book where AccessionNo='" + cmbAccessionNo.Text + "' and NoOfBooks <=0";
				cmd = new OleDbCommand(ct);
				cmd.Connection = con;
				rdr = cmd.ExecuteReader();
				if (rdr.Read()) {
					MessageBox.Show("Book is not available for issue", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					FileSystem.Reset();
					if ((rdr != null)) {
						rdr.Close();
					}
					return;
				}
				dtpDueDate.Text = dtpIssueDate.Value.Date.AddDays(4);
				txtTransactionID.Text = "T-" + GetUniqueKey(6);
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "insert into Bookissue_Student(TransactionID, IssueDate, DueDate, AccessionNo, StudentID, Status) VALUES('" + txtTransactionID.Text + "',#" + dtpIssueDate.Text + "#,#" + dtpDueDate.Text + "#,'" + cmbAccessionNo.Text + "','" + cmbStudentID.Text + "','Issued')";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				con = new OleDbConnection(cs);
				con.Open();
				string cb1 = "Update book set NoOfBooks = NoOfBooks-1 where AccessionNo='" + cmbAccessionNo.Text + "'";
				cmd = new OleDbCommand(cb1);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Successfully issued", "Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtTransactionID.Text = "";
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnNewRecord_Click(System.Object sender, System.EventArgs e)
		{
			FileSystem.Reset();
		}

		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookRecord2.Show();
			My.MyProject.Forms.frmBookRecord2.Clear();
		}

		private void cmbStudentID_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "select StudentName,Course,Department from Student where StudentID='" + cmbStudentID.Text + "'";
				cmd = new OleDbCommand(ct);
				cmd.Connection = con;
				rdr = cmd.ExecuteReader();
				if (rdr.Read()) {
					txtStudentName.Text = rdr["StudentName"].ToString();
					txtCourse.Text = rdr["Course"].ToString();
					txtDepartment.Text = rdr["Department"].ToString();
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void fillStudentID()
		{
			try {
				cmbStudentID.DataSource = null;
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct StudentID FROM Student ", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbStudentID.DisplayMember = "StudentID";
				cmbStudentID.DataSource = dtable;
				cmbStudentID.SelectedIndex = -1;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void fillStaffID()
		{
			try {
				cmbStaffID.DataSource = null;
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct StaffID FROM Staff ", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbStaffID.DisplayMember = "StaffID";
				cmbStaffID.DataSource = dtable;
				cmbStaffID.SelectedIndex = -1;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookIssueRecord.Show();
			My.MyProject.Forms.frmBookIssueRecord.Reset();
		}


		private void btnNewRecord1_Click(System.Object sender, System.EventArgs e)
		{
			Reset1();
		}

		private void btnSave1_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if ((string.IsNullOrEmpty(cmbStaffID.Text))) {
					MessageBox.Show("Please retrieve staff id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbStaffID.Focus();
					return;
				}
				if ((string.IsNullOrEmpty(txtStaffName.Text))) {
					MessageBox.Show("Please retrieve staff name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtStaffName.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbAccessionNo1.Text)) == 0) {
					MessageBox.Show("Please select accession no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbAccessionNo1.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtBookTitle1.Text)) == 0) {
					MessageBox.Show("Please retrieve book title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtBookTitle1.Focus();
					return;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "select NoOfBooks from Book where AccessionNo='" + cmbAccessionNo1.Text + "' and NoOfBooks <=0";
				cmd = new OleDbCommand(ct);
				cmd.Connection = con;
				rdr = cmd.ExecuteReader();
				if (rdr.Read()) {
					MessageBox.Show("Book is not available for issue", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					FileSystem.Reset();
					if ((rdr != null)) {
						rdr.Close();
					}
					return;
				}
				dtpDueDate1.Text = dtpIssueDate1.Value.Date.AddDays(4);
				txtTransactionID1.Text = "T-" + GetUniqueKey(6);
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "insert into Bookissue_Staff(TransactionID, IssueDate, DueDate, AccessionNo, StaffID, Status) VALUES('" + txtTransactionID1.Text + "',#" + dtpIssueDate1.Text + "#,#" + dtpDueDate1.Text + "#,'" + cmbAccessionNo1.Text + "','" + cmbStaffID.Text + "','Issued')";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				con = new OleDbConnection(cs);
				con.Open();
				string cb1 = "Update book set NoOfBooks = NoOfBooks-1 where AccessionNo='" + cmbAccessionNo1.Text + "'";
				cmd = new OleDbCommand(cb1);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Successfully issued", "Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtTransactionID.Text = "";
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnUpdate1_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if ((string.IsNullOrEmpty(cmbStaffID.Text))) {
					MessageBox.Show("Please retrieve staff id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbStaffID.Focus();
					return;
				}
				if ((string.IsNullOrEmpty(txtStaffName.Text))) {
					MessageBox.Show("Please retrieve staff name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtStaffName.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbAccessionNo1.Text)) == 0) {
					MessageBox.Show("Please select accession no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbAccessionNo1.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtBookTitle1.Text)) == 0) {
					MessageBox.Show("Please retrieve book title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtBookTitle1.Focus();
					return;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "select NoOfBooks from Book where AccessionNo='" + cmbAccessionNo1.Text + "' and NoOfBooks <=0";
				cmd = new OleDbCommand(ct);
				cmd.Connection = con;
				rdr = cmd.ExecuteReader();
				if (rdr.Read()) {
					MessageBox.Show("Book is not available for issue", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					FileSystem.Reset();
					if ((rdr != null)) {
						rdr.Close();
					}
					return;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "update Bookissue_staff set IssueDate=#" + dtpIssueDate1.Text + "#,DueDate=#" + dtpDueDate1.Text + "#,AccessionNo='" + cmbAccessionNo1.Text + "',StaffID= '" + cmbStaffID.Text + "' where TransactionID='" + txtTransactionID1.Text + "'";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				if ((cmbAccessionNo1.Text != TextBox2.Text) & (txtStatus1.Text == "Issued")) {
					con = new OleDbConnection(cs);
					con.Open();
					string cb1 = "Update book set NoOfBooks = NoOfBooks + 1 where AccessionNo='" + TextBox2.Text + "'";
					cmd = new OleDbCommand(cb1);
					cmd.Connection = con;
					cmd.ExecuteNonQuery();
					con.Close();
					con = new OleDbConnection(cs);
					con.Open();
					string cb2 = "Update book set NoOfBooks = NoOfBooks - 1 where AccessionNo='" + cmbAccessionNo1.Text + "'";
					cmd = new OleDbCommand(cb2);
					cmd.Connection = con;
					cmd.ExecuteNonQuery();
					con.Close();
				}
				MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnUpdate1.Enabled = false;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDelete1_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes) {
					DeleteRecord1();
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Button4_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookIssueRecord_Staff.Show();
			My.MyProject.Forms.frmBookIssueRecord_Staff.Reset();
		}

		private void Button5_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmStaffRecord2.Show();
			My.MyProject.Forms.frmStaffRecord2.txtStaffName.Text = "";
			My.MyProject.Forms.frmStaffRecord2.dtpDateFrom.Text = DateAndTime.Today;
			My.MyProject.Forms.frmStaffRecord2.cmbDepartment.Text = "";
			My.MyProject.Forms.frmStaffRecord2.dtpDateTo.Text = DateAndTime.Today;
			My.MyProject.Forms.frmStaffRecord2.GetData();
		}

		private void cmbAccessionNo1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "select BookTitle,Author,Subject,ISBN,Edition from book where AccessionNo='" + cmbAccessionNo1.Text + "'";
				cmd = new OleDbCommand(ct);
				cmd.Connection = con;
				rdr = cmd.ExecuteReader();
				if (rdr.Read()) {
					txtBookTitle1.Text = rdr["BookTitle"].ToString();
					txtAuthor1.Text = rdr["Author"].ToString();
					txtCategory1.Text = rdr["Subject"].ToString();
					txtISBN1.Text = rdr["ISBN"].ToString();
					txtEdition1.Text = rdr["Edition"].ToString();
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmbStaffID_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "select Staffname,Department from Staff where StaffID='" + cmbStaffID.Text + "'";
				cmd = new OleDbCommand(ct);
				cmd.Connection = con;
				rdr = cmd.ExecuteReader();
				if (rdr.Read()) {
					txtStaffName.Text = rdr["StaffName"].ToString();
					txtDepartment1.Text = rdr["Department"].ToString();
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Button6_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookRecord3.Show();
			My.MyProject.Forms.frmBookRecord3.Clear();
		}

		private void dtpIssueDate1_ValueChanged(System.Object sender, System.EventArgs e)
		{
			dtpDueDate1.Text = dtpIssueDate1.Value.Date.AddDays(4);
		}
		public frmBookIssue()
		{
			Load += frmBookIssue_Load;
			InitializeComponent();
		}
	}
}

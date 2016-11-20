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
	public partial class frmBookReturn
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
			txtStudentID.Text = "";
			dtpReturnDate.Text = DateAndTime.Today;
			txtTransactionID.Text = "";
			txtAuthor.Text = "";
			txtBookTitle.Text = "";
			txtCategory.Text = "";
			txtDepartment.Text = "";
			txtEdition.Text = "";
			txtISBN.Text = "";
			txtCourse.Text = "";
			txtStudentName.Text = "";
			txtAccessionNo.Text = "";
			dtpDueDate.Text = "";
			dtpIssueDate.Text = "";
			txtFine.Text = "";
			btnSave.Enabled = true;
			btnDelete.Enabled = false;
			btnUpdate_record.Enabled = false;
		}
		public void Reset1()
		{
			txtStaffID.Text = "";
			txtTransactionID1.Text = "";
			dtpReturnDate1.Text = DateAndTime.Today;
			txtAuthor1.Text = "";
			txtBookTitle1.Text = "";
			txtCategory1.Text = "";
			txtDepartment1.Text = "";
			txtEdition1.Text = "";
			txtISBN1.Text = "";
			txtStaffName.Text = "";
			txtAccessionNo1.Text = "";
			dtpDueDate1.Text = "";
			dtpIssueDate1.Text = "";
			txtFine1.Text = "";
			btnSave1.Enabled = true;
			btnDelete1.Enabled = false;
			btnUpdate1.Enabled = false;
		}
		private void btnNewRecord1_Click(System.Object sender, System.EventArgs e)
		{
			Reset1();
		}

		private void btnNewRecord_Click(System.Object sender, System.EventArgs e)
		{
			FileSystem.Reset();
		}

		private void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (Strings.Len(Strings.Trim(txtTransactionID.Text)) == 0) {
					MessageBox.Show("Please retrieve transaction id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtTransactionID.Focus();
					return;
				}
				if ((dtpReturnDate.Value.Date < dtpDueDate.Value.Date)) {
					MessageBox.Show("Return date can not be less than due date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					dtpReturnDate.Focus();
					return;
				}
				if (string.IsNullOrEmpty(txtFine.Text)) {
					txtFine.Text = 0;
				}
				txtReturnID.Text = "R-" + GetUniqueKey(6);
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "insert into return_Student(ReturnID, TransactionID, ReturnDate, Fine) VALUES('" + txtReturnID.Text + "','" + txtTransactionID.Text + "',#" + dtpReturnDate.Text + "#," + txtFine.Text + ")";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				con = new OleDbConnection(cs);
				con.Open();
				string cb1 = "Update book set NoOfBooks = NoOfBooks+1 where AccessionNo='" + txtAccessionNo.Text + "'";
				cmd = new OleDbCommand(cb1);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				con = new OleDbConnection(cs);
				con.Open();
				string cb2 = "Update bookIssue_student set Status = 'Returned' where AccessionNo='" + txtAccessionNo.Text + "'";
				cmd = new OleDbCommand(cb2);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Successfully returned", "Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnSave.Enabled = false;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dtpReturnDate_ValueChanged(System.Object sender, System.EventArgs e)
		{
			int st = dtpReturnDate.Value.Date.Subtract(dtpDueDate.Value.Date).Days;
			if ((st > 0)) {
				txtFine.Text = (st * 5).ToString();
			} else {
				txtFine.Text = 0;
			}
		}

		private void dtpReturnDate_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			if ((dtpDueDate.Value.Date) > (dtpReturnDate.Value.Date)) {
				MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dtpReturnDate.Focus();
			}
		}

		private void dtpReturnDate1_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			if ((dtpDueDate1.Value.Date) > (dtpReturnDate1.Value.Date)) {
				MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dtpReturnDate1.Focus();
			}
		}

		private void dtpReturnDate1_ValueChanged(System.Object sender, System.EventArgs e)
		{
			int st = dtpReturnDate1.Value.Date.Subtract(dtpDueDate1.Value.Date).Days;
			if ((st > 0)) {
				txtFine1.Text = (st * 5).ToString();

			} else {
				txtFine1.Text = 0;
			}
		}

		private void btnSave1_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (Strings.Len(Strings.Trim(txtTransactionID1.Text)) == 0) {
					MessageBox.Show("Please retrieve transaction id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtTransactionID1.Focus();
					return;
				}
				if ((dtpReturnDate1.Value.Date < dtpDueDate1.Value.Date)) {
					MessageBox.Show("Return date can not be less than due date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					dtpReturnDate1.Focus();
					return;
				}
				if (string.IsNullOrEmpty(txtFine1.Text)) {
					txtFine1.Text = 0;
				}
				txtReturnID1.Text = "R-" + GetUniqueKey(6);
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "insert into return_Staff(ReturnID, TransactionID, ReturnDate, Fine) VALUES('" + txtReturnID1.Text + "','" + txtTransactionID1.Text + "',#" + dtpReturnDate1.Text + "#," + txtFine1.Text + ")";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				con = new OleDbConnection(cs);
				con.Open();
				string cb1 = "Update book set NoOfBooks = NoOfBooks+1 where AccessionNo='" + txtAccessionNo1.Text + "'";
				cmd = new OleDbCommand(cb1);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				con = new OleDbConnection(cs);
				con.Open();
				string cb2 = "Update bookIssue_staff set Status = 'Returned' where AccessionNo='" + txtAccessionNo1.Text + "'";
				cmd = new OleDbCommand(cb2);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Successfully returned", "Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnSave1.Enabled = false;

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
		public void DeleteRecord()
		{
			try {
				int RowsAffected = 0;
				con = new OleDbConnection(cs);
				con.Open();
				string cq = "delete from Return_Student where ReturnID = '" + txtReturnID.Text + "'";
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
				string cq = "delete from Return_Staff where ReturnID = '" + txtReturnID1.Text + "'";
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

		private void btnUpdate_record_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (Strings.Len(Strings.Trim(txtTransactionID.Text)) == 0) {
					MessageBox.Show("Please retrieve transaction id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtTransactionID.Focus();
					return;
				}
				if ((dtpReturnDate.Value.Date < dtpDueDate.Value.Date)) {
					MessageBox.Show("Return date can not be less than due date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					dtpReturnDate.Focus();
					return;
				}
				if (string.IsNullOrEmpty(txtFine.Text)) {
					txtFine.Text = 0;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "update Return_student set TransactionID='" + txtTransactionID.Text + "',ReturnDate=#" + dtpReturnDate.Text + "#,Fine='" + txtFine.Text + "' where ReturnID='" + txtReturnID.Text + "'";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				if ((txtAccessionNo.Text != TextBox1.Text)) {
					con = new OleDbConnection(cs);
					con.Open();
					string cb1 = "Update book set NoOfBooks = NoOfBooks - 1 where AccessionNo='" + TextBox1.Text + "'";
					cmd = new OleDbCommand(cb1);
					cmd.Connection = con;
					cmd.ExecuteNonQuery();
					con.Close();
					con = new OleDbConnection(cs);
					con.Open();
					string cb2 = "Update book set NoOfBooks = NoOfBooks + 1 where AccessionNo='" + txtAccessionNo.Text + "'";
					cmd = new OleDbCommand(cb2);
					cmd.Connection = con;
					cmd.ExecuteNonQuery();
					con.Close();
					con = new OleDbConnection(cs);
					con.Open();
					string cb3 = "Update bookIssue_student set Status = 'Returned' where AccessionNo='" + txtAccessionNo.Text + "'";
					cmd = new OleDbCommand(cb3);
					cmd.Connection = con;
					cmd.ExecuteNonQuery();
					con.Close();
					con = new OleDbConnection(cs);
					con.Open();
					string cb4 = "Update bookIssue_student set Status = 'Issued' where AccessionNo='" + TextBox1.Text + "'";
					cmd = new OleDbCommand(cb4);
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

		private void btnUpdate1_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (Strings.Len(Strings.Trim(txtTransactionID1.Text)) == 0) {
					MessageBox.Show("Please retrieve transaction id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtTransactionID1.Focus();
					return;
				}
				if ((dtpReturnDate1.Value.Date < dtpDueDate1.Value.Date)) {
					MessageBox.Show("Return date can not be less than due date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					dtpReturnDate1.Focus();
					return;
				}
				if (string.IsNullOrEmpty(txtFine1.Text)) {
					txtFine1.Text = 0;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "update Return_staff set TransactionID='" + txtTransactionID1.Text + "',ReturnDate=#" + dtpReturnDate1.Text + "#,Fine='" + txtFine1.Text + "' where ReturnID='" + txtReturnID1.Text + "'";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				if ((txtAccessionNo1.Text != TextBox2.Text)) {
					con = new OleDbConnection(cs);
					con.Open();
					string cb1 = "Update book set NoOfBooks = NoOfBooks - 1 where AccessionNo='" + TextBox2.Text + "'";
					cmd = new OleDbCommand(cb1);
					cmd.Connection = con;
					cmd.ExecuteNonQuery();
					con.Close();
					con = new OleDbConnection(cs);
					con.Open();
					string cb2 = "Update book set NoOfBooks = NoOfBooks + 1 where AccessionNo='" + txtAccessionNo1.Text + "'";
					cmd = new OleDbCommand(cb2);
					cmd.Connection = con;
					cmd.ExecuteNonQuery();
					con.Close();
					con = new OleDbConnection(cs);
					con.Open();
					string cb3 = "Update bookIssue_staff set Status = 'Returned' where AccessionNo='" + txtAccessionNo1.Text + "'";
					cmd = new OleDbCommand(cb3);
					cmd.Connection = con;
					cmd.ExecuteNonQuery();
					con.Close();
					con = new OleDbConnection(cs);
					con.Open();
					string cb4 = "Update bookIssue_staff set Status = 'Issued' where AccessionNo='" + TextBox2.Text + "'";
					cmd = new OleDbCommand(cb4);
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

		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookIssueRecord_Staff2.Show();
			My.MyProject.Forms.frmBookIssueRecord_Staff2.Reset();
		}

		private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookIssueRecord2.Show();
			My.MyProject.Forms.frmBookIssueRecord2.Reset();
		}

		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookReturnRecord_Student.Show();
			My.MyProject.Forms.frmBookReturnRecord_Student.Reset();
		}

		private void Button4_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookReturnRecord_Staff.Show();
			My.MyProject.Forms.frmBookReturnRecord_Staff.Reset();
		}
		public frmBookReturn()
		{
			InitializeComponent();
		}
	}
}

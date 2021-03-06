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
using System.Security.Cryptography;
using System.Text;
namespace LibraryManagementSystem
{

	public partial class frmStaff
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
		private void frmStudent_Load(System.Object sender, System.EventArgs e)
		{
			fillDepartment();
		}

		private void Browse_Click_1(System.Object sender, System.EventArgs e)
		{
			try {
				var _with1 = OpenFileDialog1;
				_with1.Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
				_with1.FilterIndex = 4;
				//Clear the file name
				OpenFileDialog1.FileName = "";
				if (OpenFileDialog1.ShowDialog() == DialogResult.OK) {
					Picture.Image = Image.FromFile(OpenFileDialog1.FileName);
				}
			} catch (Exception ex) {
				Interaction.MsgBox(ex.ToString());
			}
		}

		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmStaffRecord.Show();
			My.MyProject.Forms.frmStaffRecord.GetData();
			My.MyProject.Forms.frmStaffRecord.txtStaffName.Text = "";
			My.MyProject.Forms.frmStaffRecord.cmbDepartment.Text = "";
			My.MyProject.Forms.frmStaffRecord.dtpDateFrom.Text = DateAndTime.Today;
			My.MyProject.Forms.frmStaffRecord.dtpDateTo.Text = DateAndTime.Today;
		}


		private void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (Strings.Len(Strings.Trim(txtStaffName.Text)) == 0) {
					MessageBox.Show("Please enter staff name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtStaffName.Focus();
					return;
				}
				if (rbMale.Checked == false & rbFemale.Checked == false) {
					MessageBox.Show("Please select gender", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
					return;
				}
				if (Strings.Len(Strings.Trim(txtFatherName.Text)) == 0) {
					MessageBox.Show("Please enter father's name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtFatherName.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbDepartment.Text)) == 0) {
					MessageBox.Show("Please select department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbDepartment.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtTempAddress.Text)) == 0) {
					MessageBox.Show("Please enter temporary address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtTempAddress.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtPermanentAddress.Text)) == 0) {
					MessageBox.Show("Please enter permanent address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtPermanentAddress.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtMobileNo.Text)) == 0) {
					MessageBox.Show("Please enter mobile no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtMobileNo.Focus();
					return;
				}
				if (rbMale.Checked == true) {
					gender = rbMale.Text;
				}
				if (rbFemale.Checked == true) {
					gender = rbFemale.Text;
				}
				txtStaffID.Text = "F-" + GetUniqueKey(6);
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "insert into Staff(StaffID, StaffName, FatherName, dateofjoining, Department, TemporaryAddress, PermanentAddress, DOB, PhoneNo, MobileNo, Email, Photo,Gender) VALUES('" + txtStaffID.Text + "','" + txtStaffName.Text + "','" + txtFatherName.Text + "',#" + dtpDateOfJoining.Text + "#,'" + cmbDepartment.Text + "','" + txtTempAddress.Text + "','" + txtPermanentAddress.Text + "','" + dtpDOB.Text + "','" + txtPhoneNo.Text + "','" + txtMobileNo.Text + "','" + txtEmail.Text + "',@image,'" + gender + "')";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				MemoryStream ms = new MemoryStream();
				Bitmap bmpImage = new Bitmap(Picture.Image);
				bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
				byte[] data = ms.GetBuffer();
				OleDbParameter p = new OleDbParameter("@image", OleDbType.VarBinary);
				p.Value = data;
				cmd.Parameters.Add(p);
				cmd.ExecuteNonQuery();
				con.Close();
				con = new OleDbConnection(cs);
				con.Open();
				string cb2 = "insert into Cards_staff(StaffID,Status) VALUES('" + txtStaffID.Text + "','No')";
				cmd = new OleDbCommand(cb2);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				con = new OleDbConnection(cs);
				con.Open();
				string cb3 = "insert into NoDues_staff(StaffID,Status) VALUES('" + txtStaffID.Text + "','No')";
				cmd = new OleDbCommand(cb3);
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Successfully saved", " Staff Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnSave.Enabled = false;
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
				string cq = "delete from Staff where StaffID = '" + txtStaffID.Text + "'";
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
		public void Reset()
		{
			txtStaffID.Text = "";
			txtContactNo.Text = "";
			txtEmail.Text = "";
			txtFatherName.Text = "";
			txtMobileNo.Text = "";
			txtPermanentAddress.Text = "";
			txtPhoneNo.Text = "";
			txtStaffName.Text = "";
			txtTempAddress.Text = "";
			txtPermanentAddress.Text = "";
			dtpDateOfJoining.Text = DateAndTime.Today;
			dtpDOB.Text = DateAndTime.Today;
			cmbDepartment.Text = "";
			Picture.Image = LibraryManagementSystem.My.Resources.photo;
			rbMale.Checked = false;
			rbFemale.Checked = false;
			btnSave.Enabled = true;
			btnDelete.Enabled = false;
			btnUpdate_record.Enabled = false;
			txtStaffName.Focus();
		}

		private void btnNewRecord_Click(System.Object sender, System.EventArgs e)
		{
			FileSystem.Reset();
		}

		private void btnUpdate_record_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (Strings.Len(Strings.Trim(txtStaffName.Text)) == 0) {
					MessageBox.Show("Please enter staff name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtStaffName.Focus();
					return;
				}
				if (rbMale.Checked == false & rbFemale.Checked == false) {
					MessageBox.Show("Please select gender", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (Strings.Len(Strings.Trim(txtFatherName.Text)) == 0) {
					MessageBox.Show("Please enter father's name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtFatherName.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(cmbDepartment.Text)) == 0) {
					MessageBox.Show("Please select department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbDepartment.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtTempAddress.Text)) == 0) {
					MessageBox.Show("Please enter temporary address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtTempAddress.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtPermanentAddress.Text)) == 0) {
					MessageBox.Show("Please enter permanent address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtPermanentAddress.Focus();
					return;
				}
				if (Strings.Len(Strings.Trim(txtMobileNo.Text)) == 0) {
					MessageBox.Show("Please enter mobile no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtMobileNo.Focus();
					return;
				}

				if (rbMale.Checked == true) {
					gender = rbMale.Text;
				}
				if (rbFemale.Checked == true) {
					gender = rbFemale.Text;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "update Staff set Staffname='" + txtStaffName.Text + "',Fathername='" + txtFatherName.Text + "',DateOfJoining=#" + dtpDateOfJoining.Text + "#,Department='" + cmbDepartment.Text + "',TemporaryAddress='" + txtTempAddress.Text + "',PermanentAddress='" + txtPermanentAddress.Text + "',DOB=#" + dtpDOB.Text + "#,PhoneNo='" + txtPhoneNo.Text + "',MobileNo='" + txtMobileNo.Text + "',Email='" + txtEmail.Text + "',Photo=@image,Gender='" + gender + "' where StaffID= '" + txtStaffID.Text + "'";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				MemoryStream ms = new MemoryStream();
				Bitmap bmpImage = new Bitmap(Picture.Image);
				bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
				byte[] data = ms.GetBuffer();
				OleDbParameter p = new OleDbParameter("@image", OleDbType.VarBinary);
				p.Value = data;
				cmd.Parameters.Add(p);
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Successfully updated", " Staff Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnUpdate_record.Enabled = false;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtEmail_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex("^[a-zA-Z][\\w\\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\\w\\.-]*[a-zA-Z0-9]\\.[a-zA-Z][a-zA-Z\\.]*[a-zA-Z]$");
			if (txtEmail.Text.Length > 0) {
				if (!rEMail.IsMatch(txtEmail.Text)) {
					MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtEmail.SelectAll();
					e.Cancel = true;
				}
			}
		}

		private void txtMobileNo_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			if ((txtMobileNo.TextLength > 10)) {
				MessageBox.Show("Only 10 digits are allowed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtMobileNo.Focus();
			}
		}

		private void txtMobileNo_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar < Strings.Chr(48) | e.KeyChar > Strings.Chr(57)) & e.KeyChar != Strings.Chr(8)) {
				e.Handled = true;
			}
		}

		private void txtPhoneNo_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar < Strings.Chr(48) | e.KeyChar > Strings.Chr(57)) & e.KeyChar != Strings.Chr(8)) {
				e.Handled = true;
			}
		}
		public frmStaff()
		{
			Load += frmStudent_Load;
			InitializeComponent();
		}

	}
}

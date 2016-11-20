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
	public partial class frmDepartment
	{
		OleDbConnection con = null;
		OleDbCommand cmd = null;
		OleDbDataReader rdr;

		string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;";
		public void Reset()
		{
			txtDepartmentName.Text = "";
			btnSave.Enabled = true;
			btnUpdate_record.Enabled = false;
			btnDelete.Enabled = false;
			txtDepartmentName.Focus();
		}
		public void GetData()
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT departmentname from Department order by departmentname", con);
				rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
				DataGridView1.Rows.Clear();
				while ((rdr.Read() == true)) {
					DataGridView1.Rows.Add(rdr[0]);
				}
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void frmDepartment_Load(System.Object sender, System.EventArgs e)
		{
			GetData();
		}

		private void btnNewRecord_Click(System.Object sender, System.EventArgs e)
		{
			FileSystem.Reset();
		}

		private void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			if (Strings.Len(Strings.Trim(txtDepartmentName.Text)) == 0) {
				MessageBox.Show("Please enter department name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtDepartmentName.Focus();
				return;
			}

			try {
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "select departmentname from Department where departmentname='" + txtDepartmentName.Text + "'";
				cmd = new OleDbCommand(ct);
				cmd.Connection = con;
				rdr = cmd.ExecuteReader();
				if (rdr.Read()) {
					MessageBox.Show("department name Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					FileSystem.Reset();
					if ((rdr != null)) {
						rdr.Close();
					}
					return;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "insert into Department(departmentname) VALUES ('" + txtDepartmentName.Text + "')";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteReader();
				MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				GetData();
				btnSave.Enabled = false;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DataGridView1_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			try {
				DataGridViewRow dr = DataGridView1.SelectedRows[0];
				txtDepartmentName.Text = dr.Cells[0].Value.ToString();
				TextBox1.Text = dr.Cells[0].Value.ToString();
				btnUpdate_record.Enabled = true;
				btnDelete.Enabled = true;
				btnSave.Enabled = false;
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


		public void DeleteRecord()
		{
			try {
				int RowsAffected = 0;
				con = new OleDbConnection(cs);
				con.Open();
				string cq = "delete from Department where departmentname='" + txtDepartmentName.Text + "'";
				cmd = new OleDbCommand(cq);
				cmd.Connection = con;
				RowsAffected = cmd.ExecuteNonQuery();
				if (RowsAffected > 0) {
					MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
					GetData();
					FileSystem.Reset();
				} else {
					MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
					FileSystem.Reset();
					GetData();
					if (con.State == ConnectionState.Open) {
						con.Close();
					}
					con.Close();
				}
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

		private void btnUpdate_record_Click(System.Object sender, System.EventArgs e)
		{
			if (Strings.Len(Strings.Trim(txtDepartmentName.Text)) == 0) {
				MessageBox.Show("Please enter department name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtDepartmentName.Focus();
				return;
			}

			try {
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "update Department set departmentname='" + txtDepartmentName.Text + "' where departmentname='" + TextBox1.Text + "'";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteReader();
				MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				GetData();
				btnUpdate_record.Enabled = false;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public frmDepartment()
		{
			Load += frmDepartment_Load;
			InitializeComponent();
		}
	}
}

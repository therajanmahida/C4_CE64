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
	public partial class frmYears
	{
		OleDbDataReader rdr = null;
		DataTable dtable;
		OleDbConnection con = null;
		OleDbDataAdapter adp;
		DataSet ds;
		OleDbCommand cmd = null;
		DataTable dt = new DataTable();

		string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;";
		public void Reset()
		{
			txtYears.Text = "";
			cmbCourse.Text = "";
			txtID.Text = "";
			btnSave.Enabled = true;
			btnUpdate_record.Enabled = false;
			btnDelete.Enabled = false;
			txtYears.Focus();
		}
		public void fillCourse()
		{
			try {
				OleDbConnection CN = new OleDbConnection(cs);
				CN.Open();
				adp = new OleDbDataAdapter();
				adp.SelectCommand = new OleDbCommand("SELECT distinct RTRIM(Coursename) FROM Course", CN);
				ds = new DataSet("ds");
				adp.Fill(ds);
				dtable = ds.Tables[0];
				cmbCourse.Items.Clear();
				foreach (DataRow drow in dtable.Rows) {
					cmbCourse.Items.Add(drow[0].ToString());
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void GetData()
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				cmd = new OleDbCommand("SELECT * from tblYears order by Course", con);
				rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
				DataGridView1.Rows.Clear();
				while ((rdr.Read() == true)) {
					DataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2]);
				}
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void frmCourse_Load(System.Object sender, System.EventArgs e)
		{
			GetData();
			fillCourse();
			Autocomplete();
		}
		public void Autocomplete()
		{
			try {
				con = new OleDbConnection(cs);
				con.Open();
				OleDbCommand cmd = new OleDbCommand("SELECT distinct C_Year FROM tblYears", con);
				DataSet ds = new DataSet();
				OleDbDataAdapter da = new OleDbDataAdapter(cmd);
				da.Fill(ds, "tblYears");
				AutoCompleteStringCollection col = new AutoCompleteStringCollection();
				int i = 0;
				for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++) {
					col.Add(ds.Tables[0].Rows[i]["C_Year"].ToString());
				}
				txtYears.AutoCompleteSource = AutoCompleteSource.CustomSource;
				txtYears.AutoCompleteCustomSource = col;
				txtYears.AutoCompleteMode = AutoCompleteMode.Suggest;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnNewRecord_Click(System.Object sender, System.EventArgs e)
		{
			FileSystem.Reset();
		}

		private void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			if (Strings.Len(Strings.Trim(txtYears.Text)) == 0) {
				MessageBox.Show("Please enter year", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtYears.Focus();
				return;
			}
			if (Strings.Len(Strings.Trim(cmbCourse.Text)) == 0) {
				MessageBox.Show("Please select course", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cmbCourse.Focus();
				return;
			}

			try {
				con = new OleDbConnection(cs);
				con.Open();
				string ct = "select C_Year,Course from tblYears where Course='" + cmbCourse.Text + "' and C_Year='" + txtYears.Text + "'";
				cmd = new OleDbCommand(ct);
				cmd.Connection = con;
				rdr = cmd.ExecuteReader();
				if (rdr.Read()) {
					MessageBox.Show("Record Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					FileSystem.Reset();
					if ((rdr != null)) {
						rdr.Close();
					}
					return;
				}
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "insert into tblYears(C_year,Course) VALUES ('" + txtYears.Text + "','" + cmbCourse.Text + "')";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteReader();
				MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				GetData();
				Autocomplete();
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
				txtID.Text = dr.Cells[0].Value.ToString();
				txtYears.Text = dr.Cells[1].Value.ToString();
				cmbCourse.Text = dr.Cells[2].Value.ToString();
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
				string cq = "delete from tblYears where ID=" + txtID.Text + "";
				cmd = new OleDbCommand(cq);
				cmd.Connection = con;
				RowsAffected = cmd.ExecuteNonQuery();
				if (RowsAffected > 0) {
					MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
					GetData();
					Autocomplete();
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
			if (Strings.Len(Strings.Trim(txtYears.Text)) == 0) {
				MessageBox.Show("Please enter year", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtYears.Focus();
				return;
			}
			if (Strings.Len(Strings.Trim(cmbCourse.Text)) == 0) {
				MessageBox.Show("Please select course", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cmbCourse.Focus();
				return;
			}
			try {
				con = new OleDbConnection(cs);
				con.Open();
				string cb = "update tblYears set Course='" + cmbCourse.Text + "',C_Year= '" + txtYears.Text + "' where ID= " + txtID.Text + "";
				cmd = new OleDbCommand(cb);
				cmd.Connection = con;
				cmd.ExecuteReader();
				MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				GetData();
				Autocomplete();
				btnUpdate_record.Enabled = false;
				con.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public frmYears()
		{
			Load += frmCourse_Load;
			InitializeComponent();
		}
	}
}

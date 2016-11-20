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
	public partial class frmMain
	{

		private void AboutToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmAbout.Show();
		}

		private void Timer1_Tick(System.Object sender, System.EventArgs e)
		{
			lblDateTime.Text = DateAndTime.Now;
		}

		private void CalculatorToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("Calc.exe");
		}

		private void NotepadToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("Notepad.exe");
		}

		private void TaskManagerToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("TaskMgr.exe");
		}

		private void MSWordToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("WinWord.exe");
		}

		private void WordpadToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("Wordpad.exe");
		}

		private void SystemInfoToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmSystemInfo.Show();
		}

		private void StudentsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmStudent.Show();
		}

		private void LogoutToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			this.Hide();
			My.MyProject.Forms.frmAbout.Hide();
			My.MyProject.Forms.frmSystemInfo.Hide();
			My.MyProject.Forms.frmStudent.Hide();
			My.MyProject.Forms.frmBookIssue.Hide();
			My.MyProject.Forms.frmBookReturn.Hide();
			My.MyProject.Forms.frmBookEntry.Hide();
			My.MyProject.Forms.frmStudent.Hide();
			My.MyProject.Forms.frmBookReturn.Hide();
			My.MyProject.Forms.frmCourse.Hide();
			My.MyProject.Forms.frmStaff.Hide();
			My.MyProject.Forms.frmSupplier.Hide();
			My.MyProject.Forms.frmRegistration.Hide();
			My.MyProject.Forms.frmLoginDetails.Hide();
			My.MyProject.Forms.frmBookRecord.Hide();
			My.MyProject.Forms.frmDepartment.Hide();
			My.MyProject.Forms.frmYears.Hide();
			My.MyProject.Forms.frmJournalsMagzinesRecord1.Hide();
			My.MyProject.Forms.frmStudentRecord1.Hide();
			My.MyProject.Forms.frmStaffRecord1.Hide();
			My.MyProject.Forms.frmNewsPaper.Hide();
			My.MyProject.Forms.frmNewsPaperRecord1.Hide();
			My.MyProject.Forms.frmProjectRecord1.Hide();
			My.MyProject.Forms.frmBookIssueRecord1.Hide();
			My.MyProject.Forms.frmBookIssueRecord_Staff1.Hide();
			My.MyProject.Forms.frmSupplierRecord.Hide();
			My.MyProject.Forms.frmStudentList.Hide();
			My.MyProject.Forms.frmStudentListRecord1.Hide();
			My.MyProject.Forms.frmBookIssueRecord1.Hide();
			My.MyProject.Forms.frmBookIssueRecord_Staff1.Hide();
			My.MyProject.Forms.frmBookReturnRecord_Student1.Hide();
			My.MyProject.Forms.frmBookReturnRecord_Staff1.Hide();
			My.MyProject.Forms.frmCards.Hide();
			My.MyProject.Forms.frmStudentsCardRecord.Hide();
			My.MyProject.Forms.frmStaffCardRecord.Hide();
			My.MyProject.Forms.frmNoDues.Hide();
			My.MyProject.Forms.frmStudentsNoDuesdRecord.Hide();
			My.MyProject.Forms.frmStaffsNoDuesRecord.Hide();
			My.MyProject.Forms.Frmlogin.Show();
			My.MyProject.Forms.Frmlogin.cmbUserType.Text = "";
			My.MyProject.Forms.Frmlogin.txtUsername.Text = "";
			My.MyProject.Forms.Frmlogin.txtPassword.Text = "";
			My.MyProject.Forms.Frmlogin.ProgressBar1.Visible = false;
			My.MyProject.Forms.Frmlogin.cmbUserType.Focus();
		}

		private void IssueToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookIssue.Show();
		}

		private void BookReturnToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookReturn.Show();
		}

		private void BooksToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookEntry.Show();
		}

		private void BooksToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookEntry.Show();
		}

		private void StudentsToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmStudent.Show();
		}

		private void BooksReturnToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookReturn.Show();
		}

		private void BooksIssueToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookIssue.Show();
		}

		private void CourseToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmCourse.Show();
		}

		private void FacultiesToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmStaff.Show();
		}
		private void SuppliersToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmSupplier.Show();
		}

		private void RegistrationToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmRegistration.Show();
		}

		private void LoginDetailsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmLoginDetails.Show();
		}

		private void RegistrationToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmRegistration.Show();
		}

		private void FacultiesToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmStaff.Show();
		}

		private void SearchToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookRecord.Show();

		}

		private void frmMain_FormClosing(System.Object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			System.Environment.Exit(0);
		}

		private void DepartmentToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmDepartment.Show();
		}

		private void MasterEntryToolStripMenuItem2_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookRecord.Show();
		}

		private void YearsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmYears.Show();
		}

		private void JournalsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmJournalsAndMagzines.Show();
		}

		private void JournalsAndMagzinesToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmJournalsMagzinesRecord1.Show();
		}

		private void StudentsToolStripMenuItem3_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmStudentRecord1.Show();
		}

		private void FacultiesToolStripMenuItem3_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmStaffRecord1.Show();
		}

		private void NewPapersToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmNewsPaper.Show();
		}

		private void BooksToolStripMenuItem4_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmNewsPaperRecord1.Show();
			My.MyProject.Forms.frmNewsPaperRecord1.Reset();
		}

		private void SubscriptionToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmProject.Show();
		}

		private void ProjectsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmProjectRecord1.Show();
			My.MyProject.Forms.frmProjectRecord1.Reset();
		}

		private void StudentsToolStripMenuItem2_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookIssueRecord1.Show();
			My.MyProject.Forms.frmBookIssueRecord1.Reset();
		}

		private void StaffToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookIssueRecord_Staff1.Show();
			My.MyProject.Forms.frmBookIssueRecord_Staff1.Reset();
		}

		private void SuppliersToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmSupplierRecord.Show();
		}

		private void StudentListToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmStudentList.Show();
		}

		private void StudentsListToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmStudentListRecord1.Show();
			My.MyProject.Forms.frmStudentListRecord1.Reset();
		}

		private void StudentsToolStripMenuItem5_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookIssueRecord1.Show();
			My.MyProject.Forms.frmBookIssueRecord1.Reset();
		}

		private void StaffsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookIssueRecord_Staff1.Show();
			My.MyProject.Forms.frmBookIssueRecord_Staff1.Reset();
		}

		private void StudentsToolStripMenuItem6_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookReturnRecord_Student1.Show();
			My.MyProject.Forms.frmBookReturnRecord_Student1.Reset();
		}

		private void StaffsToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmBookReturnRecord_Staff1.Show();
			My.MyProject.Forms.frmBookReturnRecord_Staff1.Reset();
		}

		private void CardsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmCards.Show();
		}

		private void StudentsToolStripMenuItem7_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmStudentsCardRecord.Show();
		}

		private void StaffToolStripMenuItem2_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmStaffCardRecord.Show();
		}

		private void NoDuesDocToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmNoDues.Show();
		}

		private void StudentsToolStripMenuItem8_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmStudentsNoDuesdRecord.Show();
		}

		private void StaffToolStripMenuItem3_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frmStaffsNoDuesRecord.Show();
		}
	}
}

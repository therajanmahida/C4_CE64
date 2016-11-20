using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

// This file was created by the VB to C# converter (SharpDevelop 4.4.2.9749).
// It contains classes for supporting the VB "My" namespace in C#.
// If the VB application does not use the "My" namespace, or if you removed the usage
// after the conversion to C#, you can delete this file.

namespace LibraryManagementSystem.My
{
	sealed partial class MyProject
	{
		[ThreadStatic] static MyApplication application;
		
		public static MyApplication Application {
			[DebuggerStepThrough]
			get {
				if (application == null)
					application = new MyApplication();
				return application;
			}
		}
		
		[ThreadStatic] static MyComputer computer;
		
		public static MyComputer Computer {
			[DebuggerStepThrough]
			get {
				if (computer == null)
					computer = new MyComputer();
				return computer;
			}
		}
		
		[ThreadStatic] static User user;
		
		public static User User {
			[DebuggerStepThrough]
			get {
				if (user == null)
					user = new User();
				return user;
			}
		}
		
		[ThreadStatic] static MyForms forms;
		
		public static MyForms Forms {
			[DebuggerStepThrough]
			get {
				if (forms == null)
					forms = new MyForms();
				return forms;
			}
		}
		
		internal sealed class MyForms
		{
			global::LibraryManagementSystem.frmBookIssueRecord_Staff frmBookIssueRecord_Staff_instance;
			bool frmBookIssueRecord_Staff_isCreating;
			public global::LibraryManagementSystem.frmBookIssueRecord_Staff frmBookIssueRecord_Staff {
				[DebuggerStepThrough] get { return GetForm(ref frmBookIssueRecord_Staff_instance, ref frmBookIssueRecord_Staff_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBookIssueRecord_Staff_instance, value); }
			}
			
			global::LibraryManagementSystem.frmStudentListRecord1 frmStudentListRecord1_instance;
			bool frmStudentListRecord1_isCreating;
			public global::LibraryManagementSystem.frmStudentListRecord1 frmStudentListRecord1 {
				[DebuggerStepThrough] get { return GetForm(ref frmStudentListRecord1_instance, ref frmStudentListRecord1_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmStudentListRecord1_instance, value); }
			}
			
			global::LibraryManagementSystem.Frmlogin Frmlogin_instance;
			bool Frmlogin_isCreating;
			public global::LibraryManagementSystem.Frmlogin Frmlogin {
				[DebuggerStepThrough] get { return GetForm(ref Frmlogin_instance, ref Frmlogin_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref Frmlogin_instance, value); }
			}
			
			global::LibraryManagementSystem.frmStudentRecord1 frmStudentRecord1_instance;
			bool frmStudentRecord1_isCreating;
			public global::LibraryManagementSystem.frmStudentRecord1 frmStudentRecord1 {
				[DebuggerStepThrough] get { return GetForm(ref frmStudentRecord1_instance, ref frmStudentRecord1_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmStudentRecord1_instance, value); }
			}
			
			global::LibraryManagementSystem.frmProject frmProject_instance;
			bool frmProject_isCreating;
			public global::LibraryManagementSystem.frmProject frmProject {
				[DebuggerStepThrough] get { return GetForm(ref frmProject_instance, ref frmProject_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmProject_instance, value); }
			}
			
			global::LibraryManagementSystem.frmBookReturn frmBookReturn_instance;
			bool frmBookReturn_isCreating;
			public global::LibraryManagementSystem.frmBookReturn frmBookReturn {
				[DebuggerStepThrough] get { return GetForm(ref frmBookReturn_instance, ref frmBookReturn_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBookReturn_instance, value); }
			}
			
			global::LibraryManagementSystem.frmBookRecord2 frmBookRecord2_instance;
			bool frmBookRecord2_isCreating;
			public global::LibraryManagementSystem.frmBookRecord2 frmBookRecord2 {
				[DebuggerStepThrough] get { return GetForm(ref frmBookRecord2_instance, ref frmBookRecord2_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBookRecord2_instance, value); }
			}
			
			global::LibraryManagementSystem.frmStudentRecord3 frmStudentRecord3_instance;
			bool frmStudentRecord3_isCreating;
			public global::LibraryManagementSystem.frmStudentRecord3 frmStudentRecord3 {
				[DebuggerStepThrough] get { return GetForm(ref frmStudentRecord3_instance, ref frmStudentRecord3_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmStudentRecord3_instance, value); }
			}
			
			global::LibraryManagementSystem.frmBookIssueRecord_Staff1 frmBookIssueRecord_Staff1_instance;
			bool frmBookIssueRecord_Staff1_isCreating;
			public global::LibraryManagementSystem.frmBookIssueRecord_Staff1 frmBookIssueRecord_Staff1 {
				[DebuggerStepThrough] get { return GetForm(ref frmBookIssueRecord_Staff1_instance, ref frmBookIssueRecord_Staff1_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBookIssueRecord_Staff1_instance, value); }
			}
			
			global::LibraryManagementSystem.frmRegistration frmRegistration_instance;
			bool frmRegistration_isCreating;
			public global::LibraryManagementSystem.frmRegistration frmRegistration {
				[DebuggerStepThrough] get { return GetForm(ref frmRegistration_instance, ref frmRegistration_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmRegistration_instance, value); }
			}
			
			global::LibraryManagementSystem.frmStaffRecord frmStaffRecord_instance;
			bool frmStaffRecord_isCreating;
			public global::LibraryManagementSystem.frmStaffRecord frmStaffRecord {
				[DebuggerStepThrough] get { return GetForm(ref frmStaffRecord_instance, ref frmStaffRecord_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmStaffRecord_instance, value); }
			}
			
			global::LibraryManagementSystem.frmJournalsMagzinesRecord1 frmJournalsMagzinesRecord1_instance;
			bool frmJournalsMagzinesRecord1_isCreating;
			public global::LibraryManagementSystem.frmJournalsMagzinesRecord1 frmJournalsMagzinesRecord1 {
				[DebuggerStepThrough] get { return GetForm(ref frmJournalsMagzinesRecord1_instance, ref frmJournalsMagzinesRecord1_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmJournalsMagzinesRecord1_instance, value); }
			}
			
			global::LibraryManagementSystem.frmStudentListRecord frmStudentListRecord_instance;
			bool frmStudentListRecord_isCreating;
			public global::LibraryManagementSystem.frmStudentListRecord frmStudentListRecord {
				[DebuggerStepThrough] get { return GetForm(ref frmStudentListRecord_instance, ref frmStudentListRecord_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmStudentListRecord_instance, value); }
			}
			
			global::LibraryManagementSystem.frmStaffRecord2 frmStaffRecord2_instance;
			bool frmStaffRecord2_isCreating;
			public global::LibraryManagementSystem.frmStaffRecord2 frmStaffRecord2 {
				[DebuggerStepThrough] get { return GetForm(ref frmStaffRecord2_instance, ref frmStaffRecord2_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmStaffRecord2_instance, value); }
			}
			
			global::LibraryManagementSystem.frmJournalsMagzinesRecord frmJournalsMagzinesRecord_instance;
			bool frmJournalsMagzinesRecord_isCreating;
			public global::LibraryManagementSystem.frmJournalsMagzinesRecord frmJournalsMagzinesRecord {
				[DebuggerStepThrough] get { return GetForm(ref frmJournalsMagzinesRecord_instance, ref frmJournalsMagzinesRecord_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmJournalsMagzinesRecord_instance, value); }
			}
			
			global::LibraryManagementSystem.frmStaffsNoDuesRecord frmStaffsNoDuesRecord_instance;
			bool frmStaffsNoDuesRecord_isCreating;
			public global::LibraryManagementSystem.frmStaffsNoDuesRecord frmStaffsNoDuesRecord {
				[DebuggerStepThrough] get { return GetForm(ref frmStaffsNoDuesRecord_instance, ref frmStaffsNoDuesRecord_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmStaffsNoDuesRecord_instance, value); }
			}
			
			global::LibraryManagementSystem.frmBookIssueRecord_Staff2 frmBookIssueRecord_Staff2_instance;
			bool frmBookIssueRecord_Staff2_isCreating;
			public global::LibraryManagementSystem.frmBookIssueRecord_Staff2 frmBookIssueRecord_Staff2 {
				[DebuggerStepThrough] get { return GetForm(ref frmBookIssueRecord_Staff2_instance, ref frmBookIssueRecord_Staff2_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBookIssueRecord_Staff2_instance, value); }
			}
			
			global::LibraryManagementSystem.frmStudentRecord frmStudentRecord_instance;
			bool frmStudentRecord_isCreating;
			public global::LibraryManagementSystem.frmStudentRecord frmStudentRecord {
				[DebuggerStepThrough] get { return GetForm(ref frmStudentRecord_instance, ref frmStudentRecord_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmStudentRecord_instance, value); }
			}
			
			global::LibraryManagementSystem.frmProjectRecord1 frmProjectRecord1_instance;
			bool frmProjectRecord1_isCreating;
			public global::LibraryManagementSystem.frmProjectRecord1 frmProjectRecord1 {
				[DebuggerStepThrough] get { return GetForm(ref frmProjectRecord1_instance, ref frmProjectRecord1_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmProjectRecord1_instance, value); }
			}
			
			global::LibraryManagementSystem.frmStaff frmStaff_instance;
			bool frmStaff_isCreating;
			public global::LibraryManagementSystem.frmStaff frmStaff {
				[DebuggerStepThrough] get { return GetForm(ref frmStaff_instance, ref frmStaff_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmStaff_instance, value); }
			}
			
			global::LibraryManagementSystem.frmBooksSearch frmBooksSearch_instance;
			bool frmBooksSearch_isCreating;
			public global::LibraryManagementSystem.frmBooksSearch frmBooksSearch {
				[DebuggerStepThrough] get { return GetForm(ref frmBooksSearch_instance, ref frmBooksSearch_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBooksSearch_instance, value); }
			}
			
			global::LibraryManagementSystem.frmSupplierRecord frmSupplierRecord_instance;
			bool frmSupplierRecord_isCreating;
			public global::LibraryManagementSystem.frmSupplierRecord frmSupplierRecord {
				[DebuggerStepThrough] get { return GetForm(ref frmSupplierRecord_instance, ref frmSupplierRecord_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmSupplierRecord_instance, value); }
			}
			
			global::LibraryManagementSystem.frmStudentsNoDuesdRecord frmStudentsNoDuesdRecord_instance;
			bool frmStudentsNoDuesdRecord_isCreating;
			public global::LibraryManagementSystem.frmStudentsNoDuesdRecord frmStudentsNoDuesdRecord {
				[DebuggerStepThrough] get { return GetForm(ref frmStudentsNoDuesdRecord_instance, ref frmStudentsNoDuesdRecord_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmStudentsNoDuesdRecord_instance, value); }
			}
			
			global::LibraryManagementSystem.frmSupplier frmSupplier_instance;
			bool frmSupplier_isCreating;
			public global::LibraryManagementSystem.frmSupplier frmSupplier {
				[DebuggerStepThrough] get { return GetForm(ref frmSupplier_instance, ref frmSupplier_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmSupplier_instance, value); }
			}
			
			global::LibraryManagementSystem.frmBookIssueRecord2 frmBookIssueRecord2_instance;
			bool frmBookIssueRecord2_isCreating;
			public global::LibraryManagementSystem.frmBookIssueRecord2 frmBookIssueRecord2 {
				[DebuggerStepThrough] get { return GetForm(ref frmBookIssueRecord2_instance, ref frmBookIssueRecord2_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBookIssueRecord2_instance, value); }
			}
			
			global::LibraryManagementSystem.frmProjectRecord frmProjectRecord_instance;
			bool frmProjectRecord_isCreating;
			public global::LibraryManagementSystem.frmProjectRecord frmProjectRecord {
				[DebuggerStepThrough] get { return GetForm(ref frmProjectRecord_instance, ref frmProjectRecord_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmProjectRecord_instance, value); }
			}
			
			global::LibraryManagementSystem.frmBookReturnRecord_Student frmBookReturnRecord_Student_instance;
			bool frmBookReturnRecord_Student_isCreating;
			public global::LibraryManagementSystem.frmBookReturnRecord_Student frmBookReturnRecord_Student {
				[DebuggerStepThrough] get { return GetForm(ref frmBookReturnRecord_Student_instance, ref frmBookReturnRecord_Student_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBookReturnRecord_Student_instance, value); }
			}
			
			global::LibraryManagementSystem.frmYears frmYears_instance;
			bool frmYears_isCreating;
			public global::LibraryManagementSystem.frmYears frmYears {
				[DebuggerStepThrough] get { return GetForm(ref frmYears_instance, ref frmYears_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmYears_instance, value); }
			}
			
			global::LibraryManagementSystem.frmStudent frmStudent_instance;
			bool frmStudent_isCreating;
			public global::LibraryManagementSystem.frmStudent frmStudent {
				[DebuggerStepThrough] get { return GetForm(ref frmStudent_instance, ref frmStudent_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmStudent_instance, value); }
			}
			
			global::LibraryManagementSystem.frmNoDues frmNoDues_instance;
			bool frmNoDues_isCreating;
			public global::LibraryManagementSystem.frmNoDues frmNoDues {
				[DebuggerStepThrough] get { return GetForm(ref frmNoDues_instance, ref frmNoDues_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmNoDues_instance, value); }
			}
			
			global::LibraryManagementSystem.frmStaffCardRecord frmStaffCardRecord_instance;
			bool frmStaffCardRecord_isCreating;
			public global::LibraryManagementSystem.frmStaffCardRecord frmStaffCardRecord {
				[DebuggerStepThrough] get { return GetForm(ref frmStaffCardRecord_instance, ref frmStaffCardRecord_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmStaffCardRecord_instance, value); }
			}
			
			global::LibraryManagementSystem.frmStudentRecord2 frmStudentRecord2_instance;
			bool frmStudentRecord2_isCreating;
			public global::LibraryManagementSystem.frmStudentRecord2 frmStudentRecord2 {
				[DebuggerStepThrough] get { return GetForm(ref frmStudentRecord2_instance, ref frmStudentRecord2_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmStudentRecord2_instance, value); }
			}
			
			global::LibraryManagementSystem.frmSystemInfo frmSystemInfo_instance;
			bool frmSystemInfo_isCreating;
			public global::LibraryManagementSystem.frmSystemInfo frmSystemInfo {
				[DebuggerStepThrough] get { return GetForm(ref frmSystemInfo_instance, ref frmSystemInfo_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmSystemInfo_instance, value); }
			}
			
			global::LibraryManagementSystem.frmDepartment frmDepartment_instance;
			bool frmDepartment_isCreating;
			public global::LibraryManagementSystem.frmDepartment frmDepartment {
				[DebuggerStepThrough] get { return GetForm(ref frmDepartment_instance, ref frmDepartment_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmDepartment_instance, value); }
			}
			
			global::LibraryManagementSystem.frmStudentsCardRecord frmStudentsCardRecord_instance;
			bool frmStudentsCardRecord_isCreating;
			public global::LibraryManagementSystem.frmStudentsCardRecord frmStudentsCardRecord {
				[DebuggerStepThrough] get { return GetForm(ref frmStudentsCardRecord_instance, ref frmStudentsCardRecord_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmStudentsCardRecord_instance, value); }
			}
			
			global::LibraryManagementSystem.frmBookReturnRecord_Staff frmBookReturnRecord_Staff_instance;
			bool frmBookReturnRecord_Staff_isCreating;
			public global::LibraryManagementSystem.frmBookReturnRecord_Staff frmBookReturnRecord_Staff {
				[DebuggerStepThrough] get { return GetForm(ref frmBookReturnRecord_Staff_instance, ref frmBookReturnRecord_Staff_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBookReturnRecord_Staff_instance, value); }
			}
			
			global::LibraryManagementSystem.frmBookEntry frmBookEntry_instance;
			bool frmBookEntry_isCreating;
			public global::LibraryManagementSystem.frmBookEntry frmBookEntry {
				[DebuggerStepThrough] get { return GetForm(ref frmBookEntry_instance, ref frmBookEntry_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBookEntry_instance, value); }
			}
			
			global::LibraryManagementSystem.frmMain frmMain_instance;
			bool frmMain_isCreating;
			public global::LibraryManagementSystem.frmMain frmMain {
				[DebuggerStepThrough] get { return GetForm(ref frmMain_instance, ref frmMain_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmMain_instance, value); }
			}
			
			global::LibraryManagementSystem.frmProjectReport frmProjectReport_instance;
			bool frmProjectReport_isCreating;
			public global::LibraryManagementSystem.frmProjectReport frmProjectReport {
				[DebuggerStepThrough] get { return GetForm(ref frmProjectReport_instance, ref frmProjectReport_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmProjectReport_instance, value); }
			}
			
			global::LibraryManagementSystem.frmNewsPaperRecord1 frmNewsPaperRecord1_instance;
			bool frmNewsPaperRecord1_isCreating;
			public global::LibraryManagementSystem.frmNewsPaperRecord1 frmNewsPaperRecord1 {
				[DebuggerStepThrough] get { return GetForm(ref frmNewsPaperRecord1_instance, ref frmNewsPaperRecord1_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmNewsPaperRecord1_instance, value); }
			}
			
			global::LibraryManagementSystem.frmStudentList frmStudentList_instance;
			bool frmStudentList_isCreating;
			public global::LibraryManagementSystem.frmStudentList frmStudentList {
				[DebuggerStepThrough] get { return GetForm(ref frmStudentList_instance, ref frmStudentList_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmStudentList_instance, value); }
			}
			
			global::LibraryManagementSystem.frmBookIssueRecord frmBookIssueRecord_instance;
			bool frmBookIssueRecord_isCreating;
			public global::LibraryManagementSystem.frmBookIssueRecord frmBookIssueRecord {
				[DebuggerStepThrough] get { return GetForm(ref frmBookIssueRecord_instance, ref frmBookIssueRecord_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBookIssueRecord_instance, value); }
			}
			
			global::LibraryManagementSystem.frmCards frmCards_instance;
			bool frmCards_isCreating;
			public global::LibraryManagementSystem.frmCards frmCards {
				[DebuggerStepThrough] get { return GetForm(ref frmCards_instance, ref frmCards_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmCards_instance, value); }
			}
			
			global::LibraryManagementSystem.frmCourse frmCourse_instance;
			bool frmCourse_isCreating;
			public global::LibraryManagementSystem.frmCourse frmCourse {
				[DebuggerStepThrough] get { return GetForm(ref frmCourse_instance, ref frmCourse_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmCourse_instance, value); }
			}
			
			global::LibraryManagementSystem.frmStaffRecord1 frmStaffRecord1_instance;
			bool frmStaffRecord1_isCreating;
			public global::LibraryManagementSystem.frmStaffRecord1 frmStaffRecord1 {
				[DebuggerStepThrough] get { return GetForm(ref frmStaffRecord1_instance, ref frmStaffRecord1_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmStaffRecord1_instance, value); }
			}
			
			global::LibraryManagementSystem.frmNewsPaperRecord frmNewsPaperRecord_instance;
			bool frmNewsPaperRecord_isCreating;
			public global::LibraryManagementSystem.frmNewsPaperRecord frmNewsPaperRecord {
				[DebuggerStepThrough] get { return GetForm(ref frmNewsPaperRecord_instance, ref frmNewsPaperRecord_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmNewsPaperRecord_instance, value); }
			}
			
			global::LibraryManagementSystem.frmSplash frmSplash_instance;
			bool frmSplash_isCreating;
			public global::LibraryManagementSystem.frmSplash frmSplash {
				[DebuggerStepThrough] get { return GetForm(ref frmSplash_instance, ref frmSplash_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmSplash_instance, value); }
			}
			
			global::LibraryManagementSystem.frmBookIssue frmBookIssue_instance;
			bool frmBookIssue_isCreating;
			public global::LibraryManagementSystem.frmBookIssue frmBookIssue {
				[DebuggerStepThrough] get { return GetForm(ref frmBookIssue_instance, ref frmBookIssue_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBookIssue_instance, value); }
			}
			
			global::LibraryManagementSystem.frmBookReturnRecord_Student1 frmBookReturnRecord_Student1_instance;
			bool frmBookReturnRecord_Student1_isCreating;
			public global::LibraryManagementSystem.frmBookReturnRecord_Student1 frmBookReturnRecord_Student1 {
				[DebuggerStepThrough] get { return GetForm(ref frmBookReturnRecord_Student1_instance, ref frmBookReturnRecord_Student1_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBookReturnRecord_Student1_instance, value); }
			}
			
			global::LibraryManagementSystem.frmAbout frmAbout_instance;
			bool frmAbout_isCreating;
			public global::LibraryManagementSystem.frmAbout frmAbout {
				[DebuggerStepThrough] get { return GetForm(ref frmAbout_instance, ref frmAbout_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmAbout_instance, value); }
			}
			
			global::LibraryManagementSystem.frmPasswordRecovery frmPasswordRecovery_instance;
			bool frmPasswordRecovery_isCreating;
			public global::LibraryManagementSystem.frmPasswordRecovery frmPasswordRecovery {
				[DebuggerStepThrough] get { return GetForm(ref frmPasswordRecovery_instance, ref frmPasswordRecovery_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmPasswordRecovery_instance, value); }
			}
			
			global::LibraryManagementSystem.frmChangePassword frmChangePassword_instance;
			bool frmChangePassword_isCreating;
			public global::LibraryManagementSystem.frmChangePassword frmChangePassword {
				[DebuggerStepThrough] get { return GetForm(ref frmChangePassword_instance, ref frmChangePassword_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmChangePassword_instance, value); }
			}
			
			global::LibraryManagementSystem.frmStudentsReport frmStudentsReport_instance;
			bool frmStudentsReport_isCreating;
			public global::LibraryManagementSystem.frmStudentsReport frmStudentsReport {
				[DebuggerStepThrough] get { return GetForm(ref frmStudentsReport_instance, ref frmStudentsReport_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmStudentsReport_instance, value); }
			}
			
			global::LibraryManagementSystem.frmBookReturnRecord_Staff1 frmBookReturnRecord_Staff1_instance;
			bool frmBookReturnRecord_Staff1_isCreating;
			public global::LibraryManagementSystem.frmBookReturnRecord_Staff1 frmBookReturnRecord_Staff1 {
				[DebuggerStepThrough] get { return GetForm(ref frmBookReturnRecord_Staff1_instance, ref frmBookReturnRecord_Staff1_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBookReturnRecord_Staff1_instance, value); }
			}
			
			global::LibraryManagementSystem.frmJournalsAndMagzines frmJournalsAndMagzines_instance;
			bool frmJournalsAndMagzines_isCreating;
			public global::LibraryManagementSystem.frmJournalsAndMagzines frmJournalsAndMagzines {
				[DebuggerStepThrough] get { return GetForm(ref frmJournalsAndMagzines_instance, ref frmJournalsAndMagzines_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmJournalsAndMagzines_instance, value); }
			}
			
			global::LibraryManagementSystem.frmBookRecord1 frmBookRecord1_instance;
			bool frmBookRecord1_isCreating;
			public global::LibraryManagementSystem.frmBookRecord1 frmBookRecord1 {
				[DebuggerStepThrough] get { return GetForm(ref frmBookRecord1_instance, ref frmBookRecord1_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBookRecord1_instance, value); }
			}
			
			global::LibraryManagementSystem.frmBookIssueRecord1 frmBookIssueRecord1_instance;
			bool frmBookIssueRecord1_isCreating;
			public global::LibraryManagementSystem.frmBookIssueRecord1 frmBookIssueRecord1 {
				[DebuggerStepThrough] get { return GetForm(ref frmBookIssueRecord1_instance, ref frmBookIssueRecord1_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBookIssueRecord1_instance, value); }
			}
			
			global::LibraryManagementSystem.frmLoginDetails frmLoginDetails_instance;
			bool frmLoginDetails_isCreating;
			public global::LibraryManagementSystem.frmLoginDetails frmLoginDetails {
				[DebuggerStepThrough] get { return GetForm(ref frmLoginDetails_instance, ref frmLoginDetails_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmLoginDetails_instance, value); }
			}
			
			global::LibraryManagementSystem.frmNewsPaper frmNewsPaper_instance;
			bool frmNewsPaper_isCreating;
			public global::LibraryManagementSystem.frmNewsPaper frmNewsPaper {
				[DebuggerStepThrough] get { return GetForm(ref frmNewsPaper_instance, ref frmNewsPaper_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmNewsPaper_instance, value); }
			}
			
			global::LibraryManagementSystem.frmBookRecord frmBookRecord_instance;
			bool frmBookRecord_isCreating;
			public global::LibraryManagementSystem.frmBookRecord frmBookRecord {
				[DebuggerStepThrough] get { return GetForm(ref frmBookRecord_instance, ref frmBookRecord_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBookRecord_instance, value); }
			}
			
			global::LibraryManagementSystem.frmBookRecord3 frmBookRecord3_instance;
			bool frmBookRecord3_isCreating;
			public global::LibraryManagementSystem.frmBookRecord3 frmBookRecord3 {
				[DebuggerStepThrough] get { return GetForm(ref frmBookRecord3_instance, ref frmBookRecord3_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBookRecord3_instance, value); }
			}
			
			[DebuggerStepThrough]
			static T GetForm<T>(ref T instance, ref bool isCreating) where T : Form, new()
			{
				if (instance == null || instance.IsDisposed) {
					if (isCreating) {
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
					isCreating = true;
					try {
						instance = new T();
					} catch (System.Reflection.TargetInvocationException ex) {
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[] { ex.InnerException.Message }), ex.InnerException);
					} finally {
						isCreating = false;
					}
				}
				return instance;
			}
			
			[DebuggerStepThrough]
			static void SetForm<T>(ref T instance, T value) where T : Form
			{
				if (instance != value) {
					if (value == null) {
						instance.Dispose();
						instance = null;
					} else {
						throw new ArgumentException("Property can only be set to null");
					}
				}
			}
		}
	}
	
	partial class MyApplication : WindowsFormsApplicationBase
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Application.SetCompatibleTextRenderingDefault(UseCompatibleTextRendering);
			MyProject.Application.Run(args);
		}
	}
	
	partial class MyComputer : Computer
	{
	}
}

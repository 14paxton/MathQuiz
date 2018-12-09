﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    public partial class frmStudentHome : Form
    {
        Student student;
        Klass klass = new Klass();

        PlacementTest availablePlacementTest;
        List<PracticeTest> availablePracticeTests;
        List<MasteryTest> availableMasteryTests;
        

        public frmStudentHome(string username)
        {
            InitializeComponent();
            student = MathWizDA.SelectStudent(username); //this has to go here
        }

        private void frmStudentHome_Load(object sender, EventArgs e)
        {
            if(student.MasteryLevel == 0)
            {
                btnTakeMasteryTest.Enabled = false;
                btnTakePlacementTest.Enabled = true;
            }
            else
            {
                btnTakeMasteryTest.Enabled = true;
                btnTakePlacementTest.Enabled = false;
            }

            cmbMasteryLevel.SelectedIndex = student.MasteryLevel;
            cmbNumberOfQuestions.SelectedIndex = 1;

            klass.Id = MathWizDA.SelectStudentsKlassID(student.Id);
            klass = MathWizDA.SelectKlass(klass.Id);

            backgroundWorkerLoadData.RunWorkerAsync();
        }

        private void backgroundWorkerLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            if(student.MasteryLevel == 0) //if student has not taken placement test yet, only load that test
            {
                availablePlacementTest = MathWizDA.SelectKlassesPlacementTest(klass.Id);
            }
            else //load the tests that the student can take, but not the placement test since they already took it
            {
                availablePracticeTests = MathWizDA.SelectKlassesPracticeTests(klass.Id);
                availableMasteryTests = MathWizDA.SelectKlassesMasteryTests(klass.Id);
            }
        }

        private void backgroundWorkerLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStudentName.Text = "Logged in as: " + student.FirstName + " " + student.LastName;
            lblKlassName.Text = klass.KlassName;
            lblMasteryLevel.Text = "Mastery Level: " + student.MasteryLevel.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new frmAboutBox();
            aboutForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTakePlacementTest_Click(object sender, EventArgs e)
        {
            Form placementForm = new frmTakeTest(student, klass.Id, availablePlacementTest); //TODO Pass Correct Test object
            placementForm.Tag = "placement";
            placementForm.ShowDialog();
        }

        private void btnTakeRandomPracticeTest_Click(object sender, EventArgs e)
        {
            if(Validation.IsComboSelected(cmbMasteryLevel) && Validation.IsComboSelected(cmbNumberOfQuestions))
            {
                int masteryLevel = Convert.ToInt16(cmbMasteryLevel.SelectedItem);
                int numberOfQuestions = Convert.ToInt16(cmbNumberOfQuestions.SelectedItem);
                PracticeTest practiceTest = new PracticeTest(Question.GenerateRandomQuestions(masteryLevel, new TimeSpan(0, 0, 30), numberOfQuestions), new TimeSpan(0, 10, 0), true, masteryLevel, masteryLevel);


                Form practiceForm = new frmTakeTest(student, klass.Id, practiceTest);
                practiceForm.Tag = "practice";
                practiceForm.ShowDialog();
            }
        }

        private void btnTakeMasteryTest_Click(object sender, EventArgs e)
        {
            Form masteryForm = new frmTakeTest(student, klass.Id, null); //Passes the students mastery level
            masteryForm.Tag = "mastery";
            masteryForm.ShowDialog();
        }
    }
}

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
        public frmStudentHome(string username)
        {
            InitializeComponent();
            student = MathWizDA.SelectStudent(username);
        }

        private void frmStudentHome_Load(object sender, EventArgs e)
        {
            if(student.MasteryLevel == 0)
            {
                btnPractice.Enabled = false;
                btnMastery.Enabled = false;
                btnPlacement.Enabled = true;
            }
            else
            {
                btnPractice.Enabled = true;
                btnMastery.Enabled = true;
                btnPlacement.Enabled = false;
            }
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

        private void btnPlacement_Click(object sender, EventArgs e)
        {
            Form placementForm = new frmTakeTest(student, 1); //TODO Pass Correct Test ID
            placementForm.Tag = "placement";
            placementForm.ShowDialog();
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            Form practiceForm = new frmTakeTest(student, 1);
            practiceForm.Tag = "practice";
            practiceForm.ShowDialog();
        }

        private void btnMastery_Click(object sender, EventArgs e)
        {
            Form masteryForm = new frmTakeTest(student, 1); //Passes the students mastery level
            masteryForm.Tag = "mastery";
            masteryForm.ShowDialog();
        }
    }
}

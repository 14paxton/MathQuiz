﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    public partial class frmTakeTest : Form
    {
        Test test;
        GradedTest gradedTest;
        Student student;
        int testID;
        int currentQuestionNum = 0;

        public frmTakeTest(Student s, Test t) 
        {
            InitializeComponent();
            student = s;
            test = t;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            switch (this.Tag.ToString())
            {
                case "placement":

                    gradedTest = new GradedPlacementTest();
                    gbxQuestion.Text = "Placement Test";
                    this.Text = "Placement Test";
                    break;

                case "practice":

                    gradedTest = new GradedPracticeTest();
                    this.Text = "Practice Test";
                    gbxQuestion.Text = "Practice Test";
                    break;

                case "mastery":

                    gradedTest = new GradedMasteryTest();
                    this.Text = "Mastery Test";
                    gbxQuestion.Text = "Mastery Test";
                    break;

                default:
                    gradedTest = new GradedPracticeTest();
                    this.Text = "Practice Test";
                    gbxQuestion.Text = "Practice Test";
                    break;
            }

            this.Text += " - " + student.FirstName + " " + student.LastName;
            btnStartFinish.Text = "Start Test";
            gbxQuestion.Text = "";
            backgroundWorkerLoadTest.RunWorkerAsync();
        }

        private void backgroundWorkerLoadTest_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (this.Tag.ToString())
            {
                case "placement":

                    test = MathWizDA.SelectPlacementTest(testID);
                    break;

                case "practice":

                    //TODO call a method to generate a test -- OR I guess load one from the database
                    break;

                case "mastery":

                    test = MathWizDA.SelectMasteryTest(testID);
                    break;
            }
        }

        private void backgroundWorkerLoadTest_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void ShowQuestion(Question q)
        {
            //show timer stuff
            lblTimerQuestion.Text = q.TimeLimit.ToString();
            timerQuestion.Start();

            //show the question number
            gbxQuestion.Text = "Question " + (currentQuestionNum + 1).ToString() + " of " + test.Questions.Count;

            //show the question text
            lblQuestionText.Text = q.QuestionText;
            lblQuestionText.Show();

            //hide the answers, but set its text
            lblCorrectAnswer.Hide();
            lblCorrectAnswer.Text = q.CorrectAnswer.ToString();

            //show the buttons
            btnSubmitAnswer.Show();
            txtStudentAnswer.Show();

            if (false) //TODO is multiple choice
            {
                pnlChoices.Show();
            }

        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (Validation.IsInteger(txtStudentAnswer))
            {
                if (Convert.ToInt32(txtStudentAnswer.Text.Trim()) == test.Questions[currentQuestionNum].CorrectAnswer)
                {
                    GradedQuestion correctlyAnsweredQuestion = new GradedQuestion(test.Questions[currentQuestionNum], txtStudentAnswer.Text, true, new TimeSpan(0,1,1));
                    gradedTest.CorrectlyAnsweredQuestions.Add(correctlyAnsweredQuestion);

                    
                }
                else
                {
                    GradedQuestion wronglyAnsweredQuestion = new GradedQuestion(test.Questions[currentQuestionNum], txtStudentAnswer.Text, false, new TimeSpan(0, 1, 1));
                    gradedTest.WronglyAnsweredQuestions.Add(wronglyAnsweredQuestion);
                }
                //TODO: Correct answer doesn't show up
                //We can use Thread.Sleep(amountofTimeHere) to delay the program from moving on for a period of time
                lblCorrectAnswer.Show();

                currentQuestionNum++;

                if (currentQuestionNum < test.Questions.Count)
                {
                    ShowQuestion(test.Questions[currentQuestionNum]);
                }
                else //the test if finished
                {
                    btnStartFinish.Show();
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(currentQuestionNum > 1)
            {
                currentQuestionNum--;
            }

            if (btnStartFinish.Visible)
            {
                btnStartFinish.Hide();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(currentQuestionNum < test.Questions.Count)
            {
                currentQuestionNum++;
            }

            if(currentQuestionNum == test.Questions.Count)
            {
                btnStartFinish.Show();
            }
        }

        private void btnStartFinish_Click(object sender, EventArgs e)
        {
            if(btnStartFinish.Text == "Start Test")
            {
                btnStartFinish.Text = "Finish Test";
                
                btnStartFinish.Hide();
                

                ShowQuestion(test.Questions[currentQuestionNum]);
                
            }
            else if(btnStartFinish.Text == "Finish Test")
            {
                //TODO record score
                gradedTest.Score = gradedTest.CorrectlyAnsweredQuestions.Count / gradedTest.CorrectlyAnsweredQuestions.Count + gradedTest.WronglyAnsweredQuestions.Count;
                gradedTest.TimeTakenToComplete = test.TimeLimit - TimeSpan.Parse(lblTimerTest.Text);
                gradedTest.DateTaken = DateTime.Now;
                gradedTest.Feedback = gradedTest.Score.ToString();
            }
        }

        private void timerTest_Tick(object sender, EventArgs e)
        {
         //   lblTimerTest.Text = timerTest.ToString();

            
        }

        private void timerQuestion_Tick(object sender, EventArgs e)
        {
            lblTimerQuestion.Text = timerQuestion.ToString();

            //if (TimeSpan.Parse(lblTimerQuestion.Text) <= new TimeSpan(0,0,0)) //if time runs out
            //{
            //    timerQuestion.Stop();
            //    btnSubmitAnswer.Enabled = false;
            //    lblCorrectAnswer.Show();
            //}
        }

        private void frmTakeTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit this test? This may result in a grade of 0", "Are you sure?", MessageBoxButtons.YesNoCancel);
            if(dialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}

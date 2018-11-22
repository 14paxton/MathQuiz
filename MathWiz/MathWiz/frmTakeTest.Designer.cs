﻿namespace MathWiz
{
    partial class frmTakeTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorkerLoadTest = new System.ComponentModel.BackgroundWorker();
            this.gbxQuestion = new System.Windows.Forms.GroupBox();
            this.lblTimerQuestion = new System.Windows.Forms.Label();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.txtStudentAnswer = new System.Windows.Forms.TextBox();
            this.pnlChoices = new System.Windows.Forms.Panel();
            this.rdoChoice4 = new System.Windows.Forms.RadioButton();
            this.rdoChoice3 = new System.Windows.Forms.RadioButton();
            this.rdoChoice2 = new System.Windows.Forms.RadioButton();
            this.rdoChoice1 = new System.Windows.Forms.RadioButton();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStartFinish = new System.Windows.Forms.Button();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.lblTimerTest = new System.Windows.Forms.Label();
            this.timerQuestion = new System.Windows.Forms.Timer(this.components);
            this.gbxQuestion.SuspendLayout();
            this.pnlChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorkerLoadTest
            // 
            this.backgroundWorkerLoadTest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoadTest_DoWork);
            this.backgroundWorkerLoadTest.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoadTest_RunWorkerCompleted);
            // 
            // gbxQuestion
            // 
            this.gbxQuestion.Controls.Add(this.lblTimerQuestion);
            this.gbxQuestion.Controls.Add(this.btnSubmitAnswer);
            this.gbxQuestion.Controls.Add(this.lblCorrectAnswer);
            this.gbxQuestion.Controls.Add(this.txtStudentAnswer);
            this.gbxQuestion.Controls.Add(this.pnlChoices);
            this.gbxQuestion.Controls.Add(this.lblQuestionText);
            this.gbxQuestion.Controls.Add(this.btnNext);
            this.gbxQuestion.Controls.Add(this.btnBack);
            this.gbxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxQuestion.Location = new System.Drawing.Point(38, 36);
            this.gbxQuestion.Name = "gbxQuestion";
            this.gbxQuestion.Size = new System.Drawing.Size(498, 263);
            this.gbxQuestion.TabIndex = 0;
            this.gbxQuestion.TabStop = false;
            this.gbxQuestion.Text = "Question # of #";
            // 
            // lblTimerQuestion
            // 
            this.lblTimerQuestion.AutoSize = true;
            this.lblTimerQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerQuestion.Location = new System.Drawing.Point(412, 30);
            this.lblTimerQuestion.Name = "lblTimerQuestion";
            this.lblTimerQuestion.Size = new System.Drawing.Size(36, 17);
            this.lblTimerQuestion.TabIndex = 7;
            this.lblTimerQuestion.Text = "1:00";
            this.lblTimerQuestion.Visible = false;
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAnswer.Location = new System.Drawing.Point(398, 59);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(78, 46);
            this.btnSubmitAnswer.TabIndex = 6;
            this.btnSubmitAnswer.Text = "Submit";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Visible = false;
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswer.ForeColor = System.Drawing.Color.Green;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(136, 64);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(35, 37);
            this.lblCorrectAnswer.TabIndex = 5;
            this.lblCorrectAnswer.Text = "4";
            this.lblCorrectAnswer.Visible = false;
            // 
            // txtStudentAnswer
            // 
            this.txtStudentAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentAnswer.Location = new System.Drawing.Point(267, 59);
            this.txtStudentAnswer.MaxLength = 6;
            this.txtStudentAnswer.Name = "txtStudentAnswer";
            this.txtStudentAnswer.Size = new System.Drawing.Size(125, 44);
            this.txtStudentAnswer.TabIndex = 0;
            this.txtStudentAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStudentAnswer.Visible = false;
            // 
            // pnlChoices
            // 
            this.pnlChoices.Controls.Add(this.rdoChoice4);
            this.pnlChoices.Controls.Add(this.rdoChoice3);
            this.pnlChoices.Controls.Add(this.rdoChoice2);
            this.pnlChoices.Controls.Add(this.rdoChoice1);
            this.pnlChoices.Location = new System.Drawing.Point(25, 124);
            this.pnlChoices.Name = "pnlChoices";
            this.pnlChoices.Size = new System.Drawing.Size(451, 63);
            this.pnlChoices.TabIndex = 4;
            this.pnlChoices.Visible = false;
            // 
            // rdoChoice4
            // 
            this.rdoChoice4.AutoSize = true;
            this.rdoChoice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoice4.Location = new System.Drawing.Point(372, 15);
            this.rdoChoice4.Name = "rdoChoice4";
            this.rdoChoice4.Size = new System.Drawing.Size(42, 30);
            this.rdoChoice4.TabIndex = 3;
            this.rdoChoice4.TabStop = true;
            this.rdoChoice4.Text = "4";
            this.rdoChoice4.UseVisualStyleBackColor = true;
            // 
            // rdoChoice3
            // 
            this.rdoChoice3.AutoSize = true;
            this.rdoChoice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoice3.Location = new System.Drawing.Point(254, 15);
            this.rdoChoice3.Name = "rdoChoice3";
            this.rdoChoice3.Size = new System.Drawing.Size(42, 30);
            this.rdoChoice3.TabIndex = 2;
            this.rdoChoice3.TabStop = true;
            this.rdoChoice3.Text = "3";
            this.rdoChoice3.UseVisualStyleBackColor = true;
            // 
            // rdoChoice2
            // 
            this.rdoChoice2.AutoSize = true;
            this.rdoChoice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoice2.Location = new System.Drawing.Point(136, 15);
            this.rdoChoice2.Name = "rdoChoice2";
            this.rdoChoice2.Size = new System.Drawing.Size(42, 30);
            this.rdoChoice2.TabIndex = 1;
            this.rdoChoice2.TabStop = true;
            this.rdoChoice2.Text = "2";
            this.rdoChoice2.UseVisualStyleBackColor = true;
            // 
            // rdoChoice1
            // 
            this.rdoChoice1.AutoSize = true;
            this.rdoChoice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoice1.Location = new System.Drawing.Point(18, 15);
            this.rdoChoice1.Name = "rdoChoice1";
            this.rdoChoice1.Size = new System.Drawing.Size(42, 30);
            this.rdoChoice1.TabIndex = 0;
            this.rdoChoice1.TabStop = true;
            this.rdoChoice1.Text = "1";
            this.rdoChoice1.UseVisualStyleBackColor = true;
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.Location = new System.Drawing.Point(18, 64);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(127, 37);
            this.lblQuestionText.TabIndex = 3;
            this.lblQuestionText.Text = "2 + 2 = ";
            this.lblQuestionText.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(309, 202);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(167, 37);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(25, 202);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(167, 37);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Previous Question";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStartFinish
            // 
            this.btnStartFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartFinish.Location = new System.Drawing.Point(199, 329);
            this.btnStartFinish.Name = "btnStartFinish";
            this.btnStartFinish.Size = new System.Drawing.Size(167, 37);
            this.btnStartFinish.TabIndex = 2;
            this.btnStartFinish.Text = "Start/Finish Test";
            this.btnStartFinish.UseVisualStyleBackColor = true;
            this.btnStartFinish.Click += new System.EventHandler(this.btnStartFinish_Click);
            // 
            // lblTimerTest
            // 
            this.lblTimerTest.AutoSize = true;
            this.lblTimerTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerTest.Location = new System.Drawing.Point(263, 384);
            this.lblTimerTest.Name = "lblTimerTest";
            this.lblTimerTest.Size = new System.Drawing.Size(44, 17);
            this.lblTimerTest.TabIndex = 3;
            this.lblTimerTest.Text = "10:00";
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 434);
            this.Controls.Add(this.lblTimerTest);
            this.Controls.Add(this.btnStartFinish);
            this.Controls.Add(this.gbxQuestion);
            this.Name = "frmTakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.gbxQuestion.ResumeLayout(false);
            this.gbxQuestion.PerformLayout();
            this.pnlChoices.ResumeLayout(false);
            this.pnlChoices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadTest;
        private System.Windows.Forms.GroupBox gbxQuestion;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStartFinish;
        private System.Windows.Forms.Panel pnlChoices;
        private System.Windows.Forms.RadioButton rdoChoice4;
        private System.Windows.Forms.RadioButton rdoChoice3;
        private System.Windows.Forms.RadioButton rdoChoice2;
        private System.Windows.Forms.RadioButton rdoChoice1;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.TextBox txtStudentAnswer;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Timer timerTest;
        private System.Windows.Forms.Label lblTimerTest;
        private System.Windows.Forms.Timer timerQuestion;
        private System.Windows.Forms.Label lblTimerQuestion;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTakeTest));
            this.gbxQuestion = new System.Windows.Forms.GroupBox();
            this.lblTimerQuestion = new System.Windows.Forms.Label();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.txtStudentAnswer = new System.Windows.Forms.TextBox();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.btnStartFinish = new System.Windows.Forms.Button();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.lblTimerTest = new System.Windows.Forms.Label();
            this.timerQuestion = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerSaveTest = new System.ComponentModel.BackgroundWorker();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.gbxQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxQuestion
            // 
            this.gbxQuestion.Controls.Add(this.lblTimerQuestion);
            this.gbxQuestion.Controls.Add(this.btnSubmitAnswer);
            this.gbxQuestion.Controls.Add(this.lblCorrectAnswer);
            this.gbxQuestion.Controls.Add(this.txtStudentAnswer);
            this.gbxQuestion.Controls.Add(this.lblQuestionText);
            this.gbxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxQuestion.Location = new System.Drawing.Point(44, 124);
            this.gbxQuestion.Name = "gbxQuestion";
            this.gbxQuestion.Size = new System.Drawing.Size(596, 171);
            this.gbxQuestion.TabIndex = 0;
            this.gbxQuestion.TabStop = false;
            this.gbxQuestion.Text = "Question # of #";
            // 
            // lblTimerQuestion
            // 
            this.lblTimerQuestion.AutoSize = true;
            this.lblTimerQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerQuestion.Location = new System.Drawing.Point(524, 82);
            this.lblTimerQuestion.Name = "lblTimerQuestion";
            this.lblTimerQuestion.Size = new System.Drawing.Size(55, 24);
            this.lblTimerQuestion.TabIndex = 7;
            this.lblTimerQuestion.Text = "01:00";
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAnswer.Location = new System.Drawing.Point(413, 61);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(105, 55);
            this.btnSubmitAnswer.TabIndex = 6;
            this.btnSubmitAnswer.Text = "Submit";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswer.ForeColor = System.Drawing.Color.Green;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(189, 64);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(42, 46);
            this.lblCorrectAnswer.TabIndex = 5;
            this.lblCorrectAnswer.Text = "4";
            // 
            // txtStudentAnswer
            // 
            this.txtStudentAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentAnswer.Location = new System.Drawing.Point(282, 61);
            this.txtStudentAnswer.MaxLength = 6;
            this.txtStudentAnswer.Name = "txtStudentAnswer";
            this.txtStudentAnswer.Size = new System.Drawing.Size(125, 53);
            this.txtStudentAnswer.TabIndex = 0;
            this.txtStudentAnswer.Tag = "Answer";
            this.txtStudentAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStudentAnswer.TextChanged += new System.EventHandler(this.txtStudentAnswer_TextChanged);
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.Location = new System.Drawing.Point(18, 64);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(154, 46);
            this.lblQuestionText.TabIndex = 3;
            this.lblQuestionText.Text = "2 + 2 = ";
            // 
            // btnStartFinish
            // 
            this.btnStartFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartFinish.Location = new System.Drawing.Point(234, 346);
            this.btnStartFinish.Name = "btnStartFinish";
            this.btnStartFinish.Size = new System.Drawing.Size(224, 51);
            this.btnStartFinish.TabIndex = 2;
            this.btnStartFinish.Text = "Start/Finish Test";
            this.btnStartFinish.UseVisualStyleBackColor = true;
            this.btnStartFinish.Click += new System.EventHandler(this.btnStartFinish_Click);
            // 
            // timerTest
            // 
            this.timerTest.Interval = 1000;
            this.timerTest.Tick += new System.EventHandler(this.timerTest_Tick);
            // 
            // lblTimerTest
            // 
            this.lblTimerTest.AutoSize = true;
            this.lblTimerTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerTest.Location = new System.Drawing.Point(305, 409);
            this.lblTimerTest.Name = "lblTimerTest";
            this.lblTimerTest.Size = new System.Drawing.Size(82, 31);
            this.lblTimerTest.TabIndex = 3;
            this.lblTimerTest.Text = "10:00";
            // 
            // timerQuestion
            // 
            this.timerQuestion.Interval = 1000;
            this.timerQuestion.Tick += new System.EventHandler(this.timerQuestion_Tick);
            // 
            // backgroundWorkerSaveTest
            // 
            this.backgroundWorkerSaveTest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSaveTest_DoWork);
            this.backgroundWorkerSaveTest.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSaveTest_RunWorkerCompleted);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(49, 39);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(127, 31);
            this.lblStudentName.TabIndex = 8;
            this.lblStudentName.Text = "First Last";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(435, 39);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(162, 31);
            this.lblClassName.TabIndex = 9;
            this.lblClassName.Text = "Class Name";
            this.lblClassName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmTakeTest
            // 
            this.AcceptButton = this.btnSubmitAnswer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 460);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.btnStartFinish);
            this.Controls.Add(this.lblTimerTest);
            this.Controls.Add(this.gbxQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(580, 360);
            this.Name = "frmTakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taking Test";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTakeTest_FormClosing);
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.gbxQuestion.ResumeLayout(false);
            this.gbxQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxQuestion;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Button btnStartFinish;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.TextBox txtStudentAnswer;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Timer timerTest;
        private System.Windows.Forms.Label lblTimerTest;
        private System.Windows.Forms.Timer timerQuestion;
        private System.Windows.Forms.Label lblTimerQuestion;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSaveTest;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblClassName;
    }
}
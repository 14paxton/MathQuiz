﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MathWiz
{
    public partial class frmLogin : Form
    {
        User user;
        Form homeForm;

        string errorFlag = "";
        int loginAttempts = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        //button actions
        private void btnShowHideUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.UseSystemPasswordChar)
            {
                btnShowHideUsername.BackgroundImage = Properties.Resources.hide_password;
                txtUsername.UseSystemPasswordChar = false;
            }
            else
            {
                btnShowHideUsername.BackgroundImage = Properties.Resources.show_password;
                txtUsername.UseSystemPasswordChar = true;
            }
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                btnShowHidePassword.BackgroundImage = Properties.Resources.hide_password;
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                btnShowHidePassword.BackgroundImage = Properties.Resources.show_password;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //hide the errors if they were previously shown so that they only show when triggered again
            lblUsernameError.Hide();
            lblPasswordError.Hide();
            
            if(txtUsername.Text == "" && txtPassword.Text == "")
            {
                lblUsernameError.Show();
                lblPasswordError.Show();
            }
            if(txtUsername.Text == "")
            {
                lblUsernameError.Show();
            }
            else if(txtPassword.Text == "")
            {
                lblPasswordError.Show();
            }
            else
            {
                btnLogin.Text = "Logging In";
                btnLogin.Enabled = false;
                backgroundWorkerLogin.RunWorkerAsync();
            }
        }

        private void backgroundWorkerLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            string userType = MathWizDA.FindUserType(txtUsername.Text);
            
            if (userType == "admin")
            {
                user = new Admin();
                if (user.VerifyPassword(txtUsername.Text, txtPassword.Text))
                {
                    errorFlag = "";
                    homeForm = new frmAdminHome(txtUsername.Text);
                }
                else
                {
                    errorFlag = "password";
                }
            }
            else if (userType == "teacher")
            {
                user = new Teacher();
                if (user.VerifyPassword(txtUsername.Text, txtPassword.Text))
                {
                    errorFlag = "";
                    homeForm = new frmTeacherHome(txtUsername.Text);
                }
                else
                {
                    errorFlag = "password";
                }
            }
            else if (userType == "parent")
            {
                user = new Parent();
                if (user.VerifyPassword(txtUsername.Text, txtPassword.Text))
                {
                    errorFlag = "";
                    homeForm = new frmParentHome(txtUsername.Text);
                }
                else
                {
                    errorFlag = "password";
                }
            }
            else if (userType == "student")
            {
                user = new Student();
                if (user.VerifyPassword(txtUsername.Text, txtPassword.Text))
                {
                    errorFlag = "";
                    homeForm = new frmStudentHome(txtUsername.Text);
                }
                else
                {
                    errorFlag = "password";
                }
            }
            else if (userType == "none") //could not find username
            {
                errorFlag = "username";
            }
            else //the sql statement must have had an error
            {
                MessageBox.Show("Login Error. We could not verify your username, but this may be due to a slow connection", "Connection Error");
            }
        }

        private void backgroundWorkerLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null && errorFlag == "")
            {
                loginAttempts = 0;
                if (txtUsername.UseSystemPasswordChar)
                {
                    txtUsername.Text = ""; //get rid of username text if the user was hiding their username from the screen so next user does not see it
                }
                txtPassword.Text = "";//get rid of password text for security so that the next user who uses the computer doesn't have it
                this.Hide();            //hide login form
                if(homeForm != null)
                {
                    homeForm.ShowDialog();  //only show the home form (of the type that was passed)
                }
                if (!this.IsDisposed)   //only reshow this login form again if the user is logging out or clicking the red X, not if they are exiting the application
                {
                    this.Show();        //after the home form closes, show the login form again
                }
            }
            else if (errorFlag == "username")
            {
                lblUsernameError.Show();
            }
            else if (errorFlag == "password")
            {
                lblPasswordError.Show();
            }
            else if(loginAttempts < 3) //This is so that if there is a bad connection, it will try 3 times to  connect to db and login
            {
                loginAttempts++;
                backgroundWorkerLogin.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Could Not log in. This could be due to a slow internet connection. Try again.");
            }
            btnLogin.Enabled = true; //re-enable login button for the next user or person who had login error
            btnLogin.Text = "Log In";
        }

        //menu item actions
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutBox = new frmAboutBox();
            aboutBox.ShowDialog();
        }

        private void iCantLogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ask your teacher to reset your password", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backgroundWorkerLogin.CancelAsync();
            this.Close();
        }
    }
}
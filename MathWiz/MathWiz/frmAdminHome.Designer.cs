﻿namespace MathWiz
{
    partial class frmAdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminHome));
            this.gbxManageAccounts = new System.Windows.Forms.GroupBox();
            this.btnDeleteSelectedUser = new System.Windows.Forms.Button();
            this.pbxUserProperties = new System.Windows.Forms.PropertyGrid();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblUserTypes = new System.Windows.Forms.Label();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.btnCreateParent = new System.Windows.Forms.Button();
            this.btnCreateTeacher = new System.Windows.Forms.Button();
            this.btnCreateAdmin = new System.Windows.Forms.Button();
            this.lstUserTypes = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxManageAccounts.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxManageAccounts
            // 
            this.gbxManageAccounts.Controls.Add(this.btnDeleteSelectedUser);
            this.gbxManageAccounts.Controls.Add(this.pbxUserProperties);
            this.gbxManageAccounts.Controls.Add(this.lblUsers);
            this.gbxManageAccounts.Controls.Add(this.lblUserTypes);
            this.gbxManageAccounts.Controls.Add(this.lstUsers);
            this.gbxManageAccounts.Controls.Add(this.btnCreateStudent);
            this.gbxManageAccounts.Controls.Add(this.btnCreateParent);
            this.gbxManageAccounts.Controls.Add(this.btnCreateTeacher);
            this.gbxManageAccounts.Controls.Add(this.btnCreateAdmin);
            this.gbxManageAccounts.Controls.Add(this.lstUserTypes);
            this.gbxManageAccounts.Location = new System.Drawing.Point(24, 47);
            this.gbxManageAccounts.Name = "gbxManageAccounts";
            this.gbxManageAccounts.Size = new System.Drawing.Size(960, 328);
            this.gbxManageAccounts.TabIndex = 0;
            this.gbxManageAccounts.TabStop = false;
            this.gbxManageAccounts.Text = "Manage Accounts";
            // 
            // btnDeleteSelectedUser
            // 
            this.btnDeleteSelectedUser.Enabled = false;
            this.btnDeleteSelectedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedUser.Location = new System.Drawing.Point(481, 258);
            this.btnDeleteSelectedUser.Name = "btnDeleteSelectedUser";
            this.btnDeleteSelectedUser.Size = new System.Drawing.Size(180, 39);
            this.btnDeleteSelectedUser.TabIndex = 1;
            this.btnDeleteSelectedUser.Text = "Delete Selected User";
            this.btnDeleteSelectedUser.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedUser.Click += new System.EventHandler(this.btnDeleteSelectedUser_Click);
            // 
            // pbxUserProperties
            // 
            this.pbxUserProperties.Enabled = false;
            this.pbxUserProperties.Location = new System.Drawing.Point(700, 43);
            this.pbxUserProperties.Name = "pbxUserProperties";
            this.pbxUserProperties.Size = new System.Drawing.Size(180, 199);
            this.pbxUserProperties.TabIndex = 9;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(539, 16);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(34, 13);
            this.lblUsers.TabIndex = 7;
            this.lblUsers.Text = "Users";
            // 
            // lblUserTypes
            // 
            this.lblUserTypes.AutoSize = true;
            this.lblUserTypes.Location = new System.Drawing.Point(317, 16);
            this.lblUserTypes.Name = "lblUserTypes";
            this.lblUserTypes.Size = new System.Drawing.Size(61, 13);
            this.lblUserTypes.TabIndex = 6;
            this.lblUserTypes.Text = "User Types";
            // 
            // lstUsers
            // 
            this.lstUsers.Enabled = false;
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(481, 44);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(180, 199);
            this.lstUsers.TabIndex = 5;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateStudent.Location = new System.Drawing.Point(16, 203);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(217, 39);
            this.btnCreateStudent.TabIndex = 4;
            this.btnCreateStudent.Text = "Create New Student Account";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // btnCreateParent
            // 
            this.btnCreateParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateParent.Location = new System.Drawing.Point(16, 150);
            this.btnCreateParent.Name = "btnCreateParent";
            this.btnCreateParent.Size = new System.Drawing.Size(217, 39);
            this.btnCreateParent.TabIndex = 3;
            this.btnCreateParent.Text = "Create New Parent Account";
            this.btnCreateParent.UseVisualStyleBackColor = true;
            this.btnCreateParent.Click += new System.EventHandler(this.btnCreateParent_Click);
            // 
            // btnCreateTeacher
            // 
            this.btnCreateTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeacher.Location = new System.Drawing.Point(16, 97);
            this.btnCreateTeacher.Name = "btnCreateTeacher";
            this.btnCreateTeacher.Size = new System.Drawing.Size(217, 39);
            this.btnCreateTeacher.TabIndex = 2;
            this.btnCreateTeacher.Text = "Create New Teacher Account";
            this.btnCreateTeacher.UseVisualStyleBackColor = true;
            this.btnCreateTeacher.Click += new System.EventHandler(this.btnCreateTeacher_Click);
            // 
            // btnCreateAdmin
            // 
            this.btnCreateAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAdmin.Location = new System.Drawing.Point(16, 44);
            this.btnCreateAdmin.Name = "btnCreateAdmin";
            this.btnCreateAdmin.Size = new System.Drawing.Size(217, 39);
            this.btnCreateAdmin.TabIndex = 1;
            this.btnCreateAdmin.Text = "Create New Admin Account";
            this.btnCreateAdmin.UseVisualStyleBackColor = true;
            this.btnCreateAdmin.Click += new System.EventHandler(this.btnCreateAdmin_Click);
            // 
            // lstUserTypes
            // 
            this.lstUserTypes.FormattingEnabled = true;
            this.lstUserTypes.Location = new System.Drawing.Point(267, 44);
            this.lstUserTypes.Name = "lstUserTypes";
            this.lstUserTypes.Size = new System.Drawing.Size(180, 199);
            this.lstUserTypes.TabIndex = 0;
            this.lstUserTypes.SelectedIndexChanged += new System.EventHandler(this.lstUserTypes_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1169, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccountToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.parentToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addAccountToolStripMenuItem.Text = "Create Account";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.teacherToolStripMenuItem.Text = "Teacher";
            // 
            // parentToolStripMenuItem
            // 
            this.parentToolStripMenuItem.Name = "parentToolStripMenuItem";
            this.parentToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.parentToolStripMenuItem.Text = "Parent";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // frmAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1169, 623);
            this.Controls.Add(this.gbxManageAccounts);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdminHome";
            this.Text = "MathWiz - Admin Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdminHome_Load);
            this.gbxManageAccounts.ResumeLayout(false);
            this.gbxManageAccounts.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxManageAccounts;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button btnCreateParent;
        private System.Windows.Forms.Button btnCreateTeacher;
        private System.Windows.Forms.Button btnCreateAdmin;
        private System.Windows.Forms.ListBox lstUserTypes;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblUserTypes;
        private System.Windows.Forms.PropertyGrid pbxUserProperties;
        private System.Windows.Forms.Button btnDeleteSelectedUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}
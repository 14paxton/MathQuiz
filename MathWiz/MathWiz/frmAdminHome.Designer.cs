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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminHome));
            this.gbxManageAccounts = new System.Windows.Forms.GroupBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnViewUserInfo = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathWizGroup3DataSet1 = new MathWiz.MathWizGroup3DataSet();
            this.pnlUserTypes = new System.Windows.Forms.Panel();
            this.rdoStudents = new System.Windows.Forms.RadioButton();
            this.rdoParents = new System.Windows.Forms.RadioButton();
            this.rdoTeachers = new System.Windows.Forms.RadioButton();
            this.rdoAdmins = new System.Windows.Forms.RadioButton();
            this.btnDeleteSelectedUser = new System.Windows.Forms.Button();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.btnCreateParent = new System.Windows.Forms.Button();
            this.btnCreateTeacher = new System.Windows.Forms.Button();
            this.btnCreateAdmin = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxManageClasses = new System.Windows.Forms.GroupBox();
            this.lstStudentsInKlass = new System.Windows.Forms.ListBox();
            this.lstClasses = new System.Windows.Forms.ListBox();
            this.btnCreateClass = new System.Windows.Forms.Button();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.teachersTableAdapter();
            this.parentsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.parentsTableAdapter();
            this.studentsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.studentsTableAdapter();
            this.adminsTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.adminsTableAdapter();
            this.klassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassesTableAdapter = new MathWiz.MathWizGroup3DataSetTableAdapters.klassesTableAdapter();
            this.fKstudentsKlassI44FF419ABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxManageAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet1)).BeginInit();
            this.pnlUserTypes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbxManageClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKstudentsKlassI44FF419ABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxManageAccounts
            // 
            this.gbxManageAccounts.Controls.Add(this.btnRefresh);
            this.gbxManageAccounts.Controls.Add(this.btnChangePassword);
            this.gbxManageAccounts.Controls.Add(this.btnViewUserInfo);
            this.gbxManageAccounts.Controls.Add(this.dgvUsers);
            this.gbxManageAccounts.Controls.Add(this.pnlUserTypes);
            this.gbxManageAccounts.Controls.Add(this.btnDeleteSelectedUser);
            this.gbxManageAccounts.Controls.Add(this.btnCreateStudent);
            this.gbxManageAccounts.Controls.Add(this.btnCreateParent);
            this.gbxManageAccounts.Controls.Add(this.btnCreateTeacher);
            this.gbxManageAccounts.Controls.Add(this.btnCreateAdmin);
            this.gbxManageAccounts.Location = new System.Drawing.Point(24, 47);
            this.gbxManageAccounts.Name = "gbxManageAccounts";
            this.gbxManageAccounts.Size = new System.Drawing.Size(1097, 269);
            this.gbxManageAccounts.TabIndex = 0;
            this.gbxManageAccounts.TabStop = false;
            this.gbxManageAccounts.Text = "Manage Accounts";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Enabled = false;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(907, 99);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(161, 39);
            this.btnChangePassword.TabIndex = 10;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnViewUserInfo
            // 
            this.btnViewUserInfo.Enabled = false;
            this.btnViewUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUserInfo.Location = new System.Drawing.Point(907, 46);
            this.btnViewUserInfo.Name = "btnViewUserInfo";
            this.btnViewUserInfo.Size = new System.Drawing.Size(161, 39);
            this.btnViewUserInfo.TabIndex = 9;
            this.btnViewUserInfo.Text = "View User Info";
            this.btnViewUserInfo.UseVisualStyleBackColor = true;
            this.btnViewUserInfo.Click += new System.EventHandler(this.btnViewUserInfo_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.usernameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.dgvUsers.DataSource = this.adminsBindingSource;
            this.dgvUsers.Location = new System.Drawing.Point(406, 44);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 10;
            this.dgvUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(475, 200);
            this.dgvUsers.TabIndex = 7;
            this.dgvUsers.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellEndEdit);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 30.45685F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.FillWeight = 151.6018F;
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.FillWeight = 105.7999F;
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.FillWeight = 112.1414F;
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "admins";
            this.adminsBindingSource.DataSource = this.mathWizGroup3DataSet1;
            // 
            // mathWizGroup3DataSet1
            // 
            this.mathWizGroup3DataSet1.DataSetName = "MathWizGroup3DataSet";
            this.mathWizGroup3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlUserTypes
            // 
            this.pnlUserTypes.Controls.Add(this.rdoStudents);
            this.pnlUserTypes.Controls.Add(this.rdoParents);
            this.pnlUserTypes.Controls.Add(this.rdoTeachers);
            this.pnlUserTypes.Controls.Add(this.rdoAdmins);
            this.pnlUserTypes.Location = new System.Drawing.Point(239, 46);
            this.pnlUserTypes.Name = "pnlUserTypes";
            this.pnlUserTypes.Size = new System.Drawing.Size(161, 190);
            this.pnlUserTypes.TabIndex = 8;
            // 
            // rdoStudents
            // 
            this.rdoStudents.AutoSize = true;
            this.rdoStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStudents.Location = new System.Drawing.Point(16, 159);
            this.rdoStudents.Name = "rdoStudents";
            this.rdoStudents.Size = new System.Drawing.Size(120, 21);
            this.rdoStudents.TabIndex = 3;
            this.rdoStudents.TabStop = true;
            this.rdoStudents.Text = "Show Students";
            this.rdoStudents.UseVisualStyleBackColor = true;
            this.rdoStudents.CheckedChanged += new System.EventHandler(this.rdoUserTypes_CheckChanged);
            // 
            // rdoParents
            // 
            this.rdoParents.AutoSize = true;
            this.rdoParents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoParents.Location = new System.Drawing.Point(16, 109);
            this.rdoParents.Name = "rdoParents";
            this.rdoParents.Size = new System.Drawing.Size(113, 21);
            this.rdoParents.TabIndex = 2;
            this.rdoParents.TabStop = true;
            this.rdoParents.Text = "Show Parents";
            this.rdoParents.UseVisualStyleBackColor = true;
            this.rdoParents.CheckedChanged += new System.EventHandler(this.rdoUserTypes_CheckChanged);
            // 
            // rdoTeachers
            // 
            this.rdoTeachers.AutoSize = true;
            this.rdoTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTeachers.Location = new System.Drawing.Point(16, 59);
            this.rdoTeachers.Name = "rdoTeachers";
            this.rdoTeachers.Size = new System.Drawing.Size(124, 21);
            this.rdoTeachers.TabIndex = 1;
            this.rdoTeachers.TabStop = true;
            this.rdoTeachers.Text = "Show Teachers";
            this.rdoTeachers.UseVisualStyleBackColor = true;
            this.rdoTeachers.CheckedChanged += new System.EventHandler(this.rdoUserTypes_CheckChanged);
            // 
            // rdoAdmins
            // 
            this.rdoAdmins.AutoSize = true;
            this.rdoAdmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdmins.Location = new System.Drawing.Point(16, 9);
            this.rdoAdmins.Name = "rdoAdmins";
            this.rdoAdmins.Size = new System.Drawing.Size(110, 21);
            this.rdoAdmins.TabIndex = 0;
            this.rdoAdmins.TabStop = true;
            this.rdoAdmins.Text = "Show Admins";
            this.rdoAdmins.UseVisualStyleBackColor = true;
            this.rdoAdmins.CheckedChanged += new System.EventHandler(this.rdoUserTypes_CheckChanged);
            // 
            // btnDeleteSelectedUser
            // 
            this.btnDeleteSelectedUser.Enabled = false;
            this.btnDeleteSelectedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedUser.Location = new System.Drawing.Point(907, 152);
            this.btnDeleteSelectedUser.Name = "btnDeleteSelectedUser";
            this.btnDeleteSelectedUser.Size = new System.Drawing.Size(161, 39);
            this.btnDeleteSelectedUser.TabIndex = 1;
            this.btnDeleteSelectedUser.Text = "Delete Selected User";
            this.btnDeleteSelectedUser.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedUser.Click += new System.EventHandler(this.btnDeleteSelectedUser_Click);
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateStudent.Location = new System.Drawing.Point(16, 197);
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
            this.btnCreateParent.Location = new System.Drawing.Point(16, 146);
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
            this.btnCreateTeacher.Location = new System.Drawing.Point(16, 95);
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1197, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // gbxManageClasses
            // 
            this.gbxManageClasses.Controls.Add(this.lstStudentsInKlass);
            this.gbxManageClasses.Controls.Add(this.lstClasses);
            this.gbxManageClasses.Controls.Add(this.btnCreateClass);
            this.gbxManageClasses.Location = new System.Drawing.Point(24, 379);
            this.gbxManageClasses.Name = "gbxManageClasses";
            this.gbxManageClasses.Size = new System.Drawing.Size(1041, 309);
            this.gbxManageClasses.TabIndex = 2;
            this.gbxManageClasses.TabStop = false;
            this.gbxManageClasses.Text = "Manage Classes";
            // 
            // lstStudentsInKlass
            // 
            this.lstStudentsInKlass.Enabled = false;
            this.lstStudentsInKlass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStudentsInKlass.FormattingEnabled = true;
            this.lstStudentsInKlass.ItemHeight = 16;
            this.lstStudentsInKlass.Location = new System.Drawing.Point(473, 39);
            this.lstStudentsInKlass.Name = "lstStudentsInKlass";
            this.lstStudentsInKlass.Size = new System.Drawing.Size(180, 228);
            this.lstStudentsInKlass.TabIndex = 7;
            // 
            // lstClasses
            // 
            this.lstClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClasses.FormattingEnabled = true;
            this.lstClasses.ItemHeight = 16;
            this.lstClasses.Location = new System.Drawing.Point(263, 39);
            this.lstClasses.Name = "lstClasses";
            this.lstClasses.Size = new System.Drawing.Size(180, 228);
            this.lstClasses.TabIndex = 6;
            this.lstClasses.SelectedIndexChanged += new System.EventHandler(this.lstClasses_SelectedIndexChanged);
            // 
            // btnCreateClass
            // 
            this.btnCreateClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateClass.Location = new System.Drawing.Point(16, 39);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Size = new System.Drawing.Size(217, 39);
            this.btnCreateClass.TabIndex = 5;
            this.btnCreateClass.Text = "Create New Class";
            this.btnCreateClass.UseVisualStyleBackColor = true;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.mathWizGroup3DataSet1;
            // 
            // parentsBindingSource
            // 
            this.parentsBindingSource.DataMember = "parents";
            this.parentsBindingSource.DataSource = this.mathWizGroup3DataSet1;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.mathWizGroup3DataSet1;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // parentsTableAdapter
            // 
            this.parentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // klassesBindingSource
            // 
            this.klassesBindingSource.DataMember = "klasses";
            this.klassesBindingSource.DataSource = this.mathWizGroup3DataSet1;
            // 
            // klassesTableAdapter
            // 
            this.klassesTableAdapter.ClearBeforeFill = true;
            // 
            // fKstudentsKlassI44FF419ABindingSource
            // 
            this.fKstudentsKlassI44FF419ABindingSource.DataMember = "FK__students__KlassI__44FF419A";
            this.fKstudentsKlassI44FF419ABindingSource.DataSource = this.klassesBindingSource;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(907, 205);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(161, 39);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // frmAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1197, 688);
            this.Controls.Add(this.gbxManageClasses);
            this.Controls.Add(this.gbxManageAccounts);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdminHome";
            this.Text = "MathWiz - Admin Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdminHome_Load);
            this.gbxManageAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizGroup3DataSet1)).EndInit();
            this.pnlUserTypes.ResumeLayout(false);
            this.pnlUserTypes.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxManageClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKstudentsKlassI44FF419ABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxManageAccounts;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button btnCreateParent;
        private System.Windows.Forms.Button btnCreateTeacher;
        private System.Windows.Forms.Button btnCreateAdmin;
        private System.Windows.Forms.Button btnDeleteSelectedUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxManageClasses;
        private System.Windows.Forms.Panel pnlUserTypes;
        private System.Windows.Forms.RadioButton rdoStudents;
        private System.Windows.Forms.RadioButton rdoParents;
        private System.Windows.Forms.RadioButton rdoTeachers;
        private System.Windows.Forms.RadioButton rdoAdmins;
        private System.Windows.Forms.Button btnCreateClass;
        private System.Windows.Forms.ListBox lstClasses;
        private MathWizGroup3DataSet mathWizGroup3DataSet1;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private MathWizGroup3DataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.BindingSource parentsBindingSource;
        private MathWizGroup3DataSetTableAdapters.parentsTableAdapter parentsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private MathWizGroup3DataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.ListBox lstStudentsInKlass;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private MathWizGroup3DataSetTableAdapters.adminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnViewUserInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.BindingSource klassesBindingSource;
        private MathWizGroup3DataSetTableAdapters.klassesTableAdapter klassesTableAdapter;
        private System.Windows.Forms.BindingSource fKstudentsKlassI44FF419ABindingSource;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}
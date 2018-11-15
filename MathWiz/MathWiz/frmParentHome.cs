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
    public partial class frmParentHome : Form
    {
        Parent parent;
        public frmParentHome(string username)
        {
            InitializeComponent();
            parent = MathWizDA.SelectParent(username);
        }

        private void frmParentHome_Load(object sender, EventArgs e)
        {
            List<Student> myChildren = MathWizDA.SelectStudentsViaParent(parent.Id);
            foreach (Student child in myChildren) {
                lstChildren.Items.Add(child);
            }
        }

        private void frmParentHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutBox = new frmAboutBox();
            aboutBox.ShowDialog();
        }

    }
}

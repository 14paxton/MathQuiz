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
    public partial class frmAdminHome : Form
    {
        public frmAdminHome()
        {
            InitializeComponent();
        }

        private void frmAdminHome_Load(object sender, EventArgs e)
        {

        }

        private void frmAdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form = new frmLogin();
            form.Show();
        }
    }
}

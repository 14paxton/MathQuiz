﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTeacherHome("TylerPerry"));
            Application.Run(new frmLogin());
            //Question.GeneratesSubtractDivide(true, 1);
            //Question.GeneratesAddMultiply(false);


        }
    }
}

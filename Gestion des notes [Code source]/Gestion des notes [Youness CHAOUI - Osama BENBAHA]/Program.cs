using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.forms;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.forms;
using Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.GUI.test;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Application.Run(new loginForm());
            Application.Run(new authentificationForm());
            //Application.Run(new adminForm());
        }
    }
}

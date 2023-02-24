using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using POS.GUI;
using POS.GUI.Inventory;
using POS.GUI.Maintains;
using POS.GUI.POS;
using POS.GUI.Purchases;
using POS.GUI.User;
using POS.Test;

namespace POS
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
            //            var progressbar_FRM = new PROGRESSBAR_FRM();
            //            Application.Run(new SICAT_FRM(progressbar_FRM));
            var mainForm = new LOGIN_FRM();
            // mainForm.SetUpContainer();
            Application.Run(mainForm);
        }
    }
}

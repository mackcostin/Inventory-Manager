﻿using Inventory_Manager.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Manager.Settings;

namespace Inventory_Manager
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
            if (Properties.Settings.Default.SetupCompleted == true)
            {
                Application.Run(new MainForm());
            }
            else
            {
                Application.Run(new SetupForm());
            }
        }
    }
}

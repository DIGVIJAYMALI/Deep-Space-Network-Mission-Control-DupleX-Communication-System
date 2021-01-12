﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Payload
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // MessageBox.Show("Arg =" + e.Args[0].ToString());
            string SpacecraftName = e.Args[0].ToString();
            string PayloadName = e.Args[1].ToString();
            MainWindow window = new MainWindow(SpacecraftName, PayloadName);
            this.MainWindow = window;



            window.Show();
        }
    }
}

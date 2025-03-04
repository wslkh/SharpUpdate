﻿using SharpUpdate;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        private SharpUpdater updater;

        public Form1()
        {
            InitializeComponent();

            label1.Text = ProductName + "\n" + ProductVersion;

            updater = new SharpUpdater(Assembly.GetExecutingAssembly(), this, new Uri("https://raw.githubusercontent.com/wslkh/SharpUpdate/master/project.xml"));
            
            //Assembly:TestApp, Version=3.1.0.0, Culture=neutral, PublicKeyToken=null
            //Console.WriteLine("Assembly:" + Assembly.GetExecutingAssembly());

            //updater = new SharpUpdater(Assembly.GetExecutingAssembly(), this, new Uri(new System.IO.FileInfo(@"..\..\..\project.xml").FullName));       // for local testing
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();
        }
    }
}

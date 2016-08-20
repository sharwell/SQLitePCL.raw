﻿using System.Reflection;
using Xunit.Runners.UI;

namespace Tests.WP80
{
    public partial class MainPage : RunnerApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnInitializeRunner()
        {
            SQLitePCL.Batteries.Init();
            
            // tests can be inside the main assembly
            AddTestAssembly(Assembly.GetExecutingAssembly());
            // otherwise you need to ensure that the test assemblies will 
            // become part of the app bundle
            AddTestAssembly(typeof(SQLitePCL.Tests.Init).Assembly);

        }
    }
}

﻿using System;
using System.Windows;
using Caliburn.Micro;
using Setup.Silverlight.ViewModels;

namespace Setup.Silverlight
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}

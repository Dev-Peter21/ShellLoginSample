﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellLoginSample
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }
    }

    public class HiddenItem : ShellItem
    {

    }
}

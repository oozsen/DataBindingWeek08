﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DataBindingWeek08
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            BindingContext = new MyBindingObject();
        }
    }
}

using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DataBindingWeek08
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
            //BindingContext = new MyBindingObject();
            
            ResultLabel.BindingContext = new MyBindingObject
            {
                Color = "TempColor",
                Name = "Bim493"
            };
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBindingWeek08
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //BindingContext = new MainViewModel();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}

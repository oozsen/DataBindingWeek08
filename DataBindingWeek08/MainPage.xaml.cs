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
            //BindingContext = new MainViewModel();   //instead it's used on the XAML side.
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        void Button2_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
    }
}

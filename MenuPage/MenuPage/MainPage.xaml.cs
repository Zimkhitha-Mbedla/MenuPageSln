using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MenuPage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void RecycleWaste_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecycleWaste());
        }

        private void ThriftStores_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThriftStores());
        }

        private void Learn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Learn());
        }

        private void RecycleBuddy_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecycleBuddy());
        }
    }
}

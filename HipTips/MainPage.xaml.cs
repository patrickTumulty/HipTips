using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HipTips
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible (true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void nav_NewShiftPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ShiftPage());
        }

        void nav_ShiftListPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ShiftListView());
        }
    }
}

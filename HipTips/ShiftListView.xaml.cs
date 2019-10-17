using System;
using System.Collections.Generic;
using SQLite;
using System.Linq;
using Xamarin.Forms;

namespace HipTips
{
    public partial class ShiftListView : ContentPage
    {
        public ShiftListView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Shift>();
                var shifts = conn.Table<Shift>().ToList();
                BindingContext = shifts;
            }
        }


        void nav_ShiftDetail(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            Shift target = e.Item as Shift;
            Navigation.PushAsync(new ShiftDetailPage(target));
        }
    }
}

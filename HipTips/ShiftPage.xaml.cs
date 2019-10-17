using System;
using System.Collections.Generic;
using SQLite;
using Xamarin.Forms;


namespace HipTips
{
    public partial class ShiftPage : ContentPage
    {
        public ShiftPage()
        {
            InitializeComponent();
        }

        void Save_Shift(object sender, System.EventArgs e)
        {
            DatePicker datePicker = new DatePicker();
            Shift shift = new Shift(Convert.ToDouble(ent_Tips.Text), Convert.ToDouble(ent_Hours.Text), datePicker.Date);

            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Shift>();
                int rowsAdded = conn.Insert(shift);
            }

            Navigation.PopAsync();
        }
    }
}

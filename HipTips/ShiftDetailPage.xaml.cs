using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HipTips
{
    public partial class ShiftDetailPage : ContentPage
    {
        public ShiftDetailPage()
        {
            InitializeComponent();
        }

        public ShiftDetailPage(object s)
        {
            InitializeComponent();
            var _shift = s;
            BindingContext = _shift;
        }
    }
}

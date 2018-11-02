using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ergo
{
    public partial class Video : ContentPage
    {
        public Video()
        {
            InitializeComponent();

            btn_Forward.Clicked += (s, e) => Navigation.PushAsync(new Step1());

        }
    }
}

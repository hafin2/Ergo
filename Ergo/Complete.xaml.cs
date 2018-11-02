using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ergo
{
    public partial class Complete : ContentPage
    {
        public Complete()
        {
            InitializeComponent();
            btn_Home.Clicked += (s, e) => Navigation.PushAsync(new MainPage());
        }
    }
}

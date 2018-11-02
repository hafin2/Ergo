using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ergo
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();

            VideoBtn.Clicked += (s, e) => Navigation.PushAsync(new Video());
        }

}
}

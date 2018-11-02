using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ergo
{
    public partial class Step2 : ContentPage
    {
        public Step2()
        {
            InitializeComponent();

            btn_Forward.Clicked += (s, e) => Navigation.PushAsync(new Complete());
        }
    }
}

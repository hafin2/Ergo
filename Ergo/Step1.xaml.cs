using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ergo
{
    public partial class Step1 : ContentPage
    {
        public Step1()
        {
            InitializeComponent();

            btn_Forward.Clicked += (s, e) => Navigation.PushAsync(new Step2());
        }
    }
}

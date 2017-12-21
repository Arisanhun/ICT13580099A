using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580099A
{
    public partial class NAVPage1 : ContentPage
    {
        public NAVPage1()
        {
            InitializeComponent();
            nextButton.Clicked += NextButton_Clicked;
        }


        void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NAVPage2());
        }
    }
}

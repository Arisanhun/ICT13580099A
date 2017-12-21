using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580099A
{
    public partial class NAVPage2 : ContentPage
    {
        public NAVPage2()
        {
            InitializeComponent();
            nextButton.Clicked += NextButton_Clicked;
            backButton.Clicked += BackButton_Clicked;


        }

        void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavPage3());
        }

        void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
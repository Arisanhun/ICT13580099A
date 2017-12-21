using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ICT13580099A.Droid
{
    [Activity(Label = "ICT13580099A.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = https://www.google.co.th/search?q=kalie&rlz=1C5CHFA_enTH562TH562&source=lnms&tbm=isch&sa=X&ved=0ahUKEwjCl5O1jr3WAhVEo48KHc3wAbEQ_AUICigB&biw=1673&bih=947#imgrc=pjjYGqBOWQWGaM:Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());
        }
    }
}

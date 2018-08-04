using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System.Drawing;
using Android.Views;

namespace sit313project1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            //show splash screen
            var config = new SplashScreen(this)
                .WithFullScreen()
                .WithSplashScreen(Java.Lang.Class.FromType(typeof(SplashScreen)))
                .WithSplashTimeOut(5000)
                .WithBackgroundColor(Color.ParseColor("#074E72"))
                .WithHeadText("Welcome Guest !!!")
                .WithFooterText("Copyright 2018")
                .WithBeforeLogoText("YUAN")
                .WithAfterLogoText("This is Splash Screen");


            config.HeaderTextView.SetTextColor(Color.White);
            config.FooterTextView.SetTextColor(Color.White);
            config.BeforeLogoTextView.SetTextColor(Color.White);
            config.AfterLogoTextView.SetTextColor(Color.White);

            View view = config.Create();

            SetContentView(view);



        }
    }
}


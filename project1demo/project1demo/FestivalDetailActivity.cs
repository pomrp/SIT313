using Android.App;
using Android.OS;
using SupportToolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using System;
using Android.Widget;
using Android.Views;
using project1demo.Fragments;

namespace project1demo
{
    [Activity(Label = "FestivalDetailActivity", Theme = "@style/Theme.DesignDemo")]
    public class FestivalDetailActivity : AppCompatActivity
    {
        public const string EXTRA_NAME = "Festival_name";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Activity_Detail);

            SupportToolbar toolBar = FindViewById<SupportToolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolBar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            string festivalName = Intent.GetStringExtra(EXTRA_NAME);

            CollapsingToolbarLayout collapsingToolBar = FindViewById<CollapsingToolbarLayout>(Resource.Id.collapsing_toolbar);
            collapsingToolBar.Title = festivalName;

            LoadBackDrop();
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    Finish();
                    return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.sample_actions, menu);
            return true;
        }

        private void LoadBackDrop()
        {
            ImageView imageView = FindViewById<ImageView>(Resource.Id.backdrop);
            imageView.SetImageResource(festival.RandomFestivalDrawable);
        }
    }
}
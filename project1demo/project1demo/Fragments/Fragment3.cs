﻿using Android.OS;
using Android.Views;
using project1demo;
using SupportFragment = Android.Support.V4.App.Fragment;

namespace project1demo.Fragments
{
    public class Fragment3 : SupportFragment

    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.Fragment3, container, false);

            return view;
        }
    }
}
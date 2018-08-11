using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace project1demo.Fragments
{
    public static class festival
    {
        private static Random RANDOM = new Random();

        public static int RandomFestivalDrawable
        {
            get
            {
                switch (RANDOM.Next(5))
                {
                    default:
                    case 0:
                        return Resource.Drawable.festival_1;
                    case 1:
                        return Resource.Drawable.festival_2;
                    case 2:
                        return Resource.Drawable.festival_3;
                    case 3:
                        return Resource.Drawable.festival_4;
                    case 4:
                        return Resource.Drawable.festival_5;
                }
            }
        }
        public static List<string> FestivalStrings
        {
            get
            {
                return new List<string>() {"Chinese New Year", "Chinese Lanterrn Festival", "Qingming Festival",
                    "Dragon Boat Festival", "Qixi Festival", "Middle-autumn Festival", "Chongyang Festival"};
            }
        }

        public static int CalculateInSampleSize(BitmapFactory.Options options, int reqWidth, int reqHeight)
        {
            // Raw height and width of image
            int height = options.OutHeight;
            int width = options.OutWidth;
            int inSampleSize = 1;

            if (height > reqHeight || width > reqWidth)
            {

                // Calculate ratios of height and width to requested height and
                // width
                int heightRatio = height / reqHeight;
                int widthRatio = width / reqWidth;

                // Choose the smallest ratio as inSampleSize value, this will
                // guarantee
                // a final image with both dimensions larger than or equal to the
                // requested height and width.
                inSampleSize = heightRatio < widthRatio ? heightRatio : widthRatio;
            }

            return inSampleSize;
        }
    }
}
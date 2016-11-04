using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace RealCocktails.Droid.Utility
{
    public class ImageHelper
    {
        public static Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;
            using (var webclient = new WebClient())
            {
                byte[] imageBytes = webclient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }
            return imageBitmap;
        }
    }
}
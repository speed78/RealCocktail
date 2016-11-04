using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace RealCocktails.Droid
{
    [Activity(Label = "MenuActivity", MainLauncher = true)]
    public class MenuActivity : Activity
    {
        private Button _menuButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MenuView);
            FindViews();
            HandleEvents();
        }

        private void FindViews()
        {
            _menuButton = FindViewById<Button>(Resource.Id.menuButton);

        }

        private void HandleEvents()
        {
           _menuButton.Click+=MenuButtonOnClick;
        }

        private void MenuButtonOnClick(object sender, EventArgs eventArgs)
        {
            var intent=new Intent(this,typeof(CocktailMenuActivity));
            StartActivity(intent);
        }
    }
}
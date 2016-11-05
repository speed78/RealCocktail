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
using RealCocktails.Core.Model;
using RealCocktails.Core.Service;
using RealCocktails.Droid.Adapter;
using RealCocktails.Droid.Fragments;

namespace RealCocktails.Droid
{
    [Activity(Label = "CocktailMenuActivity", MainLauncher = false)]
    public class CocktailMenuActivity : Activity
    {
        private ListView _cocktailListView;
        private List<Cocktail> _allCocktails;
        private CocktailsDataService _dataService;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CocktailsMenuView);
            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            AddTab("tutti", Resource.Drawable.allCoctails, new FavoriteCocktailFragment());
           // AddTab("Preveriti", Resource.Drawable.allCoctails, new FavoriteCocktailFragment());


        }

        private void AddTab(string tabText, int iconResourceId, Fragment view)
        {
            var tab = this.ActionBar.NewTab();
            tab.SetText(tabText);
            tab.SetIcon(iconResourceId);
            tab.TabSelected += delegate (object sender, ActionBar.TabEventArgs e)
            {
                var fragment = this.FragmentManager.FindFragmentById(Resource.Id.fragmentContainer);
                if (fragment != null)
                {
                    e.FragmentTransaction.Remove(fragment);
                }
                e.FragmentTransaction.Add(Resource.Id.fragmentContainer, view);
            };
            tab.TabUnselected += delegate (object sender, ActionBar.TabEventArgs e)
            {

                e.FragmentTransaction.Remove(view);
            };
            this.ActionBar.AddTab(tab);
        }

        private void Tab_TabSelected(object sender, ActionBar.TabEventArgs e)
        {

        }




       
    }
}
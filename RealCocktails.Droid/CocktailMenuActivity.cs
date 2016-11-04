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
            _cocktailListView = FindViewById<ListView>(Resource.Id.cocktailListView);
            _dataService = new CocktailsDataService();
            _allCocktails = _dataService.GetAllCocktails();
            _cocktailListView.Adapter = new CocktailListAdapter(this, _allCocktails);
            _cocktailListView.ItemClick += CocktailListViewOnItemClick;
        }

        private void CocktailListViewOnItemClick(object sender, AdapterView.ItemClickEventArgs itemClickEventArgs)
        {
            Cocktail cocktail = _allCocktails[itemClickEventArgs.Position];
            Intent intent = new Intent();
            intent.SetClass(this, typeof(CocktailDetailActivity));
            intent.PutExtra("selectedId", cocktail.Id);
            StartActivityForResult(intent, 100);


        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (resultCode == Result.Ok && requestCode == 100)
            {
                var selectedCocktail = _dataService.GetCocktail(data.GetIntExtra("selectedId", 0));

                var amount = data.GetIntExtra("amount", 0);
                var quantity = data.GetIntExtra("quantity", 0);
                var dialog = new AlertDialog.Builder(this);
                dialog.SetTitle("conferma");
                dialog.SetMessage(String.Format("hai ordinato N° {0} {1} per un tottale di € {2}", quantity, selectedCocktail.Name, amount));
                dialog.Show();


            }
        }
    }
}
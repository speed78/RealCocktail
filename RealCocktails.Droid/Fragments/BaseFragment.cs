using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using RealCocktails.Core.Model;
using RealCocktails.Core.Service;
using RealCocktails.Droid.Adapter;

namespace RealCocktails.Droid.Fragments
{
    public class BaseFragment : Fragment
    {
        protected ListView _listView;
        protected CocktailsDataService _dataServices;
        protected List<Cocktail> _cocktails;

        public BaseFragment()
        {
            _dataServices = new CocktailsDataService();
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            FindViews();
            HandleEvent();
            _cocktails = new CocktailsDataService().GetAllCocktails();
            _listView.Adapter = new CocktailListAdapter(this.Activity, _cocktails);
        }

        protected void FindViews()
        {
            _listView = this.View.FindViewById<ListView>(Resource.Id.cocktailListView);
        }

        protected void HandleEvent()
        {
            _listView.ItemClick += ListViewOnItemClick;
        }

        private void ListViewOnItemClick(object sender, AdapterView.ItemClickEventArgs itemClickEventArgs)
        {
            var cocktail = _cocktails[itemClickEventArgs.Position];
            var intent = new Intent();

            intent.SetClass(this.Activity, typeof(CocktailDetailActivity));
            intent.PutExtra("selectedId", cocktail.Id);
            StartActivityForResult(intent, 100);
        }

        public override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (resultCode == Result.Ok && requestCode == 100)
            {
                var selectedCocktail = _dataServices.GetCocktail(data.GetIntExtra("selectedId", 0));

                var amount = data.GetIntExtra("amount", 0);
                var quantity = data.GetIntExtra("quantity", 0);
                var dialog = new AlertDialog.Builder(this.Activity);
                dialog.SetTitle("conferma");
                dialog.SetMessage(String.Format("hai ordinato N° {0} {1} per un tottale di € {2}", quantity, selectedCocktail.Name, amount));
                dialog.Show();


            }
        }
    }
}
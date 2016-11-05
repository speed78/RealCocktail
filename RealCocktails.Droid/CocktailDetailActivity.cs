using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using RealCocktails.Core.Model;
using RealCocktails.Core.Service;
using RealCocktails.Droid.Utility;

namespace RealCocktails.Droid
{
    [Activity(Label = "Cocktail Detail", MainLauncher = false, Icon = "@drawable/icon")]
    public class CocktailDetailActivity : Activity
    {
        private ImageView _cocktailImageView;
        private TextView _nametextView;
        private TextView _preparationTextView;
        private TextView _priceTextView;
        private TextView _quantityEditText;
        private Button _orderButton;
        private Cocktail _selectedCocktail;
        private CocktailsDataService _dataservice;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var selectedId = Intent.Extras.GetInt("selectedId");
            SetContentView(Resource.Layout.CocktailDetailView);
            _dataservice = new CocktailsDataService();
            _selectedCocktail = _dataservice.GetCocktail(selectedId);

            FindViews();
            BindData();
            HandleEvents();

        }

        private void FindViews()
        {
            _cocktailImageView = FindViewById<ImageView>(Resource.Id.cocktailImageView);
            _nametextView = FindViewById<TextView>(Resource.Id.nametextView);
            _preparationTextView = FindViewById<TextView>(Resource.Id.preparationTextView);
            _priceTextView = FindViewById<TextView>(Resource.Id.priceTextView);
            _quantityEditText = FindViewById<TextView>(Resource.Id.quantityEditText);
            _orderButton = FindViewById<Button>(Resource.Id.orderButton);
        }

        private void BindData()
        {
            _nametextView.Text = _selectedCocktail.Name;
            _preparationTextView.Text = _selectedCocktail.Preparation;
            _priceTextView.Text = "prezzo:" + _selectedCocktail.Price;
            //var imageBitmap =
            //    ImageHelper.GetImageBitmapFromUrl("https://s-media-cache-ak0.pinimg.com/236x/85/aa/4f/85aa4faff3ab916edc6266cddc5fb6d1.jpg");
            //_cocktailImageView.SetImageBitmap(imageBitmap);
        }

        private void HandleEvents()
        {
            _orderButton.Click += _orderButton_Click;
        }

        private void _orderButton_Click(object sender, EventArgs e)
        {
            var amount = _selectedCocktail.Price * int.Parse(_quantityEditText.Text);
            Intent intent = new Intent();
            intent.PutExtra("selectedId", _selectedCocktail.Id);
            intent.PutExtra("amount", amount);
            intent.PutExtra("quantity", int.Parse(_quantityEditText.Text));
            SetResult(Result.Ok, intent);
            this.Finish();
        }
    }
}
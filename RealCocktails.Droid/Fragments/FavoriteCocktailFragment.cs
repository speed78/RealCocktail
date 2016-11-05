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
using RealCocktails.Droid.Adapter;

namespace RealCocktails.Droid.Fragments
{
    public class FavoriteCocktailFragment : BaseFragment
    {


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            return inflater.Inflate(Resource.Layout.FavoriteCocktailFragment, container, false);
        }
    }
}
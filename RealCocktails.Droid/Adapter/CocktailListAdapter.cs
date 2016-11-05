using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using RealCocktails.Core.Model;
using RealCocktails.Droid.Utility;

namespace RealCocktails.Droid.Adapter
{
    public class CocktailListAdapter : BaseAdapter<Cocktail>
    {
        private Activity _context;
        private List<Cocktail> _items;

        public CocktailListAdapter(Activity context, List<Cocktail> items) : base()
        {
            _context = context;
            _items = items;

        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _items[position];
            //var imageBitmap = ImageHelper.GetImageBitmapFromUrl("https://s-media-cache-ak0.pinimg.com/236x/85/aa/4f/85aa4faff3ab916edc6266cddc5fb6d1.jpg"); ;

            if (convertView == null)
            {
                convertView = _context.LayoutInflater.Inflate(Resource.Layout.CocktailRowView, null);
            }
            convertView.FindViewById<TextView>(Resource.Id.cocktailNameTextView).Text = item.Name;
            convertView.FindViewById<TextView>(Resource.Id.cocktailPrepationTextView).Text = item.Preparation;
            //convertView.FindViewById<ImageView>(Resource.Id.cocktailImageView).SetImageBitmap(imageBitmap);
            return convertView;
        }

        public override int Count
        {
            get { return _items.Count; }
        }

        public override Cocktail this[int position]
        {
            get { return _items[position]; }
        }
    }
}

using System.Collections.Generic;

namespace RealCocktails.Core.Model
{
    public class CocktailGroup
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public List<Cocktail> Cocktails { get; set; }
    }
}

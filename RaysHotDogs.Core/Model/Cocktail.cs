using System.Collections.Generic;

namespace RealCocktails.Core.Model
{
    public class Cocktail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Preparation { get; set; }
        public string ImagePath { get; set; }
        public int Price { get; set; }
        public bool Available { get; set; }
        public int PrepTime { get; set; }
        public List<string> Ingredients { get; set; }
        public bool IsAlcoholic { get; set; }
        public string GroupName { get; set; }
        //
    }
}

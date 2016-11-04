using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealCocktails.Core.Model;
using RealCocktails.Core.Repositoty;

namespace RealCocktails.Core.Service
{
    public class CocktailsDataService
    {
        private static readonly CocktailsRepository _repository=new CocktailsRepository();


        public List<Cocktail> GetAllCocktails()
        {
            return _repository.GetAllCocktails();
        }

        public Cocktail GetCocktail(int id)
        {
            return _repository.GetCocktail(id);
        }

        public List<CocktailGroup> GetCocktailGroups()
        {
            return _repository.GetCocktailGroups();
        }

        public List<Cocktail> GetCocktailsForGroup(int idGroup)
        {
            return _repository.GetCocktailsForGroup(idGroup);
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using RealCocktails.Core.Model;

namespace RealCocktails.Core.Repositoty
{
    public class CocktailsRepository
    {
        private static List<CocktailGroup> _cocktailGroups = new List<CocktailGroup>()
        {
            new CocktailGroup()
            {
                Id = 1,
                Title = "Pre dinner",
                ImagePath = "",
                Cocktails = new List<Cocktail>()
                {

                    new Cocktail()
                    {
                        Id = 1,
                        Name = "Bellini",
                        Preparation = "Si prepara direttamente nel bicchiere a Flute.",
                        ImagePath = "cktl1",
                        Available = true,
                        PrepTime = 2,
                        Ingredients = new List<string>() {"7/10 Prosecco", "3/10 Pesca Frullata"},
                        IsAlcoholic = true,
                        Price = 2

                    },
                    new Cocktail()
                    {
                        Id = 1,
                        Name = "CubaLibre",
                        Preparation = "Si prepara direttamente nel bicchiere a Flute.",
                        ImagePath = "cktl1",
                        Available = true,
                        PrepTime = 2,
                        Ingredients = new List<string>() {"7/10 Prosecco", "3/10 Pesca Frullata"},
                        IsAlcoholic = true,
                        Price = 2

                    },
                    new Cocktail()
                    {
                        Id = 1,
                        Name = "GinTonic",
                        Preparation = "Si prepara direttamente nel bicchiere a Flute.",
                        ImagePath = "cktl1",
                        Available = true,
                        PrepTime = 2,
                        Ingredients = new List<string>() {"7/10 Prosecco", "3/10 Pesca Frullata"},
                        IsAlcoholic = true,
                        Price = 2

                    },
                    new Cocktail()
                    {
                        Id = 1,
                        Name = "Gin lemon",
                        Preparation = "Si prepara direttamente nel bicchiere a Flute.",
                        ImagePath = "cktl1",
                        Available = true,
                        PrepTime = 2,
                        Ingredients = new List<string>() {"7/10 Prosecco", "3/10 Pesca Frullata"},
                        IsAlcoholic = true,
                        Price = 2

                    },
                    new Cocktail()
                    {
                        Id = 1,
                        Name = "Gin Fizz",
                        Preparation = "Si prepara direttamente nel bicchiere a Flute.",
                        ImagePath = "cktl1",
                        Available = true,
                        PrepTime = 2,
                        Ingredients = new List<string>() {"7/10 Prosecco", "3/10 Pesca Frullata"},
                        IsAlcoholic = true,
                        Price = 2

                    },
                    new Cocktail()
                    {
                        Id = 1,
                        Name = "Tequila sunrise",
                        Preparation = "Si prepara direttamente nel bicchiere a Flute.",
                        ImagePath = "cktl1",
                        Available = true,
                        PrepTime = 2,
                        Ingredients = new List<string>() {"7/10 Prosecco", "3/10 Pesca Frullata"},
                        IsAlcoholic = true,
                        Price = 2

                    },
                    new Cocktail()
                    {
                        Id = 1,
                        Name = "Long Island",
                        Preparation = "Si prepara direttamente nel bicchiere a Flute.",
                        ImagePath = "cktl1",
                        Available = true,
                        PrepTime = 2,
                        Ingredients = new List<string>() {"7/10 Prosecco", "3/10 Pesca Frullata"},
                        IsAlcoholic = true,
                        Price = 2

                    },
                    new Cocktail()
                    {
                        Id = 1,
                        Name = "Mojito",
                        Preparation = "Si prepara direttamente nel bicchiere a Flute.",
                        ImagePath = "cktl1",
                        Available = true,
                        PrepTime = 2,
                        Ingredients = new List<string>() {"7/10 Prosecco", "3/10 Pesca Frullata"},
                        IsAlcoholic = true,
                        Price = 2

                    },
                    new Cocktail()
                    {
                        Id = 1,
                        Name = "Mad Man",
                        Preparation = "Si prepara direttamente nel bicchiere a Flute.",
                        ImagePath = "cktl1",
                        Available = true,
                        PrepTime = 2,
                        Ingredients = new List<string>() {"7/10 Prosecco", "3/10 Pesca Frullata"},
                        IsAlcoholic = true,
                        Price = 2

                    },
                    new Cocktail()
                    {
                        Id = 1,
                        Name = "B52",
                        Preparation = "Si prepara direttamente nel bicchiere a Flute.",
                        ImagePath = "cktl1",
                        Available = true,
                        PrepTime = 2,
                        Ingredients = new List<string>() {"7/10 Prosecco", "3/10 Pesca Frullata"},
                        IsAlcoholic = true,
                        Price = 2

                    },
                    new Cocktail()
                    {
                        Id = 1,
                        Name = "Capiroska",
                        Preparation = "Si prepara direttamente nel bicchiere a Flute.",
                        ImagePath = "cktl1",
                        Available = true,
                        PrepTime = 2,
                        Ingredients = new List<string>() {"7/10 Prosecco", "3/10 Pesca Frullata"},
                        IsAlcoholic = true,
                        Price = 2

                    },
                    new Cocktail()
                    {
                        Id = 1,
                        Name = "Vodka Lemon",
                        Preparation = "Si prepara direttamente nel bicchiere a Flute.",
                        ImagePath = "cktl1",
                        Available = true,
                        PrepTime = 2,
                        Ingredients = new List<string>() {"7/10 Prosecco", "3/10 Pesca Frullata"},
                        IsAlcoholic = true,
                        Price = 2

                    },

                    new Cocktail()
                    {
                        Id = 2,
                        Name = "Americano",
                        Preparation =
                            "Miscelare direttamente sul Ghiaccio nel bicchiere Old Fashined. Completare con Soda Water. Decorare con mezza fetta d’ Arancia e Scorza di Limone.",
                        ImagePath = "cktl2",
                        Available = true,
                        PrepTime = 4,
                        Ingredients = new List<string>() {"1/2 Bitter", "1/2 Vermouth Rosso", "Soda Water"},
                        IsAlcoholic = true,
                        Price = 2

                    }
                }

            },


            new CocktailGroup()
            {
                Id = 2,
                Title = "After dinner",
                ImagePath = "",
                Cocktails = new List<Cocktail>()
                {

                    new Cocktail()
                    {
                        Id = 3,
                        Name = "Daiquiri",
                        Preparation = "Shakerare con Ghiaccio e servire nella Coppa da Cocktail.",
                        ImagePath = "cktl3",
                        Available = true,
                        PrepTime = 2,
                        Ingredients =
                            new List<string>()
                            {
                                "6/10 Rum Bianco",
                                "3/10 Succo di Lime",
                                "1/10 Sciroppo di Zucchero di Canna"
                            },
                        IsAlcoholic = true,
                        Price = 2

                    },
                    new Cocktail()
                    {
                        Id = 4,
                        Name = "Grasshopper",
                        Preparation = "Si prepara nello Shaker con Ghiaccio. Si serve nella Coppa da Cocktail.",
                        ImagePath = "cktl4",
                        Available = true,
                        PrepTime = 1,
                        Ingredients =
                            new List<string>()
                            {
                                "1/3 Crema di Menta Verde",
                                "1/3 Crema di Cacao Bianca",
                                "1/3 Crema di Latte"
                            },
                        IsAlcoholic = true,
                        Price = 2

                    }
                }
            }
        };

        public List<Cocktail> GetAllCocktails()
        {
            return _cocktailGroups.SelectMany(p => p.Cocktails).ToList();
        }

        public Cocktail GetCocktail(int id)
        {
            return _cocktailGroups.SelectMany(x => x.Cocktails.Where(p => p.Id == id)).FirstOrDefault();
        }

        public List<CocktailGroup> GetCocktailGroups()
        {
            return _cocktailGroups;
        }

        public List<Cocktail> GetCocktailsForGroup(int idGroup)
        {
            return _cocktailGroups.Where(p => p.Id == idGroup).SelectMany(p => p.Cocktails).ToList();
        }

    }








}

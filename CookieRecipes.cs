using cookies_cookBook.IngredientsNameSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace cookies_cookBook
{
    public class CookieRecipes
    {
      public List <Ingredients> IngredientsList { private get;  set; } = new List<Ingredients>();

        public void AddList(Ingredients item)
        {
            IngredientsList.Add(item);
           
        }
        public  void ListAll()
        {
            foreach (var ingredient in IngredientsList)
            {
                Console.WriteLine($"ingredint:{ingredient.Name}");
            }
        } 
    }
}

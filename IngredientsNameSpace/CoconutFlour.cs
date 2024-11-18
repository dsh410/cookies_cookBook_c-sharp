using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cookies_cookBook.IngredientsNameSpace
{
    public class CoconutFlour : Ingredients
    {
        override public string Name => "Coconut Flour";
        override public int ID => 2;

        override public void Preparation()
        {
            Console.WriteLine("Sieve. Add to other ingredients.");
        }
    }
}

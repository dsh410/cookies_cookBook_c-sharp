using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cookies_cookBook.IngredientsNameSpace
{
    public class WheatFlour: Ingredients
    {
        override public string Name => "Wheat Flour";
        override public int ID => 1;

        override public void Preparation()
        {
            Console.WriteLine("Sieve. Add to other ingredients.");
        }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cookies_cookBook.Ingredients
{
    public class Chocolate : Ingredients
    {
        override public string Name => "Chocolate";
        override public int ID => 4;
        override public void Preparation()
        {
            Console.WriteLine("Melt in a water bath. Add to other ingredients.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cookies_cookBook.Ingredients
{
    public class Cinnamon : Ingredients
    {
        override public string Name => "Cinnamon";
        override public int ID => 7;
        override public void Preparation()
        {
            Console.WriteLine("Take half a teaspoon. Add to other ingredients.");
        }
    }
}

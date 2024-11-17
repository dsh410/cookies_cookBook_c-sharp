using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cookies_cookBook.Ingredients
{
    public class Cardamom : Ingredients
    {
        override public string Name => "Cardamom";
        override public int ID => 6;
        override public void Preparation()
        {
            Console.WriteLine("Take half a teaspoon. Add to other ingredients.");
        }
    }
}

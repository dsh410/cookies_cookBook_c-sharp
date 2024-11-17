using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cookies_cookBook.Ingredients
{
    public class Sugar : Ingredients
    {
        override public string Name => "Sugar";
        override public int ID => 5;
        override public void Preparation()
        {
            Console.WriteLine("Add to other ingredients.");
        }
    }
}

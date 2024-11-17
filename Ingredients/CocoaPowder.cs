using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cookies_cookBook.Ingredients
{
    public class CocoaPowder : Ingredients
    {
        override public string Name => "Cocoa Powder";
        override public int ID => 8;
        override public void Preparation()
        {
            Console.WriteLine("Add to other ingredients.");
        }
    }
}

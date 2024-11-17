using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cookies_cookBook.Ingredients
{
    public class Butter : Ingredients
    {
        override public string Name => "Butter";
        override public int  ID => 3;
        override public void  Preparation()
        {
            Console.WriteLine("Melt on low heat. Add to other ingredients.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeWithArray
{
    class MenuMaker
    {
        public Random Randomizer;
        string[] Meats = { "Roast beef", "Chicken", "Pork steam", "Bacon" };
        string[] Condiments = { "yellow mustard", "brown mustard", "mayonaise" };
        string[] Breads = { "rye", "white", "wheat", "pumpernickel", "italian bread", "a roll" };

        public string GetMenuItem()
        {
            string rdMeat = Meats[Randomizer.Next(Meats.Length)];
            string rdCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string rdBread = Breads[Randomizer.Next(Breads.Length)];
            return rdMeat + " with " + rdCondiment + " on " + rdBread;
        }
    }
}

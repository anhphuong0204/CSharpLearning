using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPeopleUsingInterface
{
    class FunnyFunny : IClown
    {
        protected string funnyThingIHave;
        public string FunnyThingIHave { get { return funnyThingIHave; } }

        public void Honk()
        {
            Console.WriteLine("Hi, kids! I have a " + funnyThingIHave);
        }
        public FunnyFunny(string funnyFunny)
        {
            funnyThingIHave = funnyFunny;
        }
    }
}

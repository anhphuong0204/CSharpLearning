using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPeopleUsingInterface
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        private int numberOfScaryThings;
        public string ScaryThingIHave { get { return numberOfScaryThings + " spiders"; } }

        public void ScareLittleChildren()
        {
            Console.WriteLine("Boo! Gotcha!");
        }
        public ScaryScary (int numberOfScaryThings, string funnyFunny) : base(funnyFunny)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
    }
}

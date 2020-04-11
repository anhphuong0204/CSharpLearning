using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelsClass_HowToInherit_
{
    class Owner
    {
        private Jewels returnContents;
        public void ReceiveContents(Jewels safeContents)
        {
            returnContents = safeContents;
            Console.WriteLine("Thanks for returning my jewels! " + returnContents.Sparkle());
        }
    }
}

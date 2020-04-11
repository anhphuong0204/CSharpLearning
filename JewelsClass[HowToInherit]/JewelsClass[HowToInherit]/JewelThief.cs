using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelsClass_HowToInherit_
{
    class JewelThief : LockSmith
    {
        private Jewels stolenJewels = null;
        override public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("I've stolen the contents ! " + stolenJewels.Sparkle());
        }
        //public void SayMyName()
        //{
        //    Console.WriteLine("My name is Jewel Thief");
        //}
    }
}

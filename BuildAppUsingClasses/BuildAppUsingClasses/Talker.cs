using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildAppUsingClasses
{
    class Talker
    {
            public static int BlahBlah(string thingToSay, int timesToSay)
        {
            string finalStr = "";
            for (int i = 0; i < timesToSay; i++)
            {
                finalStr = finalStr + thingToSay + '\n';
            }
            MessageBox.Show(finalStr);
            return finalStr.Length;
        }
    }
}

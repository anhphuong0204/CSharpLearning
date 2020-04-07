using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWithRef
{
    class Elephant
    {
        public string Name;
        public int EarSize;

        public void WhoIAm()
        {
            MessageBox.Show("I am " + Name + ", my ear size is " + EarSize);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructorForBaseAndSubclass
{
    class Subclass : BaseClass
    {
        public Subclass(string subString, int anotherValue) : base(subString)
        {
            MessageBox.Show("This is subclass: " + subString + " and " + anotherValue);
        }
    }
}

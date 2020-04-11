using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructorForBaseAndSubclass
{
    class BaseClass
    {
        public BaseClass(string baseString)
        {
            MessageBox.Show("This is the base class: " + baseString);
        }
    }
}

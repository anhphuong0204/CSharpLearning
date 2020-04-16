using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StingInterface
{
    class Bee : IStingPatrol
    {
        public int AlertLevel { get { return 10; } }
        public int StingLength { get; set; }
        public bool LookForEnemies()
        {
            return true;
        }
        public int SharpenStinger(int length)
        {
            return length;
        }
    }
}

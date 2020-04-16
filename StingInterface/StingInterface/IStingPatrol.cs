using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StingInterface
{
    interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingLength { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int length);
    }
}

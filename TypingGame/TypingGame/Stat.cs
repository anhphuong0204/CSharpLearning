using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGame
{
    class Stat
    {
        public int Correct = 0;
        public int Miss = 0;
        public int Total = 0;
        public int Accuracy = 0;

        public void Update(bool correctKey)
        {
            Total++;
            if (!correctKey)
                Miss++;
            else
                Correct++;
            Accuracy = 100 * Correct / Total;
        }
    }
}

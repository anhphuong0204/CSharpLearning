﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelsClass_HowToInherit_
{
    class Safe
    {
        private Jewels contents = new Jewels();
        private string safeCombination = "123456";
        public Jewels Open(string combination)
        {
            if (combination == safeCombination)
                return contents;
            return null;
        }
        public void PickLock(LockSmith lockPicker)
        {
            lockPicker.WriteDownCombination(safeCombination);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSimulation
{
    class Outside : Location
    {
        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }

        private bool hot;
        public override string Description
        {
            get
            {
                string description = base.Description;
                if (hot)
                    description += " It's really hot here.";
                return description;
            }          
        }
    }
}

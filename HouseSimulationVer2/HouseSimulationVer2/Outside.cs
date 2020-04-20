using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSimulationVer2
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

    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool hot, string hidingPlace) : base(name, hot)
        {
            HidingPlace = hidingPlace;
        }
        public string HidingPlace { get; private set; }
    }
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot)
        {
            this.doorDescription = doorDescription;
        }

        private string doorDescription;
        public string DoorDescription
        {
            get
            {
                return doorDescription;
            }
        }

        public Location DoorLocation { get; set; }
    }
}

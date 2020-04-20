using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSimulationVer2
{
    class Room : Location
    {
        public Room(string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }
        private string decoration;
        public override string Description
        {
            get
            {
                return base.Description + " You see " + decoration + ".";
            }
        }
    }

    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string decoration, string hidingPlace) : base(name, decoration)
        {
            HidingPlace = hidingPlace;
        }
        public string HidingPlace { get; private set; }
    }

    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string hidingPlace, string doorDescription) : base(name, decoration, hidingPlace)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSimulationVer2
{
    class Opponent
    {
        public Opponent(Location myLocation)
        {
            this.myLocation = myLocation;
            random = new Random();
        }
        private Location myLocation;
        private Random random;

        public void Move()
        {
            if (myLocation is IHasExteriorDoor)
            {
                if (random.Next(2) == 1)
                {
                    IHasExteriorDoor myDoorLocation = myLocation as IHasExteriorDoor;
                    myLocation = myDoorLocation.DoorLocation;
                }
            }
            while (true)
            {
                myLocation = myLocation.Exits[random.Next(myLocation.Exits.Length)];
                if (myLocation is IHidingPlace)
                    return;
            }
        }
        public bool Check(Location checkLocation)
        {
            if (checkLocation == myLocation)
                return true;
            return false;
        }
    }
}
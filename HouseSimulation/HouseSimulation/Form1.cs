using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseSimulation
{
    public partial class Form1 : Form
    {
        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;

        Location currentLocation;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }
        private void CreateObjects()
        {
            // Initilize locations
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            diningRoom = new Room("Dining Room", "a crystal chandelier");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "a screen door");
            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new Outside("Garden", false);

            // Set the exits to each locations
            livingRoom.Exits = new Location[] { frontYard, diningRoom };
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { diningRoom, backYard };
            frontYard.Exits = new Location[] { livingRoom, garden };
            backYard.Exits = new Location[] { kitchen, garden };
            garden.Exits = new Location[] { frontYard, backYard };

            // Set the entrance to locations has exterior door
            livingRoom.DoorLocation = frontYard;
            kitchen.DoorLocation = backYard;
            frontYard.DoorLocation = livingRoom;
            backYard.DoorLocation = kitchen;
        }
        private void MoveToANewLocation(Location newLocation)
        {
            // Set currentLocation and where it leads to
            currentLocation = newLocation;
            listOfLocations.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                listOfLocations.Items.Add(currentLocation.Exits[i].Name);
            listOfLocations.SelectedIndex = 0;

            // Descript where you are in
            //if (currentLocation is Outside)
            //{
            //    Outside currentOutside = currentLocation as Outside;
            //    descriptionBox.Text = currentOutside.Description;
            //}
            //else
            //{
            //    Room currentRoom = currentLocation as Room;
            //    descriptionBox.Text = currentRoom.Description;
            //}
            descriptionBox.Text = currentLocation.Description;

            // Check if new location has a door
            if (currentLocation is IHasExteriorDoor)
                goThruTheDoorBtn.Visible = true;
            else
                goThruTheDoorBtn.Visible = false;
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[listOfLocations.SelectedIndex]);
        }

        private void goThruTheDoorBtn_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor placeHasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(placeHasDoor.DoorLocation);
        }
    }
}

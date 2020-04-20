using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseSimulationVer2
{
    public partial class Form1 : Form
    {
        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace upstairsHallway;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;
        RoomWithHidingPlace bathroom;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;

        Location currentLocation;
        Opponent myOpponent;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
            RedrawForm(false);
        }

        private void CreateObjects()
        {
            // Initilize locations
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "cabinet", "an oak door with a brass knob");
            diningRoom = new Room("Dining Room", "a crystal chandelier");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "closet", "a screen door");
            stairs = new Room("Stairs", "a wooden bannister");
            upstairsHallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a big dog", "closet");
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed", "the bed");
            secondBedroom = new RoomWithHidingPlace("Second Bed", "a small bed", "the bed");
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilet", "the shower");
            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new OutsideWithHidingPlace("Garden", false, "the shed");
            driveway = new OutsideWithHidingPlace("Driveway", false, "the garbage");

            // Set the exits to each locations
            livingRoom.Exits = new Location[] { frontYard, diningRoom, stairs };
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { diningRoom, backYard };
            stairs.Exits = new Location[] { livingRoom, upstairsHallway };
            upstairsHallway.Exits = new Location[] { masterBedroom, secondBedroom, bathroom, stairs };
            masterBedroom.Exits = new Location[] { upstairsHallway };
            secondBedroom.Exits = new Location[] { upstairsHallway };
            bathroom.Exits = new Location[] { upstairsHallway };
            frontYard.Exits = new Location[] { livingRoom, garden, driveway };
            backYard.Exits = new Location[] { kitchen, garden, driveway };
            garden.Exits = new Location[] { frontYard, backYard };
            driveway.Exits = new Location[] { frontYard, backYard };

            // Set the entrance to locations has exterior door
            livingRoom.DoorLocation = frontYard;
            kitchen.DoorLocation = backYard;
            frontYard.DoorLocation = livingRoom;
            backYard.DoorLocation = kitchen;

            // Initialize new opponent
            myOpponent = new Opponent(frontYard);
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
            descriptionBox.Text = currentLocation.Description;

            // Check if new location has a door
            if (currentLocation is IHasExteriorDoor)
                goThruTheDoorBtn.Visible = true;
            else
                goThruTheDoorBtn.Visible = false;

            // Check if new location has place to hide
            if (currentLocation is IHidingPlace)
            {
                checkBtn.Visible = true;
                IHidingPlace myHiding = currentLocation as IHidingPlace;
                checkBtn.Text = "Check " + myHiding.HidingPlace;
            }
            else
                checkBtn.Visible = false;
        }

        private void RedrawForm(bool isShow)
        {
            if (!isShow)
            {
                goBtn.Visible = false;
                listOfLocations.Visible = false;
                checkBtn.Visible = false;
                goThruTheDoorBtn.Visible = false;
                hideBtn.Visible = true;
                descriptionBox.Text = "";
            }
            else
            {
                goBtn.Visible = true;
                listOfLocations.Visible = true;
                checkBtn.Visible = true;
                goThruTheDoorBtn.Visible = true;
                hideBtn.Visible = false;
            }
        }

        private void ResetGame(bool isWon)
        {
            if (isWon == false)
            {
                IHidingPlace currentHiding = currentLocation as IHidingPlace;
                MessageBox.Show("He's not in " + currentHiding.HidingPlace);
                return;
            }
            MessageBox.Show("Found him after " + count + " checking times!");
            count = 0;
            MoveToANewLocation(livingRoom);
            RedrawForm(false);
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

        private void hideBtn_Click(object sender, EventArgs e)
        {
            hideBtn.Visible = false;
            for (int i = 1; i <= 10; i++)
            {
                myOpponent.Move();
                descriptionBox.Text = i + "... ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            descriptionBox.Text = "Ready or not, here I come!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            MoveToANewLocation(livingRoom);
            RedrawForm(true);
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (myOpponent.Check(currentLocation))
            {
                ResetGame(true);
                return;
            }
            ResetGame(false);
            count++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExploringDungeons
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            // Update player position and stats
            player.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            // Update enemys' location and hit points
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }
            if (!showBat)
            {
                batHitPoints.Text = "";
                bat.Visible = false;
            }
            if (!showGhost)
            {
                ghostHitPoints.Text = "";
                ghost.Visible = false;
            }
            if (!showGhoul)
            {
                ghoulHitPoints.Text = "";
                ghoul.Visible = false;

            }

            // Update weapon picturebox
            sword.Visible = false;
            bow.Visible = false;
            redPotion.Visible = false;
            bluePotion.Visible = false;
            mace.Visible = false;
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword; 
                    break;
                case "Bow":
                    weaponControl = bow;
                    break;
                case "Mace":
                    weaponControl = mace;
                    break;
                case "Blue Potion":
                    weaponControl = bluePotion;
                    break;
                default:
                    weaponControl = redPotion;
                    break;
            }
            weaponControl.Visible = true;

            // Display inventory
            if (game.CheckPlayerInventory("Sword"))
            {
                sword.Visible = true;
            }

            if (game.CheckPlayerInventory("Bow"))
            {
                bow.Visible = true;
            }

            if (game.CheckPlayerInventory("Mace"))
            {
                mace.Visible = true;
            }

            if (game.CheckPlayerInventory("Red Potion"))
            {
                redPotion.Visible = true;
            }

            if (game.CheckPlayerInventory("Blue Potion"))
            {
                bluePotion.Visible = true;
            }

            // Check if player has already picked up weapon
            // Check if player died
            // Check if player defeated all enemies
            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;
            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }
            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }

        private void sword_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
                sword.BorderStyle = BorderStyle.FixedSingle;
                bow.BorderStyle = BorderStyle.None;
                mace.BorderStyle = BorderStyle.None;
                redPotion.BorderStyle = BorderStyle.None;
                bluePotion.BorderStyle = BorderStyle.None;
            }
        }

        private void bluePotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                game.Equip("Sword");
                sword.BorderStyle = BorderStyle.None;
                bow.BorderStyle = BorderStyle.None;
                mace.BorderStyle = BorderStyle.None;
                redPotion.BorderStyle = BorderStyle.None;
                bluePotion.BorderStyle = BorderStyle.FixedSingle;

                label2.Text = "Drink";
                atkDown.Visible = false;
                atkLeft.Visible = false;
                atkRight.Visible = false;
            }
        }

        private void bow_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");
                sword.BorderStyle = BorderStyle.None;
                bow.BorderStyle = BorderStyle.FixedSingle;
                mace.BorderStyle = BorderStyle.None;
                redPotion.BorderStyle = BorderStyle.None;
                bluePotion.BorderStyle = BorderStyle.None;
            }
        }

        private void redPotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Red Potion"))
            {
                game.Equip("Red Potion");
                sword.BorderStyle = BorderStyle.None;
                bow.BorderStyle = BorderStyle.None;
                mace.BorderStyle = BorderStyle.None;
                redPotion.BorderStyle = BorderStyle.FixedSingle;
                bluePotion.BorderStyle = BorderStyle.None;

                label2.Text = "Drink";
                atkDown.Visible = false;
                atkLeft.Visible = false;
                atkRight.Visible = false;
            }
        }

        private void mace_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                game.Equip("Mace");
                sword.BorderStyle = BorderStyle.None;
                bow.BorderStyle = BorderStyle.None;
                mace.BorderStyle = BorderStyle.FixedSingle;
                redPotion.BorderStyle = BorderStyle.None;
                bluePotion.BorderStyle = BorderStyle.None;
            }
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void atkUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void atkRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void atkLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void atkDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }
    }
}

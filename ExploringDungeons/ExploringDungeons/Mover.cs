using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ExploringDungeons
{
    enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    abstract class Mover
    {
        private const int MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;
        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }
        public bool Nearby(Point locationToCheck, int distance)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance &&
            (Math.Abs(location.Y - locationToCheck.Y) < distance))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
                default: break;
            }
            return newLocation;
        }
    }

    class Player : Mover
    {
        private Weapon equippedWeapon;
        public int HitPoints { get; private set; }
        private List<Weapon> inventory = new List<Weapon>();
        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }
        public Player(Game game, Point location)
        : base(game, location)
        {
            HitPoints = 10;
        }
        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }
        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }
        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }
        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                // see if the weapon is nearby, and possibly pick it up
            }
        }
        public void Attack(Direction direction, Random random)
        {
            // Your code goes here
        }
    }
    
    abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 25;
        public int HitPoints { get; private set; }
        public bool Dead
        {
            get
            {
                if (HitPoints <= 0) return true;
                else return false;
            }
        }
        public Enemy(Game game, Point location, int hitPoints)
        : base(game, location) { HitPoints = hitPoints; }
        public abstract void Move(Random random);
        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }
        protected bool NearPlayer()
        {
            return (Nearby(game.PlayerLocation, NearPlayerDistance));
        }
        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > location.X + 10)
                directionToMove = Direction.Right;
            else if (playerLocation.X < location.X - 10)
                directionToMove = Direction.Left;
            else if (playerLocation.Y < location.Y - 10)
                directionToMove = Direction.Up;
            else
                directionToMove = Direction.Down;
            return directionToMove;
        }
    }

    abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }
        public Weapon(Game game, Point location) : base(game, location)
        {
            PickedUp = false;
        }
            public void PickUpWeapon() { PickedUp = true; }
        public abstract string Name { get; }
        public abstract void Attack(Direction direction, Random random);
        protected bool DamageEnemy(Direction direction, int radius,
        int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (Nearby(enemy.Location, target, distance))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }

        public bool Nearby(Point locationToCheck, Point target, int distance)
        {
            return true;
        }

        public Point Move(Direction direction, Point target, Rectangle boundaries)
        {
            return new Point();
        }
    }
}

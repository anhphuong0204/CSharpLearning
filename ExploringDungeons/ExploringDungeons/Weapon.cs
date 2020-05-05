using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ExploringDungeons
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location)
        : base(game, location) { }
        public override string Name { get { return "Sword"; } }
        public override void Attack(Direction direction, Random random)
        {
            // Your code goes here
        }
    }

    class Bow : Weapon
    {
        public Bow(Game game, Point location)
        : base(game, location) { }
        public override string Name { get { return "Bow"; } }
        public override void Attack(Direction direction, Random random)
        {
            // Your code goes here
        }
    }

    class Mace : Weapon
    {
        public Mace(Game game, Point location)
        : base(game, location) { }
        public override string Name { get { return "Mace"; } }
        public override void Attack(Direction direction, Random random)
        {
            // Your code goes here
        }
    }
}

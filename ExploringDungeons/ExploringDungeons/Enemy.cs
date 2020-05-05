using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ExploringDungeons
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location)
        : base(game, location, 6)
        { }
        public override void Move(Random random)
        {
            // Your code will go here
        }
    }

    class Ghost : Enemy
    {
        public Ghost(Game game, Point location)
        : base(game, location, 8)
        { }
        public override void Move(Random random)
        {
            // Your code will go here
        }
    }

    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
        : base(game, location, 10)
        { }
        public override void Move(Random random)
        {
            // Your code will go here
        }
    }
}

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
        public Bat(Game game, Point location) : base(game, location, 6)
        { }
        public override void Move(Random random)
        {
            // Your code will go here
            if (Dead)
                return;
            int rdNumber = random.Next(1, 2);
            Direction newDirection;
            if (rdNumber == 1)
                newDirection = FindPlayerDirection(game.PlayerLocation);
            else
                newDirection = (Direction)random.Next(0, 3);
            base.location = Move(newDirection, game.Boundaries);
            if (NearPlayer())
                game.HitPlayer(2, random);
        }
    }

    class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8) { }
        public override void Move(Random random)
        {
            // Your code will go here
            if (Dead)
                return;
            if (random.Next(1, 3) == 1)
                base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            if (NearPlayer())
                game.HitPlayer(3, random);
        }
    }

    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location) : base(game, location, 10) { }
        public override void Move(Random random)
        {
            // Your code will go here
            if (Dead)
                return;
            if (!(random.Next(1, 3) == 1))
                base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            if (NearPlayer())
                game.HitPlayer(4, random);
        }
    }
}

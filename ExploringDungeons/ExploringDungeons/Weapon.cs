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
            int timeAttack = 0;
            while (!DamageEnemy(direction, 10, 3, random)) {
                timeAttack++;
                direction = (Direction)(((int)direction + 1) % 4);
                if (timeAttack == 3)
                    return;
            }
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
            DamageEnemy(direction, 30, 1, random);
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
            int timeAttack = 0;
            while (!DamageEnemy(direction, 20, 6, random))
            {
                timeAttack++;
                direction = (Direction)(((int)direction + 1) % 4);
                if (timeAttack == 4)
                    return;
            }
        }
    }
}

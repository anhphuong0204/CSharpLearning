using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringDungeons
{
    class BluePotion : Weapon, IPotion
    {
        public BluePotion(Game game, Point point) : base(game, point) {
            used = false;
        }
        public override string Name { get { return "Blue Potion"; } }

        private bool used;
        public bool Used { get { return used; } }

        public override void Attack(Direction direction, Random random)
        {
            // increase player health up to 5p
        }
    }

    class RedPotion : Weapon, IPotion
    {
        public RedPotion(Game game, Point point) : base(game, point)
        {
            used = false;
        }
        public override string Name { get { return "Red Potion"; } }

        private bool used;
        public bool Used { get { return used; } }

        public override void Attack(Direction direction, Random random)
        {
            // increase player health up to 10p
        }
    }
}

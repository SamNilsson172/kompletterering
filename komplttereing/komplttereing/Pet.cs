using System;
using System.Collections.Generic;
using System.Text;

namespace komplttereing
{
    class Pet : Monster
    {
        int friendship = 0;

        public void IncreaseFriendship()
        {
            friendship++;
        }

        public override void Cry()
        {
            Console.WriteLine("Oh no!");
            base.Cry();
        }

        public override void Stats()
        {
            Console.WriteLine("Player");
            base.Stats();
            Console.WriteLine();
        }

        public Pet(Enemy e) : base(e.Name, e.Hp, e.Dmg)
        {
            Hp += 100;
        }
    }
}

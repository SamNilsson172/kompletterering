using System;
using System.Collections.Generic;
using System.Text;

namespace komplttereing
{
    class Enemy : Monster
    {
        readonly string deathNoise;

        public override void Cry()
        {
            Console.WriteLine(deathNoise);
            base.Cry();
        }

        public override void Stats()
        {
            Console.WriteLine("Enemy");
            base.Stats();
        }

        public Enemy(string _name, int _hp, int _dmg, string _deathNoise) : base(_name, _hp, _dmg)
        {
            deathNoise = _deathNoise;
        }
    }
}

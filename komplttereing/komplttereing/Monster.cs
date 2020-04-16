using System;
using System.Collections.Generic;
using System.Text;

namespace komplttereing
{
    class Monster : Entity
    {
        public int Hp { get; protected set; }
        readonly int maxHp;
        public int Dmg { get; private set; }

        public void Attack(Monster defender)
        {
            defender.Hp -= Dmg;
        }

        public virtual void Stats()
        {
            Console.WriteLine(Name + ": " + Hp + "/" + maxHp + " hp");
        }

        public virtual void Cry()
        {
            Console.WriteLine(Name + " died!");
        }

        public void Heal()
        {
            Hp = maxHp;
        }

        public bool Alive()
        {
            return Hp > 0;
        }

        public Monster(string _name, int _hp, int _dmg) : base(_name)
        {
            maxHp = _hp;
            Hp = maxHp;
            Dmg = _dmg;
        }
    }
}

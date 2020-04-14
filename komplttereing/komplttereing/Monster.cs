using System;
using System.Collections.Generic;
using System.Text;

namespace komplttereing
{
    class Monster : Entity
    {
        public int hp { get; protected set; }
        int maxHp;
        public int dmg { get; private set; }

        public void Attack(Monster defender)
        {
            defender.hp -= dmg;
        }

        public virtual void Stats()
        {
            Console.WriteLine(name + ": " + hp + "/" + maxHp + " hp");
        }

        public virtual void Cry()
        {
            Console.WriteLine(name + " died!");
        }

        public void Heal()
        {
            hp = maxHp;
        }

        public bool Alive()
        {
            return hp > 0;
        }

        public Monster(string _name, int _hp, int _dmg) : base(_name)
        {
            maxHp = _hp;
            hp = maxHp;
            dmg = _dmg;
        }
    }
}

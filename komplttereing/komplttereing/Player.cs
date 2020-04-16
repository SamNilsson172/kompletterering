using System;
using System.Collections.Generic;
using System.Text;

namespace komplttereing
{
    class Player : Human
    {
        public TheGoodStuff.RandomCollection<Pet> Pets { get; private set; } = new TheGoodStuff.RandomCollection<Pet>();

        public override void Description()
        {
            Console.WriteLine("You're " + age + " year old " + Name + " with " + hairColor + " hair.");
        }

        public void Catch(Enemy e)
        {
            Pets.Add(new Pet(e));
        }
        public Player(string _name, string _hairColor, int _age) : base(_name, _hairColor, _age) { }
    }
}

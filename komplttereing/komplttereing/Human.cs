using System;
using System.Collections.Generic;
using System.Text;

namespace komplttereing
{
    class Human : Entity
    {
        public string hairColor { get; private set; }
        public int age { get; private set; }

        public virtual void Description()
        {
            Console.WriteLine(name + " is " + age + " years old and has " + hairColor + " hair.");
        }

        public Human(string _name, string _haircolor, int _age) : base(_name)
        {
            hairColor = _haircolor;
            age = _age;
        }
    }
}

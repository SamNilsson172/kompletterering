using System;
using System.Collections.Generic;
using System.Text;

namespace komplttereing
{
    class Human : Entity
    {
        protected string hairColor;
        protected int age;

        public virtual void Description()
        {
            Console.WriteLine(Name + " is " + age + " years old and has " + hairColor + " hair.");
        }

        public Human(string _name, string _haircolor, int _age) : base(_name)
        {
            hairColor = _haircolor;
            age = _age;
        }
    }
}

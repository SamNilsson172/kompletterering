using System;
using System.Collections.Generic;
using System.Text;

namespace komplttereing
{
    class Entity
    {
        public string Name { get; private set; }

        public Entity(string _name)
        {
            Name = _name;
        }
    }
}

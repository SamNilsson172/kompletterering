using System;
using System.Collections.Generic;
using System.Text;

namespace komplttereing
{
    class Npc : Human
    {
        string voiceline;
        public override void Description()
        {
            base.Description();
            Console.WriteLine(voiceline);
        }

        public Npc(string _name, string _hairColor, int _age, string _voiceline) : base(_name, _hairColor, _age)
        {
            voiceline = _voiceline;
        }
    }
}

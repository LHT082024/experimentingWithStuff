using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk.building
{
    public class CharacterAttributs(string name)
    {
        public string Name = name;
        public string Species;
        // public CharacterStats Stats;
        public List<string> Spells;
    }
}
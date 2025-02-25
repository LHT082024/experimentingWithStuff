using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk.building
{
    public class Character(string name)
    {
        //connect classes with attributes
        public string Name = name;
        public CharacterStats Stats;
        public List<string> Spells;

        //Methods that can be used to add stuff
        public Character AddSpecies(string species)
        {
            Stats = CharacterBricks.Species[species];
            return this;
        }

        public Character AddMagic()
    }
}
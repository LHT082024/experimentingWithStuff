using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk.models
{
    //inteligence affect power lvl
    public class WarriorModel
    {
        public string? Name { get; set; }
        public ModelOfSpecies? species { get; set; }
        public ModelOfMagic? magic { get; set; }
        public int PowerLvl { get; set; }
        public int Mana { get; set; }
        public int Health { get; set; }


    }
}
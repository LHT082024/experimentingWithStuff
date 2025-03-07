using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using idk.character;

namespace idk.character
{
    public class Character()
    {
        //connect classes with attributes
        public string? Name;
        public string? Species;
        public string? magic;
        public CharacterStats Stats;
        public List<int> magicdm;
        public List<string> Spells;


        //Methods that can be used to add stuff
        public Character AddStats(string stats)
        {
            Stats = CharacterBricks.Stats[stats];
            return this;
        }

        public Character AddMagic(string magicType)
        {
            Spells = CharacterBricks.Spells[magicType];
            return this;
        }

        public Character MagicAttack(string dm)
        {
            magicdm = CharacterBricks.SpellDamage[dm];
            return this;
        }
    }
}
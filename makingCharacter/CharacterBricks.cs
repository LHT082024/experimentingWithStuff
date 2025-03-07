using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using idk.character;

namespace idk.character
{
    //stats for the character
    public class CharacterStats(int hp, int mana, int damage)
    {
        public int Hp = hp;
        public int Mana = mana;
        public int Damage = damage;
    }

    public class CharacterBricks
    {
        //Character stats
        public static readonly Dictionary<string, CharacterStats> Stats = new()
            {
                {
                    "eldritch creature",
                    new(30, 10, 10)
                },
            };

        //magic types
        public static readonly Dictionary<string, List<string>> Spells = new()
            {
                {
                    "eldritch",
                    ["azathot's eyes", "sphere of destruction", "shield of yog"]
                }
            };
        public static readonly Dictionary<string, List<int>> SpellDamage = new()
        {
             { "sphere of destruction", new List<int> { 6 } },
             { "azathot's eyes", new List<int> { 0 } },
             { "shield of yog", new List<int> { 0 } }

        };
    }
}
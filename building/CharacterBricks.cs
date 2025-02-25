using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using idk.building;

namespace idk.building
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
                    new(10, 10, 10)
                },

            };

        //magic types
        public static readonly Dictionary<string, List<string>> Spells = new()
            {
                {
                    "eldritch magic",
                    ["szathot's eyes", "sphere of destruction", "shield of yog"]
                }

            };
    }
}
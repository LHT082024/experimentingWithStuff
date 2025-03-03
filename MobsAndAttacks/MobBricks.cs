using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk.MobsAndAttacks
{
    public class MobInfo(int hp)
    {
        public int Hp = hp;
    };

    public class MobBricks()
    {
        public static readonly Dictionary<string, MobInfo> Stits = new()
            {
                {
                    "Human",
                    new(7)
                },
                {
                    "Goblin",
                    new(3)
                },
                {
                   "Orc",
                   new(5)
                }
            };

        public static readonly Dictionary<string, List<string>> ClassSpells = new()
            {
                {
                    "Wizard",
                    ["fireball", "slash"]
                },

                {
                    "Soldier",
                    ["stab", "slash"]

                }
            };
        public static readonly Dictionary<string, List<int>> AttackDamage = new()
        {
             { "fireball", new List<int> { 4 } },
             { "slash", new List<int> { 2 } },
             {"stab", new List<int> {4} }
        };
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk.MobsAndAttacks
{
    public class MobInfo
    {
        public int Hp { get; set; }

        public MobInfo(int hp)
        {
            Hp = hp;
        }
        public MobInfo Clone()
        {
            return new MobInfo(this.Hp);
        }
    };

    public class MobBricks()
    {
        public static readonly Dictionary<string, MobInfo> Stits = new()
            {
                {
                    "Human",
                    new MobInfo(6)
                },
                {
                    "Goblin",
                    new MobInfo(3)
                },
                {
                   "Orc",
                   new MobInfo(5)
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
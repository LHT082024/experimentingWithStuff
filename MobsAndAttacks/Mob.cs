using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk.MobsAndAttacks
{
    public class Mob(string name)
    {
        public string? Name = name;
        public string? Class;
        public MobInfo Stuff;
        public List<string> Attacks;

        public List<int> AttackDmg;

        public Mob AddSpeciesStats(string stats)
        {
            Stuff = MobBricks.Stits[stats];
            return this;
        }

        public Mob AddAttacks(string attacks)
        {
            Attacks = MobBricks.ClassSpells[attacks];
            return this;
        }

        public Mob AddAttack(string dm)
        {
            AttackDmg = MobBricks.AttackDamage[dm];
            return this;
        }
    };
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk.MobsAndAttacks
{
    public class HumanMobs
    {
        public Mob Gary = new Mob("Gary").AddSpeciesStats("Human").AddAttacks("Wizard");
        public Mob Soldier1 = new Mob("BasicSoldier").AddSpeciesStats("Human").AddAttacks("Soldier");
    }
}
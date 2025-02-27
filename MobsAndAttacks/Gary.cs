using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk.MobsAndAttacks
{
    public class Gary
    {
        DamageAttacks damageAttacks = new();

        //Gary's attacks
        public void attacks()
        {
            damageAttacks.Basicattack();
            damageAttacks.FireBall();
        }

    }
}
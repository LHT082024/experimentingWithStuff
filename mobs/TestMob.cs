using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk.mobs
{
    public class TestMob
    {
        public int hp = 15;
        public int damage = 2;
        static string playerCh = $"Wizards/Wizard-Ika.txt";


        public static void gettingHp()
        {
            string[] player = File.ReadAllLines(playerCh);

            for (int i = 0; i < player.Length; i++)
            {
                if (player[i].StartsWith("health"))
                {
                    string[] parts = player[i].Split(':');
                    if (parts.Length == 2 && int.TryParse(parts[1].Trim(), out int currentHP))
                    {

                    }
                }

            }


        }





        public void Basicattack()
        {



        }



    }
}
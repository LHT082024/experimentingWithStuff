using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk.mobs
{
    public class TestMob
    {
        public int health;
        public int damage = 2;
        static string playerCh = $"Wizards/Wizard-Ika";


        public static int ReadHp()
        {
            string[] player = File.ReadAllLines(playerCh);

            foreach (string line in player)
            {
                if (line.StartsWith("Health"))
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2 && int.TryParse(parts[1].Trim(), out int hp))
                    {
                        health = hp;
                        return health;
                    }
                }

            }
            return health;
        }


        public void printshit()
        {
            Console.WriteLine(health);
        }





        public void Basicattack()
        {



        }



    }
}
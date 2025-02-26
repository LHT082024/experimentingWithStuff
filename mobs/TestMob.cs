using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk.mobs
{
    public class TestMob
    {
        public static int health;
        public int damage = 2;
        static string playerCh = $"Wizards/Wizard-Ika.txt";


        public static void ReadHp()
        {
            string[] player = File.ReadAllLines(playerCh);

            foreach (string line in player)
            {
                if (line.StartsWith("health"))
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2 && int.TryParse(parts[1].Trim(), out int hp))
                    {
                        health = hp;
                    }
                }

            }
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
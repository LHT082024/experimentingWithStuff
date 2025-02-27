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
        public string playerCh = $"Wizards/Wizard-Ika";


        public void ReadHp()
        {
            string[] player = File.ReadAllLines(playerCh);



            foreach (string line in player)
            {
                // Console.WriteLine(line);
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim();
                    string value = parts[1].Trim();

                    switch (key)
                    {
                        case "Health":
                            int.TryParse(value, out health);
                            break;
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
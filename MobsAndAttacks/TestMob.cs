using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk.MobsAndAttacks
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
            Console.WriteLine($"your current health {health}");
        }

        public void Basicattack()
        {
            int Basicattack = 4;
            damage = Basicattack;
            health = health - Basicattack;

            if (health > 0)
            {
                Console.WriteLine($"Goblin slashed at you with it's sword your current hitpoints are {health}");
            }
            else if (health <= 0)
            {
                Console.WriteLine("Ha fucking noob died");
            }
        }

        public void SaveStats()
        {
            string[] player = File.ReadAllLines(playerCh);
            for (int i = 0; i < player.Length; i++) // Loop through each line
            {
                player[i] = player[i].Replace("Health: 10", $"Health: {health}");
            }

            File.WriteAllLines(playerCh, player);
        }
    }

}
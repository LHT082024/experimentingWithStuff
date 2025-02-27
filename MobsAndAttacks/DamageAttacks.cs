using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk.MobsAndAttacks
{
    public class DamageAttacks
    {
        //local variables
        public int health;
        public int damage;
        public string playerCh = $"Wizards/Wizard-Ika";


        //readPlayerHealthPoints
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

        //the basic attack
        public void Basicattack()
        {
            int Basicattack = 2;
            damage = Basicattack;
            health = health - Basicattack;

            if (health > 0)
            {
                Console.WriteLine($"With a quick motion you are slashed with a knife doing {Basicattack} damage");
                Console.WriteLine($"Your current health is{health}");
            }
            else if (health <= 0)
            {
                Console.WriteLine("Ha fucking noob died");
            }
        }

        //fireball
        public void FireBall()
        {
            int FireBall = 5;
            health = health - FireBall;

            if (health > 0)
            {
                Console.WriteLine($"A massive sphere of fire explodes on impact and does\n{FireBall} damage");
                Console.WriteLine($"Your current hp is{health}");
            }
            else if (health <= 0)
            {
                Console.WriteLine("The sphere explodes burning you to a crisp\nYou are dead");
            }
        }





    }
}
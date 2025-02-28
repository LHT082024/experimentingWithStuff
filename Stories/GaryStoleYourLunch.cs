using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using idk.character;
using idk.MobsAndAttacks;

namespace idk.Stories
{
    public class GaryStoleYourLunch
    {
        //adding classes that I need for the story
        HumanMobs human = new();
        public string MobName = "";
        public string fireball;
        public string slash;
        public int fireballdmg;
        public int slashdmg;

        //player variables
        public string name = "";
        public int playerhealth;
        public int GaryHealth;
        public int playermana;
        public string? spell1;
        public string? spell2;
        public int damage2;
        public string? spell3;

        public string playerCh = $"Wizards/Wizard-Ika";


        //reading stats and assigning them to local variables
        public void ReadPlayerStats()
        {
            string[] player = File.ReadAllLines(playerCh);

            foreach (string line in player)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim();
                    string value = parts[1].Trim();

                    switch (key)
                    {
                        case "Name":
                            name = value;
                            break;

                        case "Health":
                            int.TryParse(value, out playerhealth);
                            break;

                        case "Mana":
                            int.TryParse(value, out playerhealth);
                            break;

                        case "Spell 1":
                            spell1 = value;
                            break;
                        case "Spell 2":
                            spell2 = value;
                            break;

                        case "Damage2":
                            int.TryParse(value, out damage2);
                            break;

                        case "Spell 3":
                            spell3 = value;
                            break;
                    }
                }
            }
        }


        //assigning mobstats to variables
        public void mobStats()
        {
            fireball = human.Gary.Attacks[0];
            slash = human.Gary.Attacks[1];
            fireballdmg = MobBricks.AttackDamage[human.Gary.Attacks[0]][0];
            slashdmg = MobBricks.AttackDamage[human.Gary.Attacks[1]][0];
        }

        public void Intro()
        { }
        public void Morning()
        {
            //printing
            string start = @"it's a wonderful morning, you are standing on top of a castle wall enjoying the view It's been a quiet morning guarding 
the castle and you are starting to think that maybe the noble that hired you to kill demons from hell was a bit paranoid Nevertheless it's time for lunch";
            for (int i = 0; i < start.Length; i++)
            {
                Console.Write(start[i]);
                Thread.Sleep(60);
            }
            Console.WriteLine("what do you want to do?\n(1) Stare at the view hoping something interesting will happen\n(2) Go to the kitchen and get your lunch");

        }

        public void combat()
        { }
    }
}

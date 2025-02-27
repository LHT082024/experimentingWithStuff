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
        Gary gary = new();

        //variables I need
        public string name = "";
        public int health;
        public int mana;
        public string? spell1;
        public string? spell2;
        public string? spell3;

        public string playerCh = $"Wizards/Wizard-Ika";


        //reading stats and assigning them to local variables
        public void Readstats()
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
                            int.TryParse(value, out health);
                            break;

                        case "Mana":
                            int.TryParse(value, out mana);
                            break;

                        case "Spell 1":
                            spell1 = value;
                            break;
                        case "Spell 2":
                            spell2 = value;
                            break;
                        case "Spell 3":
                            spell3 = value;
                            break;
                    }
                }
            }
        }

        public void Morning()
        {
            Console.WriteLine($"{name}\n{health}\n{spell1}\n{spell2}\n{spell3}");
        }
    }
}

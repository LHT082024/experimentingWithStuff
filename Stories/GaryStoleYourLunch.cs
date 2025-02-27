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
        public int playerhealth;
        public int GaryHealth;
        public int playermana;
        public string? spell1;
        public string? spell2;
        public int damage2;
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

        public void Morning()
        {

            // GaryHealth = gary.health;
            // Console.WriteLine($"Gary currently have {GaryHealth} hit points\nClick any button to throw an Eldritch sphere at Gary");
            // Console.ReadKey();
            // GaryHealth = GaryHealth - damage2;
            // Console.WriteLine($"Gary's health after the eldritch sphere is {GaryHealth}\nYou almost killed him you monster");
            // Console.ReadKey();
            // Console.WriteLine($"your health is {playerhealth}, gary wants revenge so he fires a fireball.");
            // gary.attacks();
            // Console.WriteLine($"your health is now{playerhealth}");
        }
    }
}

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
        }
        public void Morning()
        {
            //calling attacks


            //calling attack dmg
            int fireballdmg = MobBricks.AttackDamage[human.Gary.Attacks[0]][0];
            int slashdm = MobBricks.AttackDamage[human.Gary.Attacks[1]][0];

            //printing
            Console.WriteLine($"Attack 1 name: {fireball} Damage: {fireballdmg}");
            Console.WriteLine($"Attack 2 name: {slash} Damage: {slashdm}");


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

        public void combat()
        { }
    }
}

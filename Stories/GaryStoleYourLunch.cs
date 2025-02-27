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
        public string? name;
        public int health;
        public int mana;
        public string spell1;
        public string spell2;
        public string spell3;

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

        public void Morning()
        {


        }
    }
}

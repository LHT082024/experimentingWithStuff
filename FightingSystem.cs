using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk
{
    public class FightingSystem
    {
        public void Wizards()
        {
            //stats

            //to be able to read the stats. 
            string Wizard1path = "Wizards/Wizard-Luka";
            string Wizard2path = "Wizards/Wizard-Matt";

            string[] Wizard1 = File.ReadAllLines(Wizard1path);
            string[] Wizard2 = File.ReadAllLines(Wizard2path);

            string wizard1Name = "";
            string wizard1Powerlvl = "";
            string wizard2Name = "";
            string wizard2Powerlvl = "";

            //wizard 1 stats allocated
            foreach (string stat in Wizard1)
            {
                string[] parts = stat.Split(':');
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim();
                    string value = parts[1].Trim();

                    switch (key)
                    {
                        case "Name":
                            wizard1Name = value;
                            break;

                        case "Powerlvl":
                            wizard1Powerlvl = value;
                            break;
                    }
                }
            }

            //wizard 2 stats allocated
            foreach (string stat in Wizard2)
            {
                string[] parts = stat.Split(':');
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim();
                    string value = parts[1].Trim();

                    switch (key)
                    {
                        case "Name":
                            wizard2Name = value;
                            break;

                        case "Powerlvl":
                            wizard2Powerlvl = value;
                            break;
                    }
                }
            }

            Console.WriteLine(wizard1Powerlvl);
            Console.WriteLine(wizard2Powerlvl);


        }
    }
}
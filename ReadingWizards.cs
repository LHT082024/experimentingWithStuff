using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk
{
    public class ReadingWizards
    {
        //empty variables to modify
        public string wizard1Name = "";
        public int wizard1Powerlvl = 0;
        public string wizard2Name = "";
        public int wizard2Powerlvl = 0;

        public (string, string, int, int) Wizards()
        {
            //to be able to read the stats. 
            string Wizard1path = "Wizards/Wizard-Luka";
            string Wizard2path = "Wizards/Wizard-Matt";

            string[] Wizard1 = File.ReadAllLines(Wizard1path);
            string[] Wizard2 = File.ReadAllLines(Wizard2path);

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
                            int.TryParse(value, out wizard1Powerlvl);
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
                            int.TryParse(value, out wizard2Powerlvl);
                            break;
                    }


                }
            }
            return (wizard1Name, wizard2Name, wizard1Powerlvl, wizard2Powerlvl);
        }

        public void Test()
        {
            Console.WriteLine("Hello there audience are you ready to watch wizards fight?");
            Console.Write($"the fighters of this round are {wizard1Name} vs {wizard2Name} are you ready?");
            Console.ReadKey();

            if (wizard1Powerlvl < wizard2Powerlvl)
            {
                Console.WriteLine($"AAAAAAAAAAAAAAAAAAAAAAAAAAND {wizard2Name} WIIIIIIIIIINS LIKE A FUCKING CHAMP");
            }
            else
                Console.WriteLine($"WILL YOU LOOK AT THAT {wizard1Name} WIIIIIIIINS BRUTALLY HECK YEAH!");
        }
    }
}
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
            string Wizard1path = "Wizards/Wizard-Luka.txt";
            string Wizard2path = "Wizards/Wizard-Matt.txt";

            string[] Wizard1 = File.ReadAllLines(Wizard1path);
            string[] Wizard2 = File.ReadAllLines(Wizard2path);

            foreach (string stat in Wizard1)
            {
                Console.WriteLine(stat);
            }
            foreach (string stat in Wizard2)
            {
                Console.WriteLine(stat);
            }
        }


    }
}
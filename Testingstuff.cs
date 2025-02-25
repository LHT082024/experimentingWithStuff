using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using idk.Interfaces;
using idk.models;

namespace idk
{
    public class Testingstuff : ICharacter
    {
        public string? Name { get; set; }
        public ModelOfSpecies? species { get; set; }
        public ModelOfMagic? magic { get; set; }
        public int PowerLvl { get; set; }
        public int Mana { get; set; }
        public int Health { get; set; }

        public void newCharacter()
        {

            bool restart = false;

            while (!restart)
            {
                bool nameIsRight = false;
                while (!nameIsRight)
                {
                    Console.WriteLine("\nwhat is your name? (name cannot contain more then 9 characters)");
                    string? Name = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(Name))
                    {
                        Console.WriteLine("Name cannot be blank");
                        Console.ReadKey();
                    }
                    else if (Name.Length >= 10)
                    {
                        Console.WriteLine("name is to long");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine($"Your name is: {Name}");
                        nameIsRight = true;
                        Console.ReadKey();
                    }
                }

            }

        }
    }
}
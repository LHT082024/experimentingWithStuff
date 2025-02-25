using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using idk.building;

namespace idk.models
{
    public class CreatingCharacter
    {
        public void CharacterCreation()
        {
            Character character = new();
            bool restart = false;

            // while (!restart)
            // {

            //picking your name
            Console.WriteLine("Pick your character name (cannot be longer then nine characters)");
            string newName = Console.ReadLine().ToLower();

            bool nameIsRight = false;
            while (!nameIsRight)
            {
                if (string.IsNullOrWhiteSpace(newName))
                {
                    Console.WriteLine("Name cannot be blank");
                }
                else if (newName.Length > 9)
                {
                    Console.WriteLine("name is to long try again");
                    Console.ReadKey();
                }
                else
                {
                    character.Name = newName;
                    Console.WriteLine($"Your name is {character.Name}");

                    nameIsRight = true;
                    Console.ReadKey();
                }

                if (!nameIsRight)
                {
                    Console.WriteLine("pick your character name");
                    newName = Console.ReadLine().ToLower();
                }
            }

            //giving you species list
            Console.WriteLine("\nType in one of the listed species\n");
            Console.ReadKey();
            Console.WriteLine("Eldritch creature    Demonic Ancestor");
            Console.WriteLine("Angelic Ancestor         Human       ");

            bool breakflag = false;
            while (!breakflag)
            {
                //picking species
                string? input = Console.ReadLine().ToLower();

                if (input == "eldritch creature" || input == "demonic ancestor" || input == "angelic ancestor" || input == "human")
                {
                    character.Species = input;
                    Console.WriteLine($"your species is {character.Species}");
                    breakflag = true;
                }
                else
                {
                    Console.WriteLine("You need to type in one of the species dum, dum remember spelling is important");
                    breakflag = false;
                }
            }




            // }

        }
    }

}
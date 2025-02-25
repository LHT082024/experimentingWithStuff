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
            Console.WriteLine("Eldritch creature    Demonic Ancestor");
            Console.WriteLine("Angelic Ancestor         Human       ");


            // }

        }
    }

}
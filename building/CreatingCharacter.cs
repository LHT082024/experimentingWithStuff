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
            Console.WriteLine("Pick your character name");
            string newName = Console.ReadLine().ToLower();
            character.Name = newName;
            Console.WriteLine($"Your name is {character.Name}");

        }

    }
}
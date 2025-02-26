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

            while (!restart)
            {

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
                Console.WriteLine("\nType in one of the listed species");
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
                        character.AddStats(input);
                        Console.WriteLine($"your species is {character.Species}");
                        Console.WriteLine($"{character.Stats.Hp}, {character.Stats.Damage}, {character.Stats.Mana}");
                        breakflag = true;
                    }
                    else
                    {
                        Console.WriteLine("You need to type in one of the species dum, dum remember spelling is important");
                        breakflag = false;
                    }
                }

                //choosing magic flavour text
                Console.WriteLine("\nAnd now for the exciting part choosing magic. Remember this is an important decision that will decide 3 out of your 4 spells");
                Console.ReadKey();
                Console.WriteLine("The magic types");
                Console.ReadKey();
                Console.WriteLine("Eldritch\nDarkness\nHoly\nFire\nIce");

                breakflag = false;
                while (!breakflag)
                {
                    string? input = Console.ReadLine().ToLower();
                    if (input == "eldritch" || input == "darkness" || input == "fire" || input == "ice")
                    {
                        character.magic = input;
                        character.AddMagic(input);
                        Console.WriteLine($"your magic type is {character.magic}");
                        Console.WriteLine($" your spells are the three listed below: {character.Spells[0]}, {character.Spells[1]}, {character.Spells[2]}");
                        breakflag = true;
                    }
                    else
                    {
                        Console.WriteLine("Yo if you want this game to be longer then three sentences pick a magic type");
                        breakflag = false;
                    }
                    Console.WriteLine("Your character summary");
                    Console.ReadKey();
                    Console.WriteLine($"\nCharacter Name: {character.Name}");
                    Console.ReadKey();
                    Console.WriteLine($"You are a: {character.Species}");
                    Console.ReadKey();
                    Console.WriteLine($"Your magic type is: {character.magic}");
                    Console.ReadKey();
                    Console.WriteLine($"Your stats are as followed\nYour hp: {character.Stats.Hp}\nYour mana: {character.Stats.Mana}\nYour base damage: {character.Stats.Damage}");
                    Console.ReadKey();
                    Console.WriteLine($"Your spells are: {character.Spells[0]}\n{character.Spells[1]}\n{character.Spells[2]}");
                    Console.ReadKey();
                    Console.WriteLine("\nNow press the E key to save your character and start your adventure.");
                }
                while (true)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.E)
                    {
                        restart = true;
                        break;
                    }
                    if (key == ConsoleKey.R)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please press one of the two keys listed above");
                    }
                }
            }
            //saves everything in a text document
            string CompletePlayer = $"Name: {character.Name}\nSpecies: {character.Species}\nMagic type: {character.magic}\nSpell 1:{character.Spells[0]}\nSpell 2:{character.Spells[1]}\nSpell 3:{character.Spells[2]}\nHealth: {character.Stats.Hp}\nMana: {character.Stats.Mana}\nDamage {character.Stats.Damage}";
            string folderPath = "Wizards";
            string fileName = $"Wizard-{character.Name}";

            string filePath = Path.Combine(folderPath, fileName);
            File.WriteAllText(filePath, CompletePlayer);
        }
    }

}
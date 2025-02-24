using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using idk.models;

namespace idk
{
    public class PreMadeCharacter
    {
        ModelOfMagic modelOfMagic = new();
        ModelOfSpecies modelOfSpecies = new();
        Lists lists = new();
        WarriorModel warriorModel = new();

        public void Intro()
        {
            while (true)
            {
                Console.WriteLine("press E to experience the intro or press R to skip?");
                ConsoleKeyInfo ClickKey = Console.ReadKey(true);
                if (ClickKey.Key == ConsoleKey.R)
                {
                    Console.WriteLine("I mean... That's fine I worked really hard on it but ok ;^;");
                    break;
                }
                else if (ClickKey.Key == ConsoleKey.E)
                {
                    Console.WriteLine("You are sitting on a plane looking out the window.");
                    Console.ReadKey();

                    Console.WriteLine("\nIt's a sunny day, yesturday your partner proposed over videochat too excited to wait for you to get home from the buisness trip");
                    Console.Write("But the good news dosent end there! Today you finally got that promotion. You will get a raise and afford a fancy wedding. Life is perfect");
                    Console.ReadKey();

                    Console.WriteLine("\nAn excited man sits down next to you");
                    Console.WriteLine("\n'I JUST HAVE TO TELL SOMEBODY' the man said facing you 'I JUST DISCOVERED A CURE FOR CANCER!'");
                    Console.ReadKey();


                    Console.WriteLine("\nyour blood runs cold as the engine of the plane starts");
                    Console.ReadKey();

                    Console.WriteLine("\nYou have to get off, you have a good life YOU CAN'T DIE NOW!");
                    Console.ReadKey();

                    Console.WriteLine("\nbut it's to late, as you stand up ready to jump out of the plane you see a black car driving towards the plane.");
                    Console.Write("A masked man leans out the window takes out a rocket launcher and BANG!");
                    Console.ReadKey();

                    Console.WriteLine("\nDarkness....");
                    Console.ReadKey();

                    Console.WriteLine("\nWAKE UP WAKE UP WAKE UP WAKE UP");
                    Console.ReadKey();

                    Console.WriteLine("\nYou open your eyes and see an annoying looking girl slapping your face. 'if you dont get up right now you are going to die!'");
                    Console.Write("Please create your character");
                    break;
                }
                else
                {
                    Console.WriteLine("\nYou had one job dude");
                }
            }



            //making a complete wizard
            // wizard.Name = "Luka";
            // wizard.magic = Lists.modelOfMagicss[0];

            // string CompleteWizard = $"Name: {wizard.Name}\nElement: {wizard.magic}\nPowerlvl: {wizard.PowerLvl}";
            // string fileName = $"Wizard-{wizard.Name}";
            // string folderPath = "Wizards";

            // string filePath = Path.Combine(folderPath, fileName);

            // File.WriteAllText(filePath, CompleteWizard);
        }

        public void CreateCharacter()
        {
            //choosing a name
            Console.WriteLine("\nwhat is your name?");
            string? newName = Console.ReadLine();
            warriorModel.Name = newName;

            Console.WriteLine($"Your name is: {warriorModel.Name}");
            Console.ReadKey();


            //choosing species
            Console.WriteLine("\nType in one of the listed species\n");
            Console.WriteLine("Eldritch creature    Demonic Ancestor");
            Console.WriteLine("Angelic Ancestor         Human       ");


            //selecting species. While the bool is false you are stuck in a while  loop. The Boolien becomes true
            //when species have aquired a value. While the default switches the boolean back to false making sure 
            //that the user is stuck in the while loop until they have selected one of the actual species
            bool breakflag = false;
            while (!breakflag)
            {
                string? input = Console.ReadLine().ToLower();
                ModelOfSpecies? species = lists.modelOfSpecies.FirstOrDefault(s => s.SpeciesName.ToLower() == input);

                if (species != null)
                {
                    warriorModel.species = species;
                    breakflag = true;

                    switch (warriorModel.species.SpeciesName)
                    {
                        case "eldritch creature":
                            warriorModel.PowerLvl = lists.modelOfSpecies[0].PowerlvlAdd;
                            warriorModel.Health = lists.modelOfSpecies[0].SpeciesHealth;
                            warriorModel.Mana = lists.modelOfSpecies[0].SpeciesMana;
                            Console.WriteLine("Beautiful, Eldritch creatures are truly amazing and I love you");
                            Console.ReadKey();
                            break;

                        case "demonic ancestor":
                            warriorModel.PowerLvl = lists.modelOfSpecies[1].PowerlvlAdd;
                            warriorModel.Health = lists.modelOfSpecies[1].SpeciesHealth;
                            warriorModel.Mana = lists.modelOfSpecies[1].SpeciesMana;
                            Console.WriteLine("Look on the bright side as a Demonic Ancestor, you will never get cold. On the bad side you will defintly end up in hell");
                            Console.ReadKey();
                            break;

                        case "angelic ancestor":
                            warriorModel.PowerLvl = lists.modelOfSpecies[2].PowerlvlAdd;
                            warriorModel.Health = lists.modelOfSpecies[2].SpeciesHealth;
                            warriorModel.Mana = lists.modelOfSpecies[2].SpeciesMana;
                            Console.WriteLine("I am soooooooo jealous of your wings\n I also want angel wings\n why dont I have angel wings :()");
                            Console.ReadKey();
                            break;

                        case "human":
                            warriorModel.PowerLvl = lists.modelOfSpecies[3].PowerlvlAdd;
                            warriorModel.Health = lists.modelOfSpecies[3].SpeciesHealth;
                            warriorModel.Mana = lists.modelOfSpecies[3].SpeciesMana;
                            Console.WriteLine("Seriously you had the decision between a creature beoynd reality, a demon and an angel and you choose a human??!\nYou must be fun at parties...");
                            Console.ReadKey();
                            break;
                    }
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

            //choosing magic code same system as the one above.
            breakflag = false;
            while (!breakflag)
            {
                string? input = Console.ReadLine().ToLower();
                ModelOfMagic? magic = lists.modelOfMagicss.FirstOrDefault(s => s.Element.ToLower() == input);
                if (magic != null)
                {
                    warriorModel.magic = magic;
                    breakflag = true;

                    switch (warriorModel.magic.Element)
                    {
                        case "eldritch":
                            warriorModel.PowerLvl += lists.modelOfMagicss[0].PowerlvlAdd;
                            Console.WriteLine("Lets go Eldritch you know it's the most powerful magic. As long as...You know you don't go insane and end yourself");
                            Console.ReadKey();
                            break;

                        case "darkness":
                            warriorModel.PowerLvl += lists.modelOfMagicss[1].PowerlvlAdd;
                            Console.WriteLine("The magic of the edgelords remember to listen to linkin park or something while you go on this adventure. I think it will fit you");
                            Console.ReadKey();
                            break;

                        case "holy":
                            warriorModel.PowerLvl += lists.modelOfMagicss[2].PowerlvlAdd;
                            Console.WriteLine("Ah you still have hope in life dont you. \nBet it's nice :)");
                            Console.ReadKey();
                            break;

                        case "fire":
                            warriorModel.PowerLvl += lists.modelOfMagicss[3].PowerlvlAdd;
                            Console.WriteLine("You yell allot don't you?");
                            Console.ReadKey();
                            break;

                        case "ice":
                            warriorModel.PowerLvl += lists.modelOfMagicss[4].PowerlvlAdd;
                            Console.WriteLine("I bet you are super cool, ha get it coool, I'm so funny (please like me :( )");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                    Console.WriteLine("Spelling is important try again.");
                breakflag = false;
                break;
            }
            Console.WriteLine("Your character is");
            Console.WriteLine($"\nCharacter Name: {warriorModel.Name}");
            Console.WriteLine($"\nYou are a: {warriorModel.species}");
            Console.WriteLine($"\nYour magic type is: {warriorModel.magic}");
            Console.WriteLine($"\nYour Health is: {warriorModel.Health}");
            Console.WriteLine($"\nYour Mana is: {warriorModel.Mana}");
            Console.WriteLine($"\nLastly your power lvl is: {warriorModel.PowerLvl}");
        }
    }
}

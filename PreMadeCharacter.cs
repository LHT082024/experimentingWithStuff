using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using idk.models;

namespace idk
{
    public class PreMadeCharacter
    {
        ModelOfMagic modelOfMagic = new();
        Lists Lists = new();
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
            Console.WriteLine("what is your name?");
            string? newName = Console.ReadLine().ToLower();
            warriorModel.Name = newName;

            Console.WriteLine($"Your name is{warriorModel.Name}");
            Console.ReadKey();


            //choosing species
            Console.WriteLine("Type in one of the listed species");
            Console.WriteLine("Eldritch creature    Demonic Ancestor");
            Console.WriteLine("Angelic Ancestor         Human       ");
            string? species = Console.ReadLine().ToLower();
            warriorModel.Species = species;

            switch (species)
            {
                case "eldritch creature":
                    Console.WriteLine("Beautiful Eldritch creatures are truly are an amazing creature I love you");
                    Console.ReadKey();
                    break;

                case "demonic ancestor":
                    Console.WriteLine("Look on the bright side as a Demonic Ancestor you will never get cold on the bad side you will defintly end up in hell");
                    Console.ReadKey();
                    break;

                case "angelic ancestor":
                    Console.WriteLine("I am soooooooo jelous of your wings I also want angel wings, why dont I have angel wings :()");
                    Console.ReadKey();
                    break;

                case "human":
                    Console.WriteLine("Seriously you had the decision between a creature beoynd reality, a demon and an angel and you choose a human??!\nYou must be fun at parties...");
                    Console.ReadKey();
                    break;
            }

            //choosing magic 
            Console.WriteLine("And now for the exciting part choosing magic. Remember this is an important decision that will decide 3 out of your 4 spells");



        }
    }
}
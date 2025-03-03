using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using idk.character;
using idk.MobsAndAttacks;

namespace idk.Stories
{
    public class GaryStoleYourLunch
    {
        //adding classes that I need for the story
        HumanMobs human = new();
        public string MobName = "";
        public string fireball;
        public string slash;
        public int fireballdmg;
        public int slashdmg;

        //player variables
        public string name = "";
        public int playerhealth;
        public int GaryHealth;
        public int playermana;
        public string? spell1;
        public string? spell2;
        public int damage2;
        public string? spell3;

        public string playerCh = $"Wizards/Wizard-Ika";


        //reading stats and assigning them to local variables
        public void ReadPlayerStats()
        {
            string[] player = File.ReadAllLines(playerCh);

            foreach (string line in player)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim();
                    string value = parts[1].Trim();

                    switch (key)
                    {
                        case "Name":
                            name = value;
                            break;

                        case "Health":
                            int.TryParse(value, out playerhealth);
                            break;

                        case "Mana":
                            int.TryParse(value, out playerhealth);
                            break;

                        case "Spell 1":
                            spell1 = value;
                            break;
                        case "Spell 2":
                            spell2 = value;
                            break;

                        case "Damage2":
                            int.TryParse(value, out damage2);
                            break;

                        case "Spell 3":
                            spell3 = value;
                            break;
                    }
                }
            }
        }


        //assigning mobstats to variables
        public void mobStats()
        {
            fireball = human.Gary.Attacks[0];
            slash = human.Gary.Attacks[1];
            fireballdmg = MobBricks.AttackDamage[human.Gary.Attacks[0]][0];
            slashdmg = MobBricks.AttackDamage[human.Gary.Attacks[1]][0];
        }

        public void Intro()
        { }
        public void Morning()
        {
            //printing
            string start = @"it's a wonderful morning, you are standing on top of a castle wall enjoying the view It's been a quiet morning guarding 
the castle and you are starting to think that maybe the noble that hired you to kill demons from hell was a bit paranoid Nevertheless it's time for lunch";
            for (int i = 0; i < start.Length; i++)
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);  // Consume the key press
                    Console.Write(start.Substring(i));  // Instantly print remaining text
                    break;  // Exit the loop
                }
                Console.Write(start[i]);
                Thread.Sleep(60);
            }

            bool firstChoice = false;
            int choice1Counter = 0;
            while (!firstChoice)
            {
                Console.WriteLine("You have two choices\n(1) Stare at the view hoping something interesting will happen\n(2) Go to the kitchen and get your lunch");
                string playerInput = Console.ReadLine();

                if (choice1Counter == 3)
                {
                    string death1 = @"Turns out that thing in the distance wasnt a bird it was an aincent dragon who seems very hungry, before you are able to utter a single spell it swoops down at you ripping
                    your body to pieces and swallowing it whole. Just because you didnt want lunch dosent mean the dragon dosent want lunch";
                    for (int i = 0; i < death1.Length; i++)
                    {
                        Console.Write(death1[i]);
                        Thread.Sleep(60);
                    }

                    GameOVer();
                    firstChoice = true;
                }
                else
                {
                    switch (playerInput)
                    {
                        case "1":
                            string choice1 = "You stare at the view from the castle wall\n You watch the mountains, the river, the forest you see something flying in the distance probably a bird";
                            for (int i = 0; i < choice1.Length; i++)
                            {
                                Console.Write(choice1[i]);
                                Thread.Sleep(60);
                            }
                            choice1Counter += 1;
                            firstChoice = false;
                            break;



                        case "2":
                            string choice2 = "You walk down the shittly made castle stairs that are way to narrow and should defintly be upgraded but if they have lasted for 500 years why care";
                            for (int i = 0; i < choice2.Length; i++)
                            {
                                Console.Write(choice2[i]);
                                Thread.Sleep(60);
                            }
                            TheKitchen();
                            firstChoice = true;
                            break;

                        default:
                            Console.WriteLine("invalid choice please pick\n1\nor\n2");
                            break;
                    }

                }

            }
        }

        public void TheKitchen()
        {
            string kitchenOpening = @"Entering the castle Kitchen you see the same room you have been eating in for the past three days. It's a large rectangular room made out of stone. 
            there are a row of tall glass windows on the wall opposite of the entrance wall where tables are pushed against. There is a large fireplace for the winter cold in the middle and right next to the door is a set of
            refrigirators where everyone (except the lord) stores their lunch";

            for (int i = 0; i < kitchenOpening.Length; i++)
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);  // Consume the key press
                    Console.Write(kitchenOpening.Substring(i));  // Instantly print remaining text
                    break;  // Exit the loop
                }
                Console.Write(kitchenOpening[i]);
                Thread.Sleep(60);
            }

        }

        public void GameOVer()
        {
            Console.WriteLine("You are dead\n Game over");
        }

    }
}

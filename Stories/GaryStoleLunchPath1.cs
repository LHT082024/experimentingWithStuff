using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using idk.Stories;

namespace experimentingWithStuff.Stories
{
    public class GaryStoleLunchPath1
    {
        //takes the instance from current gary stole your lunch and give me
        //the ability to use the variables modified in garystoleyourlunch class
        private readonly GaryStoleYourLunch _basic;

        public GaryStoleLunchPath1(GaryStoleYourLunch basic)
        {
            _basic = basic;

        }

        public string? soldier1Name = "";
        public string? soldier2Name = "";
        public string? soldier3Name = "";
        public string? soldier4Name = "";
        public string? soldier5Name = "";
        public string? soldier6Name = "";
        public string? soldier7Name = "";
        public string? soldier8Name = "";
        public string? soldier9Name = "";
        public string? soldier10Name = "";
        public string soldierAttack1 = "";
        public int soliderAttackDmg;


        //starts of this path in the adventure
        public void theEscape()
        {
            string start = $@"The alarm bell is ringing. You hear multiple footsteps approach you. The lord of the castle had ten soldiers for protection, you and....Gary... 
            You quickly turn around and you see Gary(the second wizard hired to protect the lord of the castle) running out the backdoor holding a {_basic.playerLunch}. You could run after him,
            you could instead focus on the guards that's apporaching you or You could escape the kitchen by jumping out of the massive hole you created in its wall.";
            for (int i = 0; i < start.Length; i++)
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    Console.Write(start.Substring(i));  // Instantly print remaining text
                    break;  // Exit the loop
                }
                Console.Write(start[i]);
                Thread.Sleep(60);
            }
            Console.WriteLine("what will you do?");
            Console.WriteLine("(1): stay in the kitchen and fight\n(2): Jump out of the newly created 'door'\n(3): go after Gary");

            bool escape1 = false;

            while (!escape1)
            {
                _basic.playerInput = Console.ReadLine();
                switch (_basic.playerInput)
                {
                    case "1":
                        Console.WriteLine("You stand your ground in the kitchen as the door bursts open by ten armoured men with swords who surrounds you");
                        FightingTenMen();
                        escape1 = true;
                        break;

                    case "2":
                        Console.WriteLine("not wanting to fight ten armoured men you jump out of the massive hole and into the castle courtyard. A dragon flies above you but dosent seem to notice you as it's to high up");
                        escape1 = true;
                        Courtyard();
                        break;

                    case "3":
                        Console.WriteLine("Realizing that this is the fifth time Gary has stolen your lunch you can't let him go. Before the guards can get to you, you run after Gary through the backdoor and into a long hallway.");
                        escape1 = true;
                        ConfrontingGary();
                        break;

                    default:
                        Console.WriteLine("please type\n(1)\n(2)\n(3)");
                        break;
                }
            }
        }

        public void FightingTenMen()
        {
            Console.WriteLine("ten Men");

        }

        public void Courtyard()
        {
            Console.WriteLine("courtYard");
        }

        public void ConfrontingGary()
        {
            Console.WriteLine("Gary");
        }
    }
}
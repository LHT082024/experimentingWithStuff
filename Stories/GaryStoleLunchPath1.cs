using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using idk.MobsAndAttacks;
using idk.Stories;

namespace experimentingWithStuff.Stories
{
    public class GaryStoleLunchPath1
    {
        //takes the instance from current gary stole your lunch and give me
        //the ability to use the variables modified in garystoleyourlunch class
        private readonly GaryStoleYourLunch _basic;
        HumanMobs humanMobs = new();

        public GaryStoleLunchPath1(GaryStoleYourLunch basic)
        {
            _basic = basic;

        }

        public void Soldiers()
        {
            int soldier1health = humanMobs.Soldier1.Stuff.Hp;
            int soldier2health = humanMobs.Soldier1.Stuff.Hp;
            int soldier3health = humanMobs.Soldier1.Stuff.Hp;
            int soldier4health = humanMobs.Soldier1.Stuff.Hp;
            int soldier5health = humanMobs.Soldier1.Stuff.Hp;
            int soldier6health = humanMobs.Soldier1.Stuff.Hp;
            int soldier7health = humanMobs.Soldier1.Stuff.Hp;
            int soldier8health = humanMobs.Soldier1.Stuff.Hp;
            int soldier9health = humanMobs.Soldier1.Stuff.Hp;
            int soldier10health = humanMobs.Soldier1.Stuff.Hp;

            string soldierAttack1 = humanMobs.Soldier1.Attacks[0];
            string soldierAttack2 = humanMobs.Soldier1.Attacks[0];
            int slashdmgS = humanMobs.Soldier1.Attacks[0][0];
            int stabdmgS = humanMobs.Soldier1.Attacks[1][0];

        }



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
            Console.WriteLine("You have ten men surronding you armed with swords and lightly armoured");
            Console.ReadKey();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine($"(1): don't wanna fight after all try to run through them\n(2): {_basic.spell2}\n(3): Tell them the castle was halfbroken when you got there");

            bool tenMen = false;
            while (!tenMen)
            {
                _basic.playerInput = Console.ReadLine();
                switch (_basic.playerInput)
                {
                    case "1":
                        Console.WriteLine("this was obviusly a very bad idea. So you decide to run through them but they are to close togheter");
                        Console.WriteLine($"five soldiers use {}")
                }
            }

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public int newPlayerHealth;
        public int soldier1health;
        public int soldier2health;
        public int soldier3health;
        public int soldier4health;
        public int soldier5health;
        public int soldier6health;
        public int soldier7health;
        public int soldier8health;
        public int soldier9health;
        public int soldier10health;
        public string soldierAttack1;
        public string soldierAttack2;
        public int slashdmgS;
        int stabdmgS;
        public List<Mob> soldierList;

        public void Soldiers()
        {
            soldierList = new List<Mob>
          {
            humanMobs.Soldier1, humanMobs.Soldier2, humanMobs.Soldier3, humanMobs.Soldier4,humanMobs.Soldier5,
            humanMobs.Soldier6,humanMobs.Soldier7,humanMobs.Soldier8,humanMobs.Soldier9,humanMobs.Soldier10,
          };

            soldierAttack1 = humanMobs.Soldier1.Attacks[0];
            soldierAttack2 = humanMobs.Soldier1.Attacks[0];
            slashdmgS = humanMobs.Soldier1.Attacks[0][0];
            stabdmgS = humanMobs.Soldier1.Attacks[1][0];
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
            Console.WriteLine($"\n(1): don't wanna fight after all try to run through them\n(2): {_basic.spell2}\n(3): Tell them the castle was halfbroken when you got there");

            bool tenMen = false;
            while (!tenMen)
            {
                _basic.playerInput = Console.ReadLine();
                switch (_basic.playerInput)
                {
                    case "1":
                        Console.WriteLine("this was obviusly a very bad idea. So you decide to run through them but they are to close togheter");
                        Console.WriteLine($"five soldiers use {soldierAttack1}");
                        newPlayerHealth = _basic.playerhealth - slashdmgS;
                        newPlayerHealth = _basic.playerhealth -= slashdmgS;
                        newPlayerHealth = _basic.playerhealth -= slashdmgS;
                        newPlayerHealth = _basic.playerhealth -= slashdmgS;
                        newPlayerHealth = _basic.playerhealth -= slashdmgS;

                        if (newPlayerHealth > 0)
                        {
                            Console.WriteLine("The soldiers look at you horrified as you stand there still alive");
                            Console.WriteLine("To terrified to do anything else the soldiers let you past them");
                            tenMen = true;
                        }
                        else
                        {
                            Console.WriteLine("not suprising get slashed by multiple soldiers multiple times you end up falling dead on the spot");
                            _basic.GameOVer();
                            tenMen = true;
                        }
                        break;

                    case "2":
                        Console.WriteLine("Another sphere of black and pink lighting forms in your hand and you toss it into the soldiers in front of you");
                        // soldier1health = soldier1health - _basic.damage2;
                        // soldier2health = soldier1health - _basic.damage2;
                        // soldier3health = soldier1health - _basic.damage2;
                        // soldier4health = soldier1health - _basic.damage2;
                        // Console.WriteLine("You killed 4 soldiers there are 6 left");
                        for (int i = 0; i < 4 && i < soldierList.Count; i++)
                        {
                            var soldier = soldierList[i];
                            soldier.Stuff.Hp -= _basic.damage2;
                            Console.WriteLine($"{soldier.Name}, {soldier.Stuff.Hp}");
                            Console.WriteLine("----");
                        }

                        // Count remaining soldiers after the attack
                        int remainingSoldiers = soldierList.Count - 4; // adjust based on your logic

                        if (remainingSoldiers > 0)
                        {
                            Console.WriteLine($"You killed 4 soldiers, there are {remainingSoldiers} left.");
                        }
                        else
                        {
                            Console.WriteLine("All soldiers have been defeated.");
                        }

                        // Optionally print the health of all soldiers if needed
                        Console.WriteLine("Current health of all soldiers:");
                        foreach (var soldier in soldierList)
                        {
                            Console.WriteLine($"{soldier.Name}, {soldier.Stuff.Hp}");
                        }

                        CombatAgainstSoldiers();
                        break;

                    case "3":
                        Console.WriteLine("You take a steb back and with a fake suprised face you say.");
                        Console.WriteLine("(1): It was like this when I got there\n(2): a dragon did it\n(3): Gary did it");
                        _basic.playerInput = Console.ReadLine();
                        if (_basic.playerInput == "1")
                        {
                            Console.WriteLine("the soldiers dosent belive it, multiple soldiers stab you and you die bleeding on the floor");
                            tenMen = true;
                            _basic.GameOVer();
                        }
                        else if (_basic.playerInput == "2")
                        {
                            Console.WriteLine("the soldiers look up and see a dragon flying over the castle");
                            Console.WriteLine("they lower their weapons and one of them shake your hand suprised you could survive that scary creature");
                            tenMen = true;
                            _basic.WinAgainstDragon();
                        }
                        break;
                }
            }
        }

        public void CombatAgainstSoldiers()
        {
            string introtext = "Four dead soldiers lie in front of you. The other six are shocked and a bit scared. But they stand strong and go for the attack";
            for (int i = 0; i < introtext.Length; i++)
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    Console.Write(introtext.Substring(i));  // Instantly print remaining text
                    break;  // Exit the loop
                }
                Console.Write(introtext[i]);
                Thread.Sleep(60);

                // Console.WriteLine(solider)
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
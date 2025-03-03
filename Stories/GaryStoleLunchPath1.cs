using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using idk.Stories;

namespace experimentingWithStuff.Stories
{
    public class GaryStoleLunchPath1
    {
        private readonly GaryStoleYourLunch _basic;

        public GaryStoleLunchPath1(GaryStoleYourLunch basic)
        {
            _basic = basic;

        }
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
        }
    }
}
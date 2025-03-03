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
            string start = @"The alarm bell is ringing. You hear multiple footsteps approach you. The lord of the castle has at least ten guards. You could try to fight them all in the kitchen
            but that might not be such a good idea as it could be deadly. You could also jump out of the massive hole you just created in the castle wall and try to run.";
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
            Console.WriteLine("(1): stay in the kitchen and fight\n(2): Jump out of the newly created 'door'");
        }
    }
}
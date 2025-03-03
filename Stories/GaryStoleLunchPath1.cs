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
            string start
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

            Console.WriteLine($"{_basic.spell2}");
        }
    }
}
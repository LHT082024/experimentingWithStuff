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
        public void testing()
        {
            Console.WriteLine($"{_basic.spell2}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using idk.Interfaces;

namespace idk
{
    public class Testingstuff : ICharacter
    {
        public void ChName()
        {
            string lol = "Name";
            Console.WriteLine(lol);
        }
    }
}
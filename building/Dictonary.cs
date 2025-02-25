using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk.building
{
    public class Dictonary
    {
        public static readonly Dictionary<string, List<string>> Species = new()
        {

        };

        public static readonly Dictionary<string, List<string>> Spells = new()
        {
            {
                 "Eldritch magic",
                ["szathot's eyes", "sphere of destruction", "shield of yog"]
            }

        };
    }
}
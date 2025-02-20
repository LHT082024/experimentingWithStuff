using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk
{
    public class ModelOfMagic
    {
        public string? Element { get; set; }
        public int PowerlvlAdd { get; set; }
        public string? NatureInspo { get; set; }
        public string? Species { get; set; }

        public override string ToString()
        {
            return $"{Element}";
        }
    }
}
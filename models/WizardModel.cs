using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idk.models
{
    //inteligence affect power lvl
    public class WizardModel
    {
        public string? Name { get; set; }
        public ModelOfMagic? magic { get; set; }
        public int PowerLvl => magic.PowerlvlAdd + 5;
        public int Wisdom { get; set; }


    }
}
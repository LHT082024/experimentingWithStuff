using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using idk.models;

namespace idk
{
    public class Lists
    {
        public List<ModelOfMagic> modelOfMagicss = new List<ModelOfMagic>(){
            new ModelOfMagic {Element = "Eldritch", NatureInspo = "Water, Lightning, Squid,", PowerlvlAdd = 10},
            new ModelOfMagic {Element = "Darkness", NatureInspo = "Ice, Shadow, Demon", PowerlvlAdd = 9},
            new ModelOfMagic {Element = "Holy", NatureInspo = "Air, Light, Angel", PowerlvlAdd = 9},
            new ModelOfMagic {Element = "Fire", NatureInspo = "Fire,  Dragon", PowerlvlAdd = 5},
            new ModelOfMagic {Element = "Ice", NatureInspo = "Frost, Giants", PowerlvlAdd = 5},
            new ModelOfMagic {Element = "EnchantedWeapon", NatureInspo = "Weapons", PowerlvlAdd = 3}
        };

        public List<ModelOfSpecies> modelOfSpecies = new List<ModelOfSpecies>()
        {

        };

    }
}
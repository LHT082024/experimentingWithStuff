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
            new ModelOfMagic {Element = "eldritch", NatureInspo = "Water, Lightning, Squid,", PowerlvlAdd = 10},
            new ModelOfMagic {Element = "darkness", NatureInspo = "Ice, Shadow, Demon", PowerlvlAdd = 9},
            new ModelOfMagic {Element = "holy", NatureInspo = "Air, Light, Angel", PowerlvlAdd = 9},
            new ModelOfMagic {Element = "fire", NatureInspo = "Fire,  Dragon", PowerlvlAdd = 5},
            new ModelOfMagic {Element = "ice", NatureInspo = "Frost, Giants", PowerlvlAdd = 5},
            new ModelOfMagic {Element = "enchantedWeapon", NatureInspo = "Weapons", PowerlvlAdd = 3}
        };

        public List<ModelOfSpecies> modelOfSpecies = new List<ModelOfSpecies>()
        {
            new ModelOfSpecies {SpeciesName = "eldritch creature", SpeciesHealth = 10, SpeciesMana = 10, SpeciesSpell = "Eldritch Tendrils"},
            new ModelOfSpecies {SpeciesName = "demonic ancestor", SpeciesHealth = 5, SpeciesMana = 5, SpeciesSpell= "Lucifer's Wings"},
            new ModelOfSpecies {SpeciesName = "angelic ancestor", SpeciesHealth = 5, SpeciesMana = 5, SpeciesSpell= "Angelic Judgment"},
            new ModelOfSpecies {SpeciesName = "human", SpeciesHealth = 3, SpeciesMana = 3, SpeciesSpell= "Magic Grenade"},
            new ModelOfSpecies {SpeciesName = "elf", SpeciesHealth = 4, SpeciesMana = 4, SpeciesSpell ="Natures Law"}
        };
    }
}
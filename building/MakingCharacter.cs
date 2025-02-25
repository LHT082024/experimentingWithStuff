using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using idk.building;

namespace idk.models
{
    public class MakingCharacter
    {
        public void CharacterCreation()
        {
            var player = new Character("Ika").AddSpecies("eldritch creature");
        }

    }
}
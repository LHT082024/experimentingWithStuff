using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using idk.building;

namespace idk.models
{
    public class CreatingCharacter
    {
        public void CharacterCreation()
        {
            var player = new Character("Ika").AddSpecies("eldritch creature").AddMagic("eldritch magic");

            Console.WriteLine($"your name: {player.Name}\n your a: {player.Stats}\n your magic type is {player.Spells}");
        }

    }
}
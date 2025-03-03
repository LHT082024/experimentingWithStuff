using idk.character;
using idk.MobsAndAttacks;
using idk.models;
using idk.Stories;

namespace idk;

class Program
{
    static void Main(string[] args)
    {
        GaryStoleYourLunch garyStoleYourLunch = new();
        CreatingCharacter creatingCharacter = new();
        // creatingCharacter.CharacterCreation();


        garyStoleYourLunch.ReadPlayerStats();
        // garyStoleYourLunch.mobStats();
        // garyStoleYourLunch.Morning();
        garyStoleYourLunch.TheKitchen();
    }
}

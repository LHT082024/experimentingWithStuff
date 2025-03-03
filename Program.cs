using experimentingWithStuff.Stories;
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
        GaryStoleLunchPath1 garyStoleLunchPath1 = new(garyStoleYourLunch);
        CreatingCharacter creatingCharacter = new();
        // creatingCharacter.CharacterCreation();


        garyStoleYourLunch.ReadPlayerStats();
        // garyStoleYourLunch.mobStats();
        // garyStoleYourLunch.Morning();
        // garyStoleYourLunch.TheKitchen();
        garyStoleLunchPath1.theEscape();
        // garyStoleLunchPath1.FightingTenMen();
        // garyStoleLunchPath1.Courtyard();
        // garyStoleLunchPath1.ConfrontingGary();

    }
}

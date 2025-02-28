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
        // //intro and character creator
        CreatingCharacter creatingCharacter = new();
        // Intros intros = new();
        // TestMob testMob = new();

        // // intros.PlaneIsekaiIntro();
        // creatingCharacter.CharacterCreation();


        // garyStoleYourLunch.ReadPlayerStats();
        // garyStoleYourLunch.mobStats();
        garyStoleYourLunch.Morning();
    }
}

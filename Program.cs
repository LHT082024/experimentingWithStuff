using idk.character;
using idk.MobsAndAttacks;
using idk.models;

namespace idk;

class Program
{
    static void Main(string[] args)
    {
        //intro and character creator
        CreatingCharacter creatingCharacter = new();
        Intros intros = new();
        TestMob testMob = new();

        // intros.PlaneIsekaiIntro();
        // creatingCharacter.CharacterCreation();

        testMob.ReadHp();
        testMob.printshit();
        testMob.Basicattack();
        testMob.printshit();
        testMob.Basicattack();
        // testMob.SaveStats();
        testMob.Basicattack();

    }
}

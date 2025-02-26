using idk.character;
using idk.mobs;
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
        // testMob.printshit();

    }
}

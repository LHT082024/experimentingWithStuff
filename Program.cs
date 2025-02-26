using idk.character;
using idk.models;

namespace idk;

class Program
{
    static void Main(string[] args)
    {
        //intro and character creator
        CreatingCharacter creatingCharacter = new();
        Intros intros = new();

        intros.PlaneIsekaiIntro();
        creatingCharacter.CharacterCreation();
    }
}

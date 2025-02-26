using idk.building;
using idk.models;

namespace idk;

class Program
{
    static void Main(string[] args)
    {
        WarriorModel myWizard = new();
        ReadingWizards readingWizards = new();
        CreatingCharacter creatingCharacter = new();

        creatingCharacter.CharacterCreation();


        // makingWizard.Intro();
        // makingWizard.CreateCharacter();

    }
}

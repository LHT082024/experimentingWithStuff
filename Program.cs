using idk.building;
using idk.models;

namespace idk;

class Program
{
    static void Main(string[] args)
    {
        MakingCharacter makingWizard = new();
        WarriorModel myWizard = new();
        ReadingWizards readingWizards = new();
        CreatingCharacter creatingCharacter = new();

        creatingCharacter.CharacterCreation();
        // readingWizards.Wizards();
        // readingWizards.Test();

        // makingWizard.Intro();
        // makingWizard.CreateCharacter();

    }
}

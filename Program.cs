using idk.building;
using idk.models;

namespace idk;

class Program
{
    static void Main(string[] args)
    {
        // WarriorModel myWizard = new();
        // ReadingWizards readingWizards = new();
        CreatingCharacter creatingCharacter = new();
        Intros intros = new();

        intros.PlaneIsekaiIntro();
        creatingCharacter.CharacterCreation();
    }
}

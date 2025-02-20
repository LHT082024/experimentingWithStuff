using idk.models;

namespace idk;

class Program
{
    static void Main(string[] args)
    {
        PreMadeCharacter makingWizard = new();
        WarriorModel myWizard = new();
        ReadingWizards readingWizards = new();

        // readingWizards.Wizards();
        // readingWizards.Test();

        makingWizard.MakeCharacter(myWizard);
    }
}

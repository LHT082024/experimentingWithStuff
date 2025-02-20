using idk.models;

namespace idk;

class Program
{
    static void Main(string[] args)
    {
        PreMadeWizards makingWizard = new();
        WizardModel myWizard = new();
        ReadingWizards readingWizards = new();
        FightSystem fightSystem = new();

        readingWizards.Wizards();
        readingWizards.test();
        // fightSystem.FightPeople();

        // makingWizard.CompleteWizards(myWizard);
    }
}

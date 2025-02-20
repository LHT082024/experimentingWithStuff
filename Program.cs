using idk.models;

namespace idk;

class Program
{
    static void Main(string[] args)
    {
        PreMadeWizards makingWizard = new();
        WizardModel myWizard = new();
        FightingSystem fightingSystem = new();

        // fightingSystem.Wizards();

        makingWizard.CompleteWizards(myWizard);
    }
}

using idk.models;

namespace idk;

class Program
{
    static void Main(string[] args)
    {
        PreMadeWizards makingWizard = new();
        WizardModel myWizard = new();

        //generating a new wizard
        makingWizard.CompleteWizards(myWizard);

        string filepath = $"Wizards/ Wizard Luka.txt";

        Console.WriteLine(filepath);


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using idk.models;

namespace idk
{
    public class PreMadeWizards
    {
        ModelOfMagic modelOfMagic = new();
        Allmagic allmagic = new();
        WizardModel wizardModel = new();

        public void CompleteWizards(WizardModel wizard)
        {
            //making a complete wizard
            wizard.Name = "Luka";
            wizard.magic = allmagic.modelOfMagicss[0];

            string CompleteWizard = $"Name: {wizard.Name}\nElement: {wizard.magic}\nPowerlvl: {wizard.PowerLvl}";
            string fileName = $"Wizard-{wizard.Name}";
            string folderPath = "Wizards";

            string filePath = Path.Combine(folderPath, fileName);

            File.WriteAllText(filePath, CompleteWizard);
        }
    }
}
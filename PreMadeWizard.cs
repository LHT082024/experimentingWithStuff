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
            wizard.Name = "Matt";
            wizard.magic = allmagic.modelOfMagicss[1];

            string CompleteWizard = $"Name: {wizard.Name}\n Element: {wizard.magic}\n Powerlvl {wizard.PowerLvl}";
            string fileName = $" Wizard-{wizard.Name}.txt";
            string folderPath = "Wizards";

            string filePath = Path.Combine(folderPath, fileName);

            File.WriteAllText(filePath, CompleteWizard);
        }
    }
}
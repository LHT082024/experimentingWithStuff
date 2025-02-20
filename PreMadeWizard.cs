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
            wizard.Name = "Luka";
            wizard.magic = allmagic.modelOfMagicss[0];

            string CompleteWizard = $"Name: {wizard.Name}\n Element: {wizard.magic}\n Powerlvl {wizard.PowerLvl}";
            string filePath = $"Wizards/ Wizard {wizard.Name}.txt";

            File.WriteAllText(filePath, CompleteWizard);
        }
    }
}
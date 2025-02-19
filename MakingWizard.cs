using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using idk.models;

namespace idk
{
    public class MakingWizard
    {
        ModelOfMagic modelOfMagic = new();
        Allmagic allmagic = new();
        WizardModel wizardModel = new();

        public void CompleteWizards(WizardModel wizard)
        {
            wizard.Name = "Luka";
            wizard.magic = allmagic.modelOfMagicss[0];

            Console.WriteLine($"your name is: {wizard.Name}\n {wizard.Name}'s magic type is {wizard.magic.Element}\n {wizard.Name} powerlevel {wizard.PowerLvl}");
        }
    }
}
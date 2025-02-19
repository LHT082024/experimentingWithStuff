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

        public void CompleteWizards()
        {
            wizardModel.Name = "Luka";
        }

    }
}
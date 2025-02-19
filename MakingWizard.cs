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
            wizardModel.MagicType = $"{modelOfMagic.Element = "Eldritch"}";
            wizardModel.PowerLvl = modelOfMagic.PowerlvlAdd + 10;
            Console.WriteLine($"Your name is: {wizardModel.Name}\n Your magic type is: {modelOfMagic.Element = "Eldritch"}\n your power level is {wizardModel.PowerLvl}");
        }

    }
}
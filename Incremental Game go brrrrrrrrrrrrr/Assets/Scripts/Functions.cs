using UnityEngine;
using static BreakInfinity.BigDouble;
namespace BreakInfinity
{
    public class Functions : MonoBehaviour
    {
        public Gain gain;//temporary
        public Helium helium;
        public Hydrogen Hydrogen;
        public Upgrades upgrades;
        public Lithium lithium;
        public void doubleHeCheck()
        {
            if (helium.BigAssNumber >= 1000 && helium.DoubleHelium == false)
            {
                helium.BigAssNumber -= 1000;
                helium.DoubleHelium = true;
            }
        }
        
        public void NuclearFusion()
        {
            if (helium.HeliumGain >= 1)
            {
                Hydrogen.BigAssNumber = 0;
                Hydrogen.ClickPower = 1;
                Hydrogen.HydrogenGen = 0;
                upgrades.HClickStrengthLevel = 0;
                upgrades.HClickStrength2Level = 0;
                upgrades.HHydrogenGenLevel = 0;
                upgrades.HHydrogenGen2Level = 0;
                helium.BigAssNumber += helium.HeliumGain;
            }
        }

		public void LithiumCheck()
        {
            if (helium.BigAssNumber>= 1e6 && helium.DoubleHelium == false)
            {
                helium.BigAssNumber -= 1e6;
                lithium.lithiumCheck = true;
            }
        }

        public void Update()
        {
            if (helium.DoubleHelium == false)
            {
                helium.HeliumGain = (150 * Sqrt(Hydrogen.BigAssNumber / 2.25e9) * Pow(1.1, upgrades.HHeliumGain1Level) * Pow(1.5, gain.heliumGainUpg2Level) *
                              (1 + gain.lithiumBoostHe) * Pow(1.25, gain.heliumGainUpg3Level));
            }
            else
            {
                helium.HeliumGain = 2 * (150 * Sqrt(Hydrogen.BigAssNumber / 2.25e9)) * Pow(1.1, upgrades.HHeliumGain1Level) * Pow(1.5,
                    gain.heliumGainUpg2Level * (1 + gain.lithiumBoostHe) * Pow(1.25, gain.heliumGainUpg3Level));
            }
        }
    }
}
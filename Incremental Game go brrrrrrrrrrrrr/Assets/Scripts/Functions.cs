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
        public Beryllium beryllium;
        public bool save1stMaxBuyCheck = false;
        public bool save1stPeriodCheck = false;
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
        public void Lithify()
        {
            if (helium.BigAssNumber >= 4.45e6 && lithium.lithiumCheck == true && save1stPeriodCheck == false)
            {
                Hydrogen.BigAssNumber = 0;
                Hydrogen.ClickPower = 1;
            
                upgrades.HHeliumGain1Level = 0;
                upgrades.HeHeliumGainLevel = 0;
                upgrades.HeHydrogenGenLevel = 0;
                if (save1stMaxBuyCheck == false)
                {
                    Hydrogen.MaxBuyerCheck = false;
                }

                helium.BigAssNumber = 0;

                lithium.bigAssNumber += lithium.lithiumGain;
            }
            else if (helium.BigAssNumber >= 4.45e6 && lithium.lithiumCheck == true && save1stPeriodCheck == true)
            {
                lithium.bigAssNumber += lithium.lithiumGain;
            }
        }
        public void save1stMaxBuy()
        {
            if (lithium.bigAssNumber >= 5e3 && save1stMaxBuyCheck == false)
            {
                save1stMaxBuyCheck = true;
                lithium.bigAssNumber -= 5e3;
            }
        }
        public void Save1stPeriod()
        {
            if (beryllium.bigAssNumber >= 2e3 && save1stPeriodCheck == false)
            {
                save1stPeriodCheck = true;
                beryllium.bigAssNumber -= 2e3;
            }
        }
    }
}
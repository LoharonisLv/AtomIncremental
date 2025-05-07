using UnityEngine;
using static BreakInfinity.BigDouble;
namespace BreakInfinity
{
    public class Upgrades : MonoBehaviour
    {
        public Hydrogen Hydrogen;
        public BigDouble HClickStrengthLevel;
        public BigDouble HClickStrength2Level;
        public BigDouble HHydrogenGenLevel;
        public BigDouble HHydrogenGen2Level;

        public BigDouble InstantCost(BigDouble startCost, BigDouble power, BigDouble level)
        {
            BigDouble cost = startCost * Pow(power, level);
            return cost;
        }

        public void HClickStrength()
        {
            if (Hydrogen.BigAssNumber >= InstantCost(10, 1.07, HClickStrengthLevel))
            {
                Hydrogen.BigAssNumber -= InstantCost(10, 1.07, HClickStrengthLevel);
                HClickStrengthLevel++;
            }
        }

        public void HClickStrength2()
        {
            if (Hydrogen.BigAssNumber >= InstantCost(200, 1.07, HClickStrength2Level))
            {
                Hydrogen.BigAssNumber -= InstantCost(200, 1.07, HClickStrength2Level);
                HClickStrength2Level++;
            }
        }

        public void HHydrogenGen()
        {
            if (Hydrogen.BigAssNumber >= InstantCost(75, 1.07, HHydrogenGenLevel))
            {
                Hydrogen.BigAssNumber -= InstantCost(75, 1.07, HHydrogenGenLevel);
                HHydrogenGenLevel++;
            }
        }

        public void HHydrogenGen2()
        {
            if (Hydrogen.BigAssNumber >= InstantCost(800, 1.07, HHydrogenGen2Level))
            {
                Hydrogen.BigAssNumber -= InstantCost(800, 1.07, HHydrogenGen2Level);
                HHydrogenGen2Level++;
            }
        }
    }
}
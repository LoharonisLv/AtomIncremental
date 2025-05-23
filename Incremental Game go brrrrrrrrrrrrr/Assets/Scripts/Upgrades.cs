using System;
using UnityEngine;
using static BreakInfinity.BigDouble;
namespace BreakInfinity
{
    public class Upgrades : MonoBehaviour
    {
        public Hydrogen Hydrogen;
        public Helium helium;
        public BigDouble HClickStrengthLevel;
        public BigDouble HClickStrength2Level;
        public BigDouble HHydrogenGenLevel;
        public BigDouble HHydrogenGen2Level;
        public BigDouble HHeliumGain1Level;
        public CanvasGroup hMaxBuyersGroup;

        public void Update()
        {
            if (Hydrogen.MaxBuyerCheck == true)
            {
                hMaxBuyersGroup.alpha = 1;
                hMaxBuyersGroup.blocksRaycasts = true;
                hMaxBuyersGroup.interactable = true;
            }
            else
            {
                hMaxBuyersGroup.alpha = 0;
                hMaxBuyersGroup.blocksRaycasts = false;
                hMaxBuyersGroup.interactable = false;
            }
        }

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
        public void HHeliumGain()
        {
            if (Hydrogen.BigAssNumber >= InstantCost(1e15, 1.1, HHeliumGain1Level))
            {
                Hydrogen.BigAssNumber -= InstantCost(1e15, 1.1, HHeliumGain1Level);
                HHeliumGain1Level++;
            }
        }

        public void UnlockMaxBuyers()
        {
            if (Hydrogen.BigAssNumber >= 1e7 && Hydrogen.MaxBuyerCheck == false)
            {
                Hydrogen.BigAssNumber -= 1e7;
                Hydrogen.MaxBuyerCheck = true;
                
            }
        }

		
        
        
        public void MaxBuyerUpgrades(string upgradeID)
        {
            switch (upgradeID)
        {
            
           case "C1MAX":
                var b = 10;
                var c = Hydrogen.BigAssNumber;
                var r = 1.07;
                var k = HClickStrengthLevel;
                var n = Floor(Log(((c * (r - 1)) / (b * Pow(r, k))) + 1, r));

                var cost2 = b * ((Pow(r, k) * (Pow(r, n) - 1)) / (r - 1));

                if (Hydrogen.BigAssNumber >= cost2)
                {
                    HClickStrengthLevel += Convert.ToInt32(n.ToDouble());
                    Hydrogen.BigAssNumber -= cost2;
                    Hydrogen.ClickPower += n;
                }
                break;
            case "C2MAX":
                var b1 = 250;
                var c1 = Hydrogen.BigAssNumber;
                var r1 = 1.07;
                var k1 = HClickStrength2Level;
                var n1 = Floor(Log(((c1 * (r1 - 1)) / (b1 * Pow(r1, k1))) + 1, r1));

                var cost3 = b1 * ((Pow(r1, k1) * (Pow(r1, n1) - 1)) / (r1 - 1));

                if (Hydrogen.BigAssNumber >= cost3)
                {
                    HClickStrength2Level += Convert.ToInt32(n1.ToDouble());
                    Hydrogen.BigAssNumber -= cost3;
                    Hydrogen.ClickPower += (n1 * 5);
                }

                break;
            case "A1MAX":
                var b2 = 100;
                var c2 = Hydrogen.BigAssNumber;
                var r2 = 1.07;
                var k2 = HHydrogenGenLevel;
                var n2 = Floor(Log(((c2 * (r2 - 1)) / (b2 * Pow(r2, k2))) + 1, r2));

                var cost6 = b2 * ((Pow(r2, k2) * (Pow(r2, n2) - 1)) / (r2 - 1));

                if (Hydrogen.BigAssNumber >= cost6)
                {
                    HHydrogenGenLevel += Convert.ToInt32(n2.ToDouble());
                    Hydrogen.BigAssNumber -= cost6;
                }

                break;
            case "A2MAX":
                var b3 = 1000;
                var c3 = Hydrogen.BigAssNumber;
                var r3 = 1.07;
                var k3 = HHydrogenGen2Level;
                var n3 = Floor(Log(((c3 * (r3 - 1)) / (b3 * Pow(r3, k3))) + 1, r3));

                var cost8 = b3 * ((Pow(r3, k3) * (Pow(r3, n3) - 1)) / (r3 - 1));

                if (Hydrogen.BigAssNumber >= cost8)
                {
                    HHydrogenGen2Level += Convert.ToInt32(n3.ToDouble());
                    Hydrogen.BigAssNumber -= cost8;
                }

                break;
            default:
                Debug.Log(message: "No upgrade found");
                break;
                }

            
        }
    }
}
using UnityEngine;
namespace BreakInfinity
    
{
    public class CurrencyGain : MonoBehaviour
    {
        public Hydrogen Hydrogen;
        public Upgrades Upgrades;

        public void HydrogenClick()
        {
            Hydrogen.BigAssNumber += Hydrogen.ClickPower;
        }

        public void Update()
        {
            Hydrogen.BigAssNumber += Hydrogen.HydrogenGen * Time.deltaTime;
            Hydrogen.ClickPower = 5*Upgrades.HClickStrength2Level + Upgrades.HClickStrengthLevel;
            Hydrogen.HydrogenGen = 5*Upgrades.HHydrogenGen2Level + Upgrades.HHydrogenGenLevel;
        }
        
        
        
    }
}
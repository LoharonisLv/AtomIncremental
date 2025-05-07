using UnityEngine;
namespace BreakInfinity
    
{
    public class CurrencyGain : MonoBehaviour
    {
        public Hydrogen Hydrogen;
        public Upgrades Upgrades;

        public void HydrogenClick()
        {
            Hydrogen.BigAssNumber += (Hydrogen.ClickPower + Upgrades.HClickStrengthLevel +(5*Upgrades.HClickStrength2Level));
        }

        public void Update()
        {
            Hydrogen.BigAssNumber += (Hydrogen.HydrogenGen + Upgrades.HHydrogenGen2Level + (5*Upgrades.HHydrogenGen2Level)) * Time.deltaTime;
        }
        
        
        
    }
}
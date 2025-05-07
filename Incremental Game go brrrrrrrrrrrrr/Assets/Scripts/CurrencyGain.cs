using UnityEngine;
namespace BreakInfinity
    
{
    public class CurrencyGain : MonoBehaviour
    {
        public Hydrogen Hydrogen;

        public void HydrogenClick()
        {
            Hydrogen.BigAssNumber += Hydrogen.ClickPower;
        }
        
    }
}
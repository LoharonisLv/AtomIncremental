using UnityEngine;
namespace BreakInfinity
    
{
    public class CurrencyGain : MonoBehaviour
    {
        public Hydrogen Hydrogen;
        void HydrogenClick()
        {
            Hydrogen.BigAssNumber += Hydrogen.ClickPower;
        }
        
    }
}
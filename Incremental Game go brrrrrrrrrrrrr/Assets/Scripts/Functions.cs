using UnityEngine;
namespace BreakInfinity
{
    public class Functions : MonoBehaviour
    {
        public Helium helium;
        public Hydrogen Hydrogen;
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
            if (Hydrogen.BigAssNumber > 1.1e5)
            {
                Hydrogen.BigAssNumber = 0;
                Hydrogen.ClickPower = 1;
            
                

                helium.BigAssNumber += helium.HeliumGain;
            }
        }
    }
}
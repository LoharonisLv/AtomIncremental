using BreakInfinity;
using UnityEngine;
using UnityEngine.UI;
using static BreakInfinity.BigDouble;

public class Texts : MonoBehaviour
{
    public Hydrogen Hydrogen;  // Reference to your data script
    public Text hydrogenText;  // Reference to a Text UI component in the scene
    public Text hydrogenTextPs;
    public Text hydrogenClickText;
    
    void Update()
    {
        hydrogenText.text = "Hydrogen: " + NotationMethod(Hydrogen.BigAssNumber, "F0");
        hydrogenTextPs.text = "Hydrogen/s: " + NotationMethod(Hydrogen.HydrogenGen, "F0");
        hydrogenClickText.text = "Click for " + NotationMethod(Hydrogen.ClickPower, "F0");
    }
    
    private string NotationMethod(BigDouble x, string y)
    {
        if (x > 1000)
        {
            var exponent = (Floor(Log10(Abs(x))));
            var mantissa = (x / Pow(10, exponent));
            return mantissa.ToString("F2") + "e" + exponent;
        }

        return x.ToString(y);
    }
}


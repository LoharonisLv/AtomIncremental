using BreakInfinity;
using UnityEngine;
using UnityEngine.UI;
using static BreakInfinity.BigDouble;

public class Texts : MonoBehaviour
{
    public Hydrogen Hydrogen;
    public Helium helium;
    public Upgrades Upgrades;
    public Lithium lithium;
    public Text hydrogenText;  // Reference to a Text UI component in the scene
    public Text hydrogenTextPs;
    public Text hydrogenClickText;
    public Text HydrogenClickStrengthText;
    public Text HydrogenClickStrength2Text;
    public Text HydrogenGenText;
    public Text HydrogenGen2Text;
    public Text heliumText;
    public Text heliumGainText1;
    public Text heliumGainText2;
	public Text hHeliumGain1Text;
    public Text unlockMaxBuyerText;
	public Text buyMaxClickUpg1Text;
    public Text buyMaxClickUpg2Text;
    public Text buyMaxAutoClicker1Text;
    public Text buyMaxAutoClicker2Text;
    public Text doubleHeTxt;
    public Text lithiumUnlockText;
    
    void Update()
    {
        hydrogenText.text = "Hydrogen: " + NotationMethod(Hydrogen.BigAssNumber, "F0");
        hydrogenTextPs.text = "Hydrogen/s: " + NotationMethod(Hydrogen.HydrogenGen, "F0");
        hydrogenClickText.text = "Click for " + NotationMethod(Hydrogen.ClickPower, "F0") + " hydrogen";
        HydrogenClickStrengthText.text = "Click strength\nCost: " + NotationMethod(Upgrades.InstantCost(10, 1.07, Upgrades.HClickStrengthLevel), "F0") + "\nPower: 1 hydrogen/click\nLevel: " +
                                         NotationMethod(Upgrades.HClickStrengthLevel, "F0");
        HydrogenClickStrength2Text.text = "Click strength 2\nCost: " + NotationMethod(Upgrades.InstantCost(200, 1.07, Upgrades.HClickStrength2Level), "F0") + "\nPower: 5 hydrogen/click\nLevel: " +
                                         NotationMethod(Upgrades.HClickStrength2Level, "F0");
        HydrogenGenText.text = "Auto clicker\nCost: " +
                               NotationMethod(Upgrades.InstantCost(80, 1.07, Upgrades.HHydrogenGenLevel), "F0") +
                               "\n1 hydrogen/s\nLevel: " + NotationMethod(Upgrades.HHydrogenGenLevel, "F0");
        HydrogenGen2Text.text = "Auto clicker 2.0\nCost: " +
                               NotationMethod(Upgrades.InstantCost(800, 1.07, Upgrades.HHydrogenGen2Level), "F0") +
                               "\n5 hydrogen/s\nLevel: " + NotationMethod(Upgrades.HHydrogenGen2Level, "F0");
        heliumGainText1.text = "Do nuclear fusion:\n+" + Floor(helium.HeliumGain).ToString("F0") + " helium";
        heliumGainText2.text = "Do nuclear fusion:\n+" + Floor(helium.HeliumGain).ToString("F0") + " helium";
        heliumText.text = "Helium: " + NotationMethod(helium.BigAssNumber,"F0");
		hHeliumGain1Text.text = "Increase helium gain by 20%\nCost: "+NotationMethod(Upgrades.InstantCost(1e5, 1.1, Upgrades.HHeliumGain1Level), "F0")+ "\nLevel: "+NotationMethod(Upgrades.HHeliumGain1Level, "F0");
        if (Hydrogen.MaxBuyerCheck == true)
        {
            unlockMaxBuyerText.text = "Unlock Maxbuyers for the first 4 hydrogen upgrades\nBought";
        }
        else
        {
            unlockMaxBuyerText.text = "Unlock Maxbuyers for the first 4 hydrogen upgrades\nCost: 1e7";
        }
buyMaxClickUpg1Text.text = "Buy max 1st hydrogen upgrades [" + BuyMaxClickUpgrade1n() + "]";
        buyMaxClickUpg2Text.text = "Buy max 2nd hydrogen upgrades [" + BuyMaxClickUpgrade2n() + "]";
        buyMaxAutoClicker1Text.text = "Buy max 3rd hydrogen upgrades [" + BuyMaxAutoClicker1n() + "]";
        buyMaxAutoClicker2Text.text = "Buy max 4th hydrogen upgrades [" + BuyMaxAutoClicker2n() + "]";
        if (helium.DoubleHelium == true)
        {
            doubleHeTxt.text = "Double your Helium gain\nBought";
        }
        else
        {
            doubleHeTxt.text = "Double your Helium gain\nCost: 1000 He";
        }
        if (lithium.lithiumCheck == true)
        {
            lithiumUnlockText.text = "Unlock 1st period reset lithify (t Li tab)\nBought";
        }
        else
        {
            lithiumUnlockText.text = "Unlock 1st period reset lithify (t Li tab)\nCost: 1.00e6 He";
        }
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
    public BigDouble BuyMaxClickUpgrade1n()
    {
        var b = 10;
        var c = Hydrogen.BigAssNumber;
        var r = 1.07;
        var k = Upgrades.HClickStrengthLevel;
        var n = Floor(Log(((c * (r - 1)) / (b * Pow(r, k))) + 1, r));
        return n;
    }

    public BigDouble BuyMaxClickUpgrade2n()
    {
        var b = 250;
        var c = Hydrogen.BigAssNumber;
        var r = 1.07;
        var k = Upgrades.HClickStrength2Level;
        var n = Floor(Log(((c * (r - 1)) / (b * Pow(r, k))) + 1, r));
        return n;
    }

    public BigDouble BuyMaxAutoClicker1n()
    {
        var b = 100;
        var c = Hydrogen.BigAssNumber;
        var r = 1.07;
        var k = Upgrades.HHydrogenGenLevel;
        var n = Floor(Log(((c * (r - 1)) / (b * Pow(r, k))) + 1, r));
        return n;
    }

    public BigDouble BuyMaxAutoClicker2n()
    {
        var b = 1000;
        var c = Hydrogen.BigAssNumber;
        var r = 1.07;
        var k = Upgrades.HHydrogenGen2Level;
        var n = Floor(Log(((c * (r - 1)) / (b * Pow(r, k))) + 1, r));
        return n;
    }
}


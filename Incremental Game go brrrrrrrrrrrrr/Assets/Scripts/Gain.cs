using UnityEngine;
using UnityEngine.UI;
using BreakInfinity;
using static BreakInfinity.BigDouble;
using System;

public class Gain : MonoBehaviour
{
    public Text hydrogenTxt;
    public BigDouble hydrogen;  //variables
    public BigDouble clickpower;
    public Text clickpowerTxt;
     
    public Text persec;
    public Text clickupg;
    public Text clickupg2;
    public Text persecupg;
    public Text cpsupg2;
    
    public BigDouble persecst;
    public BigDouble clickupgcount;
    
    public BigDouble cpscost;
    public BigDouble cpsupgcount;
    
    public BigDouble clickUpg2Level;
    
    public BigDouble cpsUpg2Cost;
    public BigDouble cpsUpg2Power;
    public BigDouble cpsUpg2Level;
    
    //for prestige
    public Text heliumText;
    public Text heliumGainText1;
    public Text heliumGainText2;


    public BigDouble helium;
    public BigDouble heliumBoost;
    public BigDouble heliumGain;

    public BigDouble heliumGainUpg1Level;
    public BigDouble heliumGainUpg2Level;
    public Text heliumGainUpg1Text;
    public Text heliumGainUpg2Text;
    public bool doubleHe;
    public Text doubleHeTxt;
    public BigDouble cpsUpg1HeLevel;
    public Text cpsUpg1HeText;

    public Text buyMaxClickUpg1Text;
    public Text buyMaxClickUpg2Text;
    public Text buyMaxAutoClicker1Text;
    public Text buyMaxAutoClicker2Text;
    
    public CanvasGroup maxBuyHGroup;
    public bool maxBuyHbought;
    public Text maxBuyHText;
    public bool lithiumUnlock;
    public Text lithiumUnlockText;
    public bool mineUnlock;

    public BigDouble lithium;
    public BigDouble lithiumBoostH;
    public BigDouble lithiumBoostHe;
    public BigDouble lithiumGain;
    public BigDouble heliumGainUpg3Level;
    
    public Text lithiumGainText;
    public Text lithiumText;
    public Text lithiumBoostText;
    public Text mineUnlockText;
    public Text heliumGainUpg3Text;
    public BigDouble cpsUpg1LiLevel;
    public Text cpsUpg1LiText;
    public bool biggerHeBoostCheck;
    public Text biggerHeBoostText;
    public bool save1stMaxBuyCheck;
    public Text save1stMaxBuyText;
    
    
    public CanvasGroup period2Group;
    public CanvasGroup period3Group;
    public CanvasGroup period4Group;
    public CanvasGroup period5Group;
    public CanvasGroup period6Group;
    public CanvasGroup period7Group;
    public CanvasGroup lanthanoidGroup;
    public CanvasGroup actinoidGroup;
    
    public void Start()
    {
        Application.targetFrameRate = 60;
        Load();
        
    }

    public void Load()
    {
        hydrogen = BigDouble.Parse(PlayerPrefs.GetString("hydrogen", "0"));
        clickpower = BigDouble.Parse(PlayerPrefs.GetString("clickpower", "1"));
        cpsUpg2Power = BigDouble.Parse(PlayerPrefs.GetString("cpsUpg2Power", "5"));
        helium = BigDouble.Parse(PlayerPrefs.GetString("helium", "0"));
        heliumGainUpg1Level = BigDouble.Parse(PlayerPrefs.GetString("heliumGainUpg1Level", "0"));
        heliumGainUpg2Level = BigDouble.Parse(PlayerPrefs.GetString("heliumGainUpg2Level", "0"));
        heliumGainUpg3Level = BigDouble.Parse(PlayerPrefs.GetString("heliumGainUpg3Level", "0"));
        cpsUpg1HeLevel = BigDouble.Parse(PlayerPrefs.GetString("cpsUpg1HeLevel", "0"));
        
        clickUpg2Level = BigDouble.Parse(PlayerPrefs.GetString("clickUpg2Level", "0"));
        cpsUpg2Level = BigDouble.Parse(PlayerPrefs.GetString("cpsUpg2Level", "0"));
        cpsUpg1LiLevel = BigDouble.Parse(PlayerPrefs.GetString("cpsUpg1LiLevel", "0"));
        clickupgcount = BigDouble.Parse(PlayerPrefs.GetString("clickupgcount", "0"));
        cpsupgcount = BigDouble.Parse(PlayerPrefs.GetString("cpsupgcount", "0"));
        maxBuyHbought = bool.Parse(PlayerPrefs.GetString("maxBuyHbought", "false"));
        doubleHe = bool.Parse(PlayerPrefs.GetString("doubleHe", "false"));
        lithiumUnlock = bool.Parse(PlayerPrefs.GetString("lithiumUnlock", "false"));
        mineUnlock = bool.Parse(PlayerPrefs.GetString("mineUnlock", "false"));
        biggerHeBoostCheck = bool.Parse(PlayerPrefs.GetString("biggerHeBoostCheck", "false"));
        save1stMaxBuyCheck = bool.Parse(PlayerPrefs.GetString("save1stMaxBuyCheck", "false"));
    }

    public void Save()
    {
        PlayerPrefs.SetString("hydrogen", hydrogen.ToString());
        PlayerPrefs.SetString("clickpower", clickpower.ToString());
        PlayerPrefs.SetString("cpsUpg2Power", cpsUpg2Power.ToString());
        PlayerPrefs.SetString("helium", helium.ToString());
        PlayerPrefs.SetString("heliumGainUpg1Level", heliumGainUpg1Level.ToString());
        PlayerPrefs.SetString("heliumGainUpg2Level", heliumGainUpg2Level.ToString());
        PlayerPrefs.SetString("heliumGainUpg3Levle", heliumGainUpg3Level.ToString());
        PlayerPrefs.SetString("cpsUpg1HeLevel", cpsUpg1HeLevel.ToString());

        PlayerPrefs.SetString("clickUpg2Level", clickUpg2Level.ToString());
        PlayerPrefs.SetString("cpsUpg2Level", cpsUpg2Level.ToString());
        PlayerPrefs.SetString("cpsUpg1LiLevel", cpsUpg1LiLevel.ToString());
        PlayerPrefs.SetString("clickupgcount", clickupgcount.ToString());
        PlayerPrefs.SetString("cpsupgcount", cpsupgcount.ToString());
        PlayerPrefs.SetString("maxBuyHbought", maxBuyHbought.ToString());
        PlayerPrefs.SetString("doubleHe", doubleHe.ToString());
        PlayerPrefs.SetString("lithiumUnlock", lithiumUnlock.ToString());
        PlayerPrefs.SetString("mineUnlock", mineUnlock.ToString());
        PlayerPrefs.SetString("biggerHeBoostCheck", biggerHeBoostCheck.ToString());
        PlayerPrefs.SetString("save1stMaxBuyCheck", save1stMaxBuyCheck.ToString());
    }

    public void Update()
    {
        buyMaxClickUpg1Text.text = "Buy max 1st hydrogen upgrades [" + BuyMaxClickUpgrade1n() + "]";
        buyMaxClickUpg2Text.text = "Buy max 2nd hydrogen upgrades [" + BuyMaxClickUpgrade2n() + "]";
        buyMaxAutoClicker1Text.text = "Buy max 3rd hydrogen upgrades [" + BuyMaxAutoClicker1n() + "]";
        buyMaxAutoClicker2Text.text = "Buy max 4th hydrogen upgrades [" + BuyMaxAutoClicker2n() + "]";
        if (doubleHe == false)
        {
            heliumGain = (150 * Sqrt(hydrogen / 1e20)* Pow(1.1, heliumGainUpg1Level)* Pow(1.5, heliumGainUpg2Level)*(1+lithiumBoostHe)*Pow(1.25, heliumGainUpg3Level));
        }
        else
        {
            heliumGain = 2*(150 * Sqrt(hydrogen / 1e20))* Pow(1.1, heliumGainUpg1Level)* Pow(1.5, heliumGainUpg2Level *(1+lithiumBoostHe)*Pow(1.25, heliumGainUpg3Level));
        }

        if (biggerHeBoostCheck == false)
        {
            heliumBoost = (helium * 0.02) + 1;
        }
        else
        {
            heliumBoost = (helium * 0.5) + 1;
        }
        heliumGainText1.text = "Do nuclear fusion:\n+" + Floor(heliumGain).ToString("F0") + " helium";
        heliumGainText2.text = "Do nuclear fusion:\n+" + Floor(heliumGain).ToString("F0") + " helium";

        heliumText.text = "Helium: " + NotationMethod(helium, "F0") + "\n" + NotationMethod(heliumBoost, "F2") + "x boost";

        lithiumGain = 150 * (Sqrt(helium / 1e11));
        lithiumText.text = "Lithium: " + NotationMethod(lithium, "F0");
        lithiumGainText.text = "Lithify for\n" + NotationMethod(lithiumGain, "F0") + " lithium";
        lithiumBoostText.text = NotationMethod(lithiumBoostH, "F2") + "xH and " + NotationMethod(lithiumBoostHe, "F2") + "He boost";
        
        hydrogenTxt.text = "Hydrogen: " + NotationMethod(hydrogen, "F0");
        
        persecst = (cpsupgcount + (cpsUpg2Level * cpsUpg2Power)) * heliumBoost * Pow(1.2, cpsUpg1HeLevel) *(1+lithiumBoostH)*Pow(1.3, cpsUpg1LiLevel);
        persec.text = NotationMethod(persecst, "F0") + " hydrogen/s";

        string clickupgcostString;
        var clickupgcost = 10 * Pow(1.07, clickupgcount);
        clickupgcostString = NotationMethod(clickupgcost, "F0");
        clickupg.text = "Click strength\nCost: " + clickupgcostString + "\nPower: 1 hydrogen/click\nLevel: " + NotationMethod(clickupgcount, "F0");
        
        string clickUpg2CostString;
        var clickUpg2Cost = 250 * Pow(1.1, clickUpg2Level);
        clickUpg2CostString = NotationMethod(clickUpg2Cost, "F0");
        clickupg2.text = "Click strength 2\nCost: " + clickUpg2CostString + "\nPower: 5 hydrogen/click\nLevel: " + NotationMethod(clickUpg2Level, "F0");    
        
        string cpscostString;
        var cpscost = 100 * Pow(1.07, cpsupgcount);
        cpscostString = NotationMethod(cpscost, "F0");
        persecupg.text = "Auto clicker\n(but bad :) )\n" + heliumBoost.ToString("F0") + " hydrogen/s\nCost: " + cpscostString + "\nLevel:" + NotationMethod(cpsupgcount, "F0");    
        
        string cpsUpg2CostString;
        var cpsUpg2Cost = 1000 * Pow(1.09, cpsUpg2Level);
        cpsUpg2CostString = NotationMethod(cpsUpg2Cost, "F0");
        cpsupg2.text = "Auto clicker 2.0\n" + (5*heliumBoost).ToString("F0") + " hydrogen/s\nCost: " + cpsUpg2CostString + "\nLevel:" + NotationMethod(cpsUpg2Level, "F0");
        
        string heliumGainUpg1CostString;
        var heliumGainUpg1Cost = 1e15 * Pow(1.1, heliumGainUpg1Level);
        heliumGainUpg1CostString = NotationMethod(heliumGainUpg1Cost, "F0");
        heliumGainUpg1Text.text = "Increase helium gain by 20%\nCost: " + heliumGainUpg1CostString + "\nLevel: "+NotationMethod(heliumGainUpg1Level, "F0");
        
        string heliumGainUpg2CostString;
        var heliumGainUpg2Cost = 5 * Pow(1.5, heliumGainUpg2Level);
        heliumGainUpg2CostString = NotationMethod(heliumGainUpg2Cost, "F0");
        heliumGainUpg2Text.text = "Increase He gain by 50%\nCost: " + heliumGainUpg2CostString + " He\nLevel: "+ NotationMethod(heliumGainUpg2Level, "F0");

        string cpsUpg1HeCostString;
        var cpsUpg1HeCost = 2 * Pow(1.5, cpsUpg1HeLevel);
        cpsUpg1HeCostString = NotationMethod(cpsUpg1HeCost, "F0");
        cpsUpg1HeText.text = "Auto clickers works 20% faster\nCost: " + cpsUpg1HeCostString + " He\nLevel: "+ NotationMethod(cpsUpg1HeLevel, "F0");
        
        string heliumGainUpg3CostString;
        var heliumGainUpg3Cost = 2 * Pow(1.5, heliumGainUpg3Level);
        heliumGainUpg3CostString = NotationMethod(heliumGainUpg3Cost, "F0");
        heliumGainUpg3Text.text = "Upgrade Helium gain by 25%\nCost: " + heliumGainUpg3CostString + " Li\nLevel: "+ NotationMethod(heliumGainUpg3Level, "F0");
        
        string cpsUpg1LiCostString;
        var cpsUpg1LiCost = 4 * Pow(1.25, cpsUpg1LiLevel);
        cpsUpg1LiCostString = NotationMethod(cpsUpg1LiCost, "F0");
        cpsUpg1LiText.text = "Increase hydrogen gain speed by 30%\nCost: " + cpsUpg1LiCostString + " Li\nLevel: "+ NotationMethod(cpsUpg1LiLevel, "F0");
        
        clickpowerTxt.text = "Click for " + NotationMethod(clickpower, "F0") + " hydrogen";

        if (maxBuyHbought ==true)
        {
            maxBuyHText.text = "Unlock Autobuyers for first 4 upgrades\nBought";
            ActivateTabs(maxBuyHGroup);
        }
        else
        {
            maxBuyHText.text = "Unlock Autobuyers for first 4 upgrades\nCost: 1.00e5";
            DeactivateTabs(maxBuyHGroup);
        }
        if (doubleHe == true)
        {
            doubleHeTxt.text = "Double your Helium gain\nBought";
        }
        else
        {
            doubleHeTxt.text = "Double your Helium gain\nCost: 1000 He";
        }
        if (lithiumUnlock == true)
        {
            lithiumUnlockText.text = "Unlock 1st period reset lithify (t Li tab)\nBought";
        }
        else
        {
            lithiumUnlockText.text = "Unlock 1st period reset lithify (t Li tab)\nCost: 1.00e6 He";
        }
        if (mineUnlock == true)
        {
            mineUnlockText.text = "Unlock mining (t Li tab)\nBought";
        }
        else
        {
            mineUnlockText.text = "Unlock mining (t Li tab)\nCost: 1.00e5 Li";
        }

        if (biggerHeBoostCheck == true)
        {
            biggerHeBoostText.text = "Improve Helium bonus to hydrogen\nBought";
        }
        else
        {
            biggerHeBoostText.text = "Improve Helium bonus to hydrogen\nCost: 1000 Li";
        }
        
        if (save1stMaxBuyCheck == true)
        {
            save1stMaxBuyText.text = "The 1st max buys don't reset on Lithify\nBought";
        }
        else
        {
            save1stMaxBuyText.text = "The 1st max buys don't reset on Lithify\nCost: 5e3 Li";
        }
        hydrogen += persecst * Time.deltaTime;

        Save();
    }

    public string NotationMethod(BigDouble x, string y)
    {
        if (x > 1000)
        {
            var exponent = (Floor(Log10(Abs(x))));
            var mantissa = (x/ Pow(10, exponent));
            return mantissa.ToString("F2") + "e" + exponent;
        }
            return x.ToString(y);   
    }

    public void NuclearFusion()
    {
        if (hydrogen > 4.45e14)
        {
            hydrogen = 0;
            clickpower = 1;
            cpsUpg2Power = 5;
        
            clickUpg2Level = 0;
            cpsUpg2Level = 0;
            clickupgcount = 0;
            cpsupgcount = 0;
            heliumGainUpg1Level = 0;
            
            helium += heliumGain;
        }
    }

    public void Lithify()
    {
        if (helium >= 4.45e6 && lithiumUnlock==true)
        {
            hydrogen = 0;
            clickpower = 1;
            cpsUpg2Power = 5;
        
            clickUpg2Level = 0;
            cpsUpg2Level = 0;
            clickupgcount = 0;
            cpsupgcount = 0;
            heliumGainUpg1Level = 0;
            heliumGainUpg2Level = 0;
            cpsUpg1HeLevel = 0;
            if (save1stMaxBuyCheck == false)
            {
                maxBuyHbought = false;
            }
            helium = 0;
        
            lithium += lithiumGain;
        }
    }

    public void Click()
    {
        hydrogen += clickpower;
    }
    
    public void BuyUpgrade(string upgradeID)
    {
        switch (upgradeID)
        {
            case "C1":
                var cost1 = 10 * Pow(1.07, clickupgcount);
                if (hydrogen >= cost1)
                {
                    clickupgcount+=1;
                    hydrogen -= cost1;
                    clickpower += 1;
                }
                break;
            case "C1MAX":
                var b = 10;
                var c = hydrogen;
                var r = 1.07;
                var k = clickupgcount;
                var n = Floor(Log(((c * (r - 1)) / (b * Pow(r, k))) + 1, r));

                var cost2 = b * ((Pow(r, k) * (Pow(r, n) - 1)) / (r - 1));

                if (hydrogen >= cost2)
                {
                    clickupgcount += Convert.ToInt32(n.ToDouble());
                    hydrogen -= cost2;
                    clickpower += n;
                }
                break;
            case "C2":
                var cost4 = 250 * Pow(1.1, clickUpg2Level);
                if (hydrogen >= cost4)
                {
                    clickUpg2Level++;
                    hydrogen -= cost4;
                    clickpower += 5;
                }
                break;
            case "C2MAX":
                var b1 = 250;
                var c1 = hydrogen;
                var r1 = 1.1;
                var k1 = clickUpg2Level;
                var n1 = Floor(Log(((c1 * (r1 - 1)) / (b1 * Pow(r1, k1))) + 1, r1));

                var cost3 = b1 * ((Pow(r1, k1) * (Pow(r1, n1) - 1)) / (r1 - 1));

                if (hydrogen >= cost3)
                {
                    clickUpg2Level += Convert.ToInt32(n1.ToDouble());
                    hydrogen -= cost3;
                    clickpower += (n1*5);
                }
                break;
            case "A1":
                var cost5 = 100 * Pow(1.07, cpsupgcount);
                if (hydrogen >= cost5)
                {
                    cpsupgcount++;
                    hydrogen -= cost5;
                }
                break;
            case "A1MAX":
                var b2 = 100;
                var c2 = hydrogen;
                var r2 = 1.07;
                var k2 = cpsupgcount;
                var n2 = Floor(Log(((c2 * (r2 - 1)) / (b2 * Pow(r2, k2))) + 1, r2));

                var cost6 = b2 * ((Pow(r2, k2) * (Pow(r2, n2) - 1)) / (r2 - 1));

                if (hydrogen >= cost6)
                {
                    cpsupgcount += Convert.ToInt32(n2.ToDouble());
                    hydrogen -= cost6;
                }
                break;
            case "A2":
                var cost7 = 1000 * Pow(1.09, cpsUpg2Level);
                if (hydrogen >= cost7)
                {
                    cpsUpg2Level++;
                    hydrogen -= cost7;
                }
                break;
            case "A2MAX":
                var b3 = 1000;
                var c3 = hydrogen;
                var r3 = 1.09;
                var k3 = cpsUpg2Level;
                var n3 = Floor(Log(((c3 * (r3 - 1)) / (b3 * Pow(r3, k3))) + 1, r3));

                var cost8 = b3 * ((Pow(r3, k3) * (Pow(r3, n3) - 1)) / (r3 - 1));

                if (hydrogen >= cost8)
                {
                    cpsUpg2Level += Convert.ToInt32(n3.ToDouble());
                    hydrogen -= cost8;
                }
                break;
            default:
                Debug.Log(message:"No upgrade found");
                break;
            case "HeG1":
                var cost = 1e15 * Pow(1.1, heliumGainUpg1Level);
                if (hydrogen >= cost)
                {
                    heliumGainUpg1Level++;
                }
                break;
            case "HeG2": 
                var cost9 = 5 * Pow(1.5, heliumGainUpg2Level);
                if (helium>= cost9)
                {
                    helium -= cost9;
                    heliumGainUpg2Level++;
                }
                break;
            case "A1He":
                var cost10 = 2 * Pow(1.5, cpsUpg1HeLevel);
                if (helium >= cost10)
                {
                    helium -= cost10;
                    cpsUpg1HeLevel++;
                }
                break;
            case "HeG3":
                var cost11 = 2 * Pow(1.5, heliumGainUpg3Level);
                if (lithium >= cost11)
                {
                    lithium -= cost11;
                    heliumGainUpg3Level++;
                }
                break;
            case "A1Li":
                var cost12 = 4 * Pow(1.25, cpsUpg1LiLevel);
                if (lithium >= cost12)
                {
                    lithium -= cost12;
                    cpsUpg1LiLevel++;
                }

                break;
        }
    }

    public void MaxBuyHConf()
    {
        if (hydrogen >= 1e5 && maxBuyHbought == false)
        {
            hydrogen -= 1e5;
            maxBuyHbought = true;
            
        }
    }

    public void doubleHeCheck()
    {
        if (helium >= 1000 && doubleHe == false)
        {
            helium -= 1000;
            doubleHe = true;
        }
    }

    public void lithiumCheck()
    {
        if (helium >= 1e6 && lithiumUnlock == false)
        {
            lithiumUnlock = true;
            helium -= 1e6;
        }
    }

    public void mineCheck()
    {
        if (lithium >= 1e5 && mineUnlock == false)
        {
            mineUnlock = true;
            lithium -= 1e5;
        }
    }

    public void biggerHeBoost()
    {
        if (lithium >= 1e3 && biggerHeBoostCheck == false)
        {
            biggerHeBoostCheck = true;
            lithium -= 1e3;
        }
    }

    public void save1stMaxBuy()
    {
        if (lithium >= 5e3 && save1stMaxBuyCheck == false)
        {
            save1stMaxBuyCheck = true;
            lithium -= 5e3;
        }
    }
    
    public BigDouble BuyMaxClickUpgrade1n()
    {
        var b = 10;
        var c = hydrogen;
        var r = 1.07;
        var k = clickupgcount;
        var n = Floor(Log(((c * (r - 1)) / (b * Pow(r, k))) + 1, r));
        return n;
    }

    public BigDouble BuyMaxClickUpgrade2n()
    {
        var b = 250;
        var c = hydrogen;
        var r = 1.1;
        var k = clickUpg2Level;
        var n = Floor(Log(((c * (r - 1)) / (b * Pow(r, k))) + 1, r));
        return n;
    }
    
    public BigDouble BuyMaxAutoClicker1n()
    {
        var b = 100;
        var c = hydrogen;
        var r = 1.07;
        var k = cpsupgcount;
        var n = Floor(Log(((c * (r - 1)) / (b * Pow(r, k))) + 1, r));
        return n;
    }
    public BigDouble BuyMaxAutoClicker2n()
    {
        var b = 1000;
        var c = hydrogen;
        var r = 1.09;
        var k = cpsUpg2Level;
        var n = Floor(Log(((c * (r - 1)) / (b * Pow(r, k))) + 1, r));
        return n;
    }

    public void wipeSave()
    {
        PlayerPrefs.DeleteAll();
        Load();
    }
    public void ActivateTabs(CanvasGroup group)
    {
        group.alpha = 1;
        group.interactable = true;
        group.blocksRaycasts = true;
    }
    
    public void DeactivateTabs(CanvasGroup group)
    {
        group.alpha = 0;
        group.interactable = false;
        group.blocksRaycasts = false;
    }
}
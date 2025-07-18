using UnityEngine;
using UnityEngine.UI;
using BreakInfinity;
using static BreakInfinity.BigDouble;
using System;

public class Gain : MonoBehaviour
{
    //classes
    public Hydrogen Hydrogen;
    
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
    public bool passiveHe;
    public Text passiveHeText;

    //beryllium

    public BigDouble beryllium;
    public BigDouble berylliumBoost;
    public BigDouble berylliumMines;
    public Text berylliumText;
    public Text berylliumBoostText;
    public Text berylliumMinesText;
    public Text berylliumGainText;
    public BigDouble mineEffUpg1Level;
    public Text mineEffUpg1Text;
    public BigDouble mineEffUpg2Level;
    public Text mineEffUpg2Text;
    public bool save1stPeriodCheck;
    public Text save1stPeriodText;
    public bool bCheck;
    public Text bCheckText;

    //boron

    public BigDouble boron;
    public BigDouble boronMines;
    public Text boronText;
    public Text boronGainText;
    public Text boronMinesText;
    public bool cCheck;
    public Text cCheckText;

    //carbon

    public BigDouble carbon;
    public BigDouble carbonMines;
    public Text carbonText;
    public Text carbonGainText;
    public Text carbonMinesText;
    public bool nCheck;
    public Text nCheckText;

    //nitrogen

    public BigDouble nitrogen;
    public BigDouble nitrogenExtractors;
    public Text nitrogenText;
    public Text nitrogenGainText;
    public Text nitrogenExtractorsText;
    public bool oCheck;
    public Text oCheckText;

    //oxygen

    public BigDouble oxygen;
    public BigDouble oxygenExtractors;
    public Text oxygenText;
    public Text oxygenGainText;
    public Text oxygenExtractorsText;
    public bool fCheck;
    public Text fCheckText;

    // fluorine

    public BigDouble fluorine;
    public BigDouble fluorineExtractors;
    public Text fluorineText;
    public Text fluorineGainText;
    public Text fluorineExtractorsText;
    public bool neCheck;
    public Text neCheckText;

    //neon

    public BigDouble neon;
    public BigDouble neonExtractors;
    public Text neonText;
    public Text neonGainText;
    public Text neonExtractorsText;

    //period unlocks

    public CanvasGroup period2Group;
    public CanvasGroup period3Group;
    public CanvasGroup period4Group;
    public CanvasGroup period5Group;
    public CanvasGroup period6Group;
    public CanvasGroup period7Group;
    public CanvasGroup lanthanoidGroup;
    public CanvasGroup actinoidGroup;

    public AudioSource audioSource;
    public Text audioSourceText;

    public void Start()
    {
        Application.targetFrameRate = 60;
        Load();
        audioSource = GetComponent<AudioSource>();
        PlayMusic();
    }

    public void Load()
    {
        
        heliumGainUpg1Level = BigDouble.Parse(PlayerPrefs.GetString("heliumGainUpg1Level", "0"));
        heliumGainUpg2Level = BigDouble.Parse(PlayerPrefs.GetString("heliumGainUpg2Level", "0"));
        heliumGainUpg3Level = BigDouble.Parse(PlayerPrefs.GetString("heliumGainUpg3Level", "0"));
        cpsUpg1HeLevel = BigDouble.Parse(PlayerPrefs.GetString("cpsUpg1HeLevel", "0"));
        
        cpsUpg1LiLevel = BigDouble.Parse(PlayerPrefs.GetString("cpsUpg1LiLevel", "0"));
        
        doubleHe = bool.Parse(PlayerPrefs.GetString("doubleHe", "false"));
        lithiumUnlock = bool.Parse(PlayerPrefs.GetString("lithiumUnlock", "false"));
        mineUnlock = bool.Parse(PlayerPrefs.GetString("mineUnlock", "false"));
        biggerHeBoostCheck = bool.Parse(PlayerPrefs.GetString("biggerHeBoostCheck", "false"));
        save1stMaxBuyCheck = bool.Parse(PlayerPrefs.GetString("save1stMaxBuyCheck", "false"));
        passiveHe = bool.Parse(PlayerPrefs.GetString("passiveHe", "false"));
        beryllium = BigDouble.Parse(PlayerPrefs.GetString("beryllium", "0"));
        berylliumMines = BigDouble.Parse(PlayerPrefs.GetString("berylliumMines", "0"));
        mineEffUpg1Level = BigDouble.Parse(PlayerPrefs.GetString("mineEffUpg1Level", "0"));
        mineEffUpg2Level = BigDouble.Parse(PlayerPrefs.GetString("mineEffUpg2Level", "0"));
        save1stPeriodCheck = bool.Parse(PlayerPrefs.GetString("save1stPeriodCheck", "false"));
        bCheck = bool.Parse(PlayerPrefs.GetString("bCheck", "false"));
        boron = BigDouble.Parse(PlayerPrefs.GetString("boron", "0"));
        boronMines = BigDouble.Parse(PlayerPrefs.GetString("boronMines", "0"));
        cCheck = bool.Parse(PlayerPrefs.GetString("cCheck", "false"));
        carbon = BigDouble.Parse(PlayerPrefs.GetString("carbon", "0"));
        carbonMines = BigDouble.Parse(PlayerPrefs.GetString("carbonMines", "0"));
        nCheck = bool.Parse(PlayerPrefs.GetString("nCheck", "false"));
        nitrogen = BigDouble.Parse(PlayerPrefs.GetString("nitrogen", "0"));
        nitrogenExtractors = BigDouble.Parse(PlayerPrefs.GetString("nitrogenExtractors", "0"));
        oCheck = bool.Parse(PlayerPrefs.GetString("oCheck", "false"));
        oxygen = BigDouble.Parse(PlayerPrefs.GetString("oxygen", "0"));
        oxygenExtractors = BigDouble.Parse(PlayerPrefs.GetString("oxygenExtractors", "0"));
        fCheck = bool.Parse(PlayerPrefs.GetString("fCheck", "false"));
        fluorine = BigDouble.Parse(PlayerPrefs.GetString("fluorine", "0"));
        fluorineExtractors = BigDouble.Parse(PlayerPrefs.GetString("fluorineExtractors", "0"));
        neCheck = bool.Parse(PlayerPrefs.GetString("neCheck", "false"));
        neon = BigDouble.Parse(PlayerPrefs.GetString("neon", "0"));
        neonExtractors = BigDouble.Parse(PlayerPrefs.GetString("neonExtractors", "0"));
    }

    public void Save()
    {
        PlayerPrefs.SetString("heliumGainUpg1Level", heliumGainUpg1Level.ToString());
        PlayerPrefs.SetString("heliumGainUpg2Level", heliumGainUpg2Level.ToString());
        PlayerPrefs.SetString("heliumGainUpg3Levle", heliumGainUpg3Level.ToString());
        PlayerPrefs.SetString("cpsUpg1HeLevel", cpsUpg1HeLevel.ToString());
        PlayerPrefs.SetString("cpsUpg1LiLevel", cpsUpg1LiLevel.ToString());  
        PlayerPrefs.SetString("doubleHe", doubleHe.ToString());
        PlayerPrefs.SetString("lithiumUnlock", lithiumUnlock.ToString());
        PlayerPrefs.SetString("mineUnlock", mineUnlock.ToString());
        PlayerPrefs.SetString("biggerHeBoostCheck", biggerHeBoostCheck.ToString());
        PlayerPrefs.SetString("save1stMaxBuyCheck", save1stMaxBuyCheck.ToString());
        PlayerPrefs.SetString("passiveHe", passiveHe.ToString());
        PlayerPrefs.SetString("beryllium", beryllium.ToString());
        PlayerPrefs.SetString("berylliumMines", berylliumMines.ToString());
        PlayerPrefs.SetString("mineEffUpg1Level", mineEffUpg1Level.ToString());
        PlayerPrefs.SetString("mineEffUpg2Level", mineEffUpg2Level.ToString());
        PlayerPrefs.SetString("save1stPeriodCheck", save1stPeriodCheck.ToString());
        PlayerPrefs.SetString("bCheck", bCheck.ToString());
        PlayerPrefs.SetString("boron", boron.ToString());
        PlayerPrefs.SetString("boronMines", boronMines.ToString());
        PlayerPrefs.SetString("cCheck", cCheck.ToString());
        PlayerPrefs.SetString("carbon", carbon.ToString());
        PlayerPrefs.SetString("carbonMines", carbonMines.ToString());
        PlayerPrefs.SetString("nCheck", nCheck.ToString());
        PlayerPrefs.SetString("nitrogen", nitrogen.ToString());
        PlayerPrefs.SetString("nitrogenExtractors", nitrogenExtractors.ToString());
        PlayerPrefs.SetString("oCheck", oCheck.ToString());
        PlayerPrefs.SetString("oxygen", oxygen.ToString());
        PlayerPrefs.SetString("oxygenExtractors", oxygenExtractors.ToString());
        PlayerPrefs.SetString("fCheck", fCheck.ToString());
        PlayerPrefs.SetString("fluorine", fluorine.ToString());
        PlayerPrefs.SetString("fluorineExtractors", fluorineExtractors.ToString());
        PlayerPrefs.SetString("neCheck", neCheck.ToString());
        PlayerPrefs.SetString("neon", neon.ToString());
        PlayerPrefs.SetString("neonExtractors", neonExtractors.ToString());
    }

    public void Update()
    {
        
/*buyMaxClickUpg1Text.text = "Buy max 1st hydrogen upgrades [" + BuyMaxClickUpgrade1n() + "]";
        buyMaxClickUpg2Text.text = "Buy max 2nd hydrogen upgrades [" + BuyMaxClickUpgrade2n() + "]";
        buyMaxAutoClicker1Text.text = "Buy max 3rd hydrogen upgrades [" + BuyMaxAutoClicker1n() + "]";
        buyMaxAutoClicker2Text.text = "Buy max 4th hydrogen upgrades [" + BuyMaxAutoClicker2n() + "]";*/
       

        if (biggerHeBoostCheck == false)
        {
            heliumBoost = (helium * 0.02) + 1;
        }
        else
        {
            heliumBoost = (helium * 0.5) + 1;
        }

        berylliumBoost = 1 + (0.04 * berylliumMines);
        

        heliumText.text = "Helium: " + NotationMethod(helium, "F0") + "\n" + NotationMethod(heliumBoost, "F2") +
                          "x boost";

        lithiumGain = (150 * (Sqrt(helium / 1e11))) * berylliumBoost;
        lithiumText.text = "Lithium: " + NotationMethod(lithium, "F0");
        lithiumGainText.text = "Lithify for\n" + NotationMethod(lithiumGain, "F0") + " lithium";
        lithiumBoostText.text = NotationMethod(lithiumBoostH, "F2") + "xH and " + NotationMethod(lithiumBoostHe, "F2") +
                                "He boost";

        

        //persecst = (cpsupgcount + (cpsUpg2Level * cpsUpg2Power)) * heliumBoost * Pow(1.2, cpsUpg1HeLevel) *
                   //(1 + lithiumBoostH) * Pow(1.3, cpsUpg1LiLevel);
        //Hydrogen per second calculation
        

        string heliumGainUpg1CostString;
        var heliumGainUpg1Cost = 1e15 * Pow(1.1, heliumGainUpg1Level);
        heliumGainUpg1CostString = NotationMethod(heliumGainUpg1Cost, "F0");
        heliumGainUpg1Text.text = "Increase helium gain by 20%\nCost: " + heliumGainUpg1CostString + "\nLevel: " +
                                  NotationMethod(heliumGainUpg1Level, "F0");

        string heliumGainUpg2CostString;
        var heliumGainUpg2Cost = 5 * Pow(1.5, heliumGainUpg2Level);
        heliumGainUpg2CostString = NotationMethod(heliumGainUpg2Cost, "F0");
        heliumGainUpg2Text.text = "Increase He gain by 50%\nCost: " + heliumGainUpg2CostString + " He\nLevel: " +
                                  NotationMethod(heliumGainUpg2Level, "F0");

        string cpsUpg1HeCostString;
        var cpsUpg1HeCost = 2 * Pow(1.5, cpsUpg1HeLevel);
        cpsUpg1HeCostString = NotationMethod(cpsUpg1HeCost, "F0");
        cpsUpg1HeText.text = "Auto clickers works 20% faster\nCost: " + cpsUpg1HeCostString + " He\nLevel: " +
                             NotationMethod(cpsUpg1HeLevel, "F0");

        string heliumGainUpg3CostString;
        var heliumGainUpg3Cost = 2 * Pow(1.5, heliumGainUpg3Level);
        heliumGainUpg3CostString = NotationMethod(heliumGainUpg3Cost, "F0");
        heliumGainUpg3Text.text = "Upgrade Helium gain by 25%\nCost: " + heliumGainUpg3CostString + " Li\nLevel: " +
                                  NotationMethod(heliumGainUpg3Level, "F0");

        string cpsUpg1LiCostString;
        var cpsUpg1LiCost = 4 * Pow(1.25, cpsUpg1LiLevel);
        cpsUpg1LiCostString = NotationMethod(cpsUpg1LiCost, "F0");
        cpsUpg1LiText.text = "Increase hydrogen gain speed by 30%\nCost: " + cpsUpg1LiCostString + " Li\nLevel: " +
                             NotationMethod(cpsUpg1LiLevel, "F0");

        string mineEffUpg1CostString;
        var mineEffUpg1Cost = 10 * Pow(1.25, mineEffUpg1Level);
        mineEffUpg1CostString = NotationMethod(mineEffUpg1Cost, "F0");
        mineEffUpg1Text.text = "Increase the effectnivness of the mines by 10%\nCost: " + mineEffUpg1CostString +
                               "\nLevel: " + NotationMethod(mineEffUpg1Level, "F0");

        string mineEffUpg2CostString;
        var mineEffUpg2Cost = 20 * Pow(1.4, mineEffUpg2Level);
        mineEffUpg2CostString = NotationMethod(mineEffUpg2Cost, "F0");
        mineEffUpg2Text.text = "Increase mining speed by 20%\nCost: " + mineEffUpg2CostString + "\nLevel: " +
                               NotationMethod(mineEffUpg2Level, "F0");

        

        

       

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

        if (passiveHe == true)
        {
            passiveHeText.text = "Gain 1% of Helium passively\nBought";
            helium += (0.01 * heliumGain) * Time.deltaTime;
        }
        else
        {
            passiveHeText.text = "Gain 1% of Helium passively\nCost: 1e4 Li";
        }

        if (save1stPeriodCheck == true)
        {
            save1stPeriodText.text = "Lithify no longer resets 1st period";
        }
        else
        {
            save1stPeriodText.text = "Lithify no longer resets 1st period\nCost: 2e3 Be";
        }

        if (bCheck == true)
        {
            bCheckText.text = "Unlock new mine (B tab)\nBought";
        }
        else
        {
            bCheckText.text = "Unlock new mine (B tab)\nCost: 1e4 Be";
        }

        if (cCheck == true)
        {
            cCheckText.text = "Unlock new mine (C tab)\nBought";
        }
        else
        {
            cCheckText.text = "Unlock new mine (C tab)\nCost: 1e4 B";
        }

        if (nCheck == true)
        {
            nCheckText.text = "Unlock new extractor (N tab)\nBought";
        }
        else
        {
            nCheckText.text = "Unlock new extractor (N tab)\nCost: 1e4 C";
        }

        if (oCheck == true)
        {
            oCheckText.text = "Unlock new extractor (O tab)\nBought";
        }
        else
        {
            oCheckText.text = "Unlock new extractor (O tab)\nCost: 1e4 N";
        }

        if (fCheck == true)
        {
            fCheckText.text = "Unlock new extractor (F tab)\nBought";
        }
        else
        {
            fCheckText.text = "Unlock new extractor (F tab)\nCost: 1e4 O";
        }

        if (neCheck == true)
        {
            neCheckText.text = "Unlock new extractor (Ne tab)\nBought";
        }
        else
        {
            neCheckText.text = "Unlock new extractor (Ne tab)\nCost: 1e4 F";
        }

        

        beryllium += (berylliumMines * Pow(1.1, mineEffUpg1Level) * Pow(1.2, mineEffUpg2Level)) * Time.deltaTime;
        berylliumText.text = "Beryllium: " + NotationMethod(beryllium, "F0");
        berylliumBoostText.text = NotationMethod(berylliumBoost, "F2") + "x to click strength and lithium";
        berylliumGainText.text = "Mining " + NotationMethod(berylliumMines, "F0") + " beryllium/s";

        string berylliumMinesCostString;
        var berylliumMinesCost = 2e4 * Pow(10, berylliumMines);
        berylliumMinesCostString = NotationMethod(berylliumMinesCost, "F0");
        berylliumMinesText.text = "Open new beryllium mine\nCost: " + berylliumMinesCostString + " Li";

        boron += boronMines * Time.deltaTime;
        boronText.text = "Boron: " + NotationMethod(boron, "F0");
        boronGainText.text = "Mining " + NotationMethod(boronMines, "F0") + " boron/s";
        string boronMinesCostString;
        var boronMinesCost = 1e5 * Pow(10, boronMines);
        boronMinesCostString = NotationMethod(boronMinesCost, "F0");
        boronMinesText.text = "Open new boron mine\nCost: " + boronMinesCostString + " Be";

        carbon += carbonMines * Time.deltaTime;
        carbonText.text = "Carbon: " + NotationMethod(carbon, "F0");
        carbonGainText.text = "Mining " + NotationMethod(carbonMines, "F0") + " carbon/s";
        string carbonMinesCostString;
        var carbonMinesCost = 1e5 * Pow(10, carbonMines);
        carbonMinesCostString = NotationMethod(carbonMinesCost, "F0");
        carbonMinesText.text = "Open new carbon mine\nCost: " + carbonMinesCostString + " B";

        nitrogen += nitrogenExtractors * Time.deltaTime;
        nitrogenText.text = "Nitrogen: " + NotationMethod(nitrogen, "F0");
        nitrogenGainText.text = "Extracting " + NotationMethod(nitrogenExtractors, "F0") + " nitrogen/s";
        string nitrogenExtractorsCostString;
        var nitrogenExtractorsCost = 1e5 * Pow(10, nitrogenExtractors);
        nitrogenExtractorsCostString = NotationMethod(nitrogenExtractorsCost, "F0");
        nitrogenExtractorsText.text = "Open new nitrogen extractor\nCost: " + nitrogenExtractorsCostString + " C";

        oxygen += oxygenExtractors * Time.deltaTime;
        oxygenText.text = "Oxygen: " + NotationMethod(oxygen, "F0");
        oxygenGainText.text = "Extracting " + NotationMethod(oxygenExtractors, "F0") + " oxygen/s";
        string oxygenExtractorsCostString;
        var oxygenExtractorsCost = 1e4 * Pow(10, oxygenExtractors);
        oxygenExtractorsCostString = NotationMethod(oxygenExtractorsCost, "F0");
        oxygenExtractorsText.text = "Open new oxygen extractor\nCost: " + oxygenExtractorsCostString + " N";

        fluorine += fluorineExtractors * Time.deltaTime;
        fluorineText.text = "Fluorine: " + NotationMethod(fluorine, "F0");
        fluorineGainText.text = "Extracting " + NotationMethod(fluorineExtractors, "F0") + " fluorine/s";
        string fluorineExtractorsCostString;
        var fluorineExtractorsCost = 1e4 * Pow(10, fluorineExtractors);
        fluorineExtractorsCostString = NotationMethod(fluorineExtractorsCost, "F0");
        fluorineExtractorsText.text = "Open new fluorine extractor\nCost: " + fluorineExtractorsCostString + " O";

        neon += neonExtractors * Time.deltaTime;
        neonText.text = "Neon: " + NotationMethod(neon, "F0");
        neonGainText.text = "Extracting " + NotationMethod(neonExtractors, "F0") + " neon/s";
        string neonExtractorsCostString;
        var neonExtractorsCost = 1e4 * Pow(10, neonExtractors);
        neonExtractorsCostString = NotationMethod(neonExtractorsCost, "F0");
        neonExtractorsText.text = "Open new neon extractor\nCost: " + neonExtractorsCostString + " F";

        Save();
    }

    public string NotationMethod(BigDouble x, string y)
    {
        if (x > 1000)
        {
            var exponent = (Floor(Log10(Abs(x))));
            var mantissa = (x / Pow(10, exponent));
            return mantissa.ToString("F2") + "e" + exponent;
        }

        return x.ToString(y);
    }

    public void NuclearFusion()
    {
        if (Hydrogen.BigAssNumber > 1.1e5)
        {
            Hydrogen.BigAssNumber = 0;
            Hydrogen.ClickPower = 1;
            
            heliumGainUpg1Level = 0;

            helium += heliumGain;
        }
    }

    public void Lithify()
    {
        if (helium >= 4.45e6 && lithiumUnlock == true && save1stPeriodCheck == false)
        {
            Hydrogen.BigAssNumber = 0;
            Hydrogen.ClickPower = 1;
            
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
        else if (helium >= 4.45e6 && lithiumUnlock == true && save1stPeriodCheck == true)
        {
            lithium += lithiumGain;
        }
    }

    public void OpenBeMine()
    {
        var cost = 2e4 * Pow(10, berylliumMines);
        if (lithium >= cost && berylliumMines == 0)
        {
            Hydrogen.BigAssNumber = 0;
            Hydrogen.ClickPower = 1;
            
            heliumGainUpg1Level = 0;
            heliumGainUpg2Level = 0;
            cpsUpg1HeLevel = 0;
            helium = 0;
            lithium = 0;
            heliumGainUpg3Level = 0;
            cpsUpg1LiLevel = 0;
            maxBuyHbought = false;
            save1stMaxBuyCheck = false;
            biggerHeBoostCheck = false;
            doubleHe = false;
            berylliumMines++;
        }
        else if (lithium >= cost && berylliumMines > 0)
        {
            berylliumMines++;
            lithium -= cost;
        }
    }

    public void OpenBMine()
    {
        var cost = 1e5 * Pow(10, boronMines);
        if (beryllium >= cost && bCheck == true)
        {
            boronMines++;
            beryllium -= cost;
        }
    }

    public void OpenCMine()
    {
        var cost = 1e5 * Pow(10, carbonMines);
        if (boron >= cost && cCheck == true)
        {
            carbonMines++;
            boron -= cost;
        }
    }

    public void OpenNExtractor()
    {
        var cost = 1e5 * Pow(10, nitrogenExtractors);
        if (carbon >= cost && nCheck == true)
        {
            nitrogenExtractors++;
            carbon -= cost;
        }
    }

    public void OpenOExtractor()
    {
        var cost = 1e5 * Pow(10, oxygenExtractors);
        if (nitrogen >= cost && oCheck == true)
        {
            oxygenExtractors++;
            nitrogen -= cost;
        }
    }

    public void OpenFExtractor()
    {
        var cost = 1e5 * Pow(10, fluorineExtractors);
        if (oxygen >= cost && fCheck == true)
        {
            fluorineExtractors++;
            oxygen -= cost;
        }
    }

    public void OpenNeExtractor()
    {
        var cost = 1e4 * Pow(10, neonExtractors);
        if (fluorine >= cost && neCheck == true)
        {
            neonExtractors++;
            fluorine -= cost;
        }
    }


    public void Click()
    {
        Hydrogen.BigAssNumber += (Hydrogen.ClickPower * berylliumBoost);
    }

    public void BuyUpgrade(string upgradeID)
    {
        switch (upgradeID)
        {
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
            case "E1Be":
                var cost13 = 10 * Pow(1.25, mineEffUpg1Level);
                if (beryllium >= cost13)
                {
                    mineEffUpg1Level++;
                    beryllium -= cost13;
                }

                break;
            case "E2Be":
                var cost14 = 20 * Pow(1.4, mineEffUpg2Level);
                if (beryllium >= cost14)
                {
                    mineEffUpg2Level++;
                    beryllium -= cost14;
                }

                break;
        }
    }

    public void MaxBuyHConf()
    {
        if (Hydrogen.BigAssNumber >= 1e5 && maxBuyHbought == false)
        {
            Hydrogen.BigAssNumber -= 1e5;
            maxBuyHbought = true;

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

    public void passiveHelium()
    {
        if (lithium >= 1e4 && passiveHe == false)
        {
            passiveHe = true;
            lithium -= 1e4;
        }
    }

    public void Save1stPeriod()
    {
        if (beryllium >= 2e3 && save1stPeriodCheck == false)
        {
            save1stPeriodCheck = true;
            beryllium -= 2e3;
        }
    }

    public void BUnlock()
    {
        if (beryllium >= 1e4 && bCheck == false)
        {
            bCheck = true;
            beryllium -= 1e4;
        }
    }

    public void CUnlock()
    {
        if (boron >= 1e4 && cCheck == false)
        {
            cCheck = true;
            boron -= 1e4;
        }
    }

    public void NUnlock()
    {
        if (carbon >= 1e4 && nCheck == false)
        {
            nCheck = true;
            carbon -= 1e4;
        }
    }

    public void OUnlock()
    {
        if (nitrogen >= 1e4 && oCheck == false)
        {
            oCheck = true;
            nitrogen -= 1e4;
        }
    }

    public void FUnlock()
    {
        if (oxygen >= 1e4 && fCheck == false)
        {
            fCheck = true;
            oxygen -= 1e4;
        }
    }

    public void NeUnlock()
    {
        if (fluorine >= 1e4 && neCheck == false)
        {
            neCheck = true;
            fluorine -= 1e4;
        }
    }

    /*public BigDouble BuyMaxClickUpgrade1n()
    {
        var b = 10;
        var c = Hydrogen.BigAssNumber;
        var r = 1.07;
        var k = clickupgcount;
        var n = Floor(Log(((c * (r - 1)) / (b * Pow(r, k))) + 1, r));
        return n;
    }

    public BigDouble BuyMaxClickUpgrade2n()
    {
        var b = 250;
        var c = Hydrogen.BigAssNumber;
        var r = 1.07;
        var k = clickUpg2Level;
        var n = Floor(Log(((c * (r - 1)) / (b * Pow(r, k))) + 1, r));
        return n;
    }

    public BigDouble BuyMaxAutoClicker1n()
    {
        var b = 100;
        var c = Hydrogen.BigAssNumber;
        var r = 1.07;
        var k = cpsupgcount;
        var n = Floor(Log(((c * (r - 1)) / (b * Pow(r, k))) + 1, r));
        return n;
    }

    public BigDouble BuyMaxAutoClicker2n()
    {
        var b = 1000;
        var c = Hydrogen.BigAssNumber;
        var r = 1.07;
        var k = cpsUpg2Level;
        var n = Floor(Log(((c * (r - 1)) / (b * Pow(r, k))) + 1, r));
        return n;
    }*/

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

    public void PlayMusic()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
/*
    public void StopMusic()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }

    public void MuteButton()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
            audioSourceText.text = "Mute";
        }
        else if (audioSource.isPlaying)
        {
            audioSource.Stop();
            audioSourceText.text = "Unmute";
        }
    }*/
}
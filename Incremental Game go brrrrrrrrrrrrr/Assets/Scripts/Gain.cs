using UnityEngine;
using UnityEngine.UI;
using BreakInfinity;
using static BreakInfinity.BigDouble;
using System;

public class Gain : MonoBehaviour
{
    public Text hydrogenTxt;
    public BigDouble hydrogen; //variables
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

    private AudioSource audioSource;
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

        buyMaxClickUpg1Text.text = "Buy max 1st hydrogen upgrades [" + BuyMaxClickUpgrade1n() + "]";
        buyMaxClickUpg2Text.text = "Buy max 2nd hydrogen upgrades [" + BuyMaxClickUpgrade2n() + "]";
        buyMaxAutoClicker1Text.text = "Buy max 3rd hydrogen upgrades [" + BuyMaxAutoClicker1n() + "]";
        buyMaxAutoClicker2Text.text = "Buy max 4th hydrogen upgrades [" + BuyMaxAutoClicker2n() + "]";
        if (doubleHe == false)
        {
            heliumGain = (150 * Sqrt(hydrogen / 1e20) * Pow(1.1, heliumGainUpg1Level) * Pow(1.5, heliumGainUpg2Level) *
                          (1 + lithiumBoostHe) * Pow(1.25, heliumGainUpg3Level));
        }
        else
        {
            heliumGain = 2 * (150 * Sqrt(hydrogen / 1e20)) * Pow(1.1, heliumGainUpg1Level) * Pow(1.5,
                heliumGainUpg2Level * (1 + lithiumBoostHe) * Pow(1.25, heliumGainUpg3Level));
        }

        if (biggerHeBoostCheck == false)
        {
            heliumBoost = (helium * 0.02) + 1;
        }
        else
        {
            heliumBoost = (helium * 0.5) + 1;
        }

        berylliumBoost = 1 + (0.04 * berylliumMines);
        heliumGainText1.text = "Do nuclear fusion:\n+" + Floor(heliumGain).ToString("F0") + " helium";
        heliumGainText2.text = "Do nuclear fusion:\n+" + Floor(heliumGain).ToString("F0") + " helium";

        heliumText.text = "Helium: " + NotationMethod(helium, "F0") + "\n" + NotationMethod(heliumBoost, "F2") +
                          "x boost";

        lithiumGain = (150 * (Sqrt(helium / 1e11))) * berylliumBoost;
        lithiumText.text = "Lithium: " + NotationMethod(lithium, "F0");
        lithiumGainText.text = "Lithify for\n" + NotationMethod(lithiumGain, "F0") + " lithium";
        lithiumBoostText.text = NotationMethod(lithiumBoostH, "F2") + "xH and " + NotationMethod(lithiumBoostHe, "F2") +
                                "He boost";

        hydrogenTxt.text = "Hydrogen: " + NotationMethod(hydrogen, "F0");

        persecst = (cpsupgcount + (cpsUpg2Level * cpsUpg2Power)) * heliumBoost * Pow(1.2, cpsUpg1HeLevel) *
                   (1 + lithiumBoostH) * Pow(1.3, cpsUpg1LiLevel);
        persec.text = NotationMethod(persecst, "F0") + " hydrogen/s";

        string clickupgcostString;
        var clickupgcost = 10 * Pow(1.07, clickupgcount);
        clickupgcostString = NotationMethod(clickupgcost, "F0");
        clickupg.text = "Click strength\nCost: " + clickupgcostString + "\nPower: 1 hydrogen/click\nLevel: " +
                        NotationMethod(clickupgcount, "F0");

        string clickUpg2CostString;
        var clickUpg2Cost = 250 * Pow(1.07, clickUpg2Level);
        clickUpg2CostString = NotationMethod(clickUpg2Cost, "F0");
        clickupg2.text = "Click strength 2\nCost: " + clickUpg2CostString + "\nPower: 5 hydrogen/click\nLevel: " +
                         NotationMethod(clickUpg2Level, "F0");

        string cpscostString;
        var cpscost = 100 * Pow(1.07, cpsupgcount);
        cpscostString = NotationMethod(cpscost, "F0");
        persecupg.text = "Auto clicker\n(but bad :) )\n" + heliumBoost.ToString("F0") + " hydrogen/s\nCost: " +
                         cpscostString + "\nLevel:" + NotationMethod(cpsupgcount, "F0");

        string cpsUpg2CostString;
        var cpsUpg2Cost = 1000 * Pow(1.09, cpsUpg2Level);
        cpsUpg2CostString = NotationMethod(cpsUpg2Cost, "F0");
        cpsupg2.text = "Auto clicker 2.0\n" + (5 * heliumBoost).ToString("F0") + " hydrogen/s\nCost: " +
                       cpsUpg2CostString + "\nLevel:" + NotationMethod(cpsUpg2Level, "F0");

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

        clickpowerTxt.text = "Click for " + NotationMethod(clickpower, "F0") + " hydrogen";

        if (maxBuyHbought == true)
        {
            maxBuyHText.text = "Unlock max buyers for first 4 upgrades\nBought";
            ActivateTabs(maxBuyHGroup);
        }
        else
        {
            maxBuyHText.text = "Unlock max buyers for first 4 upgrades\nCost: 1.00e5";
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
            save1stPeriodText.text = "Lithify longer resets 1st period\nCost: 2e3 Be";
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

        hydrogen += persecst * Time.deltaTime;

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
        if (helium >= 4.45e6 && lithiumUnlock == true && save1stPeriodCheck == false)
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
        hydrogen += (clickpower * berylliumBoost);
    }

    public void BuyUpgrade(string upgradeID)
    {
        switch (upgradeID)
        {
            case "C1":
                var cost1 = 10 * Pow(1.07, clickupgcount);
                if (hydrogen >= cost1)
                {
                    clickupgcount += 1;
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
                var cost4 = 250 * Pow(1.07, clickUpg2Level);
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
                var r1 = 1.07;
                var k1 = clickUpg2Level;
                var n1 = Floor(Log(((c1 * (r1 - 1)) / (b1 * Pow(r1, k1))) + 1, r1));

                var cost3 = b1 * ((Pow(r1, k1) * (Pow(r1, n1) - 1)) / (r1 - 1));

                if (hydrogen >= cost3)
                {
                    clickUpg2Level += Convert.ToInt32(n1.ToDouble());
                    hydrogen -= cost3;
                    clickpower += (n1 * 5);
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
                Debug.Log(message: "No upgrade found");
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
                if (helium >= cost9)
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
        var r = 1.07;
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

    public void PlayMusic()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

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
    }
}
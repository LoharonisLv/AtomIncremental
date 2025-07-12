using UnityEngine;
using System.IO;
using Unity.VisualScripting;

namespace BreakInfinity
{
    public class SaveManager : MonoBehaviour
    {
        public Hydrogen Hydrogen;
        public Upgrades Upgrades;
        public Helium helium;
        private string savePath;

        void Awake()
        {
            savePath = Application.persistentDataPath + "/save.json";
            LoadGame();
            InvokeRepeating(nameof(SaveGame), 10f, 10f);
        }

        void OnApplicationQuit() => SaveGame();
        void OnApplicationPause(bool pause) { if (pause) SaveGame(); }

        public void SaveGame()
        {
            SaveData data = new SaveData
            {
                BigAssNumber = Hydrogen.BigAssNumber.ToString(),
                ClickPower = Hydrogen.ClickPower.ToString(),
                HydrogenGen = Hydrogen.HydrogenGen.ToString(),
                HeliumBoostPower = Hydrogen.HeliumBoostPower.ToString(),
                PercentageBoost = Hydrogen.PercentageBoost.ToString(),
                HClickStrengthLevel = Upgrades.HClickStrengthLevel.ToString(),
                HClickStrength2Level = Upgrades.HClickStrength2Level.ToString(),
                HHydrogenGenLevel = Upgrades.HHydrogenGenLevel.ToString(),
                HHydrogenGen2Level = Upgrades.HHydrogenGen2Level.ToString(),
                Helium=helium.BigAssNumber.ToString(),
                DoubleHelium = helium.DoubleHelium.ToString(),
				HHeliumGain1Level = Upgrades.HHeliumGain1Level.ToString(),
                MaxBuyersCheck = Hydrogen.MaxBuyerCheck.ToString(),
				HeHeliumGainLevel = Upgrades.HeHeliumGainLevel.ToString(),
                HeHydrogenGenLevel = Upgrades.HeHydrogenGenLevel.ToString(),
                
            };

            string json = JsonUtility.ToJson(data);
            File.WriteAllText(savePath, json);
        }

        public void LoadGame()
        {
            if (!File.Exists(savePath)) return;

            string json = File.ReadAllText(savePath);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            Hydrogen.BigAssNumber = BigDouble.Parse(data.BigAssNumber);
            Hydrogen.ClickPower = BigDouble.Parse(data.ClickPower);
            Hydrogen.HydrogenGen = BigDouble.Parse(data.HydrogenGen);
            Hydrogen.HeliumBoostPower = BigDouble.Parse(data.HeliumBoostPower);
            Hydrogen.PercentageBoost = BigDouble.Parse(data.PercentageBoost);
            Upgrades.HClickStrengthLevel = BigDouble.Parse(data.HClickStrengthLevel);
            Upgrades.HClickStrength2Level = BigDouble.Parse(data.HClickStrength2Level);
            Upgrades.HHydrogenGenLevel = BigDouble.Parse(data.HHydrogenGenLevel);
            Upgrades.HHydrogenGen2Level = BigDouble.Parse(data.HHydrogenGen2Level);
            helium.BigAssNumber = BigDouble.Parse(data.Helium);
            helium.DoubleHelium = bool.Parse(data.DoubleHelium);
			Upgrades.HHeliumGain1Level = BigDouble.Parse(data.HHeliumGain1Level);
            Hydrogen.MaxBuyerCheck = bool.Parse(data.MaxBuyersCheck);
			Upgrades.HeHeliumGainLevel = BigDouble.Parse(data.HeHeliumGainLevel);
            Upgrades.HeHydrogenGenLevel = BigDouble.Parse(data.HeHydrogenGenLevel);
        }
    }

    [System.Serializable]
    public class SaveData
    {
        public string BigAssNumber;
        public string ClickPower;
        public string HydrogenGen;
        public string HeliumBoostPower;
        public string PercentageBoost;
        public string HClickStrengthLevel;
        public string HClickStrength2Level;
        public string HHydrogenGenLevel;
        public string HHydrogenGen2Level;
        public string Helium;
        public string DoubleHelium;
		public string HHeliumGain1Level;
        public string MaxBuyersCheck;
		public string HeHeliumGainLevel;
        public string HeHydrogenGenLevel;
        
    }
}
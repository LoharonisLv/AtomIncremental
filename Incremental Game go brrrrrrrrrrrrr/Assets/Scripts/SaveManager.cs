using UnityEngine;
using System.IO;
namespace BreakInfinity
{
    public class SaveManager : MonoBehaviour
    {
        public Hydrogen Hydrogen;
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
                PercentageBoost = Hydrogen.PercentageBoost.ToString()
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
    }
}
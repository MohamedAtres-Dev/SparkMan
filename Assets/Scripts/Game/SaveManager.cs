using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BayatGames.SaveGameFree;
using System.Text;
using BayatGames.SaveGameFree.Encoders;
using BayatGames.SaveGameFree.Serializers;

namespace SparkBallGame
{
    public class SaveManager : Singlton<SaveManager>
    {
        [SerializeField] PlayerData _playerData;
        [SerializeField] List<SaveValue> _saveValues;

        private string saveIdentifier = "SavePlayerData";
        private string loadedData;
        private static ISaveGameSerializer m_Serializer = new SaveGameJsonSerializer();
        private static ISaveGameEncoder m_Encoder = new SaveGameSimpleEncoder();
        private static Encoding m_Encoding = Encoding.UTF8;
        private static string m_EncodePassword = "h@e#ll$o%^";
        private void OnEnable()
        {
            LoadData();
        }

        private void OnDisable()
        {
            SaveData();
        }

        private void SaveData()
        {
            //PlayerPrefs.SetString(saveIdentifier, JsonUtility.ToJson(_playerData));
            SaveGame.Save(saveIdentifier, JsonUtility.ToJson(_playerData), true, m_EncodePassword, m_Serializer, m_Encoder, m_Encoding, SaveGamePath.PersistentDataPath);
            foreach (var val in _saveValues)
            {
                val.valueAsset.SaveValue(val.valueAsset.value, val.saveKey);
            }
        }

        private void LoadData()
        {
            foreach (var val in _saveValues)
            {
                val.valueAsset.value = val.valueAsset.LoadValue(val.saveKey);
            }

            loadedData = SaveGame.Load<string>(saveIdentifier, "", true, m_EncodePassword, m_Serializer, m_Encoder, m_Encoding, SaveGamePath.PersistentDataPath);
            JsonUtility.FromJsonOverwrite(loadedData, _playerData);
            //JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString(saveIdentifier).ToString(), _playerData);
        }
    }

    [System.Serializable]
    public class SaveValue
    {
        public ValueAsset<int> valueAsset;
        public string saveKey;
    }
}
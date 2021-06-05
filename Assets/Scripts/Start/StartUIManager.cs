using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace SparkBallGame
{
    public class StartUIManager : MonoBehaviour
    {
        [SerializeField] PlayerData _playerData;

        [Header("UI Elements")]
        [SerializeField] TextMeshProUGUI _HighScoreText;
        
        // Start is called before the first frame update
        void Start()
        {
            _HighScoreText.text = _playerData.PlayerScore.ToString();
        }

        public void StartGame()
        {
            Debug.Log("Start Game");
            SceneManager.LoadScene("Game");
            GoogleAdMobController.Instance.HideBannerAd();
        }
    }
}
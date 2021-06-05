using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
namespace SparkBallGame
{
    public class StartUIManager : MonoBehaviour
    {
        [SerializeField] PlayerData _playerData;
        [SerializeField] AudioMixer audioMixer;


        [Header("UI Elements")]
        [SerializeField] TextMeshProUGUI _HighScoreText;
        
        // Start is called before the first frame update
        void Start()
        {
            LoadAudio();
            _HighScoreText.text = _playerData.PlayerScore.ToString();
        }

        public void StartGame()
        {
            Debug.Log("Start Game");
            SceneManager.LoadScene("Game");
            GoogleAdMobController.Instance.HideBannerAd();
        }

        private void LoadAudio()
        {
            if (_playerData.MusicOn)
            {
                audioMixer.SetFloat("Music", Mathf.Log(1f) * 20);
            }
            else
            {
                audioMixer.SetFloat("Music", Mathf.Log(0.001f) * 20);
            }

            if (_playerData.SoundOn)
            {
                audioMixer.SetFloat("SoundFX", Mathf.Log(1f) * 20);
            }
            else
            {
                audioMixer.SetFloat("SoundFX", Mathf.Log(0.001f) * 20);
            }
        }
    }
}
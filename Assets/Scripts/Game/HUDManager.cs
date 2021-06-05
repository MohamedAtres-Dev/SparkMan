using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

namespace SparkBallGame
{
    public class HUDManager : MonoBehaviour
    {
        [SerializeField] GameObject _deathPanel;
        [SerializeField] GameObject _pausePanel;


        private void OnEnable()
        {
            PlayerCollision.onPlayerDied += OnPlayerDied;
        }
        private void OnDisable()
        {
            PlayerCollision.onPlayerDied -= OnPlayerDied;
        }

        public void OnPausePressed()
        {
            _pausePanel.SetActive(true);
            Time.timeScale = 0f;
        }

        public void OnContinuePressed()
        {
            _pausePanel.SetActive(false);
            Time.timeScale = 1f;
        }

        public void OnPlayerDied()
        {
            _deathPanel.SetActive(true);
        }
        
        public void OnHomePressed()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(0);
        }

        public void OnRestartPressed()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(1);
        }
    }
}
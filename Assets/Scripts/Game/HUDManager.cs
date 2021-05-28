using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnPlayerDied()
        {
            _deathPanel.SetActive(true);
        }
    }
}
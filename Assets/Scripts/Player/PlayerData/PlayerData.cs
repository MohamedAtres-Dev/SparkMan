using UnityEngine;

namespace SparkBallGame
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "Data/player data")]
    public class PlayerData : ScriptableObject
    {
        [SerializeField] private int _playerHighScore;

        [SerializeField] private float _sparkFullBar;
        [SerializeField] private int _sparkyTime;

        [SerializeField] private float _startSparkAmount;
        [SerializeField] private float _sparkAddedAmount;
        [SerializeField] private float _sparkRemovedAmount;

        [SerializeField] private bool _musicOn;
        [SerializeField] private bool _soundOn;


        [SerializeField] private bool _isRemovedAds;

        public int PlayerScore { get => _playerHighScore; set => _playerHighScore = value; }
        public bool MusicOn { get => _musicOn; set => _musicOn = value; }
        public bool SoundOn { get => _soundOn; set => _soundOn = value; }
        public bool IsRemovedAds { get => _isRemovedAds; set => _isRemovedAds = value; }
        public float SparkBarProgress { get => _sparkFullBar; set => _sparkFullBar = value; }
        public int FullSparkBarTime { get => _sparkyTime; set => _sparkyTime = value; }
        public float StartSparkAmount { get => _startSparkAmount; set => _startSparkAmount = value; }
        public float SparkAddedAmount { get => _sparkAddedAmount; set => _sparkAddedAmount = value; }
        public float SparkRemovedAmount { get => _sparkRemovedAmount; set => _sparkRemovedAmount = value; }

        public void SetPlayerScore(int score)
        {
            if (score > _playerHighScore)
            {
                _playerHighScore = score;
            }
        }
    }
}
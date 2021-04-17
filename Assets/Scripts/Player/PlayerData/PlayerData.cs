using UnityEngine;

[CreateAssetMenu(fileName ="PlayerData" , menuName ="Data/player data")]
public class PlayerData : ScriptableObject
{
    [SerializeField] private int _playerHighScore;
    [SerializeField] private bool _musicOn;
    [SerializeField] private bool _soundOn;
    [SerializeField] private bool _isRemovedAds;

    public int PlayerScore { get => _playerHighScore; set => _playerHighScore = value; }
    public bool MusicOn { get => _musicOn; set => _musicOn = value; }
    public bool SoundOn { get => _soundOn; set => _soundOn = value; }
    public bool IsRemovedAds { get => _isRemovedAds; set => _isRemovedAds = value; }

    public void SetPlayerScore(int score)
    {
        if(score > _playerHighScore)
        {
            _playerHighScore = score;
        }
    }
}

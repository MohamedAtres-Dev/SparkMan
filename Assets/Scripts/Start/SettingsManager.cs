using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace SparkBallGame
{
    public class SettingsManager : MonoBehaviour
    {
        [SerializeField] PlayerData _playerData;
        [SerializeField] AudioMixer audioMixer;

        [SerializeField] Toggle musicToggle;
        [SerializeField] Toggle soundToggle;

        private void Start()
        {
            musicToggle.onValueChanged.AddListener((bool val) => OnMusicPressed(val));

            soundToggle.onValueChanged.AddListener((bool val) => OnSoundPressed(val));
        }


        public void OnRatePressed()
        {
            //TODO: OPEN Google Page
        }

        public void OnSupportPressed()
        {
            Application.OpenURL("https://www.grintagames.com/");
        }

        public void OnAboutPressed()
        {

        }

        public void OnSettingsPressed()
        {
            musicToggle.isOn = _playerData.MusicOn;
            soundToggle.isOn = _playerData.SoundOn;
        }

        public void OnMusicPressed(bool toggleValue)
        {
            if (toggleValue)
            {
                audioMixer.SetFloat("Music", Mathf.Log(1.0f) * 20);
                _playerData.MusicOn = true;

                Debug.Log("Unmute Music");
            }
            else
            {
                audioMixer.SetFloat("Music", Mathf.Log(0.001f) * 20);
                _playerData.MusicOn = false;

                Debug.Log("mute Music");
            }
        }

        public void OnSoundPressed(bool toggleValue)
        {
            if (toggleValue)
            {
                audioMixer.SetFloat("SoundFX", Mathf.Log(1.0f) * 20);
                _playerData.SoundOn = true;

                Debug.Log("Unmute Sound");
            }
            else
            {
                audioMixer.SetFloat("SoundFX", Mathf.Log(0.001f) * 20);
                _playerData.SoundOn = false;

                Debug.Log("mute Sound");
            }
        }
    }
}
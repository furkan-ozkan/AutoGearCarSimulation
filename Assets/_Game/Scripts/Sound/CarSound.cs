using UnityEngine;

namespace _Game.Scripts.Sound
{
    public class CarSound : MonoBehaviour
    {
        #region Singleton

        public static CarSound Instance { get; private set; }
        private void Awake()
        {
            if (Instance != null && Instance != this)
            { 
                Destroy(this);
                return;
            }
            Instance = this;
        }

        #endregion
    
        [SerializeField] private AudioClip startUp;
        [SerializeField] private AudioClip lowOn;
        [SerializeField] private AudioSource carAudioSource;

        public AudioClip StartUp => startUp;
        public AudioClip LowOn => lowOn;

        public AudioSource CarAudioSource => carAudioSource;

        public void ChangeCarSound(AudioClip clip, float volume)
        {
            if (CarAudioSource.clip != clip)
            {
                CarAudioSource.clip = clip;
                CarAudioSource.volume = volume;
                CarAudioSource.Play();
            }
        }
    }
}

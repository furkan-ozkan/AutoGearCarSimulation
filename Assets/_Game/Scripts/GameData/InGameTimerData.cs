using UnityEngine;

namespace _Game.Scripts.GameData
{
    public class InGameTimerData : MonoBehaviour
    {
        #region Singleton

        public static InGameTimerData Instance { get; private set; }
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

        public float timerStart;
        public float currentTimer;
    }
}

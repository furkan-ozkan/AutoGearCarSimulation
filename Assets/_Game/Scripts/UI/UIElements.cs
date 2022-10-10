using UnityEngine;

namespace _Game.Scripts.UI
{
    public class UIElements : MonoBehaviour
    {
        #region Singleton

        public static UIElements Instance { get; private set; }
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

        public GameObject beforeGameUI;
        public GameObject inGameTimerGameUI;
        public GameObject inGameGameUI;
        public GameObject endGameUI;
    
    }
}

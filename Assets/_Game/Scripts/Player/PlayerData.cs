using UnityEngine;

namespace _Game.Scripts.Player
{
    public class PlayerData : MonoBehaviour
    {
        #region Singleton

        public static PlayerData Instance { get; private set; }
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

        public Car.Car currentCar;
        public float currentRpm;
        public float currentSpeed;
        public bool onGas, onBreak;
        public float currentGearsSpeedScale;
        public GameObject bornOutLeftPosition;
        public GameObject bornOutRightPosioton;
        public int currentGearTier;
        public float raceTimer = 0f;

    }
}

using _Game.Scripts.Player;
using UnityEngine;

namespace _Game.Scripts.Gear
{
    public abstract class GearBaseState : MonoBehaviour
    {
        public abstract void EnterState();
        public abstract void UpdateState();
        public abstract void ExitState();
    
        /// <summary>
        /// Gives us car's current speed
        /// </summary>
        /// <returns></returns>
        public float GetCurrentCarSpeed()
        {
            return PlayerData.Instance.currentSpeed;
        }
        /// <summary>
        /// This method gives us car's have minimum speed.
        /// </summary>
        /// <returns></returns>
        public float GetGearActiveMinSpeed()
        {
            return GetMinRPM() * PlayerData.Instance.currentCar.gearSpeedScale[0];
        }
        /// <summary>
        /// It gives us min rpm.
        /// </summary>
        /// <returns></returns>
        public float GetMinRPM()
        {
            return PlayerData.Instance.currentCar.maxRpm / 20;
        }
        /// <summary>
        /// Updating car speed
        /// </summary>
        /// <param name="changeAmount"></param>
        public void UpdateSpeed(float changeAmount)
        {
            PlayerData.Instance.currentSpeed += changeAmount;
        }
        public float GetCurrentSpeedScale()
        {
            return PlayerData.Instance.currentGearsSpeedScale;
        }
    }
}
using UnityEngine;

namespace _Game.Scripts.Car
{
    [CreateAssetMenu(menuName = "Create/Car")]
    public class Car : ScriptableObject
    {
        public float maxRpm;
        public float maxSpeed;
        public float autoGearRpm;
        public float[] gearSpeedScale = new float[6];
    }
}
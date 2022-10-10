using _Game.Scripts.Player;
using UnityEngine;

namespace _Game.Scripts.GameManager
{
    public class WheelRotateController : MonoBehaviour
    {
        private float timesRotatePerSecond;
        private Vector3 rotatePerSecond;
        private float wheelCircumference = 1.8f;  // meters
        public bool reverse;
        void FixedUpdate()
        {
            if (reverse)
            {
                timesRotatePerSecond = PlayerData.Instance.currentSpeed / 3600 / wheelCircumference;
                transform.Rotate(Vector3.right,-360*timesRotatePerSecond*Time.fixedDeltaTime);
            }
            else
            {
                timesRotatePerSecond = PlayerData.Instance.currentSpeed / 3600 / wheelCircumference;
                transform.Rotate(Vector3.right,360*timesRotatePerSecond*Time.fixedDeltaTime);
            }            
        }
    }
}

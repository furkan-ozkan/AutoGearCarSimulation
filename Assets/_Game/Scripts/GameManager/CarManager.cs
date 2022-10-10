using _Game.Scripts.Player;
using UnityEngine;

namespace _Game.Scripts.GameManager
{
    public class CarManager : MonoBehaviour
    {
        void FixedUpdate()
        {
            transform.position += new Vector3(PlayerData.Instance.currentSpeed/3600*Time.fixedDeltaTime, 0, 0);
        }
    }
}

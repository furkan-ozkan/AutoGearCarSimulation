using _Game.Scripts.Player;
using DG.Tweening;
using UnityEngine;

namespace _Game.Scripts.UI.InGame
{
    public class SpeedMeter : MonoBehaviour
    {
        void Update()
        {
            transform.DOLocalRotate(new Vector3(0,0,
                -(180 / PlayerData.Instance.currentCar.maxSpeed * PlayerData.Instance.currentSpeed/1000) + 90), .2f);
        }
    }
}

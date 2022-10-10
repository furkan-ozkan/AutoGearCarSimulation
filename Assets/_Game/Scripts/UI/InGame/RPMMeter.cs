using _Game.Scripts.Player;
using DG.Tweening;
using UnityEngine;

namespace _Game.Scripts.UI.InGame
{
    public class RPMMeter : MonoBehaviour
    {
        void Update()
        {
            transform.DOLocalRotate(new Vector3(0,0,
                -(180 / PlayerData.Instance.currentCar.maxRpm * PlayerData.Instance.currentRpm) + 90), .2f);
        }
    }
}

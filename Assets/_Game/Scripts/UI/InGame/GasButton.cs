using _Game.Scripts.Player;
using UnityEngine;
using UnityEngine.EventSystems;

namespace _Game.Scripts.UI.InGame
{
    public class GasButton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
    {

        public void OnPointerDown(PointerEventData eventData)
        {
            PlayerData.Instance.onGas = true;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            PlayerData.Instance.onGas = false;
        }
    }
}

using _Game.Scripts.Player;
using UnityEngine;
using UnityEngine.EventSystems;

namespace _Game.Scripts.UI.InGame
{
    public class BreakButton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
    {

        public void OnPointerDown(PointerEventData eventData)
        {
            PlayerData.Instance.onBreak = true;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            PlayerData.Instance.onBreak = false;
        }
    }
}

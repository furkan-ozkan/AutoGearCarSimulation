using _Game.Scripts.GameStates;
using UnityEngine;

namespace _Game.Scripts.UI.BeforeGame
{
    public class BeforeGameUIPanelManager : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                ClickToStartButton();
            }
        }

        public void ClickToStartButton()
        {
            GameStateManager.Instance.SwitchState(GameStateManager.Instance.CreateInGameTimerState());
        }
    }
}

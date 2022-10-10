using _Game.Scripts.GameData;
using _Game.Scripts.Gear;
using _Game.Scripts.UI;
using UnityEngine;

namespace _Game.Scripts.GameStates
{
    public class InGameTimerState : BaseGameState
    {
        public override void EnterState()
        {
            UIElements.Instance.inGameTimerGameUI.SetActive(true);
            UIElements.Instance.inGameGameUI.SetActive(true);
            GearStateManager.Instance.SwitchState(GearStateManager.Instance.CreateNGearState());
            InGameTimerData.Instance.currentTimer = InGameTimerData.Instance.timerStart;
        }

        public override void UpdateState()
        {
            InGameTimerData.Instance.currentTimer -= Time.deltaTime;
            if (InGameTimerData.Instance.currentTimer < 0)
            {
                GameStateManager.Instance.SwitchState(GameStateManager.Instance.CreateInGameState());
            }
        }

        public override void ExitState()
        {
            UIElements.Instance.inGameTimerGameUI.SetActive(false);
        }
    }
}
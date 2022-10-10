using _Game.Scripts.Gear;
using _Game.Scripts.Player;
using _Game.Scripts.UI;
using DG.Tweening;
using UnityEngine;

namespace _Game.Scripts.GameStates
{
    public class InGameState : BaseGameState
    {
        public override void EnterState()
        {
        
        }

        public override void UpdateState()
        {
            PlayerData.Instance.raceTimer += Time.deltaTime;
        }

        public override void ExitState()
        {
            UIElements.Instance.inGameGameUI.SetActive(false);
            DOTween.To(()=>PlayerData.Instance.currentSpeed, x=> PlayerData.Instance.currentSpeed = x,0 ,5f);
            GearStateManager.Instance.SwitchState(GearStateManager.Instance.CreateNGearState());
        }
    }
}
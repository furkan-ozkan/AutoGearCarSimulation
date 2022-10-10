using _Game.Scripts.Player;
using _Game.Scripts.Sound;
using _Game.Scripts.UI;

namespace _Game.Scripts.GameStates
{
    public class EndGameState : BaseGameState
    {
        public override void EnterState()
        {
            UIElements.Instance.endGameUI.SetActive(true);
        }

        public override void UpdateState()
        {
            CarSound.Instance.CarAudioSource.pitch = ((PlayerData.Instance.currentRpm / PlayerData.Instance.currentCar.maxRpm) * 2);
        }

        public override void ExitState()
        {
        
        }
    }
}
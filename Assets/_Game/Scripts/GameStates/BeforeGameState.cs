using _Game.Scripts.UI;

namespace _Game.Scripts.GameStates
{
    public class BeforeGameState : BaseGameState
    {
        public override void EnterState()
        {
        
        }

        public override void UpdateState()
        {
        
        }

        public override void ExitState()
        {
            UIElements.Instance.beforeGameUI.SetActive(false);
        }
    }
}
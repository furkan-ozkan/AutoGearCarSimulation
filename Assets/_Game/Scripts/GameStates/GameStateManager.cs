using UnityEngine;

namespace _Game.Scripts.GameStates
{
    public class GameStateManager : MonoBehaviour
    {
        #region Singleton

        public static GameStateManager Instance { get; private set; }

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this);
                return;
            }

            Instance = this;
        }

        #endregion

        private BaseGameState currentState = new BeforeGameState();

        void Start()
        {
            currentState.EnterState();
        }

        void Update()
        {
            currentState.UpdateState();
        }

        public bool CheckCurrentState(BaseGameState state)
        {
            if (currentState.ToString() == state.ToString())
                return true;
            return false;
        }

        public void SwitchState(BaseGameState state)
        {
            currentState.ExitState();
            currentState = state;
            currentState.EnterState();
        }

        #region CreateStates

        public BaseGameState CreateBeforeGameState()
        {
            return new BeforeGameState();
        }
        public BaseGameState CreateInGameTimerState()
        {
            return new InGameTimerState();
        }
        public BaseGameState CreateInGameState()
        {
            return new InGameState();
        }
        public BaseGameState CreateEndGameState()
        {
            return new EndGameState();
        }
        
        #endregion
    }
}

using _Game.Scripts.GameStates;
using UnityEngine;

namespace _Game.Scripts.GameManager
{
    public class GameManager : MonoBehaviour
    {
        public GameObject car;
        public Vector3 finishLine =  new Vector3(4000,0,0);

        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        void Update()
        {
            if (car.transform.position.x >= finishLine.x)
            {
                GameStateManager.Instance.SwitchState(GameStateManager.Instance.CreateEndGameState());
            }
        }
    }
}

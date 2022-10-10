using _Game.Scripts.GameStates;
using _Game.Scripts.Gear;
using _Game.Scripts.Player;
using UnityEngine;

namespace _Game.Scripts.GameManager
{
    public class InputManager : MonoBehaviour
    {
        public GameObject gearHand;
        public GameObject dGearButton;
        public GameObject nGearButton;
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W) && !PlayerData.Instance.onBreak)
            {
                PlayerData.Instance.onGas = true;
            }
            else if (Input.GetKeyUp(KeyCode.W) && !PlayerData.Instance.onBreak)
            {
                PlayerData.Instance.onGas = false;
            }
            if (Input.GetKeyDown(KeyCode.S) && !PlayerData.Instance.onGas)
            {
                PlayerData.Instance.onBreak = true;
            }
            else if (Input.GetKeyUp(KeyCode.S) && !PlayerData.Instance.onGas)
            {
                PlayerData.Instance.onBreak = false;
            }

            if (Input.GetKeyDown(KeyCode.Space) && GameStateManager.Instance.CheckCurrentState(GameStateManager.Instance.CreateInGameState()))
            {
                SwitchToDGear();
            }

            if (Input.GetKeyDown(KeyCode.LeftControl) && GameStateManager.Instance.CheckCurrentState(GameStateManager.Instance.CreateInGameState()))
            {
                SwitchToNGear();
            }
        }
    
        public void SwitchToDGear()
        {
            GearStateManager.Instance.SwitchState(GearStateManager.Instance.CreateDGearOneState());
            GearHandPositionUpdate(dGearButton.transform.position.y);
        }
        public void SwitchToNGear()
        {
            GearStateManager.Instance.SwitchState(GearStateManager.Instance.CreateNGearState());
            GearHandPositionUpdate(nGearButton.transform.position.y);
        }
        private void GearHandPositionUpdate(float yAxis)
        {
            gearHand.transform.position = new Vector3(gearHand.transform.position.x,yAxis,gearHand.transform.position.z);
        }
    }
}

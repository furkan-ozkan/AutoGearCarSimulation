using _Game.Scripts.Gear.DGearS;
using UnityEngine;

namespace _Game.Scripts.Gear
{
    public class GearStateManager : MonoBehaviour
    {
        #region Singleton

        public static GearStateManager Instance { get; private set; }
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
    
        private GearBaseState currentGear = new EngineStopGearState();
        void Start()
        {
            currentGear.EnterState();
        }
        void FixedUpdate()
        {
            currentGear.UpdateState();
        }

        public void SwitchState(GearBaseState state)
        {
            currentGear.ExitState();
            currentGear = state;
            currentGear.EnterState();
        }

        #region CreateStates

        public GearBaseState CreateDGearState()
        {
            return new DGearState();
        }
        public GearBaseState CreateNGearState()
        {
            return new NGearState();
        }
        public GearBaseState CreateRGearState()
        {
            return new RGearState();
        }
        public GearBaseState CreateEngineStopGearState()
        {
            return new EngineStopGearState();
        }

        #region DGears

        public GearBaseState CreateDGearOneState()
        {
            return new GearDOne();
        }
        public GearBaseState CreateDGearTwoState()
        {
            return new GearDTwo();
        }
        public GearBaseState CreateDGearThreeState()
        {
            return new GearDThree();
        }
        public GearBaseState CreateDGearFourState()
        {
            return new GearDFour();
        }
        public GearBaseState CreateDGearFiveState()
        {
            return new GearDFive();
        }
        public GearBaseState CreateDGearSixState()
        {
            return new GearDSix();
        }

        #endregion
    
        #endregion
    }
}

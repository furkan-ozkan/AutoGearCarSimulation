using _Game.Scripts.Player;
using _Game.Scripts.Sound;

namespace _Game.Scripts.Gear
{
    public class DGearState : GearBaseState
    {
        #region State Funcs.

        public override void EnterState()
        {
            RPMCalculator();
            SpeedCalculator();
        }

        public override void UpdateState()
        {
            if (CheckGasButton() && CheckIsRPMIncreasable())
            {
                UpdateRPM(40);
                UpdateSpeed(GetCurrentSpeedScale());
            }
            else
            {
                if (GetCurrentCarSpeed() > GetGearActiveMinSpeed())
                {
                    UpdateSpeed(-GetCurrentSpeedScale()*25);
                    RPMCalculator();
                }
            }

            if (CheckBreakButton())
            {
                if (GetCurrentCarSpeed() < 0)
                {
                    ChangeSpeed(0);
                }
                else if (GetCurrentCarSpeed() >0)
                {
                    UpdateSpeed(-GetCurrentSpeedScale()*40);
                }
            }
            else
            {
                SpeedCalculator();
            }

            CarSound.Instance.CarAudioSource.pitch = ((GetCurrentCarRpm() / PlayerData.Instance.currentCar.maxRpm) * 2)+1;
        }

        public override void ExitState()
        {
        
        }

        #endregion

        #region Utility Funcs.

        #region Updating Funcs.

    
        /// <summary>
        /// Changing car speed
        /// </summary>
        /// <param name="speed"></param>
        private void ChangeSpeed(float speed)
        {
            PlayerData.Instance.currentSpeed = speed;
        }

        /// <summary>
        /// Updating car rpm
        /// </summary>
        /// <param name="changeAmount"></param>
        private void UpdateRPM(float changeAmount)
        {
            PlayerData.Instance.currentRpm += changeAmount;
        }

        /// <summary>
        /// This method changes gear.
        /// </summary>
        public void UpdateGear(GearBaseState state)
        {
            GearStateManager.Instance.SwitchState(state);
        }
    
        /// <summary>
        /// Updates speed scale by given gear tier.
        /// </summary>
        /// <param name="gearTier"></param>
        public void UpdateSpeedScale(int gearTier)
        {
            PlayerData.Instance.currentGearTier = gearTier;
            PlayerData.Instance.currentGearsSpeedScale = PlayerData.Instance.currentCar.gearSpeedScale[gearTier-1];
        }
    
        /// <summary>
        /// After gear changes this method calculating new rpm
        /// </summary>
        private void RPMCalculator()
        {
            if (GetCurrentCarRpm() > GetMinRPM())
            {
                PlayerData.Instance.currentRpm =
                    PlayerData.Instance.currentSpeed / PlayerData.Instance.currentGearsSpeedScale;
            }
        }

        /// <summary>
        /// Calculating speed how much it should be and update it smoothly
        /// </summary>
        private void SpeedCalculator()
        {
            PlayerData.Instance.currentSpeed = PlayerData.Instance.currentRpm * PlayerData.Instance.currentGearsSpeedScale;
        }
    
        #endregion

        #region Getter Funcs.
    

        /// <summary>
        /// Gives us current rpm
        /// </summary>
        /// <returns></returns>
        public float GetCurrentCarRpm()
        {
            return PlayerData.Instance.currentRpm;
        }
    
        /// <summary>
        /// Gives us auto gear up rpm
        /// </summary>
        /// <returns></returns>
        public float GetAutoGearUpRPM()
        {
            return PlayerData.Instance.currentCar.autoGearRpm;
        }
    
        /// <summary>
        /// this method gives us maximum speed of given gear tier
        /// </summary>
        /// <param name="gearNumber"></param>
        /// <returns></returns>
        public float GetGearMaxSpeed(int gearNumber)
        {
            return PlayerData.Instance.currentCar.autoGearRpm *
                   PlayerData.Instance.currentCar.gearSpeedScale[gearNumber - 1];
        }
    

        private float GetCarMaxSpeed()
        {
            return PlayerData.Instance.currentCar.maxSpeed;
        }
    
        #endregion

        #region Checker Funcs.

        /// <summary>
        /// This method checks if rpm is less than max value it could be
        /// </summary>
        /// <returns></returns>
        private bool CheckIsRPMIncreasable()
        {
            return PlayerData.Instance.currentCar.maxRpm > PlayerData.Instance.currentRpm;
        }

        /// <summary>
        /// This method gives us information about gas button.
        /// is it pressed or not.
        /// </summary>
        /// <returns></returns>
        public bool CheckGasButton()
        {
            return PlayerData.Instance.onGas;
        }

        /// <summary>
        /// This method gives us information about break button.
        /// is it pressed or not.
        /// </summary>
        /// <returns></returns>
        public bool CheckBreakButton()
        {
            return PlayerData.Instance.onBreak;
        }

        #endregion

        #endregion

        #region Gears

        public GearBaseState FirstGear()
        {
            return GearStateManager.Instance.CreateDGearOneState();
        }
        public GearBaseState SecondGear()
        {
            return GearStateManager.Instance.CreateDGearTwoState();
        }
        public GearBaseState ThirdGear()
        {
            return GearStateManager.Instance.CreateDGearThreeState();
        }
        public GearBaseState FourthGear()
        {
            return GearStateManager.Instance.CreateDGearFourState();
        }
        public GearBaseState FivethGear()
        {
            return GearStateManager.Instance.CreateDGearFiveState();
        }
        public GearBaseState SixthGear()
        {
            return GearStateManager.Instance.CreateDGearSixState();
        }

        #endregion
    }
}

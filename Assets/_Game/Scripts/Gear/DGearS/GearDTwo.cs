namespace _Game.Scripts.Gear.DGearS
{
    public class GearDTwo : DGearState
    {
        public override void EnterState()
        {
            UpdateSpeedScale(2);
            base.EnterState();
        }

        public override void UpdateState()
        {
            if (GetCurrentCarRpm() > GetAutoGearUpRPM())
            {
                UpdateGear(ThirdGear());
            }
        
            base.UpdateState();
        
            if (GetGearMaxSpeed(1) > GetCurrentCarSpeed() && !CheckGasButton())
            {
                UpdateGear(FirstGear());
            }
        }
    }
}
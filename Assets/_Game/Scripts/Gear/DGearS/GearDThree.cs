namespace _Game.Scripts.Gear.DGearS
{
    public class GearDThree : DGearState
    {
        public override void EnterState()
        {
            UpdateSpeedScale(3);
            base.EnterState();
        }

        public override void UpdateState()
        {
            if (GetCurrentCarRpm() > GetAutoGearUpRPM())
            {
                UpdateGear(FourthGear());
            }

            base.UpdateState();
        
            if (GetGearMaxSpeed(2) > GetCurrentCarSpeed() && !CheckGasButton())
            {
                UpdateGear(SecondGear());
            }
        }
    }
}
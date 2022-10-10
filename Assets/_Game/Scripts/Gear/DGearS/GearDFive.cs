namespace _Game.Scripts.Gear.DGearS
{
    public class GearDFive : DGearState
    {
        public override void EnterState()
        {
            UpdateSpeedScale(5);
            base.EnterState();
        }

        public override void UpdateState()
        {
            if (GetCurrentCarRpm() > GetAutoGearUpRPM())
            {
                UpdateGear(SixthGear());
            }
            base.UpdateState();
            if (GetGearMaxSpeed(4) > GetCurrentCarSpeed() && !CheckGasButton())
            {
                UpdateGear(FourthGear());
            }
        }
    }
}
namespace _Game.Scripts.Gear.DGearS
{
    public class GearDFour : DGearState
    {
        public override void EnterState()
        {
            UpdateSpeedScale(4);
            base.EnterState();
        }

        public override void UpdateState()
        {
            if (GetCurrentCarRpm() > GetAutoGearUpRPM())
            {
                UpdateGear(FivethGear());
            }
            base.UpdateState();
            if (GetGearMaxSpeed(3) > GetCurrentCarSpeed() && !CheckGasButton())
            {
                UpdateGear(ThirdGear());
            }
        }
    }
}
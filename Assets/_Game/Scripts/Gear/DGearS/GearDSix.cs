namespace _Game.Scripts.Gear.DGearS
{
    public class GearDSix : DGearState
    {
        public override void EnterState()
        {
            UpdateSpeedScale(6);
            base.EnterState();
        }

        public override void UpdateState()
        {
            base.UpdateState();
            if (GetGearMaxSpeed(5) > GetCurrentCarSpeed() && !CheckGasButton())
            {
                UpdateGear(FivethGear());
            }
        }
    }
}
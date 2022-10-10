namespace _Game.Scripts.Gear.DGearS
{
    public class GearDOne : DGearState
    {
        public override void EnterState()
        {
            UpdateSpeedScale(1);
            base.EnterState();
        }

        public override void UpdateState()
        {
            if (GetCurrentCarRpm() > GetAutoGearUpRPM())
            {
                UpdateGear(SecondGear());
            }
            base.UpdateState();
        }
    }
}

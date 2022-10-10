using _Game.Scripts.Player;
using _Game.Scripts.Sound;
using DG.Tweening;
using UnityEngine;

namespace _Game.Scripts.Gear
{
    public class NGearState : GearBaseState
    {
        private float startUpSoundDuration;
        public override void EnterState()
        {
            if (PlayerData.Instance.currentRpm < PlayerData.Instance.currentCar.maxRpm/20)
            {
                startUpSoundDuration = CarSound.Instance.StartUp.length;
                CarSound.Instance.ChangeCarSound(CarSound.Instance.StartUp,1f);
            
                DOTween.To(()=>PlayerData.Instance.currentRpm, x=> PlayerData.Instance.currentRpm = x,PlayerData.Instance.currentCar.maxRpm/20 ,1f);
            }
        }

        public override void UpdateState()
        {
            if (PlayerData.Instance.onGas && PlayerData.Instance.currentCar.maxRpm > PlayerData.Instance.currentRpm)
            {
                PlayerData.Instance.currentRpm += 40;
            }
            else
            {
                if (PlayerData.Instance.currentRpm > PlayerData.Instance.currentCar.maxRpm / 20)
                {
                    PlayerData.Instance.currentRpm -= 20;
                }
            }
        
            if (GetCurrentCarSpeed() > GetGearActiveMinSpeed())
            {
                UpdateSpeed(-GetCurrentSpeedScale()*25);
            }

            startUpSoundDuration -= Time.deltaTime;
            if (startUpSoundDuration<0 && CarSound.Instance.CarAudioSource.clip != CarSound.Instance.LowOn)
            {
                CarSound.Instance.ChangeCarSound(CarSound.Instance.LowOn,1f);
            }
            CarSound.Instance.CarAudioSource.pitch = ((PlayerData.Instance.currentRpm / PlayerData.Instance.currentCar.maxRpm) * 2)+1;
        }

        public override void ExitState()
        {
            PlayerData.Instance.currentSpeed = PlayerData.Instance.currentRpm * PlayerData.Instance.currentCar.gearSpeedScale[0];
            if (PlayerData.Instance.currentSpeed > PlayerData.Instance.currentCar.maxRpm*PlayerData.Instance.currentCar.gearSpeedScale[0]/2)
            {
                PlayerData.Instance.currentSpeed = 0;
                Instantiate(PlayerData.Instance.bornOutRightPosioton, PlayerData.Instance.bornOutRightPosioton.transform.position,
                    PlayerData.Instance.bornOutRightPosioton.transform.rotation).SetActive(true);
                Instantiate(PlayerData.Instance.bornOutLeftPosition, PlayerData.Instance.bornOutLeftPosition.transform.position,
                    PlayerData.Instance.bornOutLeftPosition.transform.rotation).SetActive(true);
            }
        }
    }
}
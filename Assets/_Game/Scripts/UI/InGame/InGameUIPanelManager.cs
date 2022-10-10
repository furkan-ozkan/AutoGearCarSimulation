using _Game.Scripts.Player;
using TMPro;
using UnityEngine;

namespace _Game.Scripts.UI.InGame
{
    public class InGameUIPanelManager : MonoBehaviour
    {
        public TextMeshProUGUI gearTierText;
        public TextMeshProUGUI timerText;

        private void Update()
        {
            gearTierText.text = PlayerData.Instance.currentGearTier.ToString();
            timerText.text = (int)(PlayerData.Instance.raceTimer / 60) + ":" + (int)(PlayerData.Instance.raceTimer % 60);
        }
    
    }
}
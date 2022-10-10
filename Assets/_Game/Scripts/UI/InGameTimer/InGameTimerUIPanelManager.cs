using System.Collections;
using _Game.Scripts.GameData;
using TMPro;
using UnityEngine;

namespace _Game.Scripts.UI.InGameTimer
{
    public class InGameTimerUIPanelManager : MonoBehaviour
    {
        public TextMeshProUGUI countDownTimer;
        public string textAtTimerZero;
        public GameObject panel;

        private void Update()
        {
            UpdateTimerText();
        }

        private void UpdateTimerText()
        {
            if (countDownTimer.gameObject.activeSelf)
            {
                if (InGameTimerData.Instance.currentTimer > 0)
                {
                    if(InGameTimerData.Instance.currentTimer < 1)
                    {
                        countDownTimer.text = textAtTimerZero;
                        panel.SetActive(false);
                        StartCoroutine(CloseTimerText());
                    
                        IEnumerator CloseTimerText()
                        {
                            yield return new WaitForSeconds(1f);
                            countDownTimer.gameObject.SetActive(false);
                        }
                    }
                    else
                    {
                        countDownTimer.text = ((int)InGameTimerData.Instance.currentTimer).ToString();
                    }
                }
            }
        }
    }
}
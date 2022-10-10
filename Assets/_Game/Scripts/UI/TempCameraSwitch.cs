using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Game.Scripts.UI
{
    public class TempCameraSwitch : MonoBehaviour
    {
        public GameObject camOne, camTwo;
        public void SwitchCamera()
        {
            camOne.SetActive(!camOne.activeSelf);
            camTwo.SetActive(!camTwo.activeSelf);
        }

        public void RestartGame()
        {
            SceneManager.LoadScene(0);
        }
    }
}

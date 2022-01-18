using UnityEngine;

namespace UI
{
    public class Switcher : MonoBehaviour
    {
        [SerializeField] private GameObject mainUI;
        [SerializeField] private GameObject endScreen;

        private void Awake() => ActivateMainUI();
        
        private void ActivateMainUI()
        {
            mainUI.SetActive(true);
            endScreen.SetActive(false);
        }
        
        public void ActivateEndScreen()
        {
            mainUI.SetActive(false);
            endScreen.SetActive(true);
        }

        
    }    
}


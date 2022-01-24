using Commons;
using UnityEngine;

namespace Player
{
    public class Engine : GameEventListenerFloat
    {
        [SerializeField] private bool invertInput;
        [SerializeField] private GameObject[] fires;
        private float _inputValue;

        private void FixedUpdate()
        {
            if(_inputValue > 0) ActivateFires();
            else DeactivateFires();
        }

        public void GetInputValue(float value)
        {
            _inputValue = value;
            if (invertInput) _inputValue *= -1;
        }

        private void ActivateFires()
        {
            foreach (var var in fires)
            {
                var.gameObject.SetActive(true);
            }
        }
        
        private void DeactivateFires()
        {
            foreach (var var in fires)
            {
                var.gameObject.SetActive(false);
            }

            _inputValue = 0;
        }
    }    
}



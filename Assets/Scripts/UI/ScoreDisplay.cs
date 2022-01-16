using Commons;
using Player;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    [RequireComponent(typeof(Text))]
    public class ScoreDisplay : GameEventListener
    {
        [SerializeField] private Stats playerStats;
        [SerializeField] private ArrayGameObjects astronauts;

        private bool _updateText;

        private Text _score;

        private void Awake() => _score = GetComponent<Text>(); 
        
        private void Start() => SetTextToDisplay();

        private void LateUpdate() 
        {
            if (_updateText) UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            SetTextToDisplay();
            _updateText = !_updateText;
        }

        private void SetTextToDisplay()
        {
            _score.text = playerStats.RescuedAstronauts + " | " + astronauts.Array.Length;
        }

        public void ActivateTextUpdate() => _updateText = true;
    }    
}


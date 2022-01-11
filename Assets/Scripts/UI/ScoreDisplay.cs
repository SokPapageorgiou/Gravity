using System;
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

        private Text _score;

        private void Awake() => _score = GetComponent<Text>(); 
        
        private void Start() => SetTextToDisplay();
        
        public void SetTextToDisplay()
        {
            _score.text = playerStats.RescuedAstronauts + " | " + astronauts.Array.Length;
        }
    }    
}


using System;
using Commons;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    [RequireComponent(typeof(Text))]
    public class ScoreDisplay : MonoBehaviour
    {
        [SerializeField] private ArrayGameObjects astronauts;

        private Text _score;

        private void Awake()
        {
            _score = GetComponent<Text>();
        }

        private void Start()
        {
            SetTextToDisplay();
        }

        private void SetTextToDisplay()
        {
            _score.text = "0 | " + astronauts.Array.Length;
        }
    }    
}


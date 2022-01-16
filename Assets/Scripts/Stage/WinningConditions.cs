using Commons;
using Player;
using UnityEngine;

namespace Stage
{
    public class WinningConditions : GameEventListener
    {
        [SerializeField] private Stats playerStats;
        [SerializeField] private ArrayGameObjects astronauts;
        [SerializeField] private GameEvent onWinnig;

        private bool _hasScoreChanged;

        private void LateUpdate()
        {
            if (_hasScoreChanged)
            {
                CheckWinCondition();
                _hasScoreChanged = !_hasScoreChanged;
            }
        }

        private void CheckWinCondition()
        {
            if (HasWon()) onWinnig.Raise();
        }

        private bool HasWon()
        {
            return playerStats.RescuedAstronauts == astronauts.Array.Length;
        }

        public void ScoreChanges() => _hasScoreChanged = true;
    }    
}


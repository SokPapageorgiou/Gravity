using System;
using Commons;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(PlayerStatsLoader))]
    public class Score : GameEventListener
    {
        private Stats _playerStats;

        private void Awake()
        {
            _playerStats = GetComponent<PlayerStatsLoader>().playerStats;
        }

        public void OnScore()
        {
            _playerStats.GetAstronaut();
        }
    }    
}


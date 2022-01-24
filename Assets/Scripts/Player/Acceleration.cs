using Commons;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(PlayerStatsLoader))]
    public class Acceleration : GameEventListenerFloat
    {
        private Rigidbody _rigidbody;
        private Stats _playerStats;
        
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _playerStats = GetComponent<PlayerStatsLoader>().playerStats;
        }
        
        public void Accelerate(float input)
        {
            _rigidbody.AddForce(input * _playerStats.Speed * transform.forward, ForceMode.Acceleration);
        }
    }
    
}

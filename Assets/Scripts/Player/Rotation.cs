using Commons;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(PlayerStatsLoader))]
    public class Rotation : GameEventListenerFloat
    {
        private Rigidbody _rigidbody;
        private Stats _playerStats;
        
        private Vector3 _eulerVelocityAngle;
        private Quaternion _deltaRotation;
        
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _playerStats = GetComponent<PlayerStatsLoader>().playerStats;

            _eulerVelocityAngle = new Vector3(0, _playerStats.AngularSpeed, 0);
        }
        
        public void Rotate(float input)
        {
            Debug.Log("Rotation has been called");
            _deltaRotation = Quaternion.Euler(input * Time.fixedDeltaTime * _eulerVelocityAngle);
            _rigidbody.MoveRotation(_rigidbody.rotation * _deltaRotation);
        }
    }    
}


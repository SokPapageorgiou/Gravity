using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(PlayerStatsLoader))]
    public class Controller : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private Stats _playerStats;
        
        private Vector3 _eulerVelocityAngle;
        private Quaternion _deltaRotation;

        private static float _verticalInput;
        private static float _horizontalInput;
        
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _playerStats = GetComponent<PlayerStatsLoader>().playerStats;

            _eulerVelocityAngle = new Vector3(0, _playerStats.AngularSpeed, 0);
        }

        private void Update()
        {
            _verticalInput = Input.GetAxis("Vertical");
            _horizontalInput = Input.GetAxis("Horizontal");
        }

        private void FixedUpdate()
        {
            if(HasVerticalInput()) Accelerate();
            if(HasHorizontalInput()) Rotate();
        }

        private void Accelerate()
        {
            _rigidbody.AddForce(_verticalInput * _playerStats.Speed * transform.forward, ForceMode.Acceleration);
        }

        private void Rotate()
        {
            _deltaRotation = Quaternion.Euler(_horizontalInput * Time.fixedDeltaTime * _eulerVelocityAngle);
            _rigidbody.MoveRotation(_rigidbody.rotation * _deltaRotation);
        }

        private static bool HasVerticalInput()
        {
            return _verticalInput != 0;
        }

        private static bool HasHorizontalInput()
        {
            return _horizontalInput != 0;
        }
    }    
}


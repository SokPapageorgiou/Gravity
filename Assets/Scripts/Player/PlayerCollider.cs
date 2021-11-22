using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(PlayerStatsLoader))]
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Collider))]
    public class PlayerCollider : MonoBehaviour
    {
        private Stats _playerStats;

        private void Awake()
        {
            _playerStats = GetComponent<PlayerStatsLoader>().playerStats;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag($"Collectible"))
            {
                _playerStats.GetAstronaut();
                other.gameObject.SetActive(false);
            }
        }

        private void OnCollisionEnter(Collision other)
        {
            this.gameObject.SetActive(false);
        }
    }    
}


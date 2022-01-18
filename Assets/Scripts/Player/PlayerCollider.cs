using Commons;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Collider))]
    public class PlayerCollider : MonoBehaviour
    {
        [SerializeField] private GameEvent onLosing;
        private void OnCollisionEnter(Collision other)
        {
            if (!other.gameObject.CompareTag("Astronaut"))
            {
                this.gameObject.SetActive(false);
                onLosing.Raise();
            }
        }
    }    
}


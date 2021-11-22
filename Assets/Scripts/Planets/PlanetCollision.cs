using UnityEngine;

namespace Planet
{
    [RequireComponent(typeof(SphereCollider))]
    public class PlanetCollision : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            other.gameObject.SetActive(false);
        }
    }
    
}

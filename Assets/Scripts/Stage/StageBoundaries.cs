using UnityEngine;

namespace Stage
{
    [RequireComponent(typeof(Collider))]
    public class StageBoundaries : MonoBehaviour
    {
        private void OnTriggerExit(Collider other)
        {
            other.gameObject.SetActive(false);
        }
    }    
}


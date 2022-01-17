using Commons;
using UnityEngine;
using UnityEngine.Serialization;

namespace Stage
{
    [RequireComponent(typeof(Collider))]
    public class StageBoundaries : MonoBehaviour
    {
        [SerializeField] private GameEvent onLosing;
        
        private void OnTriggerExit(Collider other) 
        {
            if (other.CompareTag("Player"))
            {
                other.gameObject.SetActive(false);
                onLosing.Raise();
            }    
        }
    }    
}


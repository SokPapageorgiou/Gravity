using Commons;
using UnityEngine;

namespace Stage
{
    public class AstronautCounter : MonoBehaviour
    {
        [SerializeField] private ArrayGameObjects astronauts;
        private void Awake()
        {
            astronauts.Array = GameObject.FindGameObjectsWithTag("Astronaut");
        }
    }    
}


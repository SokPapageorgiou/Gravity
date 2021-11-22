using Player;
using UnityEngine;

namespace Stage
{
    public class Initializer : MonoBehaviour
    {
        [SerializeField] private Vector3 initialPosition;
        
        [SerializeField] private GameObject player;
        [SerializeField] private GameObject spaceStation;

        private void Awake()
        {
            player.transform.position = initialPosition;
            spaceStation.transform.position = initialPosition;
            
            player.GetComponent<PlayerStatsLoader>().playerStats.ResetAstronauts();
        }
    }    
}


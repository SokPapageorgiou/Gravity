using Player;
using UnityEngine;

namespace Stage
{
    public class Initializer : MonoBehaviour
    {
        [SerializeField] private Stats playerStats;

        private void Awake() => playerStats.ResetAstronauts();
    }    
}


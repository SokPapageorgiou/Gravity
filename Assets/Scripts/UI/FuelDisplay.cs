using Player;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    [RequireComponent(typeof(PlayerStatsLoader))]
    public class FuelDisplay : MonoBehaviour
    {
        private Stats _playerStats;
        private Text _text;

        private void Awake()
        {
            _playerStats = GetComponent<PlayerStatsLoader>().playerStats;
            _text = GetComponent<Text>();
        }

        private void LateUpdate()
        {
            _text.text = "Fuel: " + _playerStats.FuelAmount + "%";
        }
    }    
}


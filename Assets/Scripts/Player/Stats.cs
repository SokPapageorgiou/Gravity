using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Player
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Player/Stats", fileName = "PlayerStats")]
    public class Stats : ScriptableObject
    {
        [Header("Movement")]
        [SerializeField] private float speed;
        [SerializeField] private float angularSpeed;

        [Header("Fuel")] 
        [SerializeField] private int fuelAmount;
        [SerializeField] private float fuelConsumeRate;
        
        [Header("Score")]
        [SerializeField] private int astronauts;
        [SerializeField] private int winnigCondition;
        
        public float Speed => speed;
        public float AngularSpeed => angularSpeed;

        public int FuelAmount => fuelAmount;
        public float FuelConsumeRate => fuelConsumeRate;
        
        public int WinningCondition
        {
            set => winnigCondition = value;
        }
        
        public void GetAstronaut()
        {
            astronauts++;
        }

        public void ResetAstronauts()
        {
            astronauts = 0;
        }
        
        
    }    
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Player/Stats", fileName = "PlayerStats")]
    public class Stats : ScriptableObject
    {
        [Header("Movement")]
        [SerializeField] private float speed;
        [SerializeField] private float angularSpeed;

        public float Speed => speed;
        public float AngularSpeed => angularSpeed;
    }    
}

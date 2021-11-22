using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Planet
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Planet/Stats", fileName = "PlanetStats")]
    public class PlanetStats : ScriptableObject
    {
        [Header("Planet's Transform")] 
        [SerializeField] private float scale;

        [Header("Physics")]
        [SerializeField] private float mass;

        [SerializeField] private float gravityFieldScale;

        [Header("GameObjects")] 
        public GameObject planet;

        public GameObject gravityField;

        

        public float Scale => scale;
        public float Mass => mass;
        public float GravityFieldScale => gravityFieldScale;

        
    }
}

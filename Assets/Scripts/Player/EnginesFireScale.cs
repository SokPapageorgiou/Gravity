using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Player
{
    public class EnginesFireScale : MonoBehaviour
    {
        [SerializeField] private float minX;
        [SerializeField] private float minZ;

        private void FixedUpdate()
        {
            var scaleX = Random.Range(minX, 1);
            var scaleZ = Random.Range(minZ, 1);
            
            transform.localScale = new Vector3(scaleX, 1, scaleZ);
        }
    }    
}


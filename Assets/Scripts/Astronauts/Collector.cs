using System;
using Commons;
using UnityEngine;

namespace Astronaut
{
    public class Collector : MonoBehaviour
    {
        [SerializeField] private GameEvent onCollectThis;

        private void OnCollisionEnter(Collision other)
        {
            onCollectThis.Raise();
            
            this.gameObject.SetActive(false);
        }
    }    
}


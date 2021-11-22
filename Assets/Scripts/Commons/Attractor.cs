using System;
using Interfaces;
using UnityEngine;

namespace Commons
{
    [RequireComponent(typeof(Rigidbody))]
    public class Attractor : MonoBehaviour, IAttractable
    {
        private Rigidbody _rigidbody;

        public bool InRange { get; set; }

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void PullThis(Transform planet, float planetsMass)
        {
            Vector3 direction = this.transform.position - planet.position;
            float distance = direction.magnitude;

            float forceMagnitude = planetsMass / Mathf.Pow(distance, 2);
            Vector3 force = -forceMagnitude * direction.normalized;
            
            _rigidbody.AddForce(force);
        }
    }    
}


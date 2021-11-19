using System;
using Interfaces;
using UnityEngine;

namespace GravityField
{
    public class Puller : MonoBehaviour
    {
        private void OnTriggerStay(Collider other)
        {
            IAttractable iAttractable = other.gameObject.GetComponent<IAttractable>();
            iAttractable?.PullThis(this.transform, 10);
        }
    }    
}


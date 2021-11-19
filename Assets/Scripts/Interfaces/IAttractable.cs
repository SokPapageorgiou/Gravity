using UnityEngine;

namespace Interfaces
{
    public interface IAttractable
    {
        public bool InRange { get; set; }
        
        public void PullThis(Transform planet, float planetsMass);
    }    
}


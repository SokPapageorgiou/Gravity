using UnityEngine;

namespace Player
{
    public class EnginesFireScale : MonoBehaviour
    {
        [SerializeField] private float minX;
        [SerializeField] private float minY;
        [SerializeField] private float minZ;

        private Vector3 _scaleMultiplier;

        private void Awake() => _scaleMultiplier = transform.localScale;
        
        private void FixedUpdate() => SetScale();
        
        private void SetScale() => transform.localScale = GenerateScaleValues();
       
        private Vector3 GenerateScaleValues()
        {
            var scaleX = SetScaleValue(minX, _scaleMultiplier.x);
            var scaleY = SetScaleValue(minY, _scaleMultiplier.y);
            var scaleZ = SetScaleValue(minZ, _scaleMultiplier.z);
            
            return new Vector3(scaleX, scaleY, scaleZ);
        }

        private float SetScaleValue(float min, float multiplier)
            => Random.Range(min, 1) * multiplier;
        
    }    
}


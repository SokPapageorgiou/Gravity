using System;
using Commons;
using UnityEngine;

namespace Player
{
    public class InputListner : MonoBehaviour
    {
        [Header("Input Events")]
        [SerializeField] private GameEventFloat vertical;
        [SerializeField] private GameEventFloat horizontal;

        private float _verticalValue;
        private float _horizontalValue;
        
        private void Update() => GetInputAxis();
        private void FixedUpdate() => RaiseEvents(); 
        
        private void RaiseEvents()
        {
            vertical.Raise(_verticalValue);
            horizontal.Raise(_horizontalValue);
        }

        private void GetInputAxis()
        {
            _verticalValue = Input.GetAxis("Vertical");
            _horizontalValue = Input.GetAxis("Horizontal");
        }
    } 
}


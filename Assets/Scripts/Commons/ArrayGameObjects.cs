using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Commons
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Values/Array", fileName = "NewArray")]
    public class ArrayGameObjects : ScriptableObject
    {
        [SerializeField] private GameObject[] array;

        public GameObject[] Array
        {
            get => array;
            set => array = value;
        }
    }    
}



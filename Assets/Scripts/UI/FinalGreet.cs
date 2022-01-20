using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UI
{
    public class FinalGreet : MonoBehaviour
    {
        [SerializeField] private Text text;
        
        public void DisplayYouWin() => text.text = "You Win!";
        public void DisplayYouLose() => text.text = "You Lose...";
    }    
}


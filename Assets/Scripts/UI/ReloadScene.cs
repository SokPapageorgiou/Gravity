using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class ReloadScene : MonoBehaviour
    {
        public void ReloadCurrentScene() => 
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }    
}


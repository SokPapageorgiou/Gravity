using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class SceneLoader : MonoBehaviour
    {
        public void LoadScene(string scene)
        {
            Debug.Log("LoadScene has been called");
            SceneManager.LoadScene(scene);
        }
    }    
}


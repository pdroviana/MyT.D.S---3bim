using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
     public string sceneName;
    
    
        public void Load()
        {
            SceneManager.LoadScene(sceneName);
        }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

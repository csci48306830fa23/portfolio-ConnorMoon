using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Scene1Func()
    {
        
        SceneManager.LoadScene("Demo8Scene 1");
    }
    public void Scene2Func()
    {
       
        SceneManager.LoadScene("Demo8Scene");
    }
}

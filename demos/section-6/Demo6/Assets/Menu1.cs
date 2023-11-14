using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu1 : MonoBehaviour
{

    [SerializeField]
    public GameObject menu;

    



    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

      
            
        


    }

    public void menuButtonFunc()
    {

        SceneManager.LoadScene("Demo6Scene");
    }
    public void menuShow()
    {
        StartCoroutine(ShowAndHideMenu());
        
    }
    IEnumerator ShowAndHideMenu()
    {
        menu.SetActive(true);

        // Wait for 2 seconds (adjust this value as needed)
        yield return new WaitForSeconds(3f);

        menu.SetActive(false);
    }

}

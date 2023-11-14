using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    private bool levelSelBool = false;
    private bool menuBool = false;
    private bool gameBool = false;
    
    [SerializeField]
    public GameObject menuText;
    
    [SerializeField]
    public GameObject menuButton;

    [SerializeField]
    public GameObject exitButton;

    [SerializeField]
    public GameObject levelSelText;

    [SerializeField]
    public GameObject level1Button;

    [SerializeField]
    public GameObject level2Button;

    [SerializeField]
    public GameObject level3Button;
    
    [SerializeField]
    public GameObject backButton;

    // Start is called before the first frame update
    void Start()
    {
        menuBool = true;
        levelSelBool = false;
        gameBool = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (menuBool)
        {
            menuText.SetActive(true);
            menuButton.SetActive(true);
            exitButton.SetActive(true);
            levelSelText.SetActive(false);
            backButton.SetActive(false);
            level1Button.SetActive(false);
            level2Button.SetActive(false);
            level3Button.SetActive(false);
        }
        if (levelSelBool)
        {
            levelSelText.SetActive(true);
            backButton.SetActive(true);
            level1Button.SetActive(true);
            level2Button.SetActive(true);
            level3Button.SetActive(true);
            menuText.SetActive(false);
            menuButton.SetActive(false);
            exitButton.SetActive(false);
           
        }
    }

    public void playButtonFunc()
    {
        // Set menu to false
        menuBool = false;
        levelSelBool = true;
        gameBool = false;
    }
    public void backButtonFunc()
    {
        // Set menu to false
        menuBool = true;
        levelSelBool = false;
        gameBool = false;
    }
    public void level1ButtonFunc()
    {
        // Set menu to false
        menuBool = false;
        levelSelBool = false;
        gameBool = true;
        SceneManager.LoadScene("Demo6Scene 2");
    }
    public void level2ButtonFunc()
    {
        // Set menu to false
        menuBool = false;
        levelSelBool = false;
        gameBool = true;
        SceneManager.LoadScene("Demo6Scene 3");
    }
    public void level3ButtonFunc()
    {
        // Set menu to false
        menuBool = false;
        levelSelBool = false;
        gameBool = true;
        SceneManager.LoadScene("Demo6Scene 4");
    }
    public void exitFunc()
    {
        Application.Quit();
    }
}

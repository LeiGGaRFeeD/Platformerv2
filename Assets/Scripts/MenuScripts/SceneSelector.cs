using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
    int startedGame;
    private bool _debug = false;
    // Start is called before the first frame update
    void Start()
    {
        startedGame = PlayerPrefs.GetInt("startedGame");
    }
    public void QuitFromGame()
    {
        Debug.Log("Quit from application");
        Application.Quit();
    }
    public void GoToSceneSelector()
    {
        startedGame = PlayerPrefs.GetInt("startedGame");
        if (startedGame == 1)
        {
            Debug.Log("Go to scene selection");
            SceneManager.LoadScene("LevelSelect");
        }
        else
        {
            PlayerPrefs.SetInt("startedGame", 1);
          //  GoToLevelOne();
            SceneManager.LoadScene("FirstDialog");
        }
    }
    public void GoToLevelOne()
    {
        Debug.Log("Go to level one");
        SceneManager.LoadScene("LevelOne");
    }
    public void GoToLevelTwo()
    {
        Debug.Log("Go to level two");
        SceneManager.LoadScene("LevelTwo");
    }
    public void GoToLevelThree()
    {
        Debug.Log("Go to level three");
        SceneManager.LoadScene("LevelThree");
    }
    public void GoToMainMenu()
    {
        Debug.Log("Go to main menu");
        SceneManager.LoadScene("MainMenu");
    }
    // Update is called once per frame
    void Update()
    {

        if (_debug == false)
        {
            Debug.Log("Debug is ON");
            _debug = true;
        }
        else
        {
            Debug.Log("Debug is OFF");
            _debug = false;
        }
        if (_debug == true)
        {
            if (Input.GetKeyUp(KeyCode.R))
            {
                PlayerPrefs.SetInt("startedGame", 0);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugSceneCOntroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Debug.Log("Exit");
            Application.Quit();
        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Debug.Log("Go to level one");
            SceneManager.LoadScene("LevelOne");
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            Debug.Log("Go to level two");
            SceneManager.LoadScene("LevelTwo");
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            Debug.Log("Go to level three");
            SceneManager.LoadScene("LevelThree");
        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            Debug.Log("Go to map");
            SceneManager.LoadScene("LevelSelect");
        }
        if (Input.GetKeyUp(KeyCode.N))
        {
            Debug.Log("Go to main menu");
            SceneManager.LoadScene("MainMenu");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("Go to dialog scene");
            SceneManager.LoadScene("FirstDialog");
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            Debug.Log("Clearing your progress");
            
        }
    }
}

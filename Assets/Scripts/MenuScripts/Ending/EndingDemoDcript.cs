using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndingDemoDcript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            Debug.Log("Go To Main Menu");
            SceneManager.LoadScene("MainMenu");
        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            Debug.Log("Go To Level Select");
            SceneManager.LoadScene("LevelSelect");
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Debug.Log("Quiting...");
            //SceneManager.LoadScene("MainMenu");
            Application.Quit();
        }

    }
}

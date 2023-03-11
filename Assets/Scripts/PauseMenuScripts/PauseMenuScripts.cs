using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuScripts : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject canvasPause;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            Debug.Log("Game resumed");
            Time.timeScale = 1.0f;
            canvasPause.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            Debug.Log("Go to map");
            SceneManager.LoadScene("LevelSelect");
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Debug.Log("Quit from game");
            Application.Quit();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//ToDo реализовать levelID систему для перехода по уровням
public class WinZone : MonoBehaviour
{
    // Start is called before the first frame update
    private int levelOpened;
    void Start()
    {
        levelOpened = PlayerPrefs.GetInt("levelOpened");
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Level Completed");
        levelOpened++;
        PlayerPrefs.SetInt("levelOpened", levelOpened);
        // SceneManager.LoadScene("FinishScene");
        SceneManager.LoadScene("LevelSelect");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevelTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Go to level one ");
        SceneManager.LoadScene("LevelTwo");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

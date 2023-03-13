using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevelThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Go To Level Three");
        SceneManager.LoadScene("LevelThree");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

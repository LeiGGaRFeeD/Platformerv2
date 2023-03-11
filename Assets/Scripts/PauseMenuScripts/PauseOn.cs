using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseOn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject canvasPause;
    void Start()
    {
        canvasPause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Debug.Log("Pause activated");
            Time.timeScale = 0;
            canvasPause.SetActive(true);
        }
    }
}

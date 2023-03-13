using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAllProgress : MonoBehaviour
{
    private bool _Pdebug;
    [SerializeField] GameObject progressResetedText;
    [SerializeField] GameObject titleText;
    // Start is called before the first frame update
    void Start()
    {
        progressResetedText.SetActive(false);
        titleText.SetActive(true);
    }

    public void ResetButton()
    {
        Debug.Log("Reset all progress");
        PlayerPrefs.SetInt("levelOpened", 1);
        PlayerPrefs.SetInt("money", 0);
        PlayerPrefs.SetInt("startedGame", 0);
        progressResetedText.SetActive(true);
        titleText.SetActive(false);
        InvokeRepeating("TurningOffText", 1.5f,0);
    }
    private void TurningOffText()
    {
        progressResetedText.SetActive(false);
        titleText.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.B)){
            if (_Pdebug == false)
            {
                Debug.Log("Debug progress is On");
                _Pdebug = true;
            }
            else
            {
                Debug.Log("Debug progress is Off");
                _Pdebug = false;
            }
        }
        if (_Pdebug == true)
        {
            if (Input.GetKeyUp(KeyCode.T))
            {
                Debug.Log("Reset all progress");
                PlayerPrefs.SetInt("levelOpened",1);
                PlayerPrefs.SetInt("money", 0);
                PlayerPrefs.SetInt("startedGame", 0);
            }
        }
    }
}

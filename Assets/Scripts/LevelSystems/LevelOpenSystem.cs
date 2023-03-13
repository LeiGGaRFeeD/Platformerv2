using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOpenSystem : MonoBehaviour
{
    private int _level = 0;
    [SerializeField] GameObject bridgeToLevelTwo;
    [SerializeField] GameObject bridgeToLevelThree;
    private bool _debug = false;
    // Start is called before the first frame update
    void Start()
    {
        _level = PlayerPrefs.GetInt("levelOpened");
        Debug.Log("Level opener system is working");
        bridgeToLevelTwo.SetActive(false);
        bridgeToLevelThree.SetActive(false);
    }
    public void LevelOpener() //Проверяет и добавляет мосты, когда уровень открыт
    {
        switch (_level)
        {
            case 0:
                Debug.Log("Не ломай мою игру:)");
                break;
                case 1:
                {
                    Debug.Log("Level One open");
                    break;
                }
                case 2:
                {
                    Debug.Log("Level Two open");
                    bridgeToLevelTwo.SetActive(true);
                    break;
                }
            case 3:
                {
                    Debug.Log("Level Two open");
                    bridgeToLevelTwo.SetActive(true);
                    bridgeToLevelThree.SetActive(true);
                    break;
                }
            case 4:
                {
                    Debug.Log("Level Two open");
                    bridgeToLevelTwo.SetActive(true);
                    bridgeToLevelThree.SetActive(true);
                    break;
                }
        }
    }
    // Update is called once per frame
    void Update()
    {
        LevelOpener();
        if (Input.GetKeyUp(KeyCode.L))
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
        }
        if (_debug == true)
        {
            if (Input.GetKeyUp(KeyCode.K))
            {
                _level++;
                Debug.Log("Level is: "+_level);
                PlayerPrefs.SetInt("levelOpened", _level);
            }
            if (Input.GetKeyUp(KeyCode.J))
            {
                _level--;
                Debug.Log("Level is: " + _level);
                PlayerPrefs.SetInt("levelOpened", _level);
            }
        }
    }
}

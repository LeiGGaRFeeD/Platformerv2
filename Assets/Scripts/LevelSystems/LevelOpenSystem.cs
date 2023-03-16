using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOpenSystem : MonoBehaviour
{
    private int _level = 0;
    [SerializeField] GameObject bridgeToLevelTwo;
    [SerializeField] GameObject bridgeToLevelThree;
    private bool _debug = false;

    [SerializeField] GameObject levelCompletedOne;
    [SerializeField] GameObject levelCompletedTwo;
    [SerializeField] GameObject levelCompletedThree;
    // Start is called before the first frame update
    void Start()
    {
        _level = PlayerPrefs.GetInt("levelOpened");
        Debug.Log("Level opener system is working");
        bridgeToLevelTwo.SetActive(false);
        bridgeToLevelThree.SetActive(false);
        levelCompletedOne.SetActive(false);
        levelCompletedTwo.SetActive(false);
        levelCompletedThree.SetActive(false);
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
                    levelCompletedOne.SetActive(true);
                    break;
                }
            case 3:
                {
                    Debug.Log("Level Two open");
                    bridgeToLevelTwo.SetActive(true);
                    bridgeToLevelThree.SetActive(true);
                    levelCompletedTwo.SetActive (true);
                    levelCompletedOne.SetActive (true);
                    break;
                }
            case 4:
                {
                    Debug.Log("Level Two open");
                    bridgeToLevelTwo.SetActive(true);
                    bridgeToLevelThree.SetActive(true);
                    levelCompletedTwo.SetActive(true);
                    levelCompletedOne.SetActive(true);
                    levelCompletedThree.SetActive (true);
                    break;
                }
            case > 4:
                {
                    Debug.Log("All opened!");
                    bridgeToLevelTwo.SetActive(true);
                    bridgeToLevelThree.SetActive(true);
                    levelCompletedTwo.SetActive(true);
                    levelCompletedOne.SetActive(true);
                    levelCompletedThree.SetActive(true);
                    break;
                }
            case < 0:
                {
                    _level = 1;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDebug : MonoBehaviour
{
    // Start is called before the first frame update
    private bool _debugMode;
    [SerializeField] GameObject debugMoneyCanvas;
    [SerializeField] Text debugMoneyText;
    public static int _money;
   // [SerializeField]text
    void Start()
    {
        _debugMode = false;
       _money = PlayerPrefs.GetInt("money");
    }

    // Update is called once per frame
    void Update()
    {
      //  _money = PlayerPrefs.GetInt("money");
        debugMoneyText.text = _money.ToString(); //Постоянное обновление
        if (Input.GetKeyUp(KeyCode.O))
        {
            if (_debugMode ==false)
            {
                Debug.Log("Debug mode is ON");
                _debugMode=true;
                debugMoneyCanvas.SetActive(true);
            }
            else
            {
                Debug.Log("Debug mode is OFF");
                _debugMode = false;
                debugMoneyCanvas.SetActive(false);
            }
        }
        if (_debugMode == true)
        {
            if (Input.GetKeyUp(KeyCode.Y))
            {
                Debug.Log("Money set to 100");
                _money = 100;
                PlayerPrefs.SetInt("money", _money);
            }
            if (Input.GetKeyUp(KeyCode.U))
            {
                Debug.Log("Money set to 0");
                _money = 0;
                PlayerPrefs.SetInt("money", _money);
            }
            if (Input.GetKeyUp(KeyCode.I))
            {
                Debug.Log("Loaded money");
                _money = PlayerPrefs.GetInt("money");
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTestSystem : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text dialogOne;
    [SerializeField] Text dialogTwo;
    private int _state = 0;
    void Start()
    {
        _state = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            switch (_state)
            {
                case 1:
                    {
                        dialogOne.text = "Test one";
                        _state = 2;
                        break;
                    }
                case 2:
                    {
                        dialogTwo.text = "Test two";
                        _state = 3;
                        break;
                    }
                case 3:
                    {
                        dialogOne.text = "Test one more";
                        _state = 4;
                        break;
                    }
                case 4:
                    {
                        dialogTwo.text = "Test two more";
                        _state = 5;
                        break;
                    }
            }
        }
    }
}

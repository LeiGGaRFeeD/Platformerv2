using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogTestSystem : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text dialogOne;
    [SerializeField] Text dialogTwo;
    [SerializeField] Text name;

    private string _firstName = "????";
    private string _secondName = "Friend";

    [SerializeField] GameObject TitleObj;
    [SerializeField] GameObject TitleBackgroundObj;

    [SerializeField] GameObject wasdKeys;
    [SerializeField] GameObject spaceKey;
    [SerializeField] GameObject evilGuy;
    private int _state = 0;

    private AudioSource _audio;

    void Start()
    {
        _audio = GetComponent<AudioSource>();
        _state = 1;
        name.text = _firstName;
        InvokeRepeating("TitleDissappear", 2f, 0);
    }
    void TitleDissappear()
    {
        Debug.Log("Title is off");
        TitleObj.SetActive(false);
        TitleBackgroundObj.SetActive(false);
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
                        dialogOne.text = "Wake up";
                        _state = 2;
                        _audio.Play();
                        break;
                    }
                case 2:
                    {
                        dialogTwo.text = "...";
                        _state = 3;
                        _audio.Play();
                        break;
                    }
                case 3:
                    {
                        dialogOne.text = "WAKE UP!!!!";
                        _state = 4;
                        _audio.Play();
                        break;
                    }
                case 4:
                    {
                        dialogTwo.text = "Uhh.. Where i am?";
                        _state = 5;
                        _audio.Play();
                        break;
                    }
                case 5:
                    {
                        dialogOne.text = "You in... your mind. Dont ask how.";
                        _state++;
                        _audio.Play();
                        break;
                    }
                case 6:
                    {
                        dialogTwo.text = "Ok. But who are you?";
                        _state++;
                        _audio.Play();
                        break;
                    }
                case 7:
                    {
                        dialogOne.text = "I am Friend";
                        _state++;
                        name.text = _secondName;
                        _audio.Play();
                        break;
                    }
                case 8:
                    {
                        dialogTwo.text = "What is my purpose?";
                        _state++;
                        _audio.Play();
                        break;
                    }
                case 9:
                    {
                        dialogOne.text = "You need to destroy him";
                        _state++;
                        evilGuy.SetActive(true);
                        _audio.Play();
                        break;
                    }
                case 10:
                    {
                        dialogTwo.text = "How i can navigate in this world?";
                        _state++;
                        _audio.Play();
                        break;
                    }
                case 11:
                    {
                        dialogOne.text = "Use this to control";
                        _state++;
                        evilGuy.SetActive(false);
                        wasdKeys.SetActive(true);
                        _audio.Play();
                        break;
                    }
                case 12:
                    {
                        dialogTwo.text = "Do i need to know something else?";
                        _state++;
                        _audio.Play();
                        break;
                    }
                case 13:
                    {
                        dialogOne.text = "Use this to jump";
                        _state++;
                        wasdKeys.SetActive(false);
                        spaceKey.SetActive(true);
                        _audio.Play();
                        break;
                    }
                case 14:
                    {
                        dialogOne.text = "Ready to big dangerous adventure?";
                        _state++;
                        _audio.Play();
                        break;
                    }
                case 15:
                    {
                        dialogTwo.text = "Yeah! Like never before!";
                        _state++;
                        spaceKey.SetActive(false);
                        _audio.Play();
                        break;
                    }
                case 16:
                    {
                        Debug.Log("Go To level one");
                        SceneManager.LoadScene("LevelOne");
                        break;
                    }
            }
        }
    }
}

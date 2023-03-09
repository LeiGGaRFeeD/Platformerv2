using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private bool _debug;
    private bool _meshStatus = false;
    private bool _collStatus = false;
    // Start is called before the first frame update
    void Start()
    {
        _debug = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerScript>())
        {
            Application.LoadLevel(Application.loadedLevel); //Перезапуск
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Z))
        {
            if (_debug == false)
            {
                Debug.Log("Debug is ON");
                _debug = true;
            }
            else //if (_debug == true)
            {
                Debug.Log("Debug is OFF");
                _debug = false;
            }
        }
        if (_debug == true)
        {
            if (Input.GetKeyUp(KeyCode.X))
            {
                if (_meshStatus == true)
                {
                    Debug.Log("Mesh Renderer is OFF");
                    gameObject.GetComponent<MeshRenderer>().enabled = false;
                    _meshStatus = false;
                }
                else
                {
                    Debug.Log("Mesh Renderer is ON");
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    _meshStatus = true;
                }
            }


            if (Input.GetKeyUp(KeyCode.C))
            {
                if (_collStatus == true)
                {
                    Debug.Log("Collider is Off");
                    gameObject.GetComponent<BoxCollider>().enabled = false;
                    _collStatus = false;
                }
                else
                {
                    Debug.Log("Collider if ON");
                    gameObject.GetComponent<BoxCollider>().enabled = true;
                    _collStatus = true;
                }
            }

        }
    }
}

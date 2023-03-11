using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeySystem : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject keyCanvas;
    [SerializeField] GameObject bridge;
    private bool _keyCollected = false;
   // [SerializeField] GameObject ;
    void Start()
    {
        keyCanvas.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Key collected");
        keyCanvas.SetActive(true);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        _keyCollected = true;
        InvokeRepeating("Destroying",2,0);
    }
    public void Destroying()
    {
        keyCanvas.SetActive(false);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if (_keyCollected == true)
        {
            bridge.SetActive(true);
        }
        if (_keyCollected == false)
        {
            bridge.SetActive(false);
        }
    }
}

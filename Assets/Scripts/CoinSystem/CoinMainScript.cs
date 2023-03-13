using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMainScript : MonoBehaviour
{
    int money;
    private AudioSource _audio;
    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
     //  money = PlayerPrefs.GetInt("money");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerScript>())
        {
            _audio.Play();
            money++;
          //  PlayerPrefs.SetInt("money",money);
          MoneyDebug._money = MoneyDebug._money+1;
           gameObject.GetComponent<SpriteRenderer>().enabled = false;
            InvokeRepeating("Destroing", 1.5f, 0);
        }
    }
    private void Destroing()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(1f, 0f, 1f); //Вращение монетки
    }
}

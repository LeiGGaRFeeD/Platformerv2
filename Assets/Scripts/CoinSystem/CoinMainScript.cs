using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMainScript : MonoBehaviour
{
    int money;
    // Start is called before the first frame update
    void Start()
    {
     //  money = PlayerPrefs.GetInt("money");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerScript>())
        {
            money++;
          //  PlayerPrefs.SetInt("money",money);
          MoneyDebug._money = MoneyDebug._money+1;
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(1f, 0f, 1f); //Вращение монетки
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMainScript : MonoBehaviour
{
    int money;
    // Start is called before the first frame update
    void Start()
    {
       money = PlayerPrefs.GetInt("money");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
  /*  private void OnCollisionEnter(Collision collision)
    {
        if (collision<GetComponent>(PlayerScript)){

        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerScript>() == true)
        {
            Debug.Log("You dead");
            Application.LoadLevel(Application.loadedLevel); //Перезапуск
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

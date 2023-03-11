using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectSpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DestroyingSpawnCamera", 2f, 0);
    }
    void DestroyingSpawnCamera()
    {
        Debug.Log("Camera destroied");
        Destroy(gameObject); //”ничтожение камеры
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

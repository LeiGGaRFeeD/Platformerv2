using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScoreSystem : MonoBehaviour
{
    private float _time;
    private float _maxTime = 1000;
    // Start is called before the first frame update
    void Start()
    {
        _time = 0;
    }

    // Update is called once per frame
    void Update()
    {
//        Debug.Log("Now time is " + _time);
        _time = _time + 1f * Time.deltaTime;

    }
}

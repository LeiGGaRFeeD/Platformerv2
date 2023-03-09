using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class FollowCamera : MonoBehaviour
{

    public GameObject player; // тут объект игрока
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

}
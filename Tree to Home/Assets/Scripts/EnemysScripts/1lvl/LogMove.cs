using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMove : MonoBehaviour
{
    float move = -14;
    public float speed;

    void Update()
    {
        move += speed;
        transform.position = new Vector3(move, transform.position.y, 0);
    }
}

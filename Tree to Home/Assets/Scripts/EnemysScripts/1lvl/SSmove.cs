using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSmove : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * -speed * Time.deltaTime;
    }
}

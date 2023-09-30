using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadPL : MonoBehaviour
{
   
    void Start()
    {
        
    }

   
    void Update()
    {
        float x = transform.position.x;
        if(transform.position.y <= -6f)
        {
            SceneManager.LoadScene(0);
        }
        if(transform.position.y >= 10f)
        {
            transform.position = new Vector3(x, 7f, 0);
        }
        
    }
}

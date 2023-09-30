using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BigStoneDestroy : MonoBehaviour
{
    void Start()
    {
        Invoke("des", 5f);
    }

    void Update()
    {

    }

    void des()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }
}

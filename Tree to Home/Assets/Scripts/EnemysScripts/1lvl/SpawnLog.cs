using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLog : MonoBehaviour
{
    public GameObject enemy;
    Vector2 posSpawn;
    float random;
    public float spawnTime = 2;
    float nextSpawn;
    float go;


    void Update()
    {
        go += 0.03f;
        if (go >= 200f)
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnTime + 3;
                random = Random.Range(0.10f, -3.7f);
                posSpawn = new Vector2(transform.position.x, random);
                Instantiate(enemy, posSpawn, Quaternion.identity);

            }
        }


    }
}

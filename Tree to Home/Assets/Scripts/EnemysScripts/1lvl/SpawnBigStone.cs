using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBigStone : MonoBehaviour
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
        if (go >= 100f)
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnTime + 3;
                random = Random.Range(-7, 7);
                posSpawn = new Vector2(random, transform.position.y);
                Instantiate(enemy, posSpawn, Quaternion.identity);

            }
        }


    }
}

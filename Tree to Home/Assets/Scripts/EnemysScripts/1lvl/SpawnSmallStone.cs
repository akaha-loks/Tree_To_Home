using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSmallStone : MonoBehaviour
{
    public GameObject enemy;
    public float randomX;
    Vector2 whereToSpawn;
    public float spawnDelay;
    float nextSpawn = 0.0f;
    float go;
    void Update()
    {
        if (transform.position.y >= 12f)
        {
            Destroy(enemy);
        }
        if (transform.position.y <= -6f)
        {
            Destroy(enemy);
        }
        go += 0.6f;
        if (go >= 200f)
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnDelay;
                randomX = Random.Range(-9.5f, 9.5f);
                whereToSpawn = new Vector2(randomX, transform.position.y);
                GameObject Enemy = Instantiate(enemy, whereToSpawn, Quaternion.identity);
                Destroy(Enemy, 3f);
            }
        }
    }
}

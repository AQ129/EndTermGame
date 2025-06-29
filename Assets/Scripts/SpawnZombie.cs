using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Enemy;
    public float xPos;
    public float zPos;
    public int enemyCount;
    public float spawnDelay = 15f;
    public float totalTime = 300f; // 5 minutes in seconds
    public float maxZ;
    public float minZ;
    public float maxX;
    public float minX;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        WaitForSeconds delay = new WaitForSeconds(spawnDelay);
        float timer = 0f;

        while (timer < totalTime)
        {
            for (int i = 0; i < enemyCount; i++)
            {
                xPos = Random.Range(minX, maxX+1);
                zPos = Random.Range(minZ, maxZ+1);
                Instantiate(Enemy, new Vector3(xPos, 2, zPos), Quaternion.identity);
            }

            enemyCount += 1;
            timer += spawnDelay;

            yield return delay;
        }
    }
}
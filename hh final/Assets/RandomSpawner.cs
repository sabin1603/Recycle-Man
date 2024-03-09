using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject quadPrefab;

    void Update()
    {
        int i = 0;
        int n = 100;
        while (i < n)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(53, 100), Random.Range(1,10), Random.Range(60, 110));
            Instantiate(quadPrefab, randomSpawnPosition, Quaternion.identity);
            i++;
        }
    }
}
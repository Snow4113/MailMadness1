using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{

    public GameObject objectToSpawn;
    public float spawnTime;
    private float spawnDelay;

    private void Update()
    {
        if(spawnDelay > 0)
        {
            spawnDelay -= Time.deltaTime;
        }
        else
        {
            spawnObject();
            spawnDelay = spawnTime;
        }
    }

    public void spawnObject()
    {
        Instantiate(objectToSpawn);
    }
}

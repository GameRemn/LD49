using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    public GameObject spawnObj;

    public void Spawn()
    {
        var transform1 = transform;
        Instantiate(spawnObj, transform1.position, transform1.rotation);
    }

    public void Spawn(Vector3 position)
    {
        Instantiate(spawnObj, position, transform.rotation);
    }

    public void SetSpawnObject(GameObject spawnObject)
    {
        spawnObj = spawnObject;
    }
}
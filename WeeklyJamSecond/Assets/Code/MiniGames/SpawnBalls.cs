using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnBalls : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject xxl;
    public int objectsToSpawn = 15;
    public int objectsDestroyed = 0;

    void Start()
    {
        for (int i = 0; i < objectsToSpawn; i++)
        {
            SpawnObject();
        }
    }

    void Update()
    {
        if (objectsDestroyed == objectsToSpawn)
        {
            xxl.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    void SpawnObject()
    {
        Vector3 position = new Vector3(Random.Range(-600f, 600f), Random.Range(-325f, 325f), 0.0f);

        GameObject objectInstance = Instantiate(objectToSpawn, position, Quaternion.identity);
    }
}
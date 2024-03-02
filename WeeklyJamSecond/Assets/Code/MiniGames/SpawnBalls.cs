using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnBalls : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject carpParents;
    public GameObject xxl;
    public int objectsToSpawn;
    public int objectsDestroyed;

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
        Vector3 position = new Vector3(Random.Range(400, 1450), Random.Range(150, 700), 0.0f);

        GameObject objectInstance = Instantiate(objectToSpawn, position, Quaternion.identity);
        objectInstance.transform.parent = carpParents.transform;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public SpawnBalls sb;
    private void OnEnable()
    {
        sb = GameObject.FindWithTag("Balls").GetComponent<SpawnBalls>();
    }
    public void OnCarpDown()
    {
        sb.objectsDestroyed++;
        Destroy(gameObject);
    }
}

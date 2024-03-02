using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public SpawnBalls sb;

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sb.objectsDestroyed++;
            Destroy(gameObject);
        }
    }
}

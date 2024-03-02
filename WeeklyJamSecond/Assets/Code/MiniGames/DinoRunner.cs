using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoRunner : MonoBehaviour
{
    public int speed = 15;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}

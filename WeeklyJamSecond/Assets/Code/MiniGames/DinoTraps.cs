using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoTraps : MonoBehaviour
{
    public DinoRunner runner;
    public Dino dino;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Dinosaur"))
        {
            runner.gameObject.transform.position = new Vector3(350, 124, 0);
            dino.gameObject.transform.position = new Vector3(28, 140, 0);
        }
    }
}

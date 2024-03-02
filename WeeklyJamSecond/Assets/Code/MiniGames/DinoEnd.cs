using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoEnd : MonoBehaviour
{
    public GameObject xxl;
    public GameObject GMB;
    public DinoRunner runner;
    public Dino dino;
    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.CompareTag("Dinosaur"))
       {
            xxl.SetActive(true);
            GMB.SetActive(false);
            runner.gameObject.SetActive(false);
       }
    }
}

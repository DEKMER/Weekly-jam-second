using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipAdThree : MonoBehaviour
{
    public GameObject Scam;
    public GameObject Skipped;

    public void BuyFillet()
    {
        Scam.SetActive(true); 
        gameObject.SetActive(false);
    }
    public void Skip()
    {
        Skipped.SetActive(true);
        gameObject.SetActive(false);
    }
}

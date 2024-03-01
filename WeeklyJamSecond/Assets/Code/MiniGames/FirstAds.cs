using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAds : MonoBehaviour
{
    public GameObject NextAd;
    public void CloseAd()
    {
        gameObject.SetActive(false);
        NextAd.SetActive(true);
    }
    public void Download()
    {
        System.Diagnostics.Process.Start("https://dekmer.itch.io/casstle-hero");
    }
}

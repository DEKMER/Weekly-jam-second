using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdsClosing : MonoBehaviour
{
    public GameObject FirstAds;
    public GameObject SpinningPage;
    public void CloseAd()
    {
        SpinningPage.SetActive(true);
        gameObject.SetActive(false);
    }
    public void Itch()
    {
        System.Diagnostics.Process.Start("https://itch.io");
    }
    public void CastleHero()
    {
        System.Diagnostics.Process.Start("https://dekmer.itch.io/casstle-hero");
    }
    public void GoAd()
    {
        FirstAds.SetActive(true);
        gameObject.SetActive(false);
    }
}

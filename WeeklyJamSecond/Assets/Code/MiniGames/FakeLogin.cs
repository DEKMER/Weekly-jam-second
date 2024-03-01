using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeLogin : MonoBehaviour
{
    public GameObject LoginPrefab;
    public GameObject AdsPrefab;
    public GameObject BuyScam;
    public void Login()
    {
        LoginPrefab.SetActive(true);
        AdsPrefab.SetActive(true);
        gameObject.SetActive(false);
    }
    public void BuyCaptcha()
    {
        LoginPrefab.SetActive(false);
        BuyScam.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPhishing : MonoBehaviour
{
    public GameObject Captcha;
    public void BuyFishRod() 
    {
        Captcha.SetActive(true);
        gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GenerateBuyButton : MonoBehaviour
{
    public int Timer;
    public GameObject BuyButton;
    public GameObject WaitText;
    public GameObject NextPage;
    public TMP_Text WaitTMP;
    private void OnEnable()
    {
        StartCoroutine(TimeDecrease());
        Timer = 10;
    }
    private void FixedUpdate()
    {
        WaitTMP.text = "Wait for " + Timer.ToString() + " seconds to generate buy button";
        if (Timer <= 0)
        {
            BuyButton.SetActive(true);
            WaitText.SetActive(false);
        }
    }
    public IEnumerator TimeDecrease()
    {
        yield return new WaitForSeconds(1);
        Timer -= 1;
        StartCoroutine(TimeDecrease());
    }
    public void PreFinalPage()
    {
        NextPage.SetActive(true);
        gameObject.SetActive(false);
    }
}

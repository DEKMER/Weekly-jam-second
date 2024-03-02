using TMPro;
using UnityEngine;

public class FakeLogin : MonoBehaviour
{
    public TMP_InputField[] LoginTexts;
    public GameObject LoginPrefab;
    public GameObject LoginText;
    public GameObject AdsPrefab;
    public GameObject BuyScam;
    public void Login()
    {
        if (LoginTexts[0].text == "Bobby Mobby-Fishman".ToString() && LoginTexts[1].text == "Carp4578".ToString())
        {
            LoginPrefab.SetActive(true);
            LoginText.SetActive(false);
            AdsPrefab.SetActive(true);
        }
    }
    public void BuyCaptcha()
    {
        LoginPrefab.SetActive(false);
        BuyScam.SetActive(true);
    }
}

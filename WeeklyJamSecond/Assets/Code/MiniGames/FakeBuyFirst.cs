using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeBuyFirst : MonoBehaviour
{
    public GameObject WinPanel;
    public GameObject OpenAdPanel;

    public void Win()
    {
        WinPanel.SetActive(true);
        gameObject.SetActive(false);
    }
    public void OpenAd()
    {
        OpenAdPanel.SetActive(true);
        gameObject.SetActive(false);
    }
}

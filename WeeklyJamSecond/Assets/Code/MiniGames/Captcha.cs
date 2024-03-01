using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VerifyTextInput : MonoBehaviour
{
    public GameObject toDestroy;
    public GameObject toCreate;
    public TMP_InputField inputField;
    public string correctText = "W68HP";

    public void CheckTextInput()
    {
        if (inputField.text == correctText)
        {
            Destroy(toDestroy);
            toCreate.SetActive(true);
        }
        else
        {
            inputField.text = ""; 
        }
    }
}

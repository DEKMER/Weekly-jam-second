using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerifyTextInput : MonoBehaviour
{
    public InputField inputField;
    public string correctText = "Yhheggd&6hdga";

    public void CheckTextInput()
    {
        if (inputField.text == correctText)
        {
            Destroy(gameObject); 
        }
        else
        {
            inputField.text = ""; 
        }
    }
}

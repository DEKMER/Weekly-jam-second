using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public GameObject SuccesBuyed;
    public void Buy()
    {
        SuccesBuyed.SetActive(true);
    }
    public void OpenURL()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        SceneManager.LoadScene(0);
    }
}

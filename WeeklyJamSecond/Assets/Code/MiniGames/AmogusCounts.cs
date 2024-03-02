using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmogusCounts : MonoBehaviour
{
    public GameObject NextPage;
    public GameObject[] Buttons;
    public int Count;
    public void Increase(int CountBut)
    {
        if (CountBut == (Count + 1))
        {
            Count = CountBut;
            Buttons[CountBut - 1].GetComponent<Image>().color = Color.green;
            Buttons[CountBut - 1].GetComponent<Button>().enabled = false;
        }
        else
        {
            Count = 0;
            for (int x = 0; x < Buttons.Length-1; x++)
            {
                Buttons[x].GetComponent<Image>().color = Color.white;
                Buttons[x].GetComponent<Button>().enabled = true;
            }
        }
        if (Count >= 10)
        {
            NextPage.SetActive(true);
        }
    }
}

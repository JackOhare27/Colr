using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openCredits : MonoBehaviour
{
    public GameObject[] credits, menu;
    public void openCredit()
    {
        for(int i = 0; i <= credits.Length-1; i++)
        { credits[i].SetActive(true); }
        for (int i = 0; i <= menu.Length-1; i++)
        { menu[i].SetActive(false); }
    }
}

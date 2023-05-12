using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour
{
    public GameObject titleScreen, activeGame;
    public void beginGame()
    {
        
        titleScreen.SetActive(false);
        activeGame.SetActive(true);


    }
}

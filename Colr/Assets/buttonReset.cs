using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class buttonReset : MonoBehaviour
{
    public GameObject scaler;
    public Color_Change color;
    public Correct_Click correct_Click;
    public CircleCollider2D[] reactivateColliders;
    public GameObject gameOverScreen, gameManager;
    public GameObject[] reactivateGameObjects, resetOtherCircles;
    public Timer timer;


    public void yabuya()
    {
        //Resets button sizes
        scaler.transform.localScale = new Vector3(1f, 1f, 1f);
        //Allows for shake animation
        timer.shakeOnce = true;
        //Resets score back to zero and to a 2x2
        correct_Click.amountCorrect = 0; correct_Click.moreDifficult = false; correct_Click.nextDifficult = false;
        //Returns color differentiation to beginning diff
        color.discrDifficulty = .10f;
        //Timer countdown
        timer.cntdnw = 10f;
        //Game over is false; game is active
        timer.gameOver = false;
        gameOverScreen.SetActive(false);
        //Re-enables game assets
        for (int i = 0; i < reactivateColliders.Length; i++)
        {
            reactivateColliders[i].enabled = true;
        }
        for (int i = 0; i < reactivateGameObjects.Length; i++)
        {
            reactivateGameObjects[i].SetActive(true);
        }


        //Other circles dont reset back to outside the map
        for(int i = 0; i < resetOtherCircles.Length; i++)
        {
            resetOtherCircles[i].transform.position = new Vector3(20, 20, 0);
        }
        gameManager.SetActive(false);
        gameManager.SetActive(true);
       // Debug.Log("yabuya");
    }
}

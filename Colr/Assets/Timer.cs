using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public soundController sound;
    public AudioSource crash;
    public Correct_Click correctTotal;
    public GameObject timerObject, gameOverScreen;
    public CircleCollider2D[] disableOnLoss;
    public bool gameOver = false;
    public bool shakeOnce = true;
    public float cntdnw = 10f;
    private int highscoreInt;
    public int privateHighScore;
    public Text disvar;
    public Text localScore, highScore;



   

    //Used to shake screen
    private Shake shake;
    private void Start()
    {
        
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }
    void Update()
    {
        if (gameOver == true)
        {
            while (shakeOnce)
            {
                if(sound.isSound)
                { crash.Play(); }
                
                shake.camShake();
                shakeOnce = false;
                for (int i = 0; i < disableOnLoss.Length; i++)
                {


                    disableOnLoss[i].enabled = false;


                }
                localScore.text = correctTotal.amountCorrect.ToString();
                highScore.text = PlayerPrefs.GetInt("privateHighScore").ToString();
                if (correctTotal.amountCorrect > highscoreInt)
                {
                    
                    highscoreInt = correctTotal.amountCorrect;
                    PlayerPrefs.SetInt("privateHighScore", highscoreInt);
                    highScore.text = PlayerPrefs.GetInt("privateHighScore").ToString();
                }

                timerObject.SetActive(false);
                gameOverScreen.SetActive(true);
            }
           
            



        }

        if (cntdnw > 0)
        {
            cntdnw -= Time.deltaTime;
        }
        //Turns to string and makes it look luke an int
        double b = System.Math.Round(cntdnw, 1);
        disvar.text = b.ToString();

        if (cntdnw <= 0 && gameOver == false)
        {
            gameOver = true;
            Debug.Log("Out of time");
        }
    }






  
}
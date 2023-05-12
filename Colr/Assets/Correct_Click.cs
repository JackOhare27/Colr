using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Correct_Click : MonoBehaviour
{
    private Touch touch;

    public GameObject scaler;
    public Transform parent;
    public soundController sound;
    public AudioSource correctSound;
    public GameObject plusOneText;
    public GameObject gameManager;
    public Color_Change cg;
    public Timer time;

    public bool moreDifficult = false, nextDifficult = false;

    public int amountCorrect;


    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Debug.Log("EOUCHHH");
        }
    }
    private void OnMouseDown()
    {
       // Handheld.Vibrate();
        //Plays correct sound
        if(sound.isSound)
        { 
        correctSound.Play();
        }
        //Adds second to countdown timer
        time.cntdnw += 1f;


        //Increases score after every 5 questions correct
        amountCorrect++;

        if (amountCorrect % 5 == 0)
            {
            //Check statement so it does not go to being brighter than possible or back dark
            if (cg.discrDifficulty <= 0)
                {
                    Debug.LogError("SHIT");
                    cg.discrDifficulty = Random.Range(.09f, 0.1f);
                }

              //  Debug.Log("Incremented");
                cg.discrDifficulty -= (.005f); //Makes difference in color incrementally harder
            }
       // Debug.Log("Correct "+ amountCorrect);

        if (amountCorrect >= 50)
        {
            scaler.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f);
            nextDifficult = true;
        }
        else if (amountCorrect >= Random.Range(20,30))
            {
                
                scaler.transform.localScale = new Vector3(0.8f,0.8f,0.8f);
                moreDifficult = true;
            }


        Instantiate(plusOneText,parent);

        gameManager.SetActive(false);
        gameManager.SetActive(true);
    }

}

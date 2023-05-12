using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleManagement : MonoBehaviour
{
    //Used to check if we need to make the map more difficult
    public Correct_Click scoreConter;
    public Timer time;


    public Transform[] twoByTwo;
    public Transform[] twoByFour;
    public Transform[] fourByFour;
    public Transform[] circles;
    private int[] circleRandPlace = { 0, 1, 2, 3 };
    private int[] circleRandPlaceLong = { 0, 1, 2, 3, 4, 5, 6, 7 };
    private int[] circleRandPlaceFinal = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
    private int temp;
    
    // Start is called before the first frame update
    void Start()
    {
       
        Shuffle();
       for (int i = 0; i < twoByTwo.Length; i++)
        {
            Debug.Log(circleRandPlace[i]);
            circles[circleRandPlace[i]].transform.position = twoByTwo[i].transform.position;
        }
   
       /*
        * 
        * 
        * IF WANTING TO START OUT IN 2X4 MODE
        Shuffle();
        for (int i = 0; i < twoByFour.Length; i++)
        {
            Debug.Log(circleRandPlaceLong[i]);
            circles[circleRandPlaceLong[i]].transform.position = twoByFour[i].transform.position;
        }
       */
    }

    // Shuffles the array to allow for random placement of the correct answer
    void Shuffle()
    {
        if(scoreConter.moreDifficult == false)
        {
            for (int i = 0; i < circleRandPlace.Length; i++)
            {
                Debug.Log("Bruh moment");
                int rnd = Random.Range(0, circleRandPlace.Length);
                temp = circleRandPlace[rnd];
                circleRandPlace[rnd] = circleRandPlace[i];
                circleRandPlace[i] = temp;
            }
        }
        else if(scoreConter.moreDifficult == true && !scoreConter.nextDifficult)
        {
            for (int i = 0; i < circleRandPlaceLong.Length; i++)
            {
                int rnd = Random.Range(0, circleRandPlaceLong.Length);
                temp = circleRandPlaceLong[rnd];
                circleRandPlaceLong[rnd] = circleRandPlaceLong[i];
                circleRandPlaceLong[i] = temp;
            }
        }
        else if (scoreConter.moreDifficult == true && scoreConter.nextDifficult)
        {
            for (int i = 0; i < circleRandPlaceFinal.Length; i++)
            {
                int rnd = Random.Range(0, circleRandPlaceFinal.Length);
                temp = circleRandPlaceFinal[rnd];
                circleRandPlaceFinal[rnd] = circleRandPlaceFinal[i];
                circleRandPlaceFinal[i] = temp;
            }
        }


    }

    //Enabled whenever the player chooses the right answer
    private void OnEnable()
    {
        if (scoreConter.moreDifficult == false)
        {
            Shuffle();
            //if score is less than 10...
            for (int i = 0; i < twoByTwo.Length; i++)
            {
                //Debug.Log(circleRandPlace[i]); For figuring out order they are placed
                circles[circleRandPlace[i]].transform.position = twoByTwo[i].transform.position;
            }
        }
        else if (scoreConter.moreDifficult && !scoreConter.nextDifficult)
        {
            Shuffle();
            
            for (int i = 0; i < twoByFour.Length; i++)
            {
                //Debug.Log(circleRandPlace[i]); For figuring out order they are placed
                circles[circleRandPlaceLong[i]].transform.position = twoByFour[i].transform.position;
            }
        }
        else if (scoreConter.moreDifficult && scoreConter.nextDifficult)
        {
            Shuffle();

            for (int i = 0; i < fourByFour.Length; i++)
            {
                //Debug.Log(circleRandPlace[i]); For figuring out order they are placed
                circles[circleRandPlaceFinal[i]].transform.position = fourByFour[i].transform.position;
            }
        }
    }
}

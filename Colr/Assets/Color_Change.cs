using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

public class Color_Change : MonoBehaviour
{
    public SpriteRenderer[] normalCircs;
    public SpriteRenderer Distinguished;
    public float discrDifficulty = .1f;
    float x, y, z, bruh = 0f;
    

    void Awake()
    {
        ranges(); 
    }

    void Start()
    {
        
        for (int i = 0; i < normalCircs.Length; i++)
        {
            
            normalCircs[i].color = new Color(x,y,z);
            if (bruh >= .5f)
                {
                    Distinguished.color = new Color(x + discrDifficulty, y + discrDifficulty, z + discrDifficulty);
                }
            else
                {
                    Distinguished.color = new Color(x - discrDifficulty, y - discrDifficulty, z - discrDifficulty);
                }
        }
    }

    //On second time
    private void OnEnable()
    {
        ranges();

        for (int i = 0; i < normalCircs.Length; i++)
        {

            normalCircs[i].color = new Color(x, y, z);
            if (bruh >= .5f)
            {
                Distinguished.color = new Color(x + discrDifficulty, y + discrDifficulty, z + discrDifficulty);
            }
            else
            {
                Distinguished.color = new Color(x - discrDifficulty, y - discrDifficulty, z - discrDifficulty);
            }
        }
    }


    private void ranges()
    {
        x = Random.Range(.25f, .7f);
        if (x > .6)
        { y = Random.Range(.25f, .4f); }
        else
        { y = Random.Range(.25f, .7f); }

        z = Random.Range(.25f, .7f);
        bruh = Random.Range(0f, 1f);
    }
        

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrong_Click : MonoBehaviour
{
    public Transform parent;
    public soundController sound;
    public AudioSource wrongSound;
    public Timer time;
    public GameObject minusTextCounter;
    
    private void OnMouseDown()
    {
        if(sound.isSound)
        { 
           wrongSound.Play(); 
        }
        
        //Makes sure timer does not go negative
        if( time.cntdnw >= 1.5f)
        { 
        time.cntdnw -= 1.5f;
        }
        else
        {
            time.cntdnw = 0f;
        }
       // Debug.Log("Wrong Answer");

        Instantiate(minusTextCounter,parent); 
    }
}

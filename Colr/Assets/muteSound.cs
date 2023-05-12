using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muteSound : MonoBehaviour
{
    public soundController sound;
    public Sprite on, off;
    public Button button;

    public void Start()
    {
        if (sound.isSound == false)
        {
            button.image.sprite = off;

        }
    }
    public void mute()
    {
        if(button.image.sprite == on)
        { 
            button.image.sprite = off;
            sound.isSound = false;
        }
        else 
        {
            sound.isSound = true;
            button.image.sprite = on;
        }
        


    }
}

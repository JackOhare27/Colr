using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dissapear_Text : MonoBehaviour
{

    private float maxTime = .5f;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

            maxTime -= Time.deltaTime;
            text.color = new Color(text.color.r, text.color.g, text.color.b, maxTime + .2f);
            if (text.color.a <= 0)
            {
                Destroy(gameObject);
            }


    }


    private void OnEnable()
    {
        maxTime = 0.5f;
      
    }
}

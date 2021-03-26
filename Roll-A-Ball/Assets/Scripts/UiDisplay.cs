using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiDisplay : MonoBehaviour
{
    public Text displayText;
    private int count;
    private bool reverse;
    public Color upColor;
    public Image winImage;
    public Transform target;
    
    void Start()
    {
        displayText.text = "";
        displayText.color = upColor;
        winImage.gameObject.SetActive(true);
    }


    void Update()
    {
        if(reverse == false)
        {
            count = count + 1;
            displayText.text = "Count = " + count;
        }
        else
        {
            count = count - 1;
            displayText.text = "Count = " + count;
        }

        if(count >= 1000)
        {
            reverse = true;
            displayText.color = Color.red;
        }
        else if(count <= 0)
        {
            reverse = false;
            displayText.color = upColor;
        }

        

    }
}

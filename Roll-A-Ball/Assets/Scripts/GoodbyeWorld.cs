using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodbyeWorld : MonoBehaviour
{
    // sETTING UP BASIC PLAYER STATS
    public int playerHealth = 100;
    public float gameTime = 0.5f;
    public string welcomeMessage = "Oh no, not roll a ball again"; 
    public bool playerDead = false;

    void Start()
    {
        //CHECK IF PALYER IS DEAD
        if (playerHealth > 0)
        {
            print(welcomeMessage);
            playerDead = false;
        }
        else if (playerHealth == 0)
        {
            print("Just dead");
        }
        else
        {
            print("Get good scrub");
            playerDead = true;
        }

    }

    void Update()
    {

    }
    void Objection()
    {
        print("MOSHI MOSHI");
        if(0 == 0)
        {
            print("cool");
        }

    }

}

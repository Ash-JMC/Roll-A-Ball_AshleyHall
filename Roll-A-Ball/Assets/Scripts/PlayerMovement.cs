using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public float moveSpeed;
    private int score = 0;
    public Text displayText;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
        }
        float x = Input.GetAxis("Horizontal") * moveSpeed; 
        float z = Input.GetAxis("Vertical") * moveSpeed;
        rb.AddForce(x, 0, z);

        
    }
    private void OnTriggerEnter(Collider otherObject)
    {
        if(otherObject.tag == "Pickup")
        {
            Destroy(otherObject.gameObject);
            score = score + 1;
            print("Score = " + score);
            if (score >= 8)
            {
                displayText.text = "Winner";
            }
            //score += 1;
            //score++;
            //All three do the same thing, add 1 to score
        }
    }
}

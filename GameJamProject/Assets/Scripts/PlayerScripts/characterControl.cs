using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControl : MonoBehaviour
{
    private int jumpCount = 0;
    private bool isSlide;
    private Rigidbody2D rigidbody;
    public int jumpForce = 10;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && jumpCount < 2 && gameObject.CompareTag("Player1"))
        {
            jump();
        }
        if (Input.GetKeyDown(KeyCode.S) && isSlide == false && gameObject.CompareTag("Player1"))
        {
            slide();
        }
        if (Input.GetKeyDown(KeyCode.O) && jumpCount < 2 && gameObject.CompareTag("Player2"))
        {
            jump();
        }
        if (Input.GetKeyDown(KeyCode.L) && isSlide == false && gameObject.CompareTag("Player2"))
        {
            slide();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpCount = 0;
        
    }

    void jump()
    {
        Debug.Log("W");
        rigidbody.AddForce(new Vector2(0f, jumpForce));
        jumpCount++;
    }

    void slide()
    {

    }
}

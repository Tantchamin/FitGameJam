using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControl : MonoBehaviour
{
    private int jumpCount = 0;
    private bool isSlide;
    private Rigidbody2D rigidbody;
    public int jumpForce = 500;
    private Animator anim;
    private ItemList itemList;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        itemList = GameObject.FindGameObjectWithTag("ItemList").GetComponent<ItemList>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Vertical") && jumpCount < 2 && gameObject.CompareTag("Player1"))
        {
            jump();
        }
        if (Input.GetKeyDown(KeyCode.S) && isSlide == false && gameObject.CompareTag("Player1"))
        {
            slide();
        }
        if (Input.GetKeyDown(KeyCode.E) && isSlide == false && gameObject.CompareTag("Player1"))
        {
            useItem1();
        }

        if (Input.GetKeyDown(KeyCode.O) && jumpCount < 2 && gameObject.CompareTag("Player2"))
        {
            jump();
        }
        if (Input.GetKeyDown(KeyCode.L) && isSlide == false && gameObject.CompareTag("Player2"))
        {
            slide();
        }
        if (Input.GetKeyDown(KeyCode.P) && isSlide == false && gameObject.CompareTag("Player2"))
        {
            useItem2();
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

    void useItem1()
    {
        if(itemList.player1_Item[0].GetComponent<Item1>() != false)
        {
            itemList.player1_Item.RemoveAt(0);
        }
        else if (itemList.player1_Item[0].GetComponent<Item2>() != false)
        {
            itemList.player1_Item.RemoveAt(0);
        }
        else if (itemList.player1_Item[0].GetComponent<Item3>() != false)
        {
            itemList.player1_Item.RemoveAt(0);
        }
    }

    void useItem2()
    {
        if (itemList.player2_Item[0].GetComponent<Item1>() != false)
        {
            itemList.player2_Item.RemoveAt(0);
        }
        else if (itemList.player2_Item[0].GetComponent<Item2>() != false)
        {
            itemList.player2_Item.RemoveAt(0);
        }
        else if (itemList.player2_Item[0].GetComponent<Item3>() != false)
        {
            itemList.player2_Item.RemoveAt(0);
        }
    }
}

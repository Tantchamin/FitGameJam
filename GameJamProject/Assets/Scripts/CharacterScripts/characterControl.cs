using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class characterControl : MonoBehaviour
{
    private int jumpCount = 0;
    private bool isSlide = false;
    private Rigidbody2D rigidbody;
    public int jumpForce = 500;
    private Animator anim;
    private ItemList itemList;
    private Collider2D collider;
    private float StateValue;
    private float usingItemValue;

    public GameObject itemBangFai, itemTukTuk;
    public GameObject spawnPoint;

    private bool isRun;

    private EnvironmentHitPlayer environment;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        itemList = GameObject.FindGameObjectWithTag("ItemList").GetComponent<ItemList>();
        environment = GetComponent<EnvironmentHitPlayer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (StateValue <= 1 && StateValue>0 && jumpCount < 2 && gameObject.CompareTag("Player1"))
        {
            jump();
        }
        if (StateValue <-0.5 &&StateValue >= -1 && gameObject.CompareTag("Player1"))
        {
            slide();
        }
        if (usingItemValue != 0 && isSlide == false && gameObject.CompareTag("Player1"))
        {
            useItem1();
        }

        if (StateValue <= 1 && StateValue > 0 && jumpCount < 2 && gameObject.CompareTag("Player2"))
        {
            jump();
        }
        if (StateValue < 0 && StateValue >= -1 && isSlide == false && gameObject.CompareTag("Player2"))
        {
            slide();
        }
        if (usingItemValue != 0 && isSlide == false && gameObject.CompareTag("Player2"))
        {
            useItem2();
        }
        else if (StateValue >-0.5 && StateValue <=0)
        {
            Run();
        }

        anim.SetBool("isRun", isRun);
    }
    public void UpAndDownControl(InputAction.CallbackContext context)
    {
        StateValue = context.ReadValue<float>();
    }
    public void UsingItemControl(InputAction.CallbackContext context)
    {
        usingItemValue = context.ReadValue<float>();
    }
     void Run() { 
        jumpCount = 0;
        isRun = true;
        
    }

    void jump()
    {
        isRun = false;
        anim.SetTrigger("Jump");
        rigidbody.AddForce(new Vector2(0f, jumpForce));
        jumpCount++;
    }

    void slide()
    {
        isRun = false;
        isSlide = true;
        anim.SetTrigger("isSlide");

    }

    void useItem1()
    {
        if(itemList.player1_Item[0].GetComponent<Item1>() != false)
        {
            itemList.player1_Item.RemoveAt(0);
            Instantiate(itemBangFai, spawnPoint.transform.position, itemBangFai.transform.rotation);
        }
        else if (itemList.player1_Item[0].GetComponent<Item2>() != false)
        {
            itemList.player1_Item.RemoveAt(0);
            Instantiate(itemTukTuk, transform.position, itemTukTuk.transform.rotation);
            environment.enabled = false;
            Invoke("enableEnvironment", 5.0f);

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
            Instantiate(itemBangFai, spawnPoint.transform.position, itemBangFai.transform.rotation);

        }
        else if (itemList.player2_Item[0].GetComponent<Item2>() != false)
        {
            itemList.player2_Item.RemoveAt(0);
            Instantiate(itemTukTuk, transform.position, itemTukTuk.transform.rotation);
            environment.enabled = false;
            Invoke("enableEnvironment", 5.0f);
        }
        else if (itemList.player2_Item[0].GetComponent<Item3>() != false)
        {
            itemList.player2_Item.RemoveAt(0);
        }
    }

    void enableEnvironment()
    {
        environment.enabled = false;
    }
}

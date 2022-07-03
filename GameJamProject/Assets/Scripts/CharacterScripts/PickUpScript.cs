using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    private ItemList itemList;
    private int itemCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        itemList = GameObject.FindGameObjectWithTag("ItemList").GetComponent<ItemList>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            if (gameObject.CompareTag("Player1") && itemCount < 1)
            {
                itemList.player1_Item[0] = collision.gameObject;
                itemCount++;
                itemList.changeImage_Item1();
                collision.gameObject.SetActive(false);
            }
            else if (gameObject.CompareTag("Player2") && itemCount < 1)
            {
                itemList.player2_Item[0] = collision.gameObject;
                itemCount++;
                itemList.changeImage_Item2();
                collision.gameObject.SetActive(false);
            }
        }
    }
}

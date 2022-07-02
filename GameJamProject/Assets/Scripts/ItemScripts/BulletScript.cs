using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 20.0f;
    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player1" || collision.tag == "Player2" || collision.tag == "Wall")
        {
            Invoke("destroyBullet", 0.2f);
        }
    }

    private void destroyBullet()
    {
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentHitPlayer : MonoBehaviour
{
    public float knockBackDistant = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x + knockBackDistant, gameObject.transform.position.y);
        }
    }

}

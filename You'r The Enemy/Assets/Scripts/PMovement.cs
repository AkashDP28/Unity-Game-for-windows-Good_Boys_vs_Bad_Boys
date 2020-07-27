using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMovement : MonoBehaviour
{
    private Rigidbody2D MyBody;
    private float SpeedX, SpeedY;
    private void Awake()
    {
        MyBody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
       
            SpeedX = Random.Range(-6f, 6f);
            SpeedY = Random.Range(-6f, 6f);
            MyBody.velocity = new Vector2(SpeedX, SpeedY);

            Vector2 temp = transform.position;
            if (temp.x > 7.7f)
            {
                temp.x = 7.7f;
            }
            if (temp.x < -7.7f)
            {
                temp.x = -7.7f;
            }
            if (temp.y > 4f)
            {
                temp.y = 4f;
            }
            if (temp.y < -4f)
            {
                temp.y = -4f;
            }
            transform.position = temp;
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Egg")
        {
            Destroy(gameObject);
        }
    }
}//end

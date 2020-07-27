using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggScript : MonoBehaviour
{
    public float Speed;
    public Vector3 StartPosition;

   
    private void Update()
    {
            if (!Pspawnner.Stop)
            {
                Vector2 temp = transform.position;
                if (Input.GetKey(KeyCode.D))
                {
                    temp.x += Speed;
                }
                if (Input.GetKey(KeyCode.A))
                {
                    temp.x -= Speed;
                }
                if (Input.GetKey(KeyCode.W))
                {
                    temp.y += Speed;
                }
                if (Input.GetKey(KeyCode.S))
                {
                    temp.y -= Speed;
                }
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
       
    }
 
  
    }

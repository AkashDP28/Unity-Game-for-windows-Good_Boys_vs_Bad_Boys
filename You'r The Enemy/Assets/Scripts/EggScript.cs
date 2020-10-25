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
            float vertical = Input.GetAxis("Vertical")
            float horizontal = Input.GetAxis("Horizontal")
            Vector2 temp = transform.position;
                
            temp.x += Speed * horizontal;
            temp.y += Speed * vertical;
            
            temp.x = Mathf.Clamp(temp.x, -7.7f, 7.7f);
            temp.y = Mathf.Clamp(temp.y, -4f, 4f);

            transform.position = temp;
        }
    }
}

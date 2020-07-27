using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turner : MonoBehaviour
{
    public GameObject Green;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Red")
        {
            Destroy(collision.gameObject);
            Instantiate(Green, collision.gameObject.transform.position, Quaternion.identity);
        }
    }
}

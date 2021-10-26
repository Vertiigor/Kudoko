using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deletor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Bonus")
        {
            Destroy(collision.gameObject);
        }
    }
}

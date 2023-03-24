using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.collider.tag == "Bullet")
    {
        Destroy(gameObject);
    }

    if (collision.collider.tag == "Player")
    {
        Destroy(gameObject);
    }
}

}

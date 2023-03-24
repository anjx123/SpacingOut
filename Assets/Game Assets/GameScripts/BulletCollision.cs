using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.collider.tag == "Wall")
    {
        Destroy(gameObject);
    }

    if (collision.collider.tag == "Enemy")
    {
        Destroy(gameObject);
    }
}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D collision)
{

// Check out the tagging system, all sprites can be deemed as a wall and act as a collidor
    if (collision.collider.tag == "Wall")
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

    if (collision.collider.tag == "Enemy")
    {

   
    	SceneManager.LoadScene("Menu");
    

        //Make a Game Over screen instead of destroying your life savings every time player
        //walks into spike
    }
}
}

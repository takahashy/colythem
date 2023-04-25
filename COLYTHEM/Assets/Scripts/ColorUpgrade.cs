using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorUpgrade : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // change the player's color
            print("detecting collision with player");
            Destroy(gameObject); // destroy the color changer object
        }
    }    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorUpgrade : MonoBehaviour
{
    private SpriteRenderer Sprite;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // change the player's color
            Sprite = GetComponent<SpriteRenderer>();
            
            if (Sprite.sprite.name == "spritesheet (6)_5") GameHandler.upgraded[0] = true;
            if (Sprite.sprite.name == "spritesheet (6)_4") GameHandler.upgraded[1] = true;
            if (Sprite.sprite.name == "spritesheet (6)_2") GameHandler.upgraded[2] = true;
            
            Destroy(gameObject); // destroy the color changer object
        }
    }    
}

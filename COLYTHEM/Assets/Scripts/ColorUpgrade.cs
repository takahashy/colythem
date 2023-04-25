/*  ColorUpgrade.cs
 *  
 *  When the boss is defeated, the program spawns a game object of colorupgrade,
 *  which is the color of the shield that can be used now. Depending on the sprite
 *  object, it will detect which color to allow. 
 */

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
            Sprite = GetComponent<SpriteRenderer>();
            
            // orange is now allowed to be used
            if (Sprite.sprite.name == "spritesheet (6)_5") GameHandler.upgraded[0] = true;

            // green is now allowed to be used
            if (Sprite.sprite.name == "spritesheet (6)_4") GameHandler.upgraded[1] = true;

            // purple is now allowed to be used
            if (Sprite.sprite.name == "spritesheet (6)_2") GameHandler.upgraded[2] = true;

            Destroy(gameObject); // destroy the color changer object
        }
    }    
}

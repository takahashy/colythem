using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ColorSwitcher : MonoBehaviour
{
    private  SpriteRenderer spriteRenderer;
    public int LocalColor = GameHandler.color;

    void Start()
    {
        spriteRenderer  = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        LocalColor = GameHandler.color; 
        // Press 'r' to switch to red
        if (LocalColor == 1) {
            var darkred = Color.red * 0.5f;
            spriteRenderer.color = darkred;
        }

        // Press 'b' to switch to blue
        else if (LocalColor == 2)
        {
            spriteRenderer.color = Color.white;
        }

        // Press 'space' to switch to white
        else if (LocalColor == 3)
        {
            spriteRenderer.color = Color.clear;
        }
    }
}
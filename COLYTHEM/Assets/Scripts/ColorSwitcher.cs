using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ColorSwitcher : MonoBehaviour
{
    // private  SpriteRenderer spriteRenderer;
    private int LocalColor = GameHandler.color;
    public SpriteRenderer Red_Field;
    public SpriteRenderer Blue_Field;

    void Start()
    {

    }

    void Update()
    {
        LocalColor = GameHandler.color; 
        // Press 'r' to switch to red
        if (LocalColor == 1) {
            Red_Field.enabled = true;
            Blue_Field.enabled = false;
        }

        // Press 'b' to switch to blue
        else if (LocalColor == 2)
        {
            Red_Field.enabled = false;
            Blue_Field.enabled = true;
        }

        // Press 'o' to switch to orange
        else if (LocalColor == 3)
        {
            //spriteRenderer.color = Color.clear;
        }

        // Press 'g' to switch to g
        else if (LocalColor == 4)
        {
            //spriteRenderer.color = Color.clear;
        }

        // Press 'p' to switch to g
        else if (LocalColor == 5)
        {
            //spriteRenderer.color = Color.clear;
        }
    }
}
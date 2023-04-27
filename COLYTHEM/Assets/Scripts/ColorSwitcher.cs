using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ColorSwitcher : MonoBehaviour
{
    public SpriteRenderer Sprite;
    private int LocalColor = GameHandler.color;
    public SpriteRenderer Red_Field;
    public SpriteRenderer Blue_Field;
    public SpriteRenderer Green_Field;
    public SpriteRenderer Orange_Field;
    public SpriteRenderer Purple_Field;
    public SpriteRenderer Gray_Field;

    void Start()
    {

    }

    void Update()
    {
        LocalColor = GameHandler.color; 

        // color switch not on beat
        if (LocalColor == 0) {
            Red_Field.enabled = false;
            Blue_Field.enabled = false;
            Green_Field.enabled = false;
            Orange_Field.enabled = false;
            Purple_Field.enabled = false;
            Gray_Field.enabled = true;
        }

        // Press 'r' to switch to red
        else if (LocalColor == 1) {
            Red_Field.enabled = true;
            Blue_Field.enabled = false;
            Green_Field.enabled = false;
            Orange_Field.enabled = false;
            Purple_Field.enabled = false;
            Gray_Field.enabled = false;
        }

        // Press 'b' to switch to blue
        else if (LocalColor == 2)
        {
            Red_Field.enabled = false;
            Blue_Field.enabled = true;
            Green_Field.enabled = false;
            Orange_Field.enabled = false;
            Purple_Field.enabled = false;
            Gray_Field.enabled = false;
        }

        // Press 'o' to switch to orange
        else if (LocalColor == 3)
        {
            Red_Field.enabled = false;
            Blue_Field.enabled = false;
            Green_Field.enabled = false;
            Orange_Field.enabled = true;
            Purple_Field.enabled = false;
            Gray_Field.enabled = false;
        }

        // Press 'g' to switch to g
        else if (LocalColor == 4)
        {
            Red_Field.enabled = false;
            Blue_Field.enabled = false;
            Green_Field.enabled = true;
            Orange_Field.enabled = false;
            Purple_Field.enabled = false;
            Gray_Field.enabled = false;
        }

        // Press 'p' to switch to p
        else if (LocalColor == 5)
        {
            Red_Field.enabled = false;
            Blue_Field.enabled = false;
            Green_Field.enabled = false;
            Orange_Field.enabled = false;
            Purple_Field.enabled = true;
            Gray_Field.enabled = false;
        }
    }

    public void scale()
    {
        Sprite = GetComponent<SpriteRenderer>();
        Sprite.transform.localScale = new Vector3(0.5f, 0.5f, 1f);
    }
}
using UnityEngine;

public class ColorSwitcher : MonoBehaviour
{
    private  SpriteRenderer spriteRenderer ;

    void Start()
    {
        spriteRenderer  = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Press 'r' to switch to red
        if (Input.GetKeyDown(KeyCode.R)) {
            spriteRenderer.color = Color.red;
        }

        // Press 'b' to switch to blue
        else if (Input.GetKeyDown(KeyCode.B))
        {
            spriteRenderer.color = Color.white;
        }

        // Press 'space' to switch to white
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            spriteRenderer.color = Color.blue;
        }
    }
}
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
        if (Input.GetKeyDown(KeyCode.R)) {
            spriteRenderer.material.color = Color.red;
        }

        else if (Input.GetKeyDown(KeyCode.B))
        {
            spriteRenderer.material.color = Color.blue;
        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {
            spriteRenderer.material.color = Color.white;
        }
    }
}
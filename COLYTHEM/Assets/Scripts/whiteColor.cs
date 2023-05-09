using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sprite;
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = new Color (1, 1, 1, 1); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

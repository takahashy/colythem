using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float xspeed = 0f;
    public float yspeed = 0f;
    private int randomValue;
    // public SpriteRenderer treble;
    // public SpriteRenderer bass;
    // public SpriteRenderer eighth;
    // public SpriteRenderer eighthrest;
    // public SpriteRenderer flat;
    // public SpriteRenderer half;
    // public SpriteRenderer halfdot;
    // public SpriteRenderer halfrest;
    // public SpriteRenderer qrest;
    // public SpriteRenderer quarter;
    // public SpriteRenderer treble;
    // public SpriteRenderer whole;
    // public SpriteRenderer wholerest;
    public Sprite[] spriteList;

    // Start is called before the first frame update
    void Start()
    {
         int randomValue = Random.Range(0, 14);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[randomValue];
        StartCoroutine(DestroyBullet());
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector2 position = transform.position;
        position.x += xspeed;
        position.y += yspeed;
        transform.position = position;
        
    }

    void OnTriggerEnter2D(Collider2D collision){
              if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "RigidTilemap") {
                     Destroy (gameObject);
              }
       }

    IEnumerator DestroyBullet() {
        yield return new WaitForSeconds (2f);
        Destroy(gameObject);
    }
}

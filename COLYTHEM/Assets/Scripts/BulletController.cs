using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float xspeed = 0f;
    public float yspeed = 0f;

    // Start is called before the first frame update
    void Start()
    {
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
    IEnumerator DestroyBullet() {
        yield return new WaitForSeconds (5f);
        Destroy(gameObject);
    }
}

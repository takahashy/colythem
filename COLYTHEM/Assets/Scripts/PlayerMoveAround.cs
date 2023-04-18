using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMoveAround : MonoBehaviour {

    //public Animator anim;
    //public AudioSource WalkSFX;
    public Rigidbody2D rb2D;
    private bool FaceRight = true; // determine which way player is facing.
    public static float runSpeed = 10f;
    public float startSpeed = 10f;
    public bool isAlive = true;
    private Animator anim;
    public bool animate;    
    
    //for attacking
    public GameObject projectile;
    public float attackRange = 10;
    
    void Start(){
        // BoxCollider2D projectileCollider = projectile.AddComponent<BoxCollider2D>(); // add a BoxCollider2D component to the projectile
        // projectileCollider.isTrigger = false; 
        //anim = gameObject.GetComponentInChildren<Animator>();
        rb2D = transform.GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        // _gameobject = GameObject.FindWithTag("GameController").GetComponent<GameHandler>();
        // detects collision twice for everytime the projectile hits for some reason
        // current_lives = 3;
    }

    void Update(){
        //NOTE: Horizontal axis: [a] / left arrow is -1, [d] / right arrow is 1
        //NOTE: Vertical axis: [w] / up arrow, [s] / down arrow
        Vector3 hvMove = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        if (isAlive == true){
                transform.position = transform.position + hvMove * runSpeed * Time.deltaTime;
            //   transform.position = transform.position + hvMove;
                if (Input.GetKey(KeyCode.Space)) { //mouse left click detected
                    //ray = Camera.main.ScreenPointToRay(Input.mousePosition)
                    Attack(true);
                    FireProjectile();

                } else {
                    Attack(false);
                }

                if ((Input.GetAxis("Horizontal") != 0) || (Input.GetAxis("Vertical") != 0)){
                    UpdateAnimationAndMove(true);
                //     anim.SetBool ("Walk", true);
                //     if (!WalkSFX.isPlaying){
                //           WalkSFX.Play();
                //     }
                } else {
                    UpdateAnimationAndMove(false);
                //     anim.SetBool ("Walk", false);
                //     WalkSFX.Stop();
                }

                // Turning. Reverse if input is moving the Player right and Player faces left.
                if ((hvMove.x <0 && !FaceRight) || (hvMove.x >0 && FaceRight)){
                    playerTurn();
                }
        }
    }

    private void UpdateAnimationAndMove(bool moving) {
        if(anim){
                if (moving) {
                anim.SetBool("Walk", true);
                } else {
                anim.SetBool("Walk", false);
                }
        }
    }

    private void Attack(bool attacking) {
        if (anim) {
            if (attacking) {
                anim.SetBool("Attack", true);
            } else {
                anim.SetBool("Attack", false);
            }
        }
    }

    private void FireProjectile() {
        Vector2 position = transform.position;

        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            position.x += .5f;
            GameObject go = Instantiate(projectile, position, Quaternion.identity);
            go.GetComponent<BulletController>().xspeed = 0.15f;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            position.x -= .5f;
            GameObject go = Instantiate(projectile, position, Quaternion.identity);
            go.GetComponent<BulletController>().xspeed = -0.15f;


        }
        else if (Input.GetKeyDown(KeyCode.UpArrow)) {
            position.y += .5f;
            GameObject go = Instantiate(projectile, position, Quaternion.identity);
            go.GetComponent<BulletController>().yspeed = 0.15f;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            position.y -= .5f;
            GameObject go = Instantiate(projectile, position, Quaternion.identity);
            go.GetComponent<BulletController>().yspeed = -0.15f;
        }
    }

    private void playerTurn(){
        // NOTE: Switch player facing label
        FaceRight = !FaceRight;

        // NOTE: Multiply player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
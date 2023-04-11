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
    public int current_lives;
    public int starting_lives = 3;
    public Image livesImage; 
    public Text livesText;
    public Sprite[] musicNoteSprites;
    

    void Start(){
        //anim = gameObject.GetComponentInChildren<Animator>();
        rb2D = transform.GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();

        // detects collision twice for everytime the projectile hits for some reason
        current_lives = 6;
    }

    void Update(){
        //NOTE: Horizontal axis: [a] / left arrow is -1, [d] / right arrow is 1
        //NOTE: Vertical axis: [w] / up arrow, [s] / down arrow
        Vector3 hvMove = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        if (isAlive == true){
                transform.position = transform.position + hvMove * runSpeed * Time.deltaTime;
            //   transform.position = transform.position + hvMove;

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
                if (Input.GetMouseButtonDown(0)) { //mouse left click detected
                    //ray = Camera.main.ScreenPointToRay(Input.mousePosition)
                    Attack(true);

                } else {
                    Attack(false);
                }

                // Turning. Reverse if input is moving the Player right and Player faces left.
                if ((hvMove.x <0 && !FaceRight) || (hvMove.x >0 && FaceRight)){
                    playerTurn();
                }
        }
        UpdateLivesText();
    }

    void UpdateLivesText()
    {
        print("Lives: " + current_lives.ToString());
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            print("DETECTING COLLISION");
            current_lives--;
            // UpdateLivesText();
            // UpdateLivesImage();

            if (current_lives <= 0)
            {
                SceneManager.LoadScene("End Screen");
            }
            // print(current_lives);
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

    private void playerTurn(){
        // NOTE: Switch player facing label
        FaceRight = !FaceRight;

        // NOTE: Multiply player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
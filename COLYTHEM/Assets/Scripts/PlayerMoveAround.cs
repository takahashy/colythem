using System.Collections.Generic;
using System.Collections;
using UnityEngine;

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

      void Start(){
           //anim = gameObject.GetComponentInChildren<Animator>();
           rb2D = transform.GetComponent<Rigidbody2D>();
           anim = GetComponentInChildren<Animator>();

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

                  // Turning. Reverse if input is moving the Player right and Player faces left.
                 if ((hvMove.x <0 && !FaceRight) || (hvMove.x >0 && FaceRight)){
                        playerTurn();
                  }
            }
      }


      public void UpdateAnimationAndMove(bool moving) {
            if(anim){
                  if (moving) {
                  anim.SetBool("Walk", true);
                  } else {
                  anim.SetBool("Walk", false);
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
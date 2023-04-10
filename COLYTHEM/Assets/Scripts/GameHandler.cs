using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameHandler : MonoBehaviour {
    public GameObject textGameObject;
    public static int color;

    
    // Alex stuff for volume control of individual instruments
    //public AudioSource play;

    void Start () {
        

    }

    void Update () {
        // Press 'r' to switch to red
        if (Input.GetKeyDown(KeyCode.R)) {
            color = 1;
        }

        // Press 'b' to switch to blue
        else if (Input.GetKeyDown(KeyCode.B))
        {
            color = 2;
        }

        // Press 'space' to switch to white
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            color = 3;
        }
        
        // UpdateLivesText();
        // UpdateLivesImage();
    }

    // public void UpdateLives (int currlives) {
    //     // _livesImage.sprite = _liveSprites[currlives];
    // }

    

    


    // void UpdateLivesImage()
    // {
    //     current_lives = Mathf.Clamp(current_lives, 0, musicNoteSprites.Length - 1);
        
    //     // Set the sprite of the livesImage based on the current number of lives
    //     livesImage.sprite = musicNoteSprites[current_lives];
    // }

    // void FixedUpdate () {
    //     if ((lives <= 0) && (isEnd == false)){
    //         // SceneManager.LoadScene ("GameOver");
    //     }
    // }

    // public void AddLives (int nLives) {
    //     lives += nLives;
    //     UpdateLives();  
    // }

    // public void RemoveLives (int nLives) {
    //     lives += nLives;
    //     UpdateLives();  
    // }

    public void QuitGame() {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    // public void playerGetHit(int damage) {
    //     // check color of projectile vs color of player
    //     // if different, update player health with damage
    // }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameHandler : MonoBehaviour {
    public GameObject textGameObject;
    public static int color;
    private int prevColor;
    public Image livesImage; 
    public Sprite [] musicNoteSprites;

    private int counter = 0;
    public int beats = 0;
    private float timeElapsed = 0.0f;

    
    // Alex stuff for volume control of individual instruments
    //public AudioSource play;

    void Start () {
        counter = counter + 1;
    }

    void Update () {
        prevColor = color;
        // Press 'r' to switch to red
        if (Input.GetKeyDown(KeyCode.R)) {
            color = 1;
        }

        // Press 'b' to switch to blue
        else if (Input.GetKeyDown(KeyCode.B))
        {
            color = 2;
        }

        // Press 'o' to switch to orange
        else if (Input.GetKeyDown(KeyCode.O))
        {
            color = 3;
        }

        // Press 'g' to switch to green
        else if (Input.GetKeyDown(KeyCode.G))
        {
            color = 4;
        }

        // Press 'p' to switch to purple
        else if (Input.GetKeyDown(KeyCode.P))
        {
            color = 5;
        }

        // Increment the time elapsed since the last update
        timeElapsed += Time.deltaTime;

        // Check if .25 second has passed
        if (timeElapsed >= 0.2f)
        {
            // Reset the time elapsed
            timeElapsed = 0.0f;

            // Increment the counter
            beats = counter % 20;
            counter++;
        }

        // check if color switching was succesfuly on "beat" with 3/5 beat aceptance
        if(prevColor != color){
           if((counter%5) != 0) {
               color = 0;
           }
        }
    }

    public void UpdateLives(int current_lives)
    {
        print(current_lives);
        // int index = current_lives / 3;
        // if (index < 0) index = 0;
        livesImage.sprite = musicNoteSprites[current_lives];
    }
    
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

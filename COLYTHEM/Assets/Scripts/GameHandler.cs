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
    
    // Alex stuff for volume control of individual instruments
    //public AudioSource play;

    void Start () {
        counter = counter + 1;
    }

    void Update () {
        prevColor = color;

        
        // Press 'r' to switch to red
        if (Input.GetKeyDown(KeyCode.R)) {
            if (GameHandler_Rhythm.canColor){color = 1;}
            else {color = 0; Debug.Log("You are off-beat, my friend");}
        }

        // Press 'b' to switch to blue
        else if (Input.GetKeyDown(KeyCode.B))
        {
            if (GameHandler_Rhythm.canColor){color = 2;}
            else {color = 0; Debug.Log("You are off-beat, my friend");}
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

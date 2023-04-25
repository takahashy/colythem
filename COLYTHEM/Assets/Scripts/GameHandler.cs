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
    public int numLives = 3;
    public int shieldHealth;
    public bool winCondition = false;
    private int counter = 0;
    public int beats = 0;
    private char[] colors = {'n', 'r', 'b', 'o', 'g', 'p'};

    // keeps track of whether player can use that color shield
    public static bool [] upgraded = {false, false, false};

    void Start () {
        counter = counter + 1;
    }

    void Update () {
        prevColor = color;
        UpdateLives(numLives);

        if (numLives <= 0) {
            Debug.Log("You died.");
            SceneManager.LoadScene("End Screen");
        }
        
        if (winCondition == true) {
            SceneManager.LoadScene("Win Scene");
        }
        
        if (shieldHealth == 0) {
            color = 0;
        }
        
        // Press 'r' to switch to red
        if (Input.GetKeyDown(KeyCode.R)) {
            if (GameHandler_Rhythm.canColor){color = 1; shieldHealth = 3;}
            else {color = 0; Debug.Log("You are off-beat, my friend");}
        }

        // Press 'b' to switch to blue
        else if (Input.GetKeyDown(KeyCode.B))
        {
            if (GameHandler_Rhythm.canColor){color = 2; shieldHealth = 3;}
            else {color = 0; Debug.Log("You are off-beat, my friend");}
        }

        // Press 'o' to switch to orange
        else if (Input.GetKeyDown(KeyCode.O))
        {
            if (GameHandler_Rhythm.canColor && upgraded[0]){color = 3; shieldHealth = 3;}
            else {color = 0; Debug.Log("You are off-beat, my friend");}
        }

        // Press 'g' to switch to green
        else if (Input.GetKeyDown(KeyCode.G))
        {
            if (GameHandler_Rhythm.canColor && upgraded[1]){color = 4; shieldHealth = 3;}
            else {color = 0; Debug.Log("You are off-beat, my friend");}
        }

        // Press 'p' to switch to purple
        else if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameHandler_Rhythm.canColor && upgraded[2]){color = 5; shieldHealth = 3;}
            else {color = 0; Debug.Log("You are off-beat, my friend");}
        }
    }

    public void UpdateLives(int current_lives)
    {
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

    public void playerGetHit(int damage, char projColor) {
        // print("forcefield color: " + colors[color] + ", projColor: " + projColor);
        if (colors[color] == projColor) {
            print("no damage taken, well blocked!");
            shieldHealth--;
        } else {
            print("get hurt, nerd");
            // UpdateLives(numLives - 1);
            numLives--;
            print("now have " + numLives + " lives");
        }
        // check color of projectile vs color of player
        // if different, update player health with damage
    }
}

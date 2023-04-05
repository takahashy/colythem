using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameHandler : MonoBehaviour {
    public GameObject textGameObject;
    public static int color;
    public int lives;
    [SerializeField]
    private Sprite [] _liveSprites;
    [SerializeField]
    private Image _livesImage;
    
    // Alex stuff for volume control of individual instruments
    //public AudioSource play;

    void Start () {
        UpdateLives(lives);
    }

    void Update () {
        UpdateLives(lives);
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
    }

    public void UpdateLives (int currlives) {
        //_livesImage.sprite = _liveSprites[currlives];
    }

    public void damage () {
        lives--;
        UpdateLives(lives);
    }

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

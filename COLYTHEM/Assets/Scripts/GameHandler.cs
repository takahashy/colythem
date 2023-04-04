using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameHandler : MonoBehaviour {
    public GameObject textGameObject;
    public int color;
    public int lives;
    public bool isEnd = true;
    [SerializeField]
    private Sprite [] _liveSprites;
    [SerializeField]
    private Image _livesImage;

    void Start () {
        UpdateLives(lives);
        // if (isEnd){
        //     Cursor.lockState = CursorLockMode.None;
        //     Cursor.visible = true;
        // }
    }

    void Update () {
        UpdateLives(lives);
    }

    public void UpdateLives (int currlives) {
        _livesImage.sprite = _liveSprites[currlives];
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

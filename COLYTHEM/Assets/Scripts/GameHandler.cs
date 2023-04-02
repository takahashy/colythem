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

    void Start () {
        UpdateLives();
        // if (isEnd){
        //     Cursor.lockState = CursorLockMode.None;
        //     Cursor.visible = true;
        // }
    }

    void FixedUpdate () {
        if ((lives <= 0) && (isEnd == false)){
            // SceneManager.LoadScene ("GameOver");
        }
    }

    public void AddLives (int nLives) {
        lives += nLives;
        UpdateLives();  
    }

    public void RemoveLives (int nLives) {
        lives += nLives;
        UpdateLives();  
    }

    void UpdateLives () {
        // Text scoreTextB = textGameObject.GetComponent<Text>();
        // scoreTextB.text = "Lives: " + lives;
    }

    public void QuitGame() {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}

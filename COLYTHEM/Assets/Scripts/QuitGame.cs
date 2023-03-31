using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{

    public void QuitTheGame()
    {
        // Quit the game
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
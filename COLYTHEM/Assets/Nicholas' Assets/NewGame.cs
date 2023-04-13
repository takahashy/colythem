using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Running file");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void RestartGame()
    {
        Debug.Log("Testing!");
        SceneManager.LoadScene("Start Screen");
    }
}

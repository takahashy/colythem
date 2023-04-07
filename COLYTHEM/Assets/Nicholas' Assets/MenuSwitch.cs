using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MenuSwitch : MonoBehaviour
{
    
    public GameObject menu;
    public GameObject options;
    public AudioMixer mixer;
    public static float volumeLevel = 1.0f;
    private Slider sliderVolumeCtrl;

    void Start()
    {
        menuActive();
    }

    void Awake ()
    {
        SetLevel(volumeLevel);
    }
    
    public void SetLevel (float sliderValue)
    {
        // mixer.SetFloat("Volume", Mathf.Log10 (sliderValue) * 20);
        // volumeLevel = sliderValue;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            menuActive();
        }
    }
    
    public void menuActive()
    {
        menu.SetActive(true);
        options.SetActive(false);
    }
    
    public void optionsActive()
    {
        menu.SetActive(false);
        options.SetActive(true);
    }
    
    public void NewGame()
    {
        Debug.Log("New Scene!");
        SceneManager.LoadScene("Tutorial (Nick)");
    }
    
    public void fullScreen()
    {
        // Toggle fullscreen
        Screen.fullScreen = !Screen.fullScreen;
    }

    
}

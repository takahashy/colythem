using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PauseHandler : MonoBehaviour
{
    public GameObject playUI;
    public GameObject pauseUI;
    public static bool paused;
    public AudioMixer mixer;
    public AudioMixer DrumsMixer;
    public AudioMixer GuitarMixer;
    public static float volumeLevel = 1.0f;
    private Slider sliderVolumeCtrl;
    public static float maxVal;
    string thisLevel;

    void Awake ()
    {
        SetLevel(volumeLevel);
        thisLevel = SceneManager.GetActiveScene().name;
    }

    void Start()
    {
        Resume();
    }
    
    public void SetLevel (float sliderValue)
    {
        mixer.SetFloat("Volume", Mathf.Log10 (sliderValue) * 20);
        volumeLevel = sliderValue;
        if(thisLevel != "Start Screen"){
            maxVal = Mathf.Log10 (sliderValue) * 20;
            DrumsMixer.SetFloat("Drumsvol", maxVal);
            GuitarMixer.SetFloat("Guitarvol", maxVal);
        }
    }

    // checks every frame, fixed is per tick -> see how to define tick
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        playUI.SetActive(true);
        pauseUI.SetActive(false);
        paused = false;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        playUI.SetActive(false);
        pauseUI.SetActive(true);
        paused = true;
    }

    public void QuitGame(){
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}


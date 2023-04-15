using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PauseHandler : MonoBehaviour
{
    public GameObject playUI;
    public GameObject pauseUI;
    public static bool paused;
    public AudioMixer mixer;
    public static float volumeLevel = 1.0f;
    private Slider sliderVolumeCtrl;

    void Awake ()
    {
        SetLevel(volumeLevel);
    }

    void Start()
    {
        Resume();
    }
    
    public void SetLevel (float sliderValue)
    {
        mixer.SetFloat("Volume", Mathf.Log10 (sliderValue) * 20);
        volumeLevel = sliderValue;
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


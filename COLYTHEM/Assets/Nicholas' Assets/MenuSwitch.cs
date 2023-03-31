using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        // Get the Button component attached to the myButton GameObject
        Button buttonComponent = FindObjectOfType<Button>();

        // Add a listener for when the button is clicked
        buttonComponent.onClick.AddListener(optionsActive);
    }

    void Awake ()
    {
        SetLevel(volumeLevel);
    }
    
    public void SetLevel (float sliderValue)
    {
        mixer.SetFloat("Volume", Mathf.Log10 (sliderValue) * 20);
        volumeLevel = sliderValue;
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
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    private int LocalColor = GameHandler.color;
    public AudioMixer DrumsMixer;
    public AudioMixer GuitarMixer;
    public AudioMixer GreenMixer;
    public AudioMixer OrangeMixer;
    public AudioMixer BlueMixer;
    public AudioMixer RedMixer;
    public AudioMixer Purplemixer;

    // Update is called once per frame
    void Update()
    {
        LocalColor = GameHandler.color; 
        //StartCoroutine(FadeMixerGroup.StartFade(AudioMixer audioMixer, String exposedParameter, float duration, float targetVolume));
        
        // color switch not on beat
        if (LocalColor == 0) {
            // StartCoroutine(FadeMixerGroup.StartFade(RedMixer, "Redvol", 1f, 0.001f));
            // Red_Field.enabled = false;
            // Blue_Field.enabled = false;
            // Green_Field.enabled = false;
            // Orange_Field.enabled = false;
            // Purple_Field.enabled = false;
            // Gray_Field.enabled = true;
        }

        // Press 'r' to switch to red
        else if (LocalColor == 1) {
            StartCoroutine(FadeMixerGroup.StartFade(RedMixer, "Redvol", 1f, 1f));
            StartCoroutine(FadeMixerGroup.StartFade(BlueMixer, "Bluevol", 1f, 0.001f));
            // Red_Field.enabled = true;
            // Blue_Field.enabled = false;
            // Green_Field.enabled = false;
            // Orange_Field.enabled = false;
            // Purple_Field.enabled = false;
            // Gray_Field.enabled = false;
        }

        // Press 'b' to switch to blue
        else if (LocalColor == 2)
        {
            StartCoroutine(FadeMixerGroup.StartFade(RedMixer, "Redvol", 1f, 0.001f));
            StartCoroutine(FadeMixerGroup.StartFade(BlueMixer, "Bluevol", 1f, 1f));
            // Red_Field.enabled = false;
            // Blue_Field.enabled = true;
            // Green_Field.enabled = false;
            // Orange_Field.enabled = false;
            // Purple_Field.enabled = false;
            // Gray_Field.enabled = false;
        }

        // // Press 'o' to switch to orange
        // else if (LocalColor == 3)
        // {
        //     Red_Field.enabled = false;
        //     Blue_Field.enabled = false;
        //     Green_Field.enabled = false;
        //     Orange_Field.enabled = true;
        //     Purple_Field.enabled = false;
        //     Gray_Field.enabled = false;
        // }

        // // Press 'g' to switch to g
        // else if (LocalColor == 4)
        // {
        //     Red_Field.enabled = false;
        //     Blue_Field.enabled = false;
        //     Green_Field.enabled = true;
        //     Orange_Field.enabled = false;
        //     Purple_Field.enabled = false;
        //     Gray_Field.enabled = false;
        // }

        // // Press 'p' to switch to p
        // else if (LocalColor == 5)
        // {
        //     Red_Field.enabled = false;
        //     Blue_Field.enabled = false;
        //     Green_Field.enabled = false;
        //     Orange_Field.enabled = false;
        //     Purple_Field.enabled = true;
        //     Gray_Field.enabled = false;
        // }
    }
}

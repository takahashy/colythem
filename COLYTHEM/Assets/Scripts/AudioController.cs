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
    public AudioMixer PurpleMixer;


    void Start() {
        StartCoroutine(FadeMixerGroup.StartFade(RedMixer, "Redvol", 0.001f, 0.001f));
        StartCoroutine(FadeMixerGroup.StartFade(BlueMixer, "Bluevol", 0.001f, 0.001f));
        StartCoroutine(FadeMixerGroup.StartFade(GreenMixer, "Greenvol", 0.001f, 0.001f));
        StartCoroutine(FadeMixerGroup.StartFade(OrangeMixer, "Orangevol", 0.001f, 0.001f));
        StartCoroutine(FadeMixerGroup.StartFade(PurpleMixer, "Purplevol", 0.001f, 0.001f));
    }
    
    // Update is called once per frame
    void Update()
    {
        LocalColor = GameHandler.color; 
        //StartCoroutine(FadeMixerGroup.StartFade(AudioMixer audioMixer, String exposedParameter, float duration, float targetVolume));
        
        // color switch not on beat
        if (LocalColor == 0) {
            StartCoroutine(FadeMixerGroup.StartFade(RedMixer, "Redvol", 4f, 0.001f));
            StartCoroutine(FadeMixerGroup.StartFade(BlueMixer, "Bluevol", 4f, 0.001f));
            StartCoroutine(FadeMixerGroup.StartFade(GreenMixer, "Greenvol", 4f, 0.001f));
            StartCoroutine(FadeMixerGroup.StartFade(OrangeMixer, "Orangevol", 4f, 0.001f));
            StartCoroutine(FadeMixerGroup.StartFade(PurpleMixer, "Purplevol", 4f, 0.001f));
        }

        // Press 'r' to switch to red
        else if (LocalColor == 1) {
            StartCoroutine(FadeMixerGroup.StartFade(RedMixer, "Redvol", 4f, 1f));
            StartCoroutine(FadeMixerGroup.StartFade(BlueMixer, "Bluevol", 4f, 0.001f));
            StartCoroutine(FadeMixerGroup.StartFade(GreenMixer, "Greenvol", 4f, 0.001f));
            StartCoroutine(FadeMixerGroup.StartFade(OrangeMixer, "Orangevol", 4f, 0.001f));
            StartCoroutine(FadeMixerGroup.StartFade(PurpleMixer, "Purplevol", 4f, 0.001f));
        }

        // Press 'b' to switch to blue
        else if (LocalColor == 2)
        {
            StartCoroutine(FadeMixerGroup.StartFade(RedMixer, "Redvol", 4f, 0.001f));
            StartCoroutine(FadeMixerGroup.StartFade(BlueMixer, "Bluevol", 4f, 1f));
            StartCoroutine(FadeMixerGroup.StartFade(GreenMixer, "Greenvol", 4f, 0.001f));
            StartCoroutine(FadeMixerGroup.StartFade(OrangeMixer, "Orangevol", 4f, 0.001f));
            StartCoroutine(FadeMixerGroup.StartFade(PurpleMixer, "Purplevol", 4f, 0.001f));
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

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
    float maxVal = PauseHandler.maxVal;


    private float beatLength = 0.5f;

    //timer stuff
    private float theTimer = 0f;

    void Start() {
        RedMixer.SetFloat("Redvol", -79f);
        BlueMixer.SetFloat("Bluevol", -79f);
        GreenMixer.SetFloat("Greenvol", -79f);
        OrangeMixer.SetFloat("Orangevol", -79f);
        PurpleMixer.SetFloat("Purplevol", -79f);
    }
    
    // Update is called once per frame
    void FixedUpdate(){
        theTimer += 0.01f;
        if (theTimer >= beatLength){
            theTimer = 0;
            maxVal = PauseHandler.maxVal;
            Fading();
        }
    }

    void Fading()
    {
        LocalColor = GameHandler.color; 
        //StartCoroutine(FadeMixerGroup.StartFade(AudioMixer audioMixer, String exposedParameter, float duration, float targetVolume));
        
        // color switch not on beat
        if (LocalColor == 0) {
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, RedMixer, "Redvol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, BlueMixer, "Bluevol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, GreenMixer, "Greenvol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, OrangeMixer, "Orangevol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, PurpleMixer, "Purplevol", 0.3f, -79f));
        }

        // Press 'r' to switch to red
        else if (LocalColor == 1) {
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, RedMixer, "Redvol", 0.3f, maxVal));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, BlueMixer, "Bluevol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, GreenMixer, "Greenvol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, OrangeMixer, "Orangevol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, PurpleMixer, "Purplevol", 0.3f, -79f));
        }

        // Press 'b' to switch to blue
        else if (LocalColor == 2)
        {
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, RedMixer, "Redvol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, BlueMixer, "Bluevol", 0.3f, maxVal));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, GreenMixer, "Greenvol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, OrangeMixer, "Orangevol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, PurpleMixer, "Purplevol", 0.3f, -79f));
        }

        // Press 'o' to switch to orange
        else if (LocalColor == 3)
        {
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, RedMixer, "Redvol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, BlueMixer, "Bluevol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, GreenMixer, "Greenvol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, OrangeMixer, "Orangevol", 0.3f, maxVal));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, PurpleMixer, "Purplevol", 0.3f, -79f));
        }

        // Press 'g' to switch to green
        else if (LocalColor == 4)
        {
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, RedMixer, "Redvol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, BlueMixer, "Bluevol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, GreenMixer, "Greenvol", 0.3f, maxVal));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, OrangeMixer, "Orangevol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, PurpleMixer, "Purplevol", 0.3f, -79f));
        }

        // Press 'p' to switch to purple
        else if (LocalColor == 5)
        {
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, RedMixer, "Redvol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, BlueMixer, "Bluevol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, GreenMixer, "Greenvol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, OrangeMixer, "Orangevol", 0.3f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, PurpleMixer, "Purplevol", 0.3f, maxVal));
        }
    }
}

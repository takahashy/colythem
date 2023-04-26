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
    float red,blue;


    private float beatLength = 1f;

    //timer stuff
    private float theTimer = 0f;

    void Start() {
        RedMixer.SetFloat("Redvol", -79f);
        BlueMixer.SetFloat("Bluevol", -79f);
    }
    
    // Update is called once per frame
    void FixedUpdate(){
        theTimer += 0.01f;
        if (theTimer >= beatLength){
            theTimer = 0;
            Fading();
        }
        RedMixer.GetFloat("Redvol", out red);
        BlueMixer.GetFloat("Bluevol", out blue);
        Debug.Log("Red: " + red);
        Debug.Log("Blue " + blue);
        Debug.Log("Color: "+ GameHandler.color);
    }

    // Update is called once per frame
    void Fading()
    {
        LocalColor = GameHandler.color; 
        //StartCoroutine(FadeMixerGroup.StartFade(AudioMixer audioMixer, String exposedParameter, float duration, float targetVolume));
        
        // color switch not on beat
        if (LocalColor == 0) {
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, RedMixer, "Redvol", 0.2f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, BlueMixer, "Bluevol", 0.2f, -79f));
            // StartCoroutine(FadeMixerGroup.StartFade(gameObject, GreenMixer, "Greenvol", 0.2f, -79f));
            // StartCoroutine(FadeMixerGroup.StartFade(gameObject, OrangeMixer, "Orangevol", 0.2f, -79f));
            // StartCoroutine(FadeMixerGroup.StartFade(gameObject, PurpleMixer, "Purplevol", 0.2f, -79f));
        }

        // Press 'r' to switch to red
        else if (LocalColor == 1) {
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, RedMixer, "Redvol", 0.2f, 1f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, BlueMixer, "Bluevol", 0.2f, -79f));
            // StartCoroutine(FadeMixerGroup.StartFade(gameObject, GreenMixer, "Greenvol", 0.2f, -79f));
            // StartCoroutine(FadeMixerGroup.StartFade(gameObject, OrangeMixer, "Orangevol", 0.2f, -79f));
            // StartCoroutine(FadeMixerGroup.StartFade(gameObject, PurpleMixer, "Purplevol", 0.2f, -79f));
        }

        // Press 'b' to switch to blue
        else if (LocalColor == 2)
        {
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, RedMixer, "Redvol", 0.2f, -79f));
            StartCoroutine(FadeMixerGroup.StartFade(gameObject, BlueMixer, "Bluevol", 0.2f, 1f));
            // StartCoroutine(FadeMixerGroup.StartFade(gameObject, GreenMixer, "Greenvol", 0.2f, -79f));
            // StartCoroutine(FadeMixerGroup.StartFade(gameObject, OrangeMixer, "Orangevol", 0.2f, -79f));
            // StartCoroutine(FadeMixerGroup.StartFade(gameObject, PurpleMixer, "Purplevol", 0.2f, -79f));
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

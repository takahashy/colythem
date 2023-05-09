using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler_Rhythm : MonoBehaviour{
    // Notes: Need visual feedback of failure () + visual for beats + beat first then music instead of music then beat
    // public AudioSource[] sounds;
    // public AudioSource drums;
    // public AudioSource guitar;
    // public AudioSource blue;
    // public AudioSource red;
    // public AudioSource green;
    // public AudioSource orange;
    // public AudioSource purple;

    public static bool canColor = false;
    public GameObject beatThing;
    private Vector3 beatThingScale;
    public int bpm;
    //public float echoRadius = 5f;
    // private float beatLength = 0.275f; //this is the length of each beat! lower for faster bpm
    private Hashtable beatLengths = new Hashtable() {
            {108, 0.275f},
            {120, 0.235f}, 
            {180, 0.165f}
    };
    private float beatLength;
    //timer stuff
    public int timer = 0;
    private float theTimer = 0f;
    private bool doneWith12Measures;

	//public float timeToLerp = 0.5f;
	//public float scaleModifier;
	//float scaleModifierStart = 1;


    void Start(){
        // sounds = GetComponents<AudioSource>();
        // drums = sounds[0];
        // guitar = sounds[1];
        // red = sounds[2];
        // green = sounds[3];
        // orange = sounds[4];
        // purple = sounds[5];
        // blue = sounds[6];;        
        // drums.Play();
        // guitar.Play();
        // red.Play();
        // blue.Play();
        // green.Play();
        // orange.Play();
        // purple.Play();
        beatLength = (float)beatLengths[bpm];
        beatThingScale = beatThing.transform.localScale;
    }

    // Update is called once per frame
    void FixedUpdate(){
        theTimer += 0.01f;
        doneWith12Measures = theTimer == beatLength * 48 ? true : false;
        if (doneWith12Measures) { //reset after 12 measures
            timer = 0; 
            theTimer = 0f;
            // resetAudio();

        }

        if (theTimer >= (beatLength * 0.6f)){
            canColor=true;
        }

        if (theTimer >= beatLength){
            timer +=1;
            theTimer = 0;
            StartCoroutine(beatPulse(beatThing));
        }
    }

    // void resetAudio() {
        // drums.Stop();
        // guitar.Stop();
        // red.Stop();
        // blue.Stop();
        // green.stop();
        // orange.stop();
        // purple.stop();
        // drums.Play();
        // guitar.Play();
        // red.Play();
        // blue.Play();
        // green.Play();
        // orange.Play();
        // purple.Play();
    // }

    IEnumerator beatPulse(GameObject theWave){
        //temporary big and small code. Fix the better pulse code below
        beatThing.transform.localScale = new Vector3(beatThingScale.x *2, beatThingScale.y *2, beatThingScale.z);
        canColor=true;
        yield return new WaitForSeconds(beatLength * 0.6f);
        beatThing.transform.localScale = new Vector3(beatThingScale.x, beatThingScale.y, beatThingScale.z);
        canColor=false;
    }
}

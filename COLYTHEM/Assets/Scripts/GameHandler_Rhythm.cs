using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler_Rhythm : MonoBehaviour{
    // Notes: Need visual feedback of failure () + visual for beats + beat first then music instead of music then beat

    public static bool canColor = false;
    public GameObject beatThing;
    private Vector3 beatThingScale;
    //public float echoRadius = 5f;
    public float beatLength = 1f; //this is the length of each beat! lower for faster beats.

    //timer stuff
    public int timer = 0;
    private float theTimer = 0f;

	//public float timeToLerp = 0.5f;
	//public float scaleModifier;
	//float scaleModifierStart = 1;


    void Start(){
        beatThingScale = beatThing.transform.localScale;
    }

    // Update is called once per frame
    void FixedUpdate(){
        theTimer += 0.01f;
        
        if (theTimer >= (beatLength * 0.85f)){
            canColor=true;
        }

        if (theTimer >= beatLength){
            timer +=1;
            theTimer = 0;
            StartCoroutine(beatPulse(beatThing));
        }
    }

    IEnumerator beatPulse(GameObject theWave){
        //temporary big and small code. Fix the better pulse code below
        beatThing.transform.localScale = new Vector3(beatThingScale.x *2, beatThingScale.y *2, beatThingScale.z);
        canColor=true;
        yield return new WaitForSeconds(beatLength * 0.15f);
        beatThing.transform.localScale = new Vector3(beatThingScale.x, beatThingScale.y, beatThingScale.z);
        canColor=false;

        /*
        float time = 0;
		scaleModifier = scaleModifierStart;
		float startValue = beatThingScale;
		Vector3 startScale = theWave.transform.localScale;
		//Debug.Log("wave start size = " + theWave.transform.localScale);
		while (time < timeToLerp){
			scaleModifier = Mathf.Lerp(startValue, echoRadius, time / timeToLerp);
			theWave.transform.localScale = startScale * scaleModifier;
			time += Time.deltaTime;
			yield return null;
		}
		
		//activate raycasts
		//EchoRaycasts(theWave.transform.position);
		
		//reverse
		time = 0;
		scaleModifier = scaleModifierStart;
		startScale = theWave.transform.localScale;
		//Debug.Log("wave peak size = " + theWave.transform.localScale);
		while (time < timeToLerp){
			scaleModifier = Mathf.Lerp(echoRadius, startValue, time / timeToLerp);
			theWave.transform.localScale = startScale * scaleModifier/echoRadius;
			time += Time.deltaTime;
			yield return null;
		}
        */

    }


}

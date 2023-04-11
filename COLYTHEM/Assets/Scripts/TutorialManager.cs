using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    public int popUpIndex;

    // Update is called once per frame
    void Update() {
        // if (popUpIndex < popUps.Length) {
        //     for (int i = 0; i < popUps.Length; i++) {
        //         if (i == popUpIndex) {
        //             print ("setting " + popUps[popUpIndex] + " active");
        //             popUps[popUpIndex].SetActive(true);
        //         } else {
        //             popUps[popUpIndex].SetActive(false);
        //         }
        //     }
        // }

        // if (popUpIndex == 0) { // movement
        //     if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) ||
        //         Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)) {
        //         popUpIndex++;
        //         print("movement");
        //     }
        // } else if (popUpIndex == 1) { // shooting 
        //     if (Input.GetKeyDown(KeyCode.Space)) {
        //         popUpIndex++;
        //         print("shooting");
        //     }
        // } else if (popUpIndex == 2) { // color switching
        //     if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.B)) {
        //         popUpIndex++;
        //         print("color switching");
        //     }
        // } else if (popUpIndex == 3) { // boss fight
        //     if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.B)) {
        //         popUpIndex++;
        //         print("boss fight");
        //     }
        // }
    }
}

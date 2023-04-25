/*  DropColor.cs
 *
 *  When the boss is defeated create an instance of the colorupgrade game object
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropColor : MonoBehaviour
{
    public GameObject colorupgrade;
    void OnDestroy()
    {
        Instantiate(colorupgrade, transform.position, Quaternion.identity);
    }  
}

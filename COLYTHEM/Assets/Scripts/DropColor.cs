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

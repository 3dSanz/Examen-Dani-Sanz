using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorSuelo : MonoBehaviour
{
    BoxCollider2D bC2d;
    public bool enSuelo;
    void Awake() 
    {
        bC2d = GetComponent<BoxCollider2D>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
            enSuelo = true;
        }
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.layer == 3)
        {
             enSuelo = false;
        }
    }
}

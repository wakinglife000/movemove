using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadKey : MonoBehaviour
{
    public Transform mySpriteTR;

	void Start ()
    {
        
    }
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            mySpriteTR.localPosition -= (Vector3.right * 0.1f);
            //mySpriteTR.localPosition = mySpriteTR.localPosition - (Vector3.right * 1.0f);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            mySpriteTR.localPosition += (Vector3.right * 1.0f);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            mySpriteTR.localPosition += (Vector3.up * 1.0f);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            mySpriteTR.localPosition -= (Vector3.up * 1.0f);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            mySpriteTR.localPosition -= (Vector3.forward * 1.0f);
            Debug.Log("KeyCode.Z");
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            mySpriteTR.localPosition += (Vector3.forward * 1.0f);
        }

        //fff
    }
}

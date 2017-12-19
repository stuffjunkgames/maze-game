using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

    public GameObject flashLightObject;
    public bool flashLightOn, alreadyPressingKey;

	// Use this for initialization
	void Start () {
        flashLightOn = true;
        alreadyPressingKey = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.F))
        {
            if(flashLightOn)
            {
                flashLightOn = false;
            }
            else
            {
                flashLightOn = true;
            }
            flashLightObject.SetActive(flashLightOn);
        }
	}
}

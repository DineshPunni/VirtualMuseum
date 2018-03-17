using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController : MonoBehaviour {

    bool firstClick;
    float clickTimer = 0.5f;


	void Start () {
		
	}
	
	void Update () {


        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            firstClick = true;
        }

     
        

    }



    void ButtonMapping()
    {
        if (OVRInput.GetDown(OVRInput.Button.Back))
        {
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
        {
        }

        if (OVRInput.GetDown(OVRInput.Touch.PrimaryTouchpad))
        {
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
        }
    }

}

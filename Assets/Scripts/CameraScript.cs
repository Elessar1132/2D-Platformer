using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {


    GameObject mainCam;
    public float CamZ;
	// Use this for initialization
	void Start ()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            mainCam.transform.position = new Vector3(mainCam.transform.position.x, mainCam.transform.position.y, CamZ += 0.5f);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            mainCam.transform.position = new Vector3(mainCam.transform.position.x, mainCam.transform.position.y, CamZ -= 0.5f);
        }
        //mainCam.transform.position = new Vector3(mainCam.transform.position.x, mainCam.transform.position.y, CamZ);
	}
}

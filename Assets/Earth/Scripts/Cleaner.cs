using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner : MonoBehaviour {

    Transform cube;
    float vvv=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (cube)
        {
            Debug.Log("cleaner update ::::::::::::::::::::: ");
            cube.Translate(-vvv * Time.deltaTime, 0, 0);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
       //if (other.name != "EarthMain" || other.name != "Earth") {
       if (other.tag != "Earth") {
            Debug.Log("1$$$$$$$$$$$ cleaner Trigger name" + other.name);
            Debug.Log("2$$$$$$$$$$$ cleaner Trigger tag" + other.tag);
            //other.attachedRigidbody.useGravity = true;
            vvv = 1;
            cube = other.transform;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("cleaner OnCollisionEnter ::::::::::::::::::::: ");
        Debug.Log(collision.collider.name);
    }
}

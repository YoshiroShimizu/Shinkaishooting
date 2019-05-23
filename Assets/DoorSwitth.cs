using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitth : MonoBehaviour {

    GameObject DOOR;

	// Use this for initialization
	void Start () {

        DOOR = GameObject.Find("DOOR");
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("shell")
            { }
    }
}

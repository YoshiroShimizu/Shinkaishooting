using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rader : MonoBehaviour {

    public Transform target;

    // Use this for initialization
    void Start () {


    }
	
	// Update is called once per frame
	void Update () {

        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")){
            transform.root.LookAt(target);

        }
    }
}

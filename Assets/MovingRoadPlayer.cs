/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRoadPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
      if(collision.collider.gameObject.tag=="Player")
            {
            collision.collider.gameObject.transform.SetParent(transform);
            Debug.Log("parenting");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Player"){
            collision.collider.gameObject.transform.SetParent(null);
        }
        Debug.Log("exit");
    }

    
}
*/




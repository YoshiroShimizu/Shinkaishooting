using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRoad1 : MonoBehaviour {

    private Vector3 pos;

    public float movingspeed;

	// Use this for initialization
	void Start () {

        pos = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {

        this.gameObject.transform.position = new Vector3(pos.x + Mathf.Sin(Time.time) * movingspeed, pos.y, pos.z);
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControllet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        pos.x += Mathf.Sin(Time.time)*0.1f;
        transform.position = pos;
        //transform.position = new Vector3(Mathf.PingPong(Time.time, 6), transform.position.y, transform.position.z);
		
	}
}

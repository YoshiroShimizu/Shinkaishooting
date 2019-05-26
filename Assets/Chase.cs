using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour {

    
    public GameObject player;

    public float speed;
   



	// Use this for initialization
	void Start () {

        speed = 3.0f;
         player = GameObject.Find ( "Player" );
		
	}

    // Update is called once per frame
    void Update(){

        

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

        }
    }
}

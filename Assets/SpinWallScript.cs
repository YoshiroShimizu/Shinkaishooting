using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinWallScript : MonoBehaviour {

    

    

	// Use this for initialization
	void Start () {
        this.transform.Rotate(0, Random.Range(0,360), 0);
	}
	
	// Update is called once per frame
	void Update (){

        

         
       
        //transform.rotation = Quaternion.Euler(rotation_x, rotation_y+=45, 0);
        this.transform.Rotate(0,1, 0);
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("shell"))
        {
            Destroy(other.gameObject);
        }
    }





}

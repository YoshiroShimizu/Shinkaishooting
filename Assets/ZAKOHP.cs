using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAKOHP : MonoBehaviour {

    public int hitpoint = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("shell")){
            hitpoint -= 20;

            if (hitpoint <= 0){
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApperScriptC : MonoBehaviour {

    public GameObject ENEMY_C;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject enemyC = Instantiate(ENEMY_C) as GameObject;

            ENEMY_C.transform.position = new Vector3(-20, 8, 25);
        }
    }

   






}

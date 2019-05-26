using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("shell"))
        {

            //HPクラスのダメージ関数を呼び出してダメージを与える
           


            Destroy(other.gameObject);

            Debug.Log("rock");
        }
    }
}

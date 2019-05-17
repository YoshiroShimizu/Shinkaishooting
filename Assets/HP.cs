using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {

    public int hitPoint = 100; //HP

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //HPが０になった時敵を破壊する
        if (hitPoint <= 0) {

            Destroy(this.gameObject);
        }
    }

    public void Damage(int damage){

        hitPoint -= damage;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {

    public int hitPoint = 100; //HP

	
	// Update is called once per frame
	void Update () {

      
        
    }

    public void Damage(int damage){

        hitPoint -= damage;

        //HPが０になった時敵を破壊する
        if (hitPoint <= 0)
        {

            Destroy(this.gameObject);
        }


    }

}

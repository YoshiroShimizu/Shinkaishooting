using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

    public int damage;
    //private GameObject enemy;いらなかった
    private HP hp;
    


    // Use this for initialization
    void Start () {

        //enemy = GameObject.Find("ENEMY");いらなかった
        hp = GetComponentInParent<HP>();
        //hp = enemy.GetComponent<HP>();正しくは上の行


    }
	
	// Update is called once per frame
	void Update () {
        


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("shell"))
        {
            
            //HPクラスのダメージ関数を呼び出してダメージを与える
            hp.Damage(damage);
           

            Destroy(other.gameObject);
        }
    }

    

}

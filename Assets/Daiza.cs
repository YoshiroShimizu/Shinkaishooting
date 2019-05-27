using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daiza : MonoBehaviour
{

    public int hitPoint = 100; //HP


    // Update is called once per frame
    void Update()
    {



    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("shell"))
        {
            hitPoint -= 10;

        //HPが０になった時敵を破壊する
        if (hitPoint <= 0)
        

            Destroy(this.gameObject);
        }


    }

}

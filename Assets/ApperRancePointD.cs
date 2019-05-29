using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApperRancePointD : MonoBehaviour
{

    public GameObject enemy;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject enemyhoudan = Instantiate(enemy) as GameObject;

            enemyhoudan.transform.position = new Vector3(-55, 3, 4);
        }
    }








}

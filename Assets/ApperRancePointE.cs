using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApperRancePointE : MonoBehaviour
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
        var randomRotationY = Random.value * 360f;

        if (other.CompareTag("Player"))
        {
            GameObject enemyhoudan = Instantiate(enemy) as GameObject;

            enemyhoudan.transform.position = new Vector3(0, 27, -320);

            transform.rotation = Quaternion.Euler(0f, randomRotationY, 0f);


        }
    }








}

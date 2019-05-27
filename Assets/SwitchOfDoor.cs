using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOfDoor : MonoBehaviour
{

    public GameObject RedDoor;
    public GameObject GreenDoor;
    public GameObject BlueDoor;
    public GameObject RedDoorSwitch;
    public GameObject GreenDoorSwitch;
    public GameObject BlueDoorSwitch;


    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SwitchRock") && this.gameObject == RedDoorSwitch)
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Destroy(RedDoor, 2.0f);
        }
        else if (other.CompareTag("shell") && this.gameObject == GreenDoorSwitch)
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Destroy(GreenDoor, 2.0f);
        }
        else if (other.CompareTag("shell") && this.gameObject == BlueDoorSwitch)
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Destroy(BlueDoor, 2.0f);
        }
    }
}

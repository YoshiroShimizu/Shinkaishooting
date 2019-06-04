using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOfSpinWall : MonoBehaviour {
    public GameObject SpinWallRed;
    public GameObject SpinWallGreen;
    public GameObject SpinWallBlue;
    public GameObject SpinWallRedSwich;
    public GameObject SpinWallGreenSwich;
    public GameObject SpinWallBlueSwich;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("shell") && this.gameObject == SpinWallRedSwich)
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Destroy(SpinWallRed, 2.0f);
        }
        else if (other.CompareTag("shell") && this.gameObject == SpinWallGreenSwich)
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Destroy(SpinWallGreen, 2.0f);
        }
        else if (other.CompareTag("shell") && this.gameObject == SpinWallBlueSwich)
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Destroy(SpinWallBlue, 2.0f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS{



    public class CameraController : MonoBehaviour {

        [Range(0.1f, 10f)]
        public float lookScensitivity = 5f;
        [Range(0.1f, 1f)]
        public float lookSmooth=0.1f;

        public Vector2 MinMaxAngle = new Vector2(-65, 65);

        private float yRot;
        private float xRot;

        private float currentYRot;
        private float currentXRot;

        private float yRotVelocity;
        private float xRotVelocity;

	    
	
	    // Update is called once per frame
	    void Update () {
            yRot += Input.GetAxis("Mouse X") * lookScensitivity; //マウスの横移動
            xRot -= Input.GetAxis("Mouse Y") * lookScensitivity; //マウスの縦移動

            xRot = Mathf.Clamp(xRot, MinMaxAngle.x, MinMaxAngle.y); //上下の角度移動の最大、最小

            currentXRot = Mathf.SmoothDamp(currentXRot, xRot, ref xRotVelocity, lookSmooth);
            currentYRot = Mathf.SmoothDamp(currentYRot, yRot, ref yRotVelocity, lookSmooth);

            transform.rotation = Quaternion.Euler(currentXRot, currentYRot, 0);


        }
    }
}

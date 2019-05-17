﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS {

    //列挙型の宣言
    public enum PlayerState{
        Idle,Walking,Running,Jumping
    }

    [RequireComponent(typeof(CharacterController),typeof(AudioSource))]

    public class PlayerController : MonoBehaviour {

        [Range(0.1f, 2f)]
        public float walkSpeed = 1.5f;
        [Range(0.1f,10f)]
        public float runSpeed=3.5f;

        private CharacterController charaController;


	    // Use this for initialization
	    void Start () {
            charaController = GetComponent<CharacterController>();
		
	    }
	
	    // Update is called once per frame
	    void Update () {
            Move();
		
	    }

        void Move(){
            float moveH = Input.GetAxis("Horizontal");
            float moveV = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveH, 0, moveV);

            if (movement.sqrMagnitude > 1){
                movement.Normalize();
            }

            //歩行と走りを切りかえる
            if (Input.GetKey(KeyCode.Space)){
                charaController.Move(movement * Time.fixedDeltaTime * runSpeed);
            }
            else {
                charaController.Move(movement * Time.fixedDeltaTime * walkSpeed);
            }
        }

    }
}


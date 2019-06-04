using System.Collections;
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
        //落下処理追加
        private Vector3 moveDirection=Vector3.zero;
        private float gravity = 20.0f;
                   

       
        



        // Use this for initialization
        void Start () {
           

            charaController = GetComponent<CharacterController>();

            
		
	    }
	
	    // Update is called once per frame
	    void Update () {

            //カメラの難しい処理追加
            var cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
            Vector3 direction = cameraForward * Input.GetAxis("Vertical") + Camera.main.transform.right * Input.GetAxis("Horizontal");  //  テンキーや3Dスティックの入力（GetAxis）があるとdirectionに値を返す

            //落下処理追加
            if (charaController.isGrounded)
            {
                moveDirection.y = 0f;
                moveDirection = direction * walkSpeed;
                moveDirection = direction * runSpeed;

            }
            else
            {
                moveDirection.y -= gravity * Time.deltaTime;
            }


            //移動処理をMOVE関数に渡す
            Move();
		
	    }

        void Move(){
            //CharacterControllerの付いているこのオブジェクトを移動させる処理
            //charaController.Move(moveDirection * Time.deltaTime);

            float moveH = Input.GetAxis("Horizontal");
            float moveV = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveH, 0, moveV);

            if (movement.sqrMagnitude > 1){
                movement.Normalize();
            }





            // ★修正
            // 歩行とランを切り替える。
            if (Input.GetKey(KeyCode.Space))
            {
                charaController.Move(moveDirection * Time.fixedDeltaTime * runSpeed);
            }
            else
            {
                charaController.Move(moveDirection * Time.fixedDeltaTime * walkSpeed);
            }

            






        }

        /*
        private void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.tag == "MovingFloor")
            {
                transform.SetParent(col.transform);
            }
        }

        private void OnCollisionExit(Collision col)
        {
            if (col.gameObject.tag == "MovingFloor")
            {
                transform.SetParent(null);
            }
        }
        */
        





    }
}



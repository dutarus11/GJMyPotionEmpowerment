using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuickStart
{    
    public class PlayerScript : NetworkBehaviour
    {
        public Animator playerAnim;
        public Rigidbody playerRigid;
        public float w_speed, wb_speed, olw_speed, rn_speed, ro_speed;
        public bool running;
        public Transform playerTransform;
        //public GameObject projecilePoolObj;

        //ProjectilePooling projectilePooling;
        //GameObject proPooling;
        private void Awake()
        {
           // projectilePooling = GameObject.Find("ProjectilePrefab").GetComponent<ProjectilePooling>();
        }

        private void Start()
        {
          
        }

        //private void FixedUpdate()
        //{
        //    if (Input.GetKey(KeyCode.W)) 
        //    {
        //        playerRigid.velocity = transform.forward * w_speed * Time.deltaTime;
        //    }
        //    if (Input.GetKey(KeyCode.S))
        //    {
        //        playerRigid.velocity = -transform.forward * w_speed * Time.deltaTime;
        //    }
        //}
        void Update()
        {
            //if (!isLocalPlayer) { return; }

            //float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * 110.0f;
            //float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * 4f;

            //transform.Rotate(0, moveX, 0);
            //transform.Translate(0, 0, moveZ);

            if (Input.GetKeyDown(KeyCode.W)) 
            {
                playerAnim.SetTrigger("Run");
                playerAnim.ResetTrigger("Idle");
                running = true;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                playerAnim.SetTrigger("Run");
                playerAnim.ResetTrigger("Idle");
                running = false;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                playerAnim.SetTrigger("Backwards");
                playerAnim.ResetTrigger("Idle");
                running = true;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                playerAnim.SetTrigger("Backwards");
                playerAnim.ResetTrigger("Idle");
                running = false;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                playerTransform.Rotate(0, -ro_speed * Time.deltaTime, 0);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                playerTransform.Rotate(0, ro_speed * Time.deltaTime, 0);
            }
            if (running == true)
            {
                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    w_speed = w_speed + rn_speed;
                }
            }

            //InputShootingManager();
        }

        //void InputShootingManager()
        //{
        //    if (Input.GetButton("Fire1"))
        //    {
        //        //proPooling.SetActive(true);
        //        //ProjectilePooling.isActiveObj = true;
        //        //shoot attack power 
                
        //        PlayerAttackPower.Instance.Shoot();               
                              
        //    }
        //}
    }
}

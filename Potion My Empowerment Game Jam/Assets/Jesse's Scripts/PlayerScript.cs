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
               
        void Update()
        {           
           PlayerInputs();           
        }

        //player inputs 
        void PlayerInputs()
        {
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
        }
       
    }
}

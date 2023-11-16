
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuickStart
{    
    public class PlayerScript : MonoBehaviour
    {
        //The Player Controller Class 
        public Animator playerAnim;
        public Rigidbody playerRigid;
        public float w_speed, wb_speed, olw_speed, rn_speed, ro_speed;
        public float num = 0;
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
                playerTransform.Rotate(0, -ro_speed * Time.deltaTime, num);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                playerTransform.Rotate(0, ro_speed * Time.deltaTime, num);
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

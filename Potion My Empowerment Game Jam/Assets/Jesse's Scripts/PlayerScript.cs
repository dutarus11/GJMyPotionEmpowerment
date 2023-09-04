using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuickStart
{
    public class PlayerScript : NetworkBehaviour
    {
        //public GameObject projecilePoolObj;

        //ProjectilePooling projectilePooling;
        //GameObject proPooling;
        private void Awake()
        {
           // projectilePooling = GameObject.Find("ProjectilePrefab").GetComponent<ProjectilePooling>();
        }

        private void Start()
        {
          // proPooling.SetActive(false);
        }
        void Update()
        {
            if (!isLocalPlayer) { return; }

            float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * 110.0f;
            float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * 4f;

            transform.Rotate(0, moveX, 0);
            transform.Translate(0, 0, moveZ);
            InputShootingManager();
        }

        void InputShootingManager()
        {
            if (Input.GetButton("Fire1"))
            {
                //proPooling.SetActive(true);
                //ProjectilePooling.isActiveObj = true;
                //shoot attack power 
                PlayerAttackPower.Instance.Shoot();               
            }
        }
    }
}

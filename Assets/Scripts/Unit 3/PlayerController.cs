using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unit3
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody playerRB;
        public float forceMultiplier = 100f;
        public float gravityModifier;
        private bool isOnGround = false;

        private void Start()
        {
            playerRB = GetComponent<Rigidbody>();
            Physics.gravity *= gravityModifier;
            isOnGround = true;
            //Physics.gravity = Physics.gravity * gravityModifier;


        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
            {
                playerRB.AddForce(Vector3.up * forceMultiplier, ForceMode.Impulse );
                isOnGround = false;

            }
        }

        private void OnCollisionEnter(Collision other)
        {
            // Debug.Log(other.gameObject.name); 
            isOnGround = true;
            
        }

        // private void OnCollisionExit(Collision other)
        // {
        //     Debug.Log($"not on the {other.gameObject.name}");
        // }
        //
        // private void OnCollisionStay(Collision other)
        // {
        //     Debug.Log("still touching");
        // }
    }
}

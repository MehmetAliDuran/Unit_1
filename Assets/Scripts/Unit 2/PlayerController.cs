using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unit2
{


    public class PlayerController : MonoBehaviour
    {
        public float speed = 10f;
        private float horizontalInput;
        public float xRange = 22.5f;
        private Vector3 pos;
        public GameObject projectilePrefab;

        private void Update()
        {
            horizontalInput = Input.GetAxis("Horizontal");
            pos = Vector3.right * (Time.deltaTime * speed * horizontalInput);
            transform.Translate(pos);

            if (transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, pos.y, pos.z);
            }

            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, pos.y, pos.z);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            }
        }
    }
}

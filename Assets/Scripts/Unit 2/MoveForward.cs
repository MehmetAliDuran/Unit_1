using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unit2
{
    public class MoveForward : MonoBehaviour
    {
        public float moveSpeed = 25f;

        private void Update()
        {
            transform.Translate(Vector3.forward * (Time.deltaTime * moveSpeed));
        }
    }
}

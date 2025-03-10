using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unit2
{
    public class DestroyOutOfBounds : MonoBehaviour
    {
        public float topBound = 25f;
        public float lowerBound = -10f;
        private void Update()
        {
            if (transform.position.z > topBound)
            {
                Destroy(gameObject);
            }
            
            else if (transform.position.z < lowerBound)
            {
                Destroy(gameObject);
                Debug.Log("Game Over");
            }
        }
    }
}

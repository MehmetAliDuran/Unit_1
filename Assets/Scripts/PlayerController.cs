using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 30;
    private float horizontalInput;
    private float forwardInput;
   
    // Update is called once per frame
    void Update()

    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * ( Time.deltaTime * speed * forwardInput));
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
      // transform.Translate(Vector3.right * (Time.deltaTime * turnSpeed * horizontalInput));
    }
}

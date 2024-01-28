using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Do something
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}

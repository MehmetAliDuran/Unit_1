using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;

    public Vector3 offset;
    // private PlayerController _playerController;
    // Start is called before the first frame update
    private void Awake()
    {
        // _playerController = FindObjectOfType<PlayerController>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}

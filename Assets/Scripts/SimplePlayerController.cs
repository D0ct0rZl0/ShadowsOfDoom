﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private FlashlightController lightController;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
    }
}

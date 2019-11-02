﻿
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Jump : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }
    }
}

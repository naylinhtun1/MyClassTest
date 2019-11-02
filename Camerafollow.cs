using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform PlayerTransform;

    private Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float Smoothfactor = 0.5f;

    public bool LookAtPlayer = false;

  private void Update()
    {
        _cameraOffset = transform.position-PlayerTransform.position;

    }
    private void LateUpdate()
    {
        Vector3 newpos = PlayerTransform.position + _cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newpos, Smoothfactor);

        if (LookAtPlayer)
            transform.LookAt(PlayerTransform);
    }
}


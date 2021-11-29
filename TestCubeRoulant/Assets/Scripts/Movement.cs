using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Range(-1f,1f)]
    public float speed = 0.01f;
    public Transform raycastOrigin;

    void Update()
    {
    }

    public void Move(Vector3 direction)
    {
        transform.Translate(direction*speed);
    }

    public bool Jump()
    {
        var isGrounded = Physics.Raycast(raycastOrigin.position, Vector3.down, 0.1f);
        return isGrounded;
    }

}

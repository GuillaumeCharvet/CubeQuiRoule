using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Range(-1f,1f)]
    public float speed = 0.01f;
    public Transform raycastOrigin;

    [Range(0f, 10f)]
    public float alea = 2f;

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

    public void GrosseBaffe(Rigidbody rgbd)
    {
        rgbd.AddForce((Vector3.up + new Vector3(Random.Range(-alea, alea), 0, Random.Range(-alea, alea))) * speed);
    }
}

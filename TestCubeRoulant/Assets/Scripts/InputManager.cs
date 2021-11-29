using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public KeyCode up, down, left, right, espace;
    public Movement movement;
    public Rigidbody rgbd1;
    public Rigidbody rgbd2;
    public Rigidbody rgbd3;
    public Rigidbody rgbd4;

    [Range(0f, 10f)]
    public float speed = 0.01f;
    [Range(0f, 10f)]
    public float alea = 2f;

    void Update()
    {
        if(Input.GetKey(up))
        {
            movement.Move(Vector3.forward);
        }
        if (Input.GetKey(down))
        {
            movement.Move(Vector3.back);
        }
        if (Input.GetKey(right))
        {
            movement.Move(Vector3.right);
        }
        if (Input.GetKey(left))
        {
            movement.Move(Vector3.left);
        }
        if (Input.GetKey(espace) && movement.Jump())
        {
            rgbd1.AddForce((Vector3.up + new Vector3(Random.Range(-alea, alea), 0, Random.Range(-alea, alea))) * speed);
            rgbd2.AddForce((Vector3.up + new Vector3(Random.Range(-alea, alea), 0, Random.Range(-alea, alea))) * speed);
            rgbd3.AddForce((Vector3.up + new Vector3(Random.Range(-alea, alea), 0, Random.Range(-alea, alea))) * speed);
            rgbd4.AddForce((Vector3.up + new Vector3(Random.Range(-alea, alea), 0, Random.Range(-alea, alea))) * speed);
        }
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeirdMovement : MonoBehaviour
{
    
    public Transform trsf;
    public Rigidbody rgbd;

    public float rotation_speed = 0.01f;
    public float rayon_rotation = 1f;

    void Update()
    {
        if (Input.GetAxis("Vertical")>0.1f)
        {
            RotateAroundVerticalAxe(1,1);
        }
        else if (Input.GetAxis("Vertical")<-0.1f)
        {
            RotateAroundVerticalAxe(-1,1);
        }
        else if (Input.GetAxis("Horizontal")>0.1f)
        {
            RotateAroundVerticalAxe(1,-1);
        }
        else if (Input.GetAxis("Horizontal")<-0.1f)
        {
            RotateAroundVerticalAxe(-1,-1);
        }
    }

    private void RotateAroundVerticalAxe(float input_vertical, float input_horizontal)
    {
        Vector3 avance = input_horizontal * rayon_rotation * input_vertical * Mathf.Sin(rotation_speed) * trsf.forward + input_horizontal * rayon_rotation * input_vertical * (1 - Mathf.Cos(rotation_speed)) * -1 * trsf.right;
        trsf.position += avance;
        trsf.Rotate(0.0f,rotation_speed,0.0f,Space.Self);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeirdMovement : MonoBehaviour
{
    
    public Transform trsf;
    public Rigidbody rgbd;

    public float rotation_speed = 0.01f;
    public float rayon_rotation = 0.5f;

    void Update()
    {
        if (Input.GetAxis("Vertical")>0.01f)
        {
            RotateAroundVerticalAxe(1,1);
        }
        else if (Input.GetAxis("Vertical")<-0.01f)
        {
            RotateAroundVerticalAxe(-1,1);
        }
        else if (Input.GetAxis("Horizontal")>0.01f)
        {
            RotateAroundVerticalAxe(1,-1);
        }
        else if (Input.GetAxis("Horizontal")<-0.01f)
        {
            RotateAroundVerticalAxe(-1,-1);
        }
    }

    private void RotateAroundVerticalAxe(float input_vertical, float input_horizontal)
    {

        print("input_vertical");
        print(input_vertical);
        Vector3 avance = Vector3.forward;
        //Vector3 avance = (Mathf.Sin(rotation_speed * input_vertical) * trsf.forward + (1 - Mathf.Cos(rotation_speed * input_vertical)) * -1 * trsf.right) * rayon_rotation; //input_horizontal * 
        trsf.position += avance;
        trsf.Rotate(0.0f,rotation_speed,0.0f,Space.Self);
    }
}

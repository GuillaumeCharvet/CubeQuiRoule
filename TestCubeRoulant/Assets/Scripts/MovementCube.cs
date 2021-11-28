using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCube : MonoBehaviour
{

    public Transform trsf;
    public Transform trsf_cam;
    public Rigidbody rgbd;
    private Quaternion auxi;

    public float torque = 1.0f;

    void Update()
    {
        //RotateAroundVerticalAxe();
        if (Input.GetAxis("Vertical")>0.1f)
        {
            RotateAroundHorizontalAxe(1,0);
            auxi.eulerAngles = Vector3.Scale(trsf.rotation.eulerAngles, new Vector3 (1, 0, 1));
            trsf.rotation = auxi;
        }
        else if (Input.GetAxis("Vertical")<-0.1f)
        {
            RotateAroundHorizontalAxe(-1,0);
        }
        else if (Input.GetAxis("Horizontal")>0.1f)
        {
            RotateAroundHorizontalAxe(0,1);
        }
        else if (Input.GetAxis("Horizontal")<-0.1f)
        {
            RotateAroundHorizontalAxe(0,-1);
        }

        
    }

    private void RotateAroundHorizontalAxe(float input_vertical, float input_horizontal)
    {
        rgbd.AddTorque(trsf_cam.right * torque * input_vertical);
        rgbd.AddTorque(trsf_cam.forward * torque * input_horizontal);
    }
}

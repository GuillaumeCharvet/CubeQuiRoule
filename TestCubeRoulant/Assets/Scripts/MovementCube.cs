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

        if (true)
        {

        }

        //RotateAroundVerticalAxe();
        if (Input.GetAxis("Vertical")>0.1f)
        {
            RotateAroundHorizontalAxe(1,0);
        }
        else if (Input.GetAxis("Vertical")<-0.1f)
        {
            RotateAroundHorizontalAxe(-1,0);
        }
        else if (Input.GetAxis("Horizontal")>0.1f)
        {
            RotateAroundHorizontalAxe(0,-1);
        }
        else if (Input.GetAxis("Horizontal")<-0.1f)
        {
            RotateAroundHorizontalAxe(0,1);
        }


        /*auxi.eulerAngles = Vector3.Scale(trsf.rotation.eulerAngles, new Vector3(1, 0, 1));
        trsf.rotation = auxi;*/
    }

    private void RotateAroundHorizontalAxe(float input_vertical, float input_horizontal) //Vector3 main_direction, 
    {
        rgbd.AddTorque(trsf_cam.right * torque * input_vertical);
        rgbd.AddTorque(trsf_cam.forward * torque * input_horizontal);
    }
}

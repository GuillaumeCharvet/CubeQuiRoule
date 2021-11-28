using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuiviCamera : MonoBehaviour
{

    public Transform trsf_cam;
    public Transform trsf_cible;
    public float hauteur = 2.0f;
    public float retard = -2.0f;

    // Update is called once per frame
    void Update()
    {
        trsf_cam.position = new Vector3 (trsf_cible.position.x, hauteur, trsf_cible.position.z + retard);
    }
}

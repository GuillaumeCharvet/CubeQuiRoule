using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rgbd;
    public float strength;
    public float lifeSpawn = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        rgbd.AddForce(transform.forward * strength);
    }

    // Update is called once per frame
    void Update()
    {
        lifeSpawn -= Time.deltaTime;
        if(lifeSpawn <= 0)
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnThings : MonoBehaviour
{

    public GameObject prefab;
    public Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        /*Instantiate(prefab);
        Instantiate(prefab,parent);
        Instantiate(prefab,new Vector3(2, 2, 2), Quaternion.identity);*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AziSpawn()
    {
        Instantiate(prefab, parent);
    }
}

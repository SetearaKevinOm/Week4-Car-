using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject carO;
    // Start is called before the first frame update
    void Start()
    {
        carO.transform.parent = this.transform; 
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = carO.transform.position; 
    }
}

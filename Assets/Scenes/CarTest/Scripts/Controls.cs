using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public GameObject carPrefab;
    public GameObject thrusterObject;
    public Rigidbody carPrefabRigidbody;

    public KeyCode accelerate;
    public KeyCode brake;
    public KeyCode left;
    public KeyCode right;
    
    public Vector3 localVelocity;
    void Start()
    {
        carPrefabRigidbody = GetComponent<Rigidbody>();
        
    }
    
    void Update()
    {
        localVelocity = transform.InverseTransformDirection(carPrefabRigidbody.velocity);
        Debug.Log(localVelocity);
        if (Input.GetKey(accelerate))
        {
            carPrefabRigidbody.AddRelativeForce(new Vector3(5f, 0f, 0f));
        }

        if (Input.GetKey(brake))
        {
            carPrefabRigidbody.AddRelativeForce(new Vector3(-5f, 0f, 0f));
        }

        if (Input.GetKey(left))
        {
            carPrefabRigidbody.AddRelativeTorque(new Vector3(0f, -2f, 0f));
            carPrefabRigidbody.AddRelativeTorque(new Vector3(0f,-localVelocity.y/2,0f));
        }

        if (Input.GetKey(right))
        {
            carPrefabRigidbody.AddRelativeTorque(new Vector3(0f, 2f, 0f));
            carPrefabRigidbody.AddRelativeTorque(new Vector3(0f,localVelocity.y/2,0f));
        }
    }
}

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

    //public float rayMaxDistance;
    // Start is called before the first frame update
    void Start()
    {
        carPrefabRigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        /*/*if (Physics.Raycast(thrusterObject.transform.position, Vector3.down, rayMaxDistance))
        {
            Debug.DrawRay(thrusterObject.transform.position,Vector3.down);
            carPrefabRigidbody.AddRelativeForce(new Vector3(0f,rayMaxDistance,0f));
        }*/
        localVelocity = transform.InverseTransformDirection(carPrefabRigidbody.velocity);
        Debug.Log(localVelocity);
        if (Input.GetKey(accelerate))
        {
            carPrefabRigidbody.AddRelativeForce(new Vector3(5f, 0f, 0f));
            //carPrefabRigidbody.velocity = new Vector3(5f, 0f, 0f); 
        }

        if (Input.GetKey(brake))
        {
            carPrefabRigidbody.AddRelativeForce(new Vector3(-5f, 0f, 0f));
            //carPrefabRigidbody.velocity = new Vector3(-5f, 0f, 0f); 
        }

        if (Input.GetKey(left))
        {
            carPrefabRigidbody.AddRelativeTorque(new Vector3(0f, -2f, 0f));
            carPrefabRigidbody.AddRelativeTorque(new Vector3(0f,-localVelocity.y/2,0f));
            //carPrefabRigidbody.AddRelativeTorque(new Vector3(0f, 0f, Mathf.Clamp(localVelocity.x,5f,10f)));
            //carPrefabRigidbody.AddForceAtPosition(new Vector3(0f,0f,-1f), new Vector3(-1f,0f,0f));
            //carPrefabRigidbody.velocity = new Vector3(0f, 0f, 5f); 
            //carPrefabRigidbody.AddForceAtPosition(new Vector3(0f,0f,-5f), new Vector3(0f,0f,0f));
        }

        if (Input.GetKey(right))
        {
            carPrefabRigidbody.AddRelativeTorque(new Vector3(0f, 2f, 0f));
            carPrefabRigidbody.AddRelativeTorque(new Vector3(0f,localVelocity.y/2,0f));
            //carPrefabRigidbody.AddRelativeTorque(new Vector3(0f, 0f, Mathf.Clamp(localVelocity.x,5f,10f)));
            //carPrefabRigidbody.AddForceAtPosition(new Vector3(0f,0f,1f), new Vector3(-1f,0f,0f));
            //carPrefabRigidbody.velocity = new Vector3(0f, 0f, -5f); 
            //carPrefabRigidbody.AddForceAtPosition(new Vector3(0f,0f,5f), new Vector3(0f,0f,0f));
        }
    }
}

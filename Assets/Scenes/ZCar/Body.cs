using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    public Rigidbody carPrefabRigidbody;
    
    public KeyCode accelerate;
    public float accelerationSpeed = 5f;

    public KeyCode brake;

    public KeyCode left;

    public KeyCode right;

    public KeyCode boost;

    public Vector3 localVelocity;
    // Start is called before the first frame update
    void Start()
    {
        carPrefabRigidbody = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawRay(transform.position,Vector3.,Color.green);
        localVelocity = transform.InverseTransformDirection(carPrefabRigidbody.velocity);
        
        carPrefabRigidbody.AddRelativeForce(new Vector3(-localVelocity.x,0f,0f));
        
        //Debug.Log(localVelocity);
        
        if (Input.GetKey(accelerate))
        {
            carPrefabRigidbody.AddRelativeForce(new Vector3(0f, 0f, accelerationSpeed));
            if (Input.GetKey(accelerate) && Input.GetKey(boost))
            {
                carPrefabRigidbody.AddRelativeForce(new Vector3(0f, 0f, accelerationSpeed*2));
            }
        }

        if (Input.GetKey(brake))
        {
            carPrefabRigidbody.AddRelativeForce(new Vector3(0f, 0f, -5f));
        }

        if (Input.GetKey(left))
        {
            //carPrefabRigidbody.AddRelativeTorque(new Vector3(0f, -5f, 0f));
        }

        if (Input.GetKey(right))
        {
            //carPrefabRigidbody.AddRelativeTorque(new Vector3(0f, 5f, 0f));
        }
    }
}

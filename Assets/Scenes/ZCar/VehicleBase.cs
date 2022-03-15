using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleBase : MonoBehaviour
{
    public Rigidbody carPrefabRigidbody;
    
    public KeyCode accelerate;
    public float accelerationSpeed = 5f;

    public KeyCode brake;

    public KeyCode left;

    public KeyCode right;

    public KeyCode boost;

    public GameObject[] frontTyres; 
    public Vector3 localVelocity;

    public bool driverIn; 
    // Start is called before the first frame update
    void Start()
    {
        carPrefabRigidbody = GetComponent<Rigidbody>(); 
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, 0.5f);
    }

    public void Activate()
    {
        
    }

    /*public void Accelerate()
    {
        carPrefabRigidbody.AddRelativeForce(new Vector3(0f, 0f, accelerationSpeed*2));
    }

    public void Decelerate()
    {
        carPrefabRigidbody.AddRelativeForce(new Vector3(0f, 0f, -5f));
    }

    public void Left()
    {
        carPrefabRigidbody.AddRelativeTorque(new Vector3(0f, -5f, 0f));
    }

    public void Right()
    {
        carPrefabRigidbody.AddRelativeTorque(new Vector3(0f, 5f, 0f));
    }*/
    

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawRay(transform.position,Vector3.,Color.green);
        localVelocity = transform.InverseTransformDirection(carPrefabRigidbody.velocity);
        
        carPrefabRigidbody.AddRelativeForce(new Vector3(-localVelocity.x,0f,0f));
        
        //Debug.Log(localVelocity);
        
        if (Input.GetKey(accelerate) && driverIn)
        {
            /*frontTyres[0].transform.localRotation =  Quaternion.Euler(0f,0f,0f);
            frontTyres[1].transform.localRotation =  Quaternion.Euler(0f,0f,0f);*/
            carPrefabRigidbody.AddRelativeForce(new Vector3(0f, 0f, accelerationSpeed));
            if (Input.GetKey(accelerate) && Input.GetKey(boost))
            {
           
                carPrefabRigidbody.AddRelativeForce(new Vector3(0f, 0f, accelerationSpeed*2));
            }
        }

        if (Input.GetKey(brake)&& driverIn)
        {
            /*frontTyres[0].transform.localRotation =  Quaternion.Euler(0f,0f,0f);
            frontTyres[1].transform.localRotation =  Quaternion.Euler(0f,0f,0f);*/
            carPrefabRigidbody.AddRelativeForce(new Vector3(0f, 0f, -5f));
        }
        
        if (Input.GetKey(left)&& driverIn)
        {
            //frontTyres[0].transform.localRotation =  Quaternion.Euler(0f,0f,60f);
            //frontTyres[1].transform.localRotation =  Quaternion.Euler(0f,0f,60f);
            //rightFrontTyre.transform.localRotation = Quaternion.Euler(0f,45f,0f);
            //leftFrontTyre.transform.localRotation = Quaternion.Euler(0f,45f,0f);
            carPrefabRigidbody.AddRelativeTorque(new Vector3(0f, -5f, 0f));
        }

        if (Input.GetKey(right)&& driverIn)
        {
            //frontTyres[0].transform.localRotation =  Quaternion.Euler(0f,0f,-60f);
            //frontTyres[1].transform.localRotation =  Quaternion.Euler(0f,0f,-60f);
            //rightFrontTyre.transform.localRotation = Quaternion.Euler(0f,-45f,0f);
            //leftFrontTyre.transform.localRotation = Quaternion.Euler(0f,-45f,0f);
            carPrefabRigidbody.AddRelativeTorque(new Vector3(0f, 5f, 0f));
        }

        /*if (Input.GetKey(left))
        {
            
            carPrefabRigidbody.AddRelativeTorque(new Vector3(0f, -5f, 0f));
        }

        if (Input.GetKey(right))
        {
            carPrefabRigidbody.AddRelativeTorque(new Vector3(0f, 5f, 0f));
        }*/
    }
}


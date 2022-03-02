using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Wheels : MonoBehaviour
{
    public Vector3 localVelocity;

    public float rayMaxDistance;

    public GameObject carObject;

    public AnimationCurve animationCurve;

    public Vector3 force;

  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float aC = animationCurve.Evaluate(Random.Range(0,animationCurve.length/2f));
        force = new Vector3(0f, aC, 0f); 
        Ray ray = new Ray();
        ray.direction = Vector3.down;
        ray.origin = transform.position;
        RaycastHit raycastHit = new RaycastHit();
        
        if (Physics.Raycast(ray, out raycastHit, rayMaxDistance))
        {
            Debug.DrawRay(transform.position,ray.direction);
            carObject.GetComponent<Rigidbody>().AddRelativeForce(force);
        }

        
        //localVelocity = transform.InverseTransformDirection(GetComponent<Controls>().carPrefabRigidbody.velocity);
    }
}

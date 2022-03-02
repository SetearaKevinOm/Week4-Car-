using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;

public class GameManager : MonoBehaviour
{
    public GameObject carObject;
    public GameObject cO;
    public GameObject mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        cO = Instantiate(carObject);
        Instantiate(mainCamera, cO.transform);
        mainCamera.transform.rotation = Quaternion.Euler(0f,90f,0f);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}


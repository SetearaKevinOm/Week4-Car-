using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;

public class SceneManager : MonoBehaviour
{
    public GameObject carObject;
    public GameObject cO;
    public GameObject mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        cO = Instantiate(carObject);
        Instantiate(mainCamera, cO.transform);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}

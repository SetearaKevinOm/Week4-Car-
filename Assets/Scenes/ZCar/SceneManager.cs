using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;

public class SceneManager : MonoBehaviour
{
    public List<VehicleBase> carPrefabs;
    public VehicleBase cO;
    public GameObject mainCamera;
    public VehicleManager vehicleManager;
  
    void Start()
    {
        for (int i = 0; i < carPrefabs.Count; i++)
        {
               cO = Instantiate(carPrefabs[i]);
               vehicleManager.vehicles.Add(cO);
               //Instantiate(mainCamera, cO.transform);
        }
     
    }
    
}

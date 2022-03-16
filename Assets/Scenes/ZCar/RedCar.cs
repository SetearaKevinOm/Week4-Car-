using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCar : VehicleBase
{
   public override void Activate()
   {
      Debug.Log("Im Red!");
   }
   
   public virtual void RedCarEditor()
   {
      Debug.Log("Im still a red Car!");
   }
}

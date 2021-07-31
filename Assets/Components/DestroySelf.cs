using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
   void OnCollisionEnter(Collision col)
   {
      if(col.gameObject.layer != 11 && col.gameObject.layer != 12)
      {
        Destroy(this.gameObject);
      }
   }
}

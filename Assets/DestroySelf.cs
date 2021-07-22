using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
   void OnCollisionEnter(Collision col)
   {
        Destroy(this.gameObject);
   }
}

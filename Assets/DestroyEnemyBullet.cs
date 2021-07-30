using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyBullet : MonoBehaviour
{
   void OnCollisionEnter(Collision col)
   {
      if(col.gameObject.layer != 11  && col.gameObject.layer != 10)
      {
        Destroy(this.gameObject);
      }
   }
}


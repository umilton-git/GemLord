using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
   public AudioClip shatterSound;
   public AudioSource Shatter;
   void OnCollisionEnter(Collision col)
   {
      if(col.gameObject.layer != 11 && col.gameObject.layer != 12)
      {
        Shatter.PlayOneShot(shatterSound);
        Destroy(this.gameObject);
      }
   }
}

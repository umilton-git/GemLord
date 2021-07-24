using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyerHealth : MonoBehaviour
{
    public float Health = 5;
    // Start is called before the first frame update   
    void OnCollisionEnter(Collision col)
   {
       if(col.gameObject.layer == 9)
       {
        Health -= 1;
       }
   }
    // Update is called once per frame
    void Update()
    {
        if(Health == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
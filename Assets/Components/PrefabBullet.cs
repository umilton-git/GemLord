using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PrefabBullet : MonoBehaviour
{
    public Rigidbody theBullet;
    public float Speed = 20f;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            var clone = Instantiate(theBullet, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(0, 0, Speed);

            Destroy(clone.gameObject, 3);
        }
        
    }
}

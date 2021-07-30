using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyerFire : MonoBehaviour
{    public Transform player;
     public LayerMask ignore;
     private RaycastHit hitInfo;
     public float FireTimer = 3f;
     public Rigidbody theBullet;
     public float Speed;
     private float timer = 0f;
    void Update()
    {
        if(Physics.Linecast(transform.position, player.position, ignore) && timer <= 0)
        {
            var clone = Instantiate(theBullet, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(0, 0, Speed);
            Destroy(clone.gameObject, 3);
            timer = FireTimer;
        }
        else if(Physics.Linecast(transform.position, player.position, ignore) && timer > 0)
        {
                timer = timer - Time.deltaTime; 
        }
    }
}
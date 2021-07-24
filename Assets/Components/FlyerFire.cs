using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyerFire : MonoBehaviour
{    public Transform player;
     public LayerMask ignore;
     private RaycastHit hitInfo;
    void Update()
    {
        Debug.DrawLine(transform.position, player.position);
        if (Physics.Linecast(transform.position, player.position, ~ignore))
        {
            Debug.Log("blocked");
        }
    }
}
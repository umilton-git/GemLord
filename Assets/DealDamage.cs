using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{

    void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("Hit the player!");
            var health = collision.GetComponent<Health>();
            if(health != null)
            {
                health.TakeDamage();
                Debug.Log(health.currentHealth);
                Destroy(this);
            }
        }
    }
}

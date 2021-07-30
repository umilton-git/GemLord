using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamageCrab : MonoBehaviour
{
    public float damageCooldown = 3;
    private float damageCooldownCount = 0;
   void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("Crab Bite!");
            var health = collision.GetComponent<Health>();
            if(health != null && damageCooldownCount <= 0)
            {
                health.TakeDamage();
                Debug.Log(health.currentHealth);
                damageCooldownCount = damageCooldown;
            }
        }
    }

    void Update()
    {
        if(damageCooldownCount > 0)
        {
            damageCooldownCount = damageCooldownCount - Time.deltaTime;
        }

    }
}

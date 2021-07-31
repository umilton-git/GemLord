using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamageCrab : MonoBehaviour
{
    public float damageCooldown = 3;
    private float damageCooldownCount = 0;
    public GameObject Player;
    public GameObject[] hearts;

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

        var health = Player.GetComponent<Health>();
        if(health.currentHealth < 1)
        {
            Destroy(hearts[0].gameObject);
        }
        else if(health.currentHealth < 2)
        {
            Destroy(hearts[1].gameObject);
        }
        else if(health.currentHealth < 3)
        {
            Destroy(hearts[2].gameObject);
        }
        else if(health.currentHealth < 4)
        {
            Destroy(hearts[3].gameObject);
        }
        else if(health.currentHealth < 5)
        {
            Destroy(hearts[4].gameObject);
        }
        

    }
}

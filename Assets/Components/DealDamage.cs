using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    public GameObject[] hearts;
    public GameObject Player;
    

    void Update()
    {
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

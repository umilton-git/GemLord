﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage()
    {
        currentHealth -= 1;

        if(currentHealth <= 0)
        {
            // Add GameOver Here
        }
    }

    public void addHealth()
    {
        currentHealth += 1;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
void Update()
    {
        if(Health.currentHealth <= 0)
        {
        SceneManager.LoadScene("GameOver");
        }

        if(EnemyCount.enemyCount <= 0)
        {
            SceneManager.LoadScene("Win");
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyCount : MonoBehaviour
{
    public static int enemyCount;
    public TextMeshProUGUI display;
    void Start()
    {
        enemyCount = 4;
        display.SetText(enemyCount.ToString());
    }

    void Update()
    {
        display.SetText(enemyCount.ToString());    
        if(enemyCount <= 0)
        {
            // Win State Here
        }
    }
}

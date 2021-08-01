using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    void Start(){
        Cursor.lockState = CursorLockMode.None;
    }
    public void exitgame()
    {
        Application.Quit();
    }
}

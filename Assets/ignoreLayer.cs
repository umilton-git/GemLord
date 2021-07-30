using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreLayer : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        //Ignore the collisions between layer 0 (default) and layer 8 (custom layer you set in Inspector window)
        Physics.IgnoreLayerCollision(0, 11);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

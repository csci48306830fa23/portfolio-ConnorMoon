using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifespan : MonoBehaviour
{
    public float lifespan_object = 5.0f; // Lifespan in seconds

    void Start()
    {
        // Destroy the object after the specified lifespan
        Destroy(gameObject, lifespan_object);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

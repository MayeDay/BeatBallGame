using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int hits = 1;
    public int points = 10;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        hits--;
        //Score points
        if (hits <= 0) {
            //Destroy() is a predefined variable that you can access to this game object to destroy the object
            Destroy(gameObject);
        }
    }
}

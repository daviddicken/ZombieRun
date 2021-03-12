using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCollision : MonoBehaviour
{
   
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name != "Ground")
        {
            Debug.Log(collision.gameObject.name);
            Destroy(gameObject);
            Debug.Log("destroyed");

        }

        //Destroy(gameObject);
    }
}

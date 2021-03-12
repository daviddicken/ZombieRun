using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCollision : MonoBehaviour
{
    public GameObject meat1;
    public GameObject meat2;
    public GameObject meat3;

    void OnCollisionEnter(Collision collision)
    {
       

        if(collision.gameObject.name != "Ground")
        {
            var meatChunk1 = Instantiate(meat1, gameObject.transform.position, Quaternion.identity);
            var meatChunk2 = Instantiate(meat1, gameObject.transform.position, Quaternion.identity);
            var meatChunk3 = Instantiate(meat1, gameObject.transform.position, Quaternion.identity);

            Destroy(gameObject);
            //Destroy(meat, 10);
            

        }

        //Destroy(gameObject);
    }
}

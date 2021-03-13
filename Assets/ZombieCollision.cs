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
       

        if(collision.gameObject.name != "Ground" && collision.gameObject.name != "Border (1)"
                                                 && collision.gameObject.name != "Border (2)"
                                                 && collision.gameObject.name != "Border (3)"
                                                 && collision.gameObject.name != "Border (4)")
        {
            var meatChunk1 = Instantiate(meat1, gameObject.transform.position, Quaternion.identity);
            var meatChunk2 = Instantiate(meat1, gameObject.transform.position, Quaternion.identity);
            var meatChunk3 = Instantiate(meat1, gameObject.transform.position, Quaternion.identity);

            Destroy(gameObject);
            //Destroy(meat, 10);
            

        }

        //Destroy(gameObject);
    }

    void Update()
    {
        ////To add Movement to zombies
        //float randX = Random.Range(-1, 1);
        //float randZ = Random.Range(-1, 1);
        //Vector3 origPos = gameObject.transform.position;

        //gameObject.transform.position = Vector3.Lerp(origPos, new Vector3(origPos.x + randX, -1, origPos.z + randZ), Time.deltaTime);

    }
}

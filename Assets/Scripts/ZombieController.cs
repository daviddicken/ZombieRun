using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieController : MonoBehaviour
{
    private Animator anim;
    public Transform Player;
    int MoveSpeed = 7;
    int MaxDist = 15;
    int MinDist = 2;
    
    void Start()
    {
        anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Player.position) <= MaxDist && Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.LookAt(Player);
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            anim.Play("Base Layer.Z_Run");
        }
        //if (transform.rotation.eulerAngles.x < -25)// || transform.rotation.eulerAngles.z < -15)
        //{
        //    anim.Play("Base Layer.Z_FallingBack");
        //}
        //if (transform.rotation.eulerAngles.x > 25)// || transform.rotation.eulerAngles.z > 15)
        //{
        //    anim.Play("Base Layer.Z_FallingForward");
        //}

    }
}//end of class
 //Quaternion.Euler().
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public Animator animator;
    public float moveSpeed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Vertical") * moveSpeed;

        move *= Time.deltaTime;
        transform.Translate(0, 0, move);

        //if(move != 0)
        //{
        //    animator.SetBool("isMove", false);
        //}
        //else
        //{
        //    animator.SetBool("isMove", true);
        //}
    }
}

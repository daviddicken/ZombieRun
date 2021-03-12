using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{
  public Transform objToFollow;
  public Vector3 offset;
  public float followSpeed = 10;
  public float lookSpeed = 10;


  public void LookAtTarget()
  {
    Vector3 _lookDirection = objToFollow.position - transform.position;
    Quaternion _rot = Quaternion.LookRotation(_lookDirection, Vector3.up);
    transform.rotation = Quaternion.Lerp(transform.rotation, _rot, lookSpeed);// * Time.deltaTime);

    //if (Input.GetKey(KeyCode.DownArrow))
    //{
    //  _lookDirection = objToFollow.position + transform.position;
    //  _rot = Quaternion.LookRotation(_lookDirection, Vector3.up);
    //  transform.rotation = Quaternion.Lerp(transform.rotation, _rot, lookSpeed * Time.deltaTime);
    //}
  }

  public void MoveToTarget()
  {
    
    Vector3 _targetPos = objToFollow.position +
                         objToFollow.forward * offset.z +
                         objToFollow.right * offset.x +
                         objToFollow.up * offset.y;

    transform.position = Vector3.Lerp(transform.position, _targetPos, followSpeed * Time.deltaTime);

    if (Input.GetKey(KeyCode.DownArrow))
    {
      _targetPos = objToFollow.position +
                         objToFollow.forward * -offset.z +
                         objToFollow.right * -offset.x +
                         objToFollow.up * offset.y;

      transform.position = Vector3.Lerp(transform.position, _targetPos, followSpeed);// * Time.deltaTime);
    }
  }



  private void FixedUpdate()
  {
    LookAtTarget();
    MoveToTarget();
  }

  
}

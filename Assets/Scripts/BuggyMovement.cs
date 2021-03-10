﻿//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

////public class BuggyMovement : MonoBehaviour
//[SerializeField]
//class BuggyMovement : MonoBehaviour
//{

//  private Rigidbody rigidbody;
//  [SerializeField] private float moveSpeed;

//  // Start is called before the first frame update
//  void Start()
//  {
//    rigidbody = GetComponent<Rigidbody>();

//  }

//  // Update is called once per frame
//  void Update()
//  {
//    var forward = transform.forward;
//    rigidbody.AddForce(transform.forward * moveSpeed);
//  }
//}

//===============================================
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BuggyMovement : MonoBehaviour
{
  public List<AxleInfo> axleInfos; // the information about each individual axle
  public float maxMotorTorque; // maximum torque the motor can apply to wheel
  public float maxSteeringAngle; // maximum steer angle the wheel can have

  // finds the corresponding visual wheel
  // correctly applies the transform
  public void ApplyLocalPositionToVisuals(WheelCollider collider)
  {
    if (collider.transform.childCount == 0)
    {
      return;
    }

    Transform visualWheel = collider.transform.GetChild(0);

    Vector3 position;
    Quaternion rotation;
    collider.GetWorldPose(out position, out rotation);

    visualWheel.transform.position = position;
    visualWheel.transform.rotation = rotation;
  }

  public void FixedUpdate()
  {
    float motor = maxMotorTorque * Input.GetAxis("Vertical");
    float steering = maxSteeringAngle * Input.GetAxis("Horizontal");

    foreach (AxleInfo axleInfo in axleInfos)
    {
      if (axleInfo.steering)
      {
        axleInfo.leftWheel.steerAngle = steering;
        axleInfo.rightWheel.steerAngle = steering;
      }
      if (axleInfo.motor)
      {
        axleInfo.leftWheel.motorTorque = motor;
        axleInfo.rightWheel.motorTorque = motor;
      }
    }
  }
}

[System.Serializable]
public class AxleInfo
{
  public WheelCollider leftWheel;
  public WheelCollider rightWheel;
  public bool motor; // is this wheel attached to motor?
  public bool steering; // does this wheel apply steer angle?
}
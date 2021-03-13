using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuggyController : MonoBehaviour
{
  private float m_horizontalInput;
  private float m_verticalInput;
  private float m_steeringAngle;

  public WheelCollider rearRightWheel;
  public WheelCollider frontRightWheel;
  public WheelCollider rearLeftWheel;
  public WheelCollider frontLeftWheel ;
  public Transform frontLeftTransform;
  public Transform frontRightTransform;
  public Transform rearLeftTransform;
  public Transform rearRightTransform;
  public float maxSteerAngle = 30;
  public float motorForce = 50;


  public void GetInput()
  {
    m_horizontalInput = Input.GetAxis("Horizontal");
    m_verticalInput = Input.GetAxis("Vertical");
  }
  private void Steer()
  {
    m_steeringAngle = maxSteerAngle * m_horizontalInput;
    frontLeftWheel.steerAngle = m_steeringAngle;
    frontRightWheel.steerAngle = m_steeringAngle;

  }
  private void Accelerate()
  {
    frontLeftWheel.motorTorque = m_verticalInput * motorForce;
    frontRightWheel.motorTorque = m_verticalInput * motorForce;
    rearLeftWheel.motorTorque = m_verticalInput * motorForce;
    rearRightWheel.motorTorque = m_verticalInput * motorForce;
  }
  private void UpdateWheelPoses()
  {
    UpdateWheelPoses(frontLeftWheel, frontLeftTransform); 
    UpdateWheelPoses(frontRightWheel, frontRightTransform);
    UpdateWheelPoses(rearLeftWheel, rearLeftTransform);
    UpdateWheelPoses(rearRightWheel, rearRightTransform);

  }
  private void UpdateWheelPoses(WheelCollider _collider, Transform _transform)
  {
    Vector3 _pos = _transform.position;
    Quaternion _quat = _transform.rotation;

    _collider.GetWorldPose(out _pos, out _quat);

    _transform.position = _pos;
    _transform.rotation = _quat;
    //_transform.rotation = Quaternion.Euler(-_quat.eulerAngles);
  }

  private void FixedUpdate()
  {
    GetInput();
    Steer();
    Accelerate();
    UpdateWheelPoses();
  }

}
